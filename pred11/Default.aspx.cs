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
    {   //Kreiraj novu konekciju sa podacima iz web.config-a
        SqlCeConnection conn = new SqlCeConnection(WebConfigurationManager.ConnectionStrings["faks"].ConnectionString);
        //Novi command objekt koji će pročitati sve studente
        SqlCeCommand comm = new SqlCeCommand("SELECT * from student");
        comm.Connection = conn;
        //Kreiraj data adapter koji ima zadatak napuniti dataset kao izvor podataka
        SqlCeDataAdapter da = new SqlCeDataAdapter(comm);
        //Dataset kao komponenta koja će služiti kao izvor za GView
        DataSet ds = new DataSet();
        //Napuni podatke Data seta sa adapterom
        //Fill metoda će u pozadini izvesti izvršavanje SELECT-a i dobivene rez proslijediti u dataset
        //conn.Open(); Adapter će automatski otvoriti i zatvoti kon
        da.Fill(ds);
        //postavi za izvor podataka naš set
        gv_studenti.DataSource = ds;
        //refershaj podatke u gridu
        gv_studenti.DataBind();



    }
}