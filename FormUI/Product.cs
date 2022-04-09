using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormUI
{
    public class Product
    {
        public int id { get; set; }
        public string ItemNumber { get; set; }
        public string ItemDescription { get; set; }

        public string ProductInfo 
        { 
            get
            {
                return $"{ id } { ItemNumber } { ItemDescription }";
            }
        }
    }
}
