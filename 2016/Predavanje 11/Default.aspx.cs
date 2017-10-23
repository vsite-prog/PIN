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
        if (!IsPostBack) //Ne treba ponavljati kod svakog POstBack-a
        {
            //Ovo već znamo, pročitaj iz web.config i kreiraj konekciju s tim podacima
            string connectionStr = WebConfigurationManager.ConnectionStrings["FilmoviCS"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionStr);
            //SAd mi daj komandu za DataAdapter
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM Film";
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
            //Sad možemo kreirati adapter, utičnicas u koju ćemu uštekati DataSet
            SqlDataAdapter adapter = new SqlDataAdapter(); //Mogli smo i kraće
            adapter.SelectCommand = command; //samo čitamo
            DataSet dataSet = new DataSet(); //Kreirali smo naš proxy od baze, di su podaci?
            adapter.Fill(dataSet); //Evo ih , adapter je napunio DS podacima
            //Nije bilo potrebno try-catch, to sve kontrolira dataadapter
            //sad možemo ovaj DS iskoristiti kao izvor podataka
            gv_filmovi.DataSource = dataSet;
            //Idemo sad prikazati podatke
            gv_filmovi.DataBind();
        }

    }
}