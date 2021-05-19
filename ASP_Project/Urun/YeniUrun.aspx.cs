using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ASP_Project.Entity;

namespace ASP_Project.Urun
{
    public partial class YeniUrun : System.Web.UI.Page
    {
        ASPDBEntities db = new ASPDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Page.IsPostBack == false)
            {
                var kate = (from x in db.TBLKATEGORI select new { x.KATEGORIID, x.KATEGORIAD }).ToList();

                DropDownList1.DataTextField = "KATEGORIAD";
                DropDownList1.DataValueField = "KATEGORIID";
                DropDownList1.DataSource = kate;

                DropDownList1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TBLURUNLER t = new TBLURUNLER();
            t.URUNAD = TxtUrunAd.Text;
            t.URUNSTOK = short.Parse(TxtStok.Text);
            t.URUNMARKA = TxtMarka.Text;
            t.URUNFIYAT = decimal.Parse(TxtFiyat.Text);
            t.URUNKATEGORI = byte.Parse(DropDownList1.SelectedValue.ToString());

            db.TBLURUNLER.Add(t);
            db.SaveChanges();

            Response.Redirect("Urunler.aspx");
        }
    }
}