using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Cryptography;
using System.Web.Configuration;
using System.Data.SqlServerCe;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void bt_reg_Click(object sender, EventArgs e)
    {
        string lozinka = tb_lozinka.Text;
        //Generator slučajnih brojeva s početmnom vrijdnošću ms
        Random r = new Random( DateTime.Now.Millisecond);

        // Salt izračunaj slučajni broj prebaci u string i uzmi kao dodatak lozinci
        string sol = r.Next().ToString();

        //hashiraj lozinku
        string hashLozinka = hashMe(lozinka);

        //dodaj sol na hash i sve skupa opet hashiraj
        string slanaHashLozinka = hashMe(hashLozinka + sol);

        string conStr = WebConfigurationManager.ConnectionStrings["Korisnici"].ConnectionString;
        SqlCeConnection conn = new SqlCeConnection(conStr);
        SqlCeCommand comm = new SqlCeCommand();
        comm.CommandType = System.Data.CommandType.Text;
        comm.Connection = conn;
        comm.CommandText = "INSERT INTO korisnik(kime, lozinka, sol) VALUES (@kime, @lozinka, @sol)";
        comm.Parameters.AddWithValue("@kime", tb_kime.Text);
        comm.Parameters.AddWithValue("@lozinka", slanaHashLozinka);
        comm.Parameters.AddWithValue("@sol", sol);
        try
        {
            conn.Open();
            comm.ExecuteNonQuery();
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
        byte [] poljeBajtova = System.Text.Encoding.ASCII.GetBytes(ulazni);
        //hashiraj polje bajtova 
        byte[] rezultatHashiranja = algoritam.ComputeHash(poljeBajtova);
        //vrati nazad u base64 string(samo slova i brojevi...)
        return Convert.ToBase64String(rezultatHashiranja);

    }
    
}