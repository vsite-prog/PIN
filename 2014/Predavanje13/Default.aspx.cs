using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    //Handle na bazu i kontekst
    DatabaseEntities db;

    protected void Page_Load(object sender, EventArgs e)
    {
        db = new DatabaseEntities();

        if (!IsPostBack)
        {
            //Kaži što je štu DDL
            ddl_drzava.DataValueField = "id";
            ddl_drzava.DataTextField = "naziv";
            //Poveži se sa tablicom države
            ddl_drzava.DataSource = db.drzave.ToList<drzave>();
            ddl_drzava.DataBind();

            pokaziGradove();

        }



        /*Lista gradova
        gv_gradovi.DataSource = db.gradovi.ToList<gradovi>();
        gv_gradovi.DataBind();
         * */
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //Spremi novi grad
        gradovi grad = new gradovi();
        grad.naziv = tb_grad.Text;
        grad.drzavaId = Int32.Parse(ddl_drzava.SelectedValue);
        //dodaj novi grad u listu
        db.gradovi.Add(grad);
        //Sve spremi u bazu
        db.SaveChanges();

        //Sve pokaži
        pokaziGradove();
    }

    private void pokaziGradove()
    {
        // Pročitaj državu
        int drzavaId = Int32.Parse(ddl_drzava.SelectedValue);
        //Idi kroz sve gradove i vrati one iz naše države
        var sviGradovi = from g in db.gradovi
                              where g.drzavaId == drzavaId
                              select new
                              {
                                  ID = g.id,
                                  Naziv = g.naziv
                              };
        //POveži sa gridom
        gv_gradovi.DataSource = sviGradovi.ToList(); //Prebaci iz DBSet u listu
        gv_gradovi.DataBind();
    }
    protected void ddl_drzava_SelectedIndexChanged(object sender, EventArgs e)
    {
        //Sve pokaži
        pokaziGradove();
    }
}