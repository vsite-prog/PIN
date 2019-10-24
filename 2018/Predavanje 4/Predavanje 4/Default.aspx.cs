using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page { 

    // Globalna varijabla
    int i = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        //Koje je vrijeme  otvarnja stranice od strane {
        if (!IsPostBack)
        {
          Label1.Text = DateTime.Now.ToLongTimeString();
            //Promijeni izgled
            Label1.ForeColor = System.Drawing.Color.Red;
            Label1.BackColor = System.Drawing.Color.LightGray;
            //Dosta je jedan put ovo staviti
            tb_rez.Enabled = false;
        }

    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        i++;
        Label1.Text += "<br> Postback broj: " + i;
       par1.InnerHtml = "Promijenio!";

    }

    protected void B2_Click(object sender, EventArgs e)
    {
        par1.InnerHtml = "Unijeli ste"  + tb_unos.Text;
        Literal1.Text += "<br>";
        //A što ako želimo ovakav tekst? 
        //Literal1.Text += "<div> fsdfsfsa";  < = &lt; 
        Literal1.Text += Server.HtmlEncode("<div> fsdfsfsa");
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        double a, b, rez = 0;
        //Bilo bi dobro ovdje hvatati exception-e
        a = Double.Parse(tb_a.Text);
        b = Double.Parse(tb_b.Text);
        //Pročitaj iz DDL-a koja operacija
        string operacija = DropDownList1.SelectedValue;
        switch (operacija)
        {
            case "+":
                rez = a + b;
                break;
            case "-":
                rez = a - b;
                break;
            case "*":
                rez = a * b;
                break;
            case "/":
                rez = a / b;
                break;
        }
        tb_rez.Text = rez.ToString();
    }
}