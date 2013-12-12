using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlServerCe;
using System.Web.Configuration;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Dohvati podatke za konekciju iz web.config
        string cs = WebConfigurationManager.ConnectionStrings["KluboviCS"].ConnectionString;
        //konekcija na bazu
        SqlCeConnection conn = new SqlCeConnection(cs);
        // Stvori utičnicu prema bazi s kojom ćemo napuniti set podataka
        SqlCeDataAdapter da = new SqlCeDataAdapter("SELECT * FROM klub", conn);
        //Kreiraj našu kopiju baze ili bar objekt...
        DataSet ds = new DataSet();
        //Neka adapter napuni podatke u set
        da.Fill(ds);
         
        //Sad ih hoću prikazati na formu
        gv_klubovi.DataSource = ds;

        //Konačno veži podatke sa gridom
        gv_klubovi.DataBind();



    }
}