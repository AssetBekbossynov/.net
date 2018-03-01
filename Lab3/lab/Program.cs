using System;
using lib2;

namespace lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b");
            int b = Convert.ToInt32(Console.ReadLine());

            if(a - b == Calculator.Substract(a, b)){
                Console.WriteLine("true " + (a - b));
            }else{
                Console.WriteLine("false");
            }
            if(a + b == Calculator.Add(a, b)){
                Console.WriteLine("true " + (a + b));
            }else{
                Console.WriteLine("false");
            }
            if(a * b == Calculator.Multiply(a, b)){
                Console.WriteLine("true " + (a * b));
            }else{
                Console.WriteLine("false");
            }
            if(a / b == Calculator.Divide(a, b)){
                Console.WriteLine("true " + (a / b));
            }else{
                Console.WriteLine("false");
            }
        }
    }
}
