using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StudentiModel;

public partial class _Default : System.Web.UI.Page
{
    //glupo ali radi brzine naš id
    int stud_id = 10;
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
        //GridView1.DataSource = db.student;
        //Idemo preko LINQ upita dohvatiti samo one koji su iz kolegija odabranog u DDL
        //Dohvati selektirani kolegij
        int selKolegij = Int32.Parse(DropDownList1.SelectedValue);

        var listaStudenata = from s in db.student //gledamo u tablicu student
                             where s.kol_id == selKolegij //samo one iz željenog kolegija
                             select new //za svakog pronađenog kreiraj novi objekt u listi 
                             {
                                 Ime = s.ime,
                                 Prezime = s.prezime
                             };

        //Izvor podataka je ono što je LINQ vratio
        GridView1.DataSource = listaStudenata;
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
        DropDownList1.DataTextField = "naziv";
        //DDL osvježi podatke
        DropDownList1.DataBind();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //naša varijabla, inače bi trebao biti identity u bazi ali ...
        stud_id++;
        //kreiramo novog studenta
        student s = new student();
        //postavimo mu vrijednosti polja
        s.stud_id = stud_id;
        s.ime = tb_ime.Text;
        s.prezime = tb_prezime.Text;
        //Uzmi trenutno dabrani kolegij, prebaci ga u int
        s.kol_id = Int32.Parse(DropDownList1.SelectedValue);
        //Dodaj novi red u tablicu, tj novi objekt u bazu
        db.AddObject("student", s);
        //Spremi promjene tj. izvrši SQL prema bazi
        db.SaveChanges();

        refreshGrid();


    }
}