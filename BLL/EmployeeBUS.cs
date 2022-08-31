using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BLL
{
    public class EmployeeBUS
    {
        private EmployeeDAO e_dao = new EmployeeDAO();

        public bool insertEmployee(Employee emp)
        {
            return e_dao.insertEmployee(emp);
        }

        public bool updateEmployee(Employee emp)
        {

            return e_dao.updateEmployee(emp);

        }
        public DataSet getAllEmp()
        {

            return e_dao.getAllEmp();
        }

        public bool checkUserName(string username)
        {
            Employee emp = e_dao.getDetails(username);
            /*if (dept == null)
            {
                return false;
            }
            else
            {
                return true;
            }*/

            //toán tử 3 ngôi
            return emp == null ? false : true; //thay thế if - else
        }
    }
}
