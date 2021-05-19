using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ASP_Project.Entity;

namespace ASP_Project.Urun
{
    public partial class Urunler : System.Web.UI.Page
    {

        ASPDBEntities db = new ASPDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            //var urunler = db.TBLURUNLER.Where(x=>x.DURUM == true).ToList();

            var urunler = (from x in db.TBLURUNLER
                           where x.DURUM == true
                           select new
                           {
                               x.URUNID,
                               x.URUNAD,
                               x.URUNMARKA,
                               x.TBLKATEGORI.KATEGORIAD,
                               x.URUNFIYAT,
                               x.URUNSTOK
                           }).ToList();

            Repeater1.DataSource = urunler;
            Repeater1.DataBind();
        }
    }
}