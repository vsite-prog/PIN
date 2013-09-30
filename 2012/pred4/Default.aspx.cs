using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            span1.InnerHtml = "<strong> Idemo dalje... </strong>";
            lbl1.Text = "Ime: ";
            ltPunoIme.Text = "<strong> Ovdje ide puno ime </strong>";
            lbl1.ForeColor = Color.Red;
        }
    }

   
}