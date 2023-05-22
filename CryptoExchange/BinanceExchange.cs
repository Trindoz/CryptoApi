using Binance.Net.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoExchange
{
    public class BinanceExchange:IExchange
    {
        private BinanceClient binanceClient;

        public BinanceExchange()
        {
            binanceClient = new BinanceClient();
        }
        public decimal GetPrice(string symbol)
        {
            try
            {
                var price = binanceClient.SpotApi.ExchangeData.GetPriceAsync(symbol).Result.Data.Price;
                return price;
            }
            catch (Exception e)
            {
                return 0;
            }
        }
    }
}
