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
            a =Convert.ToInt32(  Console.ReadLine());
            Console.WriteLine("Ведите b");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ведите знак \n 1)+ \n 2)- \n 3)* \n 4)/ \n 5)фактариал 6)корень");
            z = Convert.ToInt32(Console.ReadLine());
        }
    }
}
