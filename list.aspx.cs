using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace XamppTry.View
{
    public partial class list : System.Web.UI.Page
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

        protected void ViewAll_Click(object sender, EventArgs e)
        {
            db.ViewList(tblcontact, "SELECT * FROM tblcontact");
        }

        protected void dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            db.ViewList(tblcontact, "SELECT * FROM tblContact WHERE id='" + dropdown.SelectedValue + "'");
        }

        protected void GridViewSelected1(object sender, EventArgs e)
        {
            TextBox1.Text = tblcontact.SelectedRow.Cells[1].Text;
            TextBox2.Text = tblcontact.SelectedRow.Cells[2].Text;
            TextBox3.Text = tblcontact.SelectedRow.Cells[3].Text;
            TextBox4.Text = tblcontact.SelectedRow.Cells[4].Text;
            TextBox5.Text = tblcontact.SelectedRow.Cells[5].Text;
            TextBox6.Text = tblcontact.SelectedRow.Cells[6].Text;
        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            db.saveupd(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text);
            db.ViewList(tblcontact, "SELECT * FROM tblcontact");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            db.delete(TextBox1.Text);
            db.ViewList(tblcontact, "SELECT * FROM tblcontact");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            db.ViewList(tblcontact, "SELECT * FROM tblcontact WHERE id AND name AND email AND phone AND message='" + TextBox6.Text + "'");
        }
    }
}