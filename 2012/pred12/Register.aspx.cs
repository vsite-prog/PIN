using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Cryptography;
using System.Data.SqlServerCe;
using System.Web.Configuration;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //procitaj lozinku
        string lozinka = tb_lozinka.Text;
        //generiraj salt
        Random r = new Random(DateTime.Now.Millisecond);
        string salt = r.Next().ToString();
        //Enkriptiraj lozinku
        string hashLozinka = hashiraj(lozinka);
        //sad dodaj još i sol na već hashiranu i sve zajedno ponovo hashiraj 
        string saltHashLozinka = hashiraj(salt + hashLozinka);
        //ADO.NET kreiraj konekciju i pročitaj ConnString iz web.config-a
        SqlCeConnection conn = new SqlCeConnection(WebConfigurationManager.ConnectionStrings["faks"].ConnectionString);
        //Kreiraj SQL objekt naredbe , daj tekst naredbe i poveži sa kreiranoj konekcijom 
        SqlCeCommand comm = new SqlCeCommand("INSERT INTO korisnik VALUES (@kime, @lozinka, @salt)", conn);
        //Proslijedi tekst SQL-a prema bazi 
        comm.CommandType = System.Data.CommandType.Text;
        //Dodaj vrijednosti parametara
        comm.Parameters.AddWithValue("@kime", tb_kime.Text);
        comm.Parameters.AddWithValue("@lozinka", saltHashLozinka);
        comm.Parameters.AddWithValue("@salt", salt);
        try
        {
            //otvori konekciju i izvrši SQL koji neće vratiti ništa 
            conn.Open();
            comm.ExecuteNonQuery();

        }
        finally
        {
            //na kraju zatvori konekciju 
            conn.Close();
        }
    }

    public string hashiraj(string ulaz) {

        //Dohvati algoritam za hashiranje, neka bude SHA256

        SHA256 algoritam = new SHA256Managed();

        // pretvori ulazni string u niz byte-ova koji će se kodirati
        byte[] ulazBajtovi = System.Text.Encoding.ASCII.GetBytes(ulaz);
        //kodiraj i preimi novi niz byte-ova koji sadrže hashiran niz 
        byte[] izlazBajtovi = algoritam.ComputeHash(ulazBajtovi);
        //pretvori ponovo u string i vrati rezultat
        return Convert.ToBase64String(izlazBajtovi);
    }
}