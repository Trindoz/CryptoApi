using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoExchange
{
    public interface IExchange
    {
        decimal GetPrice(string symbol);
    }
}
