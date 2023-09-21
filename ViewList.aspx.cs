using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace XamppTry
{
    public partial class ViewList : System.Web.UI.Page
    {
        database db = new database();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                db.ViewList(tblcontact, "SELECT * FROM tblcontact");
                db.populate(dropdown, "SELECT * FROM tblcontact");
                db.ViewList(tbluser, "SELECT * FROM tbluser");
            }          
        }

        protected void search_Click(object sender, EventArgs e)
        {
            db.ViewList(tblcontact, "SELECT * FROM tblcontact WHERE id='" + dropdown.SelectedValue + "'");
        }

        protected void viewAll_Click(object sender, EventArgs e)
        {
            db.ViewList(tblcontact, "SELECT * FROM tblcontact");
        }
    }
}