using System;

namespace git3_kalk
{
    class Program
    {
        static void Main(string[] args)
        {

            int a;
            int b;
            int c;
            int z;

            Console.WriteLine("Ведите а");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ведите b");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ведите знак \n 1)+ \n 2)- \n 3)* \n 4)/ \n 5)фактариал 6)корень");
            z = Convert.ToInt32(Console.ReadLine());



            




            if (z == 1)
            {
                Console.WriteLine(a + b);
            }
           else if (z == 2)
            {
                Console.WriteLine(a - b);
            }

           


            else if (z == 3)
                Console.WriteLine("a*b = " + a*b);
            

            else if (z == 4)
                Console.WriteLine("a/b = " + a / b);

            else if (z == 5)
            {
                Console.WriteLine("a! = ");
                int factorial = 1;
                for (int i = 1; i <= a; i++)
                {
                    factorial *= i;

                }
                Console.Write(factorial);

            }


            else if (z == 6)
                Console.WriteLine("koren a = " + Math.Sqrt(a));
        }
    }
}
