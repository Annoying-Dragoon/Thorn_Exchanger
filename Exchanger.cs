using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thorn_Exchanger
{
    public static class Exchanger
    {
        public static double USDtoGBP(double USD)
        {
            return USD * 1.37887;
        }
        public static double USDtoCAN(double USD)
        {
            return USD * 0.79728;
        }
        public static double USDtoEUR(double USD)
        {
            return USD * 1.19648;
        }
        public static double GBPtoUSD(double GBP)
        {
            return GBP * 0.72523;
        }
        public static double GBPtoCAN(double GBP)
        {
            return GBP * 0.57848;
        }
        public static double GBPtoEUR(double GBP)
        {
            return GBP * 0.86826;
        }
        public static double CANtoUSD(double CAN)
        {
            return CAN * 1.25427;
        }
        public static double CANtoGBP(double CAN)
        {
            return CAN * 1.72947;
        }
        public static double CANtoEUR(double CAN)
        {
            return CAN * 1.50040;
        }
        public static double EURtoUSD(double EUR)
        {
            return EUR * 0.83572;
        }
        public static double EURtoGBP(double EUR)
        {
            return EUR * 1.15195;
        }
        public static double EURtoCAN(double EUR)
        {
            return EUR * 0.66645;
        }
    }
}
