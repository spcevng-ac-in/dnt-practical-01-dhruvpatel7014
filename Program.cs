using System;

namespace pra1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int temp = num;
            while (temp > 0) 
            {
              int rem = num % 10;
                sum += rem;
                temp = temp / 10;

              
            }
            Console.WriteLine("summation of number is" + sum);
            Console.ReadLine();

        }
    }
}
