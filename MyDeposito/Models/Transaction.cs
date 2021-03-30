using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyDeposito.Models
{
    public class Transaction
    {
        public int ID { get; set; }

        public double Jumlah { get; set; }

        public DateTime Created_at { get; set; }
    }
}
