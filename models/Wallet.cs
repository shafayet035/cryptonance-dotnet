using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cryptonance.models
{
    internal class Wallet
    {
        public object id { get; set; }
        public float btc { get; set; }

        public float ltc { get; set; }

        public float eth { get; set; }


        public Wallet(object id, float btc, float ltc, float eth)
        {
            this.id = id;
            this.btc = btc;
            this.ltc = ltc;
            this.eth = eth;
        }

        public float GetCryptoBalance(string crypto)
        {
            if (crypto == "BTC")
            {
                return this.btc;
            }
            else if (crypto == "LTC")
            {
                return this.ltc;
            }
            else if (crypto == "ETH")
            {
                return this.eth;
            }
            return 0;
        }

        public void addAmount(float amount, string crypto)
        {
            if (crypto == "BTC")
            {
                this.btc += amount;
            }
            else if (crypto == "LTC")
            {
                this.ltc += amount;
            }
            else if (crypto == "ETH")
            {
                this.eth += amount;
            }
        }

        public void removeAmount(float amount, string crypto)
        {
            if (crypto == "BTC")
            {
                this.btc -= amount;
            }
            else if (crypto == "LTC")
            {
                this.ltc -= amount;
            }
            else if (crypto == "ETH")
            {
                this.eth -= amount;
            }
        }

    }
}
