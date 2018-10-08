using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    class Program
    {
        static void Main(string[] args)
        {

            double a = 0, b = 0, c = 0, D, x1 = 0, x2 = 0;
            bool f = false;
            do
            {
              
                Console.Write("Enter the A:");
                try
                {
                    a = readNumber();
                    f = true;
                }
                catch(Exception e)
                {

                }
            } while (!f);

            do
            {

                Console.Write("Enter the B:");
                try
                {
                    b = readNumber();
                    f = true;
                }
                catch (Exception e)
                {

                }
            } while (!f);

            do
            {

                Console.Write("Enter the C:");
                try
                {
                    c = readNumber();
                    f = true;
                }
                catch (Exception e)
                {

                }
            } while (!f);
           
            D = Disc(a,b,c);

            f = false;
            if (D >= 0)
            {
                x1 = (-b - D) / (2 * a);
                x2 = (-b + D) / (2 * a);
                f = true;
            }

            if (f)
            {
                if(x1 == x2)
                {
                    Console.Write("X = {0}", x1);
                }
                else
                {
                    Console.Write("X1 = {0}", x1);
                    Console.Write("X2 = {0}", x2);
                }
            }
            else
            {
                Console.Write("There is no roots");
            }

            Console.ReadLine();
        }



        private static double readNumber() 
        {
            bool f = false;
            double num = 0;
            string str = Console.ReadLine();
            f = double.TryParse(str, out num);
            if (!f)
            {
                Console.Write("Wrong number:");
                throw new System.Exception();
            }
          
            return num;
        }

        private static double Disc(double a, double b, double c)
        {
           return  Math.Sqrt(Math.Pow(b,2) - 4*a*c);
        }

       
    }
}
