using SalesmanApplication_Data;
using SalesmanApplication_Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesmanApplication_Business
{
    public class SalesmanInfoBusiness
    {
        public string Insertion(SalesmanInfo salesmanInfoObj)
        {
            SalesmanDataConnection salesmanDataConnectionObj = new SalesmanDataConnection();
            string msg = salesmanDataConnectionObj.InsertSalesInfo(salesmanInfoObj);
            return msg;
        }
        public string Updation(SalesmanInfo salesmanInfoObj)
        {
            SalesmanDataConnection salesmanDataConnection = new SalesmanDataConnection();
            string msg = salesmanDataConnection.UpdateSalesInfo(salesmanInfoObj);
            return msg;
        }
        public string Deletion(int salesman_id)
        {
            SalesmanDataConnection salesmanDataConnection = new SalesmanDataConnection();
            string msg = salesmanDataConnection.DeleteSalesInfoByID(salesman_id);
            return msg;
        }
        public DataTable Edit(int salesman_id)
        {
            SalesmanDataConnection salesmanDataConnection = new SalesmanDataConnection();
            DataTable dt = salesmanDataConnection.EditSalesInfoByID(salesman_id);
            return dt;
        } 
        public DataTable Selection()
        {
            SalesmanDataConnection salesmanDataConnection = new SalesmanDataConnection();
            DataTable dt = salesmanDataConnection.SelectSalesInfo();
            return dt;
        }
        public DataTable LoginCheck(int salesman_id,string pwd)
        {
            SalesmanDataConnection salesmanDataConnection = new SalesmanDataConnection();
            DataTable dt = salesmanDataConnection.LoginCheck(salesman_id, pwd);
            return dt;
        }
    }
}
