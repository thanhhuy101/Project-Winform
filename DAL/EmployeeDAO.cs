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
    public class EmployeeDAO
    {
        public Employee getDetails(string username)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=sql.bsite.net\\MSSQL2016;User Id=huynhhuu_food; Password=123456; database=huynhhuu_food";
                //tim cac nhan vien theo ma phong ban
                SqlCommand cmd = new SqlCommand("select * from employee where Account='" + username + "'", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    //Nếu có kqa tạo
                    Employee emp = new Employee()
                    {
                        Account = dr.GetString(1),
                        Password = dr.GetString(2),
                        Role = dr.GetString(3),
                    };
                    return emp;
                }

            }
            catch (Exception ex)
            {
            }
            return null;
        }


        public DataSet getAllEmp()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=sql.bsite.net\\MSSQL2016; User Id=huynhhuu_food; Password=123456; Database=huynhhuu_food";
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from employee", con);
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

        public bool insertEmployee(Employee emp)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=sql.bsite.net\\MSSQL2016; User Id=huynhhuu_food; Password=123456; Database=huynhhuu_food";
            //insert, update, delete

            SqlCommand sqlCommand = new SqlCommand(string.Format("INSERT [dbo].[employee] ( [Emp_ID], [Emp_Name], [Emp_Phone], [Account], [Password], [Role]) VALUES ( {0}, '{1}', '{2}', '{3}', '{4}', '{5}')",
                 emp.Emp_ID, emp.Emp_Name, emp.Emp_Phone, emp.Account, emp.Password, emp.Role));
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

        public bool updateEmployee(Employee emp)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=sql.bsite.net\\MSSQL2016; User Id=huynhhuu_food; Password=123456; Database=huynhhuu_food";
            //insert, update, delete

            SqlCommand sqlCommand = new SqlCommand(string.Format("Update [dbo].[employee] set " +
                "Emp_Name='{0}' , Emp_Phone='{1}', Account='{2}', Password='{3}', Role='{4}' where Emp_ID={5} ",
                            emp.Emp_Name, emp.Emp_Phone, emp.Account, emp.Password, emp.Role, emp.Emp_ID));
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
    }
}
