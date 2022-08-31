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
    public class DetailOrderBUS
    {
        private DetailOrderDAO de_dao = new DetailOrderDAO();

        public bool createOrder(DetailOrder de)
        {

            return de_dao.insertDetailOrder(de);

        }
        public bool updateDetailOrder(DetailOrder de)
        {

            return de_dao.updateDetailOrder(de);

        }
        public bool deleteDetailOrder(int id)
        {

            return de_dao.deleteDetailOrder(id);

        }

       

        public DataSet getAllDetailOrder()
        {

            return de_dao.getAllDetailOrder();
        }
    }
}
