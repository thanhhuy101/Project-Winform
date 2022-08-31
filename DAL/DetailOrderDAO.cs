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
    public class DetailOrderDAO
    {
        //insert
        public bool insertDetailOrder(DetailOrder de)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=sql.bsite.net\\MSSQL2016; User Id=huynhhuu_food; Password=123456; Database=huynhhuu_food";
            //insert / update /delete

            SqlCommand sqlCommand = new SqlCommand(string.Format("INSERT [dbo].[details] ( [ID_order], [ID_foods], " +
                "[Discount],  [Quantity], [ID_emp], [ID_user],[Date])  VALUES ( {0}, {1}, {2}, {3}, {4},{5},'{6}')",
                                                  de.ID_order, de.ID_foods, de.Discount, de.Quantity, de.ID_emp,de.ID_user,
                                                   de.Date.ToString("yyyy/MM/dd")));
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

        //delete
        public bool deleteDetailOrder(int id)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=sql.bsite.net\\MSSQL2016; User Id=huynhhuu_food; Password=123456; Database=huynhhuu_food";
            //insert / update /delete
            
            SqlCommand sqlCommand = new SqlCommand(string.Format("Delete [dbo].[details] where ID_order={0}", id));

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

        //update
        public bool updateDetailOrder(DetailOrder de)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=sql.bsite.net\\MSSQL2016; User Id=huynhhuu_food; Password=123456; Database=huynhhuu_food";
            //insert / update /delete

            string s = string.Format("Update [dbo].[details] " +
                "set ID_foods='{0}', Discount='{1}', Quantity={2}, ID_emp='{3}', ID_user ='{4}', Date ='{5}' where ID_order={6} ",
                                                  de.ID_foods, de.Discount, de.Quantity, de.ID_emp, de.ID_user, de.Date, de.ID_order);
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

        //getall
        public DataSet getAllDetailOrder()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=sql.bsite.net\\MSSQL2016; User Id=huynhhuu_food; Password=123456; Database=huynhhuu_food";
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from vw_Order", con);
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
