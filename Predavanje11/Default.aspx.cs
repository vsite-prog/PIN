using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data.SqlServerCe;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //Prikaži u GV-u životinje
            string connectionString = WebConfigurationManager.ConnectionStrings["ZivotinjeCS"].ConnectionString;
            //objekt za povezivanje
            SqlCeConnection connection = new SqlCeConnection(connectionString);
            //Command za dohvat podataka
            SqlCeCommand command = new SqlCeCommand("SELECT * FROM zivotinje",connection);
            // Adapter koji će dohvatiti podatke
            SqlCeDataAdapter adapter = new SqlCeDataAdapter();
            adapter.SelectCommand = command;
            //Novi data set koji će imati kopiju baze
            DataSet dataSet = new DataSet();
            //napuni dataset
            adapter.Fill(dataSet);
            
            //Poveži podatke
            gv_zivotinje.DataSource = dataSet;
            //Sadaaa
            gv_zivotinje.DataBind();


        }

    }
}