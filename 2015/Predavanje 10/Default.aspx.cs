using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void bt_mostovi_Click(object sender, EventArgs e)
    {
        //Read data from web.config needed for db connect
        string connStr = WebConfigurationManager.ConnectionStrings["BazaCS"].ConnectionString;
        SqlConnection conn = new SqlConnection(connStr); //Create connection object
        SqlCommand comm = new SqlCommand("SELECT * FROM Most"); //Fetch all rows from most table
        comm.Connection = conn; //set reference to connection object
        comm.CommandType = System.Data.CommandType.Text; //just send text to db
        try
        {
            //Open a connection to db
            conn.Open();
            SqlDataReader reader = comm.ExecuteReader(); //Fetch data from db and create new DR object
            if (reader.HasRows)
            {
                string tabla = "<table><tr><th>ID</th><th>Naziv</th><th>Mjesto</th></tr>";
                while (reader.Read()) //go to next record
                {
                    tabla += "<tr><td>" + reader[0] + "</td><td>" + reader[1] + "</td><td>" + reader[2] + "</td></tr>"; //Must be a number, order is important!
                }
                tabla += "</table>";
                tableDiv.InnerHtml = tabla; //inject  HTML
            } else
            {
                lb_poruka.Text = "Nema nikakvih mostova...";
            }
            
        } catch (Exception ex)        {
            lb_poruka.Text = "Greška: " + ex.Message;
        } finally
        {
            //always close db connection
            conn.Close();
        }
         
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //Read data from web.config needed for db connect
        string connStr = WebConfigurationManager.ConnectionStrings["BazaCS"].ConnectionString;
        SqlConnection conn = new SqlConnection(connStr); //Create connection object
        SqlCommand comm = new SqlCommand("INSERT INTO Most VALUES(@mjesto, @naziv)"); //Insert a new record in db
        comm.Connection = conn; //set reference to connection object
        comm.CommandType = System.Data.CommandType.Text; //just send text to db
        comm.Parameters.AddWithValue("mjesto", tb_mjesto.Text); // put a user input in param
        comm.Parameters.AddWithValue("naziv", tb_naziv.Text);
        try
        {
            //Open a connection to db
            conn.Open();
            int brojRedova = comm.ExecuteNonQuery(); //Receive nr of affected rows
            if (brojRedova == 1){
                lb_poruka.Text = "Most unesen!";
            } else
            {
                lb_poruka.Text = "Neispravan unos!";
            }
        } catch (Exception ex) {    
            lb_poruka.Text = "Greška: " + ex.Message;
        } finally
        {
            //always close db connection
            conn.Close();
        }
    }
}