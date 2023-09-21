using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace XamppTry.View
{
    public partial class register : System.Web.UI.Page
    {
        database db = new database();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            db.register(name.Text, password.Text, gender.Text);
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('record added')", true);
        }
    }
}