using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data.SqlServerCe;

public partial class Details2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        //Iz web configa dohvati connection string
        string spojiMe = WebConfigurationManager.ConnectionStrings["ZivotinjeConnectionString"].ConnectionString;

        //Spoji me na bazu
        SqlCeConnection connection = new SqlCeConnection();
        //Daj mi podatke
        connection.ConnectionString = spojiMe;
        //otvori konekciju
        connection.Open(); //Obavezno me zatvori
        //...To Be continued

        connection.Close(); 



    }
}                                         