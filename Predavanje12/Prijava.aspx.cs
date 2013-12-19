using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Cryptography;
using System.Web.Configuration;
using System.Data.SqlServerCe;

public partial class Prijava : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void bt_prijava_Click(object sender, EventArgs e)
    {
        string conStr = WebConfigurationManager.ConnectionStrings["Korisnici"].ConnectionString;
        SqlCeConnection conn = new SqlCeConnection(conStr);
        SqlCeCommand comm = new SqlCeCommand();
        comm.CommandType = System.Data.CommandType.Text;
        comm.Connection = conn;
        comm.CommandText = "SELECT lozinka, sol FROM korisnik WHERE kime = @kime";
        comm.Parameters.AddWithValue("@kime", tb_kime.Text);
        try
        {
            conn.Open();
            //pročitaj podatke
            SqlCeDataReader dr = comm.ExecuteReader();
            if (dr.Read())
            {
                //Našli smo korisnika, sada ponovo hashiraj i soli lozinku

                string lozinka = dr["lozinka"].ToString();
                string sol = dr["sol"].ToString();
                //Ponovi postupak kod registracije, uzmi unesenu lozinku
                string hashLoz = hashMe(tb_lozinka.Text);
                string hashSlanaLoz = hashMe(hashLoz + sol);
                
                if (hashSlanaLoz == lozinka)
                    Response.Redirect("Default.aspx");
                else
                    lb_greska.Text = "Kriva lozinka";
            }
            else
            {
                lb_greska.Text = "Korisnik ne postoji";
            }
        }
        finally
        {
            conn.Close();
        }


    }

    protected string hashMe(string ulazni)
    {
        //kreiraj objekt koji će hashitrat sa SHA256
        SHA256Managed algoritam = new SHA256Managed();
        //prebaci string u polje bajtova 
        byte[] poljeBajtova = System.Text.Encoding.ASCII.GetBytes(ulazni);
        //hashiraj polje bajtova 
        byte[] rezultatHashiranja = algoritam.ComputeHash(poljeBajtova);
        //vrati nazad u base64 string(samo slova i brojevi...)
        return Convert.ToBase64String(rezultatHashiranja);

    }
}