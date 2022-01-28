using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesmanApplication_Entity;
using System.Data.SqlClient;
using System.Data;

namespace SalesmanApplication_Data
{
    public class SalesmanDataConnection
    {
        string sqlConnectionStr = "Data Source=LAPTOP-DL0P9UEA;Initial Catalog=Sales;Integrated Security=True";
        public string InsertSalesInfo(SalesmanInfo salesmanInfoObj)
        {
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            #region Connected Approach
            SqlCommand sqlCommandObj=new SqlCommand("Insert into Salesman values("+salesmanInfoObj.salesman_id+",'"+salesmanInfoObj.name+"','"+salesmanInfoObj.city+"',"+salesmanInfoObj.commission+",'"+salesmanInfoObj.pwd+"')",sqlConnectionObj);
            sqlConnectionObj.Open();
            sqlCommandObj.ExecuteNonQuery();
            sqlConnectionObj.Close();
            #endregion Connected Approach
            return "Salesman Details Saved Successfully";
        }
        public string UpdateSalesInfo(SalesmanInfo salesmanInfoObj)
        {
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            #region Connected Approach
            SqlCommand sqlCommandObj = new SqlCommand("Update Salesman set name='" + salesmanInfoObj.name + "',city='" + salesmanInfoObj.city + "',commission=" + salesmanInfoObj.commission + ",pwd='"+salesmanInfoObj.pwd+"' where salesman_id="+salesmanInfoObj.salesman_id+"" ,sqlConnectionObj);
            sqlConnectionObj.Open();
            sqlCommandObj.ExecuteNonQuery();
            sqlConnectionObj.Close();
            #endregion Connected Approach
            return "Salesman Details Updated Successfully";
        }
        public DataTable EditSalesInfoByID (int salesman_id)
        {
            DataTable dataTableObj = new DataTable();
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            #region Connected Approach
            SqlCommand sqlCommandObj = new SqlCommand("Select * from Salesman where salesman_id=" + salesman_id + "", sqlConnectionObj);
            sqlConnectionObj.Open();
            SqlDataReader sqlDataReaderObj = sqlCommandObj.ExecuteReader();
            dataTableObj.Load(sqlDataReaderObj);
            sqlConnectionObj.Close();
            #endregion Connected Approach
            return dataTableObj;
        }
        public string DeleteSalesInfoByID(int salesman_id)
        {
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            #region Connected Approach
            SqlCommand sqlCommandObj = new SqlCommand("Delete from Salesman where salesman_id=" + salesman_id + "", sqlConnectionObj);
            sqlConnectionObj.Open();
            sqlCommandObj.ExecuteNonQuery();
            sqlConnectionObj.Close();
            #endregion Connected Approach
            return "SalesmanId " + salesman_id + " Details Deleted Successfully";
        }
        public DataTable SelectSalesInfo()
        {
            
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            #region Connected Approach
            SqlCommand sqlCommandObj = new SqlCommand("Select * from Salesman",sqlConnectionObj);
            sqlConnectionObj.Open();
            SqlDataReader sqlDataReaderObj = sqlCommandObj.ExecuteReader();
            DataTable dataTableObj = new DataTable();
            dataTableObj.Load(sqlDataReaderObj);
            sqlConnectionObj.Close();
            #endregion Connected Approach
            return dataTableObj;
        }
        public DataTable LoginCheck(int salesman_id,string pwd)
        {
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionStr);
            SqlCommand sqlCommandObj = new SqlCommand("Select*from Salesman where salesman_id=" + salesman_id + " and pwd='" + pwd + "'", sqlConnectionObj);
            sqlConnectionObj.Open();
            SqlDataReader sqlDataReader=sqlCommandObj.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sqlDataReader);
            sqlConnectionObj.Close();
            return dt;

        }
    }
}
