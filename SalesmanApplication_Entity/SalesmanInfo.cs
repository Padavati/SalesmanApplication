using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesmanApplication_Entity
{
    public class SalesmanInfo
    {
        public int salesman_id { get; set; }
        public string name { get; set; }
        public string city { get; set; }
        public decimal commission { get; set; }
        public string pwd { get; set; }
    }
}
