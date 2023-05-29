using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    internal class Problems
    {
        
        public static void Problem1_MultipliesOf3Or5()
        {
            //https://projecteuler.net/problem=1
            int sumBelow = 1000;
            int sum = 0;

            //For loop version
            for(int i = 0; i < sumBelow;i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    sum += i;
            }
            Console.WriteLine("Sum of Mutiples of 3 or 5 below 1000:" + sum + " For Version");

            //Lambda Version
            //https://code-maze.com/csharp-sum-up-elements-of-an-array/
            sum = 0;
            int[] numbers = Enumerable.Range(0, 1000).ToArray();
            Array.ForEach(numbers,number => {
                if (number % 3 == 0 || number % 5 == 0)
                    sum += number;
            });
            Console.WriteLine("Sum of Mutiples of 3 or 5 below 1000:" + sum + " Lambda Version");

            sum = 0;
            ///TODO Write Problem 1 with Enumerable.Aggregate
            //Enumerable.Aggregate
            /*
            var sum3 = numbers.Aggregate((total, number) => total + number);
            Console.WriteLine("Sum of Mutiples of 3 or 5 below 1000:" + sum3 + " Lambda Version");

            numbers.Sum(number =>
            {
                if (number % 3 == 0 || number % 5 == 0)
                    sum += number;
            });
            */

        }
    }
}
