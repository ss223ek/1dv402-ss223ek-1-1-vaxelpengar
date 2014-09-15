using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ss223ek_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            uint total;
            double subtotal, roundingOffAmount, payedAmount, change;
            int numberOf1, numberOf5, numberOf10, numberOf20, numberOf50, numberOf100, numberOf500, remainingNumberOf1;
            
            //mata in totalsumma och betalbelopp, kontrollera så inget är fel i datatyp
           while (true)
	       {
	         try
            {
                Console.Write("Ange totalsumman     :");
                subtotal=double.Parse(Console.ReadLine());
                break;
            }
            catch
            {
                Console.Write("Något blev fel, mata in ett tal");   
            }   
           }


           // om totalsumma avrundas till noll bryts allt

           total = (uint)Math.Round(subtotal);
            if(total<1)
            {
                Console.Write("Totalsumman är för liten! Köpet kunde inte genomföras.");
                //bryt
            }
            

            while (true)
	       {
	         try
            {
                Console.Write("Ange erhållet belopp     :");
                payedAmount=double.Parse(Console.ReadLine());
                break;
            }
            catch
            {
                Console.Write("Något blev fel, mata in ett tal");   
            }   
           }


            
          

            // om betalbelopp är för litet bryta allt
            if(payedAmount<total)
            {
                Console.Write("Erhållet belopp är för litet. Köpet kunde inte genomföras.");
            }

            // beräkna öresavrundning och hur mycket som ska ges tillbaka
                roundingOffAmount = total - subtotal;
                change = payedAmount - total;

            // Skriv ut kvitto

                Console.WriteLine("To \t:\t{0:f2}",subtotal);
                Console.WriteLine("To \t:\t{0:f2}", roundingOffAmount);
                Console.WriteLine("To \t:\t{0:f0}", total);
                Console.WriteLine("To \t:\t{0:f2}", payedAmount);
                Console.WriteLine("To \t:\t{0:f2}", change);

            //beräkna hur många av varje mynt och sedel som detta kan ges tillbaka i

                remainingNumberOf1 = (int)change;

                numberOf500 = remainingNumberOf1 / 500;
                remainingNumberOf1 = remainingNumberOf1 % 500;

                numberOf100 = remainingNumberOf1 / 100;
                remainingNumberOf1 = remainingNumberOf1 % 100;

                numberOf50 = remainingNumberOf1 / 50;
                remainingNumberOf1 = remainingNumberOf1 % 50;

                numberOf20 = remainingNumberOf1 / 20;
                remainingNumberOf1 = remainingNumberOf1 % 20;

                numberOf10 = remainingNumberOf1 / 10;
                remainingNumberOf1 = remainingNumberOf1 % 10;

                numberOf5 = remainingNumberOf1 / 5;
                remainingNumberOf1 = remainingNumberOf1 % 5;
                numberOf1 = remainingNumberOf1;



            //här kommer en sista utskrift
                Console.WriteLine("500-lappar \t: {0}",numberOf500);
                Console.WriteLine("100-lappar \t: {0}", numberOf100);
                Console.WriteLine("50-lappar \t: {0}", numberOf50);
                Console.WriteLine("20-lappar \t: {0}", numberOf20);
                Console.WriteLine("10-kronor \t: {0}", numberOf10);
                Console.WriteLine("5-kronor \t: {0}", numberOf5);
                Console.WriteLine("1-kronor \t: {0}", numberOf1);




        }
    }
}
