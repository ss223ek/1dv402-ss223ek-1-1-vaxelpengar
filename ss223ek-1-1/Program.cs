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
            double subtotal, roundingOffAmount, payedAmount;
            
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
                break;
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

            // Skriv ut kvitto


            //beräkna hur många av varje mynt och sedel som detta kan ges tillbaka i

            //har kommer en sista rad v1

        }
    }
}
