using System;
//Kelub Thorn
//IT 112
//Notes: Fun project, took some time but I'm glad I got everything figured out.
//I heavily tested it but I'm sure I didn't get all possible conversions tested.
//All functions implemented.
namespace Thorn_Exchanger
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Breakout = false;
            bool FinalChoice = false;
            string FirstChoice;
            string SecondChoice;
            string AnotherChoice;
            double Money;
            double TotalMoneyinUSD = 0;
            int NmbrOfExchanges;
            ExchangeMonitor Monitor = new ExchangeMonitor();
            do
            {
                NmbrOfExchanges = Monitor.NumberofExchanges();
                Console.WriteLine("What currency would you like to convert?");
                FirstChoice = ChoiceMethod();
                Console.WriteLine("How much money are you converting?");
                Money = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("What currency would you like to convert to?");
                SecondChoice = ChoiceMethod();
                if (FirstChoice == "USD")
                {
                    if (SecondChoice == "GBP")
                    {
                        Money = Exchanger.USDtoGBP(Money);
                    }
                    else if (SecondChoice == "CAN")
                    {
                        Money = Exchanger.USDtoCAN(Money);
                    }
                    else if (SecondChoice == "EUR")
                    {
                        Money = Exchanger.USDtoEUR(Money);
                    }
                    else if (SecondChoice == "USD")
                    {
                        Money = Money * 1;
                    }
                }
                else if (FirstChoice == "GBP")
                {
                    if (SecondChoice == "GBP")
                    {
                        Money = Money * 1;
                    }
                    else if (SecondChoice == "CAN")
                    {
                        Money = Exchanger.GBPtoCAN(Money);
                    }
                    else if (SecondChoice == "EUR")
                    {
                        Money = Exchanger.GBPtoEUR(Money);
                    }
                    else if (SecondChoice == "USD")
                    {
                        Money = Exchanger.GBPtoUSD(Money);
                    }
                }
                else if (FirstChoice == "CAN")
                {
                    if (SecondChoice == "GBP")
                    {
                        Money = Exchanger.CANtoGBP(Money);
                    }
                    else if (SecondChoice == "CAN")
                    {
                        Money = Money * 1;
                    }
                    else if (SecondChoice == "EUR")
                    {
                        Money = Exchanger.CANtoEUR(Money);
                    }
                    else if (SecondChoice == "USD")
                    {
                        Money = Exchanger.CANtoUSD(Money);
                    }
                }
                else if (FirstChoice == "EUR")
                {
                    if (SecondChoice == "GBP")
                    {
                        Money = Exchanger.EURtoGBP(Money);
                    }
                    else if (SecondChoice == "CAN")
                    {
                        Money = Exchanger.EURtoCAN(Money);
                    }
                    else if (SecondChoice == "EUR")
                    {
                        Money = Money * 1;
                    }
                    else if (SecondChoice == "USD")
                    {
                        Money = Exchanger.EURtoUSD(Money);
                    }
                }
                Console.Clear();
                Console.WriteLine("Your money in " + SecondChoice + " is:" + String.Format("{0:0.00}", Money));
                
                if (SecondChoice == "USD")
                {
                   TotalMoneyinUSD =
                        Monitor.TotalAmount(Money);
                }
                else if (SecondChoice == "GBP")
                {
                    Money = Exchanger.GBPtoUSD(Money);
                    TotalMoneyinUSD = Monitor.TotalAmount(Money);
                }
                else if (SecondChoice == "CAN")
                {
                    Money = Exchanger.CANtoUSD(Money);
                    TotalMoneyinUSD = Monitor.TotalAmount(Money);
                }
                else if(SecondChoice == "EUR")
                {
                    Money = Exchanger.EURtoUSD(Money);
                    TotalMoneyinUSD = Monitor.TotalAmount(Money);
                }
               
                do
                {
                    Console.WriteLine("Would you like to do another exchange?");
                    Console.WriteLine("1. Yes 2.No");
                    AnotherChoice = Console.ReadLine();
                    if (AnotherChoice == "1")
                    {
                        FinalChoice = true;
                        Breakout = false;
                        Console.Clear();
                    }
                    else if (AnotherChoice == "2")
                    {
                        FinalChoice = true;
                        Breakout = true;
                    }
                    else
                    {
                        FinalChoice = false;
                        Breakout = false;
                        Console.WriteLine("Please press 1 or 2 and then press Enter.");
                    }
                } while (FinalChoice == false);
                
            } while (Breakout == false);
            Console.Clear();
            Console.WriteLine("You have made " + NmbrOfExchanges + " exchange(s)");
            Console.WriteLine("The Total Amount in USD is: " + String.Format("{0:0.00}", TotalMoneyinUSD));
        }

        
        public static string ChoiceMethod()
        {

            bool Breakout2 = false;
            string Currency = null;
            do
            {
                string choice;
                Console.WriteLine("1. USD 2. GBP 3. CAN, 4. EUR"); 
                choice = Console.ReadLine();
               if(choice == "1")
               {
                    Breakout2 = true;
                    Currency = "USD";
               }
               else if(choice == "2")
               {
                    Breakout2 = true;
                    Currency = "GBP";
               }
               else if(choice == "3")
               {
                    Breakout2 = true;
                    Currency = "CAN";
               }
               else if (choice == "4")
               {
                    Breakout2 = true;
                    Currency = "EUR";
                    
               }
               else
               {
                    Console.WriteLine("Please press 1, 2, 3, or 4 and then press Enter");
                    Breakout2 = false;
               }
            } while (Breakout2 == false);
            return Currency;
        }
    }
}
