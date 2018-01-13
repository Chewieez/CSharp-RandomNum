using System;
using System.Collections.Generic;
using System.Linq;

namespace random
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();

            // Create a list
            List<int> randomNumList = new List<int>();

            // Populate the list
            randomNumList.Add(random.Next(1, 51));
            randomNumList.Add(random.Next(1, 51));
            randomNumList.Add(random.Next(1, 51));
            randomNumList.Add(random.Next(1, 51));
            randomNumList.Add(random.Next(1, 51));
            randomNumList.Add(random.Next(1, 51));
            randomNumList.Add(random.Next(1, 51));
            randomNumList.Add(random.Next(1, 51));
            randomNumList.Add(random.Next(1, 51));
            randomNumList.Add(random.Next(1, 51));
            randomNumList.Add(random.Next(1, 51));
            randomNumList.Add(random.Next(1, 51));
            randomNumList.Add(random.Next(1, 51));
            randomNumList.Add(random.Next(1, 51));
            randomNumList.Add(random.Next(1, 51));
            randomNumList.Add(random.Next(1, 51));
            randomNumList.Add(random.Next(1, 51));
            randomNumList.Add(random.Next(1, 51));
            randomNumList.Add(random.Next(1, 51));
            randomNumList.Add(random.Next(1, 51));

            // iterate through list of numbers and square each one and place them in a new ienumerable list
            IEnumerable<int> randomSqNumList = randomNumList.Select(num => num * num);

            /* alternate option */
            // IEnumerable<int> randomSqNumList = from i in randomNumList
            //                                    select i * i;

            
            // remove all the odd squared numbers
            randomSqNumList = randomSqNumList.Where(num => num % 2 == 0);

            // print out numbers in both lists to confirm computation worked correctly
            foreach (int num in randomNumList)
            {
                Console.Write(num + ", " );
            }
            
            Console.WriteLine();

            foreach (int num in randomSqNumList)
            {
                Console.Write(num + ", ");
            }


        }
    }
}
