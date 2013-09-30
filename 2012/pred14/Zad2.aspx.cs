using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Zad2 : System.Web.UI.Page
{
    //Objasni SqlDataSource komponentu, zašto ova čita sve iz životinja i kako bi čitala samo one životinje vrste majmun
    //Kako bi programski povezali sa GVIew kontrolom i pokazali podatke
    protected void Page_Load(object sender, EventArgs e)
    {
        //Za vježbu dati ljepša imena
        GridView1.DataSource = SqlDataSource1;
        //Stvarno prikaži podatke
        GridView1.DataBind();


    }
}