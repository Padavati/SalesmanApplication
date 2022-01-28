using SalesmanApplication_Business;
using SalesmanApplication_Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SalesmanApplication
{
    public partial class SalesLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            SalesmanInfoBusiness salesmanInfoBusinessObj = new SalesmanInfoBusiness();
            DataTable dtLogin = salesmanInfoBusinessObj.LoginCheck(int.Parse(txtSalesmanID.Text), txtPassword.Text);
            if(dtLogin.Rows.Count>0)
            {
                //gvSalesmanInfo.DataSource = dtLogin;
                //gvSalesmanInfo.DataBind();

                //Client Side
                //Cookies
                //HttpCookie httpObj = new HttpCookie("SalesLoginInfo");
                //httpObj["SalesmanID"] = dtLogin.Rows[0][0].ToString();
                //httpObj["NewPassword"] = dtLogin.Rows[0][4].ToString();

                //Non-Persistent Cookie: we have to set time to delete cookie data automatically
                //httpObj.Expires.AddDays(2);
                //httpObj.Expires.Add(new TimeSpan(0, 0, 10));

                //To store data into cookie
                //Response.Cookies.Add(httpObj);
                //Response.Redirect("~/Salesman.aspx");

                //Using Query String
                //Response.Redirect("Salesman.aspx?SalesmanID=" + dtLogin.Rows[0][0].ToString() + "&NewPassword=" + dtLogin.Rows[0][4].ToString()); ;

                //Server state management
                //Using Session==>Read Data from session
                //access session in contact.aspx
                //Session["SalesmanDetails"] = dtLogin;
                //Session["SalesmanID"] = dtLogin.Rows[0][0].ToString();
                //Session["NewPassword"] = dtLogin.Rows[0][4].ToString();
                //Response.Redirect("Salesman.aspx");

                //Using Application==>Read Data from application
                //access application in contact.aspx
                Application["SalesmanDetails"] = dtLogin;
                Application["SalesmanID"] = dtLogin.Rows[0][0].ToString();
                Application["NewPassword"] = dtLogin.Rows[0][4].ToString();
                Response.Redirect("Salesman.aspx");
            }
            else
            {
                lblResult.Text = "Account does not exist!";
            }

        }
    }
}