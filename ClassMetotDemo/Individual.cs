using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class Individual : IProduct
    {
        public int Id { get; set; }
        public double AccountBalance { get; set; }
        public string Phone { get; set; }
        public int City { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TCKimlikNo { get; set; }
    }
}
