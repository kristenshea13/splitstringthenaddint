using System;
using System.Collections.Generic;
using System.Linq;

namespace splitstringthenaddint
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = "1, 2, 3";

            string[] numbersSplit = numbers.Split(", ");

            var numbersInt = new List<int>();

            foreach (var item in numbersSplit)
            {
                int number = int.Parse(item);
                numbersInt.Add(number);
                
            }
            int total = 0;

            foreach (var number in numbersInt)
            {
                total = numbersInt.Sum();
            }

            Console.WriteLine($"The total of all numbers added from this list is: {total}");
            Console.ReadLine();



        }
    }
}
