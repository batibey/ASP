using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ASP_Project.Entity;

namespace ASP_Project.Urun
{
    public partial class UrunSil : System.Web.UI.Page
    {
        ASPDBEntities db = new ASPDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["URUNID"]);

            var urun = db.TBLURUNLER.Find(id);

            urun.DURUM = false;
            db.SaveChanges();
            Response.Redirect("Urunler.aspx");
        }
    }
}