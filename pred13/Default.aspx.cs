using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StudentiModel;

public partial class _Default : System.Web.UI.Page
{
    //Kreiraj novi objekt konteksta baze
    StudentiEntities db = new StudentiEntities();
    protected void Page_Load(object sender, EventArgs e)
    {
        /*
        //Kreiraj novi objekt konteksta baze
        StudentiEntities db = new StudentiEntities();

        //DropDownlista neka se poveže sa kolegijom
        DropDownList1.DataSource = db.kolegij;
        //vrijednost itema u listi je id
        DropDownList1.DataValueField = "kol_id";
        //Prikaži za tekst opis naziv
        DropDownList1.DataValueField = "naziv";
        //DDL osvježi podatke
        DropDownList1.DataBind();

        //Daj za izvor podataka GV-u tablicu iz baze
        GridView1.DataSource = db.student;
        //REfresh-aj grid
        GridView1.DataBind();
        */
        //Osvježi samo kad je nova stranica
        if (!Page.IsPostBack)
            poveziPodatke();

        //TO DO - Poveži DDL i grid
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        //Osvježi samo Grid
        refreshGrid();

    }

    private void poveziPodatke()
    {

        refreshDDL();
        refreshGrid();

        
    }
    private void refreshGrid()
    {
        //Daj za izvor podataka GV-u tablicu iz baze
        GridView1.DataSource = db.student;
        //REfresh-aj grid
        GridView1.DataBind();
    }

    private void refreshDDL()
    {

        //DropDownlista neka se poveže sa kolegijom
        DropDownList1.DataSource = db.kolegij;
        //vrijednost itema u listi je id
        DropDownList1.DataValueField = "kol_id";
        //Prikaži za tekst opis naziv
        DropDownList1.DataValueField = "naziv";
        //DDL osvježi podatke
        DropDownList1.DataBind();
    }
}