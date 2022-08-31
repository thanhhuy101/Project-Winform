using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class CheckOrderDAO
    {
        public bool updateCheckOrder(CheckOrder check)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=sql.bsite.net\\MSSQL2016; User Id=huynhhuu_food; Password=123456; Database=huynhhuu_food";
            //insert / update /delete

            string s = string.Format("Update [dbo].[order_] " +
                "set ID_user={0}, Status='{1}' where order_id={2} ",
                                                  check.ID_user, check.Status, check.order_id);
            SqlCommand sqlCommand = new SqlCommand(s);
            try
            {
                con.Open();
                sqlCommand.Connection = con;
                sqlCommand.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool deleteCheckOrder(int id)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=sql.bsite.net\\MSSQL2016; User Id=huynhhuu_food; Password=123456; Database=huynhhuu_food";
            //insert / update /delete

            SqlCommand sqlCommand = new SqlCommand(string.Format("Delete [dbo].[order_] where order_id={0}", id));
            try
            {
                con.Open();
                sqlCommand.Connection = con;
                sqlCommand.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public bool insertCheckOrder(CheckOrder check)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=sql.bsite.net\\MSSQL2016; User Id=huynhhuu_food; Password=123456; Database=huynhhuu_food";
            //insert / update /delete

            SqlCommand sqlCommand = new SqlCommand(string.Format("INSERT INTO [dbo].[order_] ( [order_id], [ID_user]) VALUES ( {0}, {1})",
                                                  check.order_id, check.ID_user
                                                   ));
            try
            {
                con.Open();
                sqlCommand.Connection = con;
                sqlCommand.ExecuteNonQuery();
                con.Close();

            return true;            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public DataSet getAllCheckOrder()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=sql.bsite.net\\MSSQL2016; User Id=huynhhuu_food; Password=123456; Database=huynhhuu_food";
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from View_Check", con);
            try
            {
                con.Open();
                adapter.Fill(ds);
                con.Close();
            }
            catch (Exception ex)
            {
                return null;
            }
            return ds;
        }
    }
}
