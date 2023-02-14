using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pcoin
{
    public class TRX
    {
        public int id { get; set; }
        public string Sender { get; set; } // public key of transaction sender
        public string Receiver { get; set; } // public key of transaction Receiver
        public double Amount { get; set; } // Amount of transaction
        public DateTime TimeStamp { get; set; } // Time of Transaction
        public double fee { get; set; } // Transaction fee
        public string feeRecipient { get; set; } // public key of fee Recipient 
    }
}