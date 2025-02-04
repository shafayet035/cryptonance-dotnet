using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cryptonance.models
{
    internal class Transaction
    {
        public object id { get; set; }

        public string type { get; set; }

        public string receiverEmail { get; set; }

        public float totalPrice { get; set; }

        public float cryptoAmount { get; set; }

        public string cryptoName { get; set; }

        public Transaction(object id, string type, string receiverEmail, float totalPrice, float cryptoAmount, string cryptoName)
        {
            this.id = id;
            this.type = type;
            this.receiverEmail = receiverEmail;
            this.totalPrice = totalPrice;
            this.cryptoAmount = cryptoAmount;
            this.cryptoName = cryptoName;
        }
    }
}
