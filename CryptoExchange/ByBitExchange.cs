using Bybit.Net.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoExchange
{
    public class ByBitExchange:IExchange
    {
        private BybitClient byBitClient;

        public ByBitExchange()
        {
            byBitClient = new BybitClient();
        }
        public decimal GetPrice(string symbol)
        {
            try
            {
                var price = byBitClient.SpotApiV1.ExchangeData.GetPriceAsync(symbol).Result.Data.Price;
                return price;
            }
            catch (Exception e)
            {
                return 0;
            }
        }
    }
}
