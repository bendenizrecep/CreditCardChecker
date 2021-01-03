using System;

namespace creditcardchecker
{
    class Program
    {
        static void Main(string[] args)
        {
            long cardnumber;
            
            do
            {
                Console.WriteLine("Enter the Card Number:");
                cardnumber = Convert.ToInt64(Console.ReadLine());
            } while (cardnumber <= 0);

            long cc = cardnumber;
            int sum = 0;
            int x = 0;
            long bolen = 10;
            
            while (cc > 0)
            {
                int lastnumber = (int)(cc % 10);
                sum = sum + lastnumber;
                cc =  cc / 100;
            }
            cc = cardnumber / 10;
            while(cc > 0)
            {
                int lastnumber = (int)(cc % 10);
                int x2 = lastnumber * 2;
                sum = sum + (x2 / 10) + (x2 % 10);
                cc = cc / 100;}

            cc = cardnumber;
            while (cc != 0)
            {
                cc = cc / 10;
                x++;
            }
            for (int i = 0; i < x-2; i++)
            {
                bolen = bolen * 10;
            }
            int firstnumber = (int)(cardnumber / bolen);
            int firs2number = (int)(cardnumber / (bolen / 10));
    
            if (sum % 10 == 0)
            {
                if (firstnumber == 4 && (x == 13 || x == 16)) { 
                    Console.WriteLine("VISA");
                }
                else if (firs2number == 34 || firs2number == 37 && (x == 15 ))
                {
                    Console.WriteLine("AMEX");
                }
                else if (50 < firs2number && firs2number < 56 && (x == 16))
                {
                    Console.WriteLine("MasterCard");
                }
                else
                {
                    Console.WriteLine("INVALID");
                }
            }
            else
            {
                Console.WriteLine("INVALID");
            }

        }
    }
}
