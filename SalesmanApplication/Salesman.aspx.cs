using SalesmanApplication_Business;
using SalesmanApplication_Entity;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SalesmanApplication
{
    public partial class Salesman : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Read data from Cookie
            //HttpCookie getUserInfoCookie = Request.Cookies["SalesLoginInfo"];
            //txtSalesmanID.Text = getUserInfoCookie["SalesmanID"]; ;
            //txtNewPassword.Text = getUserInfoCookie["NewPassword"];

            //Read data from Query String
            //string SalesmanID = Request.QueryString["SalesmanID"].ToString();
            //string NewPassword = Request.QueryString["NewPassword"].ToString();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SalesmanInfoBusiness salesmanInfoBusinessObj = new SalesmanInfoBusiness();
            SalesmanInfo salesmanInfoObj = new SalesmanInfo();
            salesmanInfoObj.salesman_id = Convert.ToInt32(txtSalesmanID.Text);
            salesmanInfoObj.name = txtSalesmanName.Text;
            salesmanInfoObj.city = txtSalesmanCity.Text;
            salesmanInfoObj.commission =decimal.Parse(txtCommission.Text);
            salesmanInfoObj.pwd = txtNewPassword.Text;
                
            string msg = salesmanInfoBusinessObj.Insertion(salesmanInfoObj);
            lblResult.Text = msg;

            LoadData();
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            SalesmanInfoBusiness salesmanInfoBusinessObj = new SalesmanInfoBusiness();
            DataTable dt=salesmanInfoBusinessObj.Edit(Convert.ToInt32(txtSalesmanID.Text));
            txtSalesmanName.Text = dt.Rows[0][1].ToString();
            txtSalesmanCity.Text = dt.Rows[0][2].ToString();
            txtCommission.Text =dt.Rows[0][3].ToString();
            txtNewPassword.Text= dt.Rows[0][4].ToString();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            SalesmanInfoBusiness salesmanInfoBusinessObj = new SalesmanInfoBusiness();
            SalesmanInfo salesmanInfoObj = new SalesmanInfo();
            salesmanInfoObj.salesman_id = int.Parse(txtSalesmanID.Text);
            salesmanInfoObj.name = txtSalesmanName.Text;
            salesmanInfoObj.city = txtSalesmanCity.Text;
            salesmanInfoObj.commission = decimal.Parse(txtCommission.Text);
            salesmanInfoObj.pwd = txtNewPassword.Text;

            string msg = salesmanInfoBusinessObj.Updation(salesmanInfoObj);
            lblResult.Text = msg;

            LoadData();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            SalesmanInfoBusiness salesmanInfoBusinessObj = new SalesmanInfoBusiness();

            string msg = salesmanInfoBusinessObj.Deletion(int.Parse(txtSalesmanID.Text));
            lblResult.Text = msg;

            LoadData();
        }
        public void LoadData()
        {
            SalesmanInfoBusiness salesmanInfoBusinessObj = new SalesmanInfoBusiness();           
            DataTable dtResult = salesmanInfoBusinessObj.Selection();
            gvSalesmanInfo.DataSource = dtResult;
            gvSalesmanInfo.DataBind();
        }
    }
}