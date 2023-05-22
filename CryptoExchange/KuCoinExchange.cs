using Kucoin.Net.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoExchange
{
    public class KuCoinExchange:IExchange
    {
        public decimal GetPrice(string symbol)
        {
            try
            {
                var symbol1 = new string(symbol.Take(3).ToArray());
                var symbol2 = new string(symbol.Skip(3).Take(3).ToArray());
                var kuCoinClient = new KucoinClient();
                var prices = kuCoinClient.SpotApi.ExchangeData.GetFiatPricesAsync(symbol2, new[] { symbol1 }).Result
                    .Data;
                return prices[symbol1];
            }
            catch (Exception e)
            {
                return 0;
            }
        }
    }
}
