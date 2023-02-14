using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Pcoin
{

    public class Block
    {
        public int id { get; set; }
        public DateTime TimeStamp { get; set; }
        public double Reward { get; set; } // for start its 50(Pcoin)  Like BTC :D
        public List<TRX> TRXs { get; set; } // No limit for trx count
        public int Dificulty { get; set; } // Dificulty level of network
        public string PreviousHash { get; set; }
        public string Nonce { get; set; } //the currect nonce to mine this block
    }
}