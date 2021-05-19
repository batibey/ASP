using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ASP_Project.Entity;
namespace ASP_Project.Musteri
{
    public partial class Musteriler : System.Web.UI.Page
    {
        ASPDBEntities db = new ASPDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var degerler = db.TBLMUSTERI.ToList();
            Repeater1.DataSource = degerler;
            Repeater1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TBLMUSTERI t = new TBLMUSTERI();
            t.MUSTERIAD = TextBox1.Text;
            t.MUSTERISOYAD = TextBox2.Text;
            db.TBLMUSTERI.Add(t);
            db.SaveChanges();
            Response.Redirect("Musteriler.aspx");
        }
    }
}