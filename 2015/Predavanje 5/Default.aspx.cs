using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    int i = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        int brojac; //This will work
        i++; //Doesn't work - always 1
        lb_text.Text += Server.HtmlEncode("<Page Load>"); //Escape HTML characters
        if (!Page.IsPostBack) //Samo prvi put
        {
            lb_text.ForeColor = System.Drawing.Color.BlueViolet;
            lt_txt.Text += "Prvo otvaranje <br>";
            ViewState["brojac"] = 1;
        }
        else
        {
            brojac = (int)ViewState["brojac"];
            brojac++; //increment counter
            // lt_txt.Text += "Otvaranje br: " + i.ToString() + " <br> ";
            lt_txt.Text += "Otvaranje br: " + brojac.ToString() + " <br> ";
            ViewState["brojac"] = brojac;

        }
    }

    protected void lB_pritisni_Click(object sender, EventArgs e)
    {
        lt_txt.Text += Server.HtmlEncode("Pritsnuli ste me!  <br>");
        lb_text.Text += Server.HtmlEncode("<Button Click>");

    }

    private void InitializeComponent()
    {
            this.Init += new System.EventHandler(this._Default_Init);

    }

    private void _Default_Init(object sender, EventArgs e)
    {
        //  lb_text.Text += "<Page Init>";
        lb_text.Text += Server.HtmlEncode("<Page Init>"); 
    }

    protected void lb_racunaj_Click(object sender, EventArgs e)
    {
       // calculate();
    }

    private void handleError(string s)
    {
        lb_poruka.Text = s;
        lb_poruka.ForeColor = System.Drawing.Color.Red;

    }

    private void calculate()
    {
        //Calculator logic
        double a, b, rez = 0;
        //a = Double.Parse(tb_a.Text); throws Exception
        if (!Double.TryParse(tb_a.Text, out a)) //Not a number
        {
            handleError("1. number is wrong");
            return;
        }
        if (!Double.TryParse(tb_b.Text, out b)) //Not a number
        {
            handleError("2. number is wrong");
            return;
        }

        switch (DropDownList1.SelectedValue)
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
                if (b == 0)
                {
                    handleError("Divide by zero");
                    return;
                }
                rez = a / b;
                break;
            default:
                rez = 0; //No need for this
                break;
        }
        lb_rez.Text = rez.ToString();
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        calculate();
    }
}