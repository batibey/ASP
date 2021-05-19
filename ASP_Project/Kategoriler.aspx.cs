using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ASP_Project.Entity;

namespace ASP_Project
{
    public partial class Kategoriler : System.Web.UI.Page
    {


        ASPDBEntities db = new ASPDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var degerler = db.TBLKATEGORI.ToList();

            Repeater1.DataSource = degerler;
            Repeater1.DataBind();
        }
    }
}