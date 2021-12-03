using System;

namespace MİDTERM_Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter the numbers of the equation whose roots you want to find.");
            double a;
            a = Convert.ToDouble(Console.ReadLine());
            double b;
            b = Convert.ToDouble(Console.ReadLine());
            double c;
            c = Convert.ToDouble(Console.ReadLine());
            double e;
            e = (b * b - 4 * a * c);
            double d1 = ( (-b) + Math.Sqrt(e) )/(2*a);

            double d2 = ((-b ) - Math.Sqrt(e)) / (2 * a);

            if (e==0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("The function has one reel root d1,d2= " + d1);
                Console.ResetColor();
            }

            else if (e<0)

            { 

                double t = (-b) / 2 * a;
                double i = Math.Sqrt(-e) / 2 * a;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("The function has two imaginary roots x1 =" + t + "+" + i+"i   " );
                Console.Write("x2= " + t + "-" + i + "i");
                Console.ResetColor();
            }
           
            else {
                Console.ForegroundColor = ConsoleColor.Green; 
                Console.WriteLine("The function has two reel root d1= "+ d1 + "  d2 = "+ d2);
                Console.ResetColor();
            }



        }
    }
}
