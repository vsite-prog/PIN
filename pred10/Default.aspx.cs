using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlServerCe;
using System.Web.Configuration;

public partial class _Default : System.Web.UI.Page
{
    //bolje bi bilo ovdje imati konekciju
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
            postavi_labele();

    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        //kreiraj novu praznu konekciju 
        SqlCeConnection conn = new SqlCeConnection();
        //dohvati tekst za povezivanje na bazu iz web.config i postavi g ana konekciju
        string connStr = WebConfigurationManager.ConnectionStrings["studenti"].ConnectionString;
        conn.ConnectionString = connStr;

        //kreiraj novu naredbu i postavi SQL kao i konekciju
        SqlCeCommand cmd = new SqlCeCommand();
        cmd.Connection = conn;
        cmd.CommandText = "INSERT INTO student(ime, prezime, faks) VALUES(@ime, @prezime, @faks)"; //@=param
        cmd.CommandType = System.Data.CommandType.Text; //tip je sql 
        cmd.Parameters.AddWithValue("ime", tb_ime.Text); //unesi param i vrijednost u komandu
        cmd.Parameters.AddWithValue("prezime", tb_ime.Text);
        cmd.Parameters.AddWithValue("faks", tb_ime.Text);
        //lijepo bi došlo try-catch-finally  - probajte
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
        postavi_labele(); //nije idealno jer bi i druge kontrole mogle okinuti postback



    }

    private void postavi_labele()
    {
        //kreiraj novu praznu konekciju 
        SqlCeConnection conn = new SqlCeConnection();
        //dohvati tekst za povezivanje na bazu iz web.config i postavi g ana konekciju
        string connStr = WebConfigurationManager.ConnectionStrings["studenti"].ConnectionString;
        conn.ConnectionString = connStr;

        //kreiraj novu naredbu i postavi SQL kao i konekciju
        SqlCeCommand cmd = new SqlCeCommand();
        cmd.Connection = conn;
        cmd.CommandText = "SELECT COUNT(*) FROM student";
        cmd.CommandType = System.Data.CommandType.Text; //tip je SQL naredba (a ne tablica ili stor.proc)
        //otvori komunikaciju sa bazom
        conn.Open();
        int brojStud = (int)cmd.ExecuteScalar(); //izvrši vrati jednu vrijednost
        Label1.Text = "U bazi imamo " + brojStud.ToString() + " studenata!";
        
        cmd.CommandText = "SELECT * FROM student";
        
        //sada ih vrati kao datareader
        SqlCeDataReader dr = cmd.ExecuteReader();
        Label2.Text = "ID -  Ime  - Prezime" + "<br>";
        // na sql Expressu ima i dr.HasRows da vidimo je li prazan if(dr.HasRows))
        while (dr.Read())
        {
            //čitaj red po red dok ne dođeš do kraja
            Label2.Text += dr["stud_id"].ToString() + " - " + dr["ime"] + " - " + dr["prezime"] + " - " + dr["faks"] + "<br>";

        }
        
        
        conn.Close();
    }
}