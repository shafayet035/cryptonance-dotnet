using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cryptonance.models
{
    internal class Crypto
    {
        public object id { get; set; }
        public string name { get; set; }
        public string tag { get; set; }
        public float price { get; set; }

        public float sellingRate { get; set; }

        public Crypto(object id, string name, string tag, float price, float sellingRate)
        {
            this.id = id;
            this.name = name;
            this.tag = tag;
            this.price = price;
            this.sellingRate = sellingRate;
        }
    }
}
