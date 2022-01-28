using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SalesmanApplication
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Read data from Session
            if(Application["SalesmanID"]!=null)
            {
                lblSalesmanID.Text = Application["SalesmanID"].ToString();
                lblNewPassword.Text = Application["NewPassword"].ToString();
            }

        }
    }
}