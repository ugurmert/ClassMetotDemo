using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class Corporate : IProduct
    {
        public int Id { get; set; }
        public double AccountBalance { get; set; }
        public string Phone { get; set; }
        public int City { get; set; }

        public string Unvan { get; set; }
        public string VergiNo { get; set; }
    }
}
