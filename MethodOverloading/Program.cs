using System;

namespace MethodOverloading
{
    class Program
    {//Create a method named Add, that accepts two integers and returns the sum of those two integers

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        //Now create an overload of the Add method to account for being able to add two decimals together

        public static double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        /*Now create another overload of the Add method that returns a string 
         * and accepts 3 parameters: 2 integers and 1 boolean*/

        public static string Add(int num1, int num2, bool isTrue)
        {
            var sum = 0;

            var response = "";
            {
                sum = num1 + num2;
                if (sum == 1)
                {
                    response = $"{sum} dollar.";
                }
                else
                {
                    response = $"{sum} dollars.";
                }
                return response;
            }

        }

        public static void Main(string[] args)
        {
            Console.WriteLine(Add(0, 1, true));

            Console.WriteLine();

            Console.WriteLine(Add(5, 7, true));

            Console.WriteLine();

            Console.WriteLine(Add(6, 3, true));
        }
    }
}
