using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        { 
            int counter = 0;
            //Nr of page opens?
            if(Application["counter"] != null)
                counter = (int)Application["counter"];

            counter++;
            Application.Lock(); //lock resource
            Application["counter"] = counter;
            Application.UnLock();
            lb_poruka.Text = "Otvaranje broj: " + counter.ToString();
        }
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        // Throw some exception
        throw new Exception("Kabooooooom, booooom.....");

        if (Session["pogodiMe"] == null)
        {
            Response.Redirect("Unos.aspx?msg=Prvo unesi broj!");
        }
        else
        {
            //Read Sessionstate
            int pogodiMe = (int)Session["pogodiMe"];
            //Better tryParse
            int broj = Int32.Parse(tb_broj.Text);
            if (broj < pogodiMe)
                lb_greska.Text = "Treba veći broj";
            else if (broj > pogodiMe)
                lb_greska.Text = "Treba manji broj";
            else
                lb_greska.Text = "Bravo, pogodak!";
        }
    }
}