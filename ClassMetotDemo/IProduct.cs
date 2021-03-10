using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    interface IProduct
    {
        public int Id { get; set; }
        public double AccountBalance { get; set; }
        public string Phone { get; set; }
        public int City { get; set; }
    }
}
