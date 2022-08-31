using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DetailOrder
    {
        public int ID_order { get; set; }
        public int ID_foods { get; set; }
        public int Discount { get; set; }
        public int ID_emp { get; set; }
        public int ID_user { get; set; }
        public int Total { get; set; }
        public int Quantity { get; set; }
        public DateTime Date { get; set; } 
        public DetailOrder() { }
    }
}
