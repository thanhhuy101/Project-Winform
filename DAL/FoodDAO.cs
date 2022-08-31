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
    public class FoodDAO
    {
        //insert
        public bool insertFood(Food f)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=sql.bsite.net\\MSSQL2016; User Id=huynhhuu_food; Password=123456; Database=huynhhuu_food";
            //insert / update /delete

            SqlCommand sqlCommand = new SqlCommand(string.Format("INSERT [dbo].[food] ( [ID_Food], [Name_], [Describe], [Price], [Img])  VALUES ( {0}, N'{1}', N'{2}', {3}, N'{4}' )",
                                                  f.Id ,f.Name, f.Des, f.Price, f.Img));
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
        public bool deleteFood(int id)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=sql.bsite.net\\MSSQL2016; User Id=huynhhuu_food; Password=123456; Database=huynhhuu_food";
            //insert / update /delete

            SqlCommand sqlCommand = new SqlCommand(string.Format("Delete [dbo].[food] where ID_Food={0}", id));
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
        public bool updateFood(Food f)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=sql.bsite.net\\MSSQL2016; User Id=huynhhuu_food; Password=123456; Database=huynhhuu_food";
            //insert / update /delete

            string s = string.Format("Update [dbo].[food] " +
                "set Name_='{0}', Describe='{1}', Price ={2}, Img ='{3}' where ID_Food={4} ",
                                                  f.Name, f.Des, f.Price, f.Img, f.Id);
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
        public DataSet getAllFood()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=sql.bsite.net\\MSSQL2016; User Id=huynhhuu_food; Password=123456; Database=huynhhuu_food";
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from food", con);
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

        public Food getDetails(int id)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=sql.bsite.net\\MSSQL2016; User Id=huynhhuu_food; Password=123456; Database=huynhhuu_food";
                //tim cac nhan vien theo ma phong ban
                SqlCommand cmd = new SqlCommand("select * from food where ID_Food=" + id, con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Food f = new Food()
                    {
                        Name = dr.GetString(0),
                        Des = dr.GetString(1),
                        Price = Int32.Parse(dr.GetString(2)),
                        Img = dr.GetString(3),
                        
                    };
                    return f;
                }
            }
            catch (Exception ex)
            {
            }
            return null;
        }
    }
}
