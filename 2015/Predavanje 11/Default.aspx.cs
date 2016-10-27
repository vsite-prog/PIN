using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data.SqlClient;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["StablaConnectionString"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);
            //Create SQL Command object
            SqlCommand comm = new SqlCommand("SELECT * from Stabla", conn);
            comm.CommandType = System.Data.CommandType.Text;
            //First create adapter for dataset
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = comm;
            DataSet dataSet = new DataSet(); //Create empty data set
            adapter.Fill(dataSet); //Load data in dataset
            // Now we have to GridView
            gv_stabla.DataSource = dataSet;
            // Now execute
            gv_stabla.DataBind();

        }
    }
}