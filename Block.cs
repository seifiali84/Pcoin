using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pcoin
{

    public class Block
    {
        public int id { get; set; }
        public DateTime TimeStamp { get; set; }
        public double BlockReward { get; set; }
        public List<TRX> TRXs { get; set; } // No limit for trx count
        public int Dificulty { get; set; } // Dificulty level of network
        public string PreviousHash { get; set; }
    }
}