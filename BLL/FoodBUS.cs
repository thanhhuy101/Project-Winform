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
    public class FoodBUS
    {
        private FoodDAO dao = new FoodDAO();

        public bool createFood(Food f)
        {

            return dao.insertFood(f);

        }
        public bool UpdateFood(Food f)
        {

            return dao.updateFood(f);

        }
        public bool DeleteFood(int id)
        {

            return dao.deleteFood(id);

        }

        public DataSet getAllFood()
        {

            return dao.getAllFood();
        }
    }
}
