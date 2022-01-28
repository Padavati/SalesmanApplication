using SalesmanApplication_Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SalesmanApplication
{
    public partial class SalesAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            
            if(int.Parse(txtUserID.Text)==5000 && txtPassword.Text=="Salesman")
            {
                
                Response.Redirect("~/Salesman.aspx");
            }
            else
            {
                lblResult.Text = "Unautorized Access";
            }

        }
    }
}