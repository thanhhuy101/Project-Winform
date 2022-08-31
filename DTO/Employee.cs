using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Employee
    {
        public int Emp_ID { get; set; }
        public string Emp_Name { get; set; }
        public string Emp_Phone { get; set; }
        public string Account { get; set; }

        public string Password { get; set; }
        public string Role { get; set; }

        public Employee() { }
    }
}
