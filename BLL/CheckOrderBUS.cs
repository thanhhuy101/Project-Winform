using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;

namespace BLL
{
    public class CheckOrderBUS
    {
        private CheckOrderDAO order = new CheckOrderDAO();
        public bool UpdateCheckOrder(CheckOrder c)
        {

            return order.updateCheckOrder(c);

        }
        public bool DeleteCheckOrder(int id)
        {

            return order.deleteCheckOrder(id);

        }
        public bool createCheckOrder(CheckOrder co)
        {

            return order.insertCheckOrder(co);

        }

        public DataSet getAllCheckOrder()
        {

            return order.getAllCheckOrder();
        }
    }
}
