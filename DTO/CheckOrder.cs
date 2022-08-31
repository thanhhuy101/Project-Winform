using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CheckOrder
    {
        public int order_id { get; set; }
        public int ID_user { get; set; }
        public string Status { get; set; }

        public CheckOrder() { }
    }
}
