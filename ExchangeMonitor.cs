using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thorn_Exchanger
{
    
    public class ExchangeMonitor
    {
       int exchanges;
       double TotalAmountInUSD;
       public int NumberofExchanges()
        {
            exchanges = exchanges + 1;
            return exchanges;
        }
       public double TotalAmount(double incomingAmount)
       {
            TotalAmountInUSD = TotalAmountInUSD + incomingAmount;
            return TotalAmountInUSD;
       }
    }
}
