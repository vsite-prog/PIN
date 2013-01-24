using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlServerCe;
using System.Web.Configuration;

public partial class Zad3 : System.Web.UI.Page
{
    //Poveži podatke u gv_zivotinje sa tablicom životinje koristeći ADO.net
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
            ispisiPodatke();
       
    }

    //Napravi kod koji će na promjenu DDL-a proimjeniti i sadržaj gv_zivotinje
    protected void ddl_vrste_SelectedIndexChanged(object sender, EventArgs e)
    {
        string connStr = "Data Source=|DataDirectory|\\Zivotinje.sdf";
        SqlCeConnection conn = new SqlCeConnection(connStr);
        conn.Open();
        SqlCeCommand comm1 = new SqlCeCommand("SELECT * FROM zivotinje WHERE vrsta = @pvrsta", conn);
        comm1.CommandType = System.Data.CommandType.Text;
        comm1.Parameters.AddWithValue("pvrsta", ddl_vrste.SelectedValue);

        
        SqlCeDataReader dr1 = comm1.ExecuteReader();



        gv_zivotinje.DataSource = dr1;
        gv_zivotinje.DataBind();

        dr1.Close();
        //Obavezno zatvoriti konekciju
        conn.Close();

        //Može biti i zad. sa while(dr.Read())
    }

    private void ispisiPodatke()
    {

        string connStr = "Data Source=|DataDirectory|\\Zivotinje.sdf";
        SqlCeConnection conn = new SqlCeConnection(connStr);
        SqlCeCommand comm1 = new SqlCeCommand("SELECT * FROM zivotinje", conn);
        comm1.CommandType = System.Data.CommandType.Text;

        SqlCeCommand comm2 = new SqlCeCommand("SELECT DISTINCT vrsta FROM zivotinje", conn);
        comm2.CommandType = System.Data.CommandType.Text;
        conn.Open();
        SqlCeDataReader dr1 = comm1.ExecuteReader();
        SqlCeDataReader dr2 = comm2.ExecuteReader();

        gv_zivotinje.DataSource = dr1;
        gv_zivotinje.DataBind();

        ddl_vrste.DataTextField = "vrsta";
        ddl_vrste.DataValueField = "vrsta";
        ddl_vrste.DataSource = dr2;
        ddl_vrste.DataBind();

        //Obavezno zatvoriti konekciju
        conn.Close();
    }
    
}