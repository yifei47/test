using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // Single-dimensional array
            int[] numbers = new int[5];

            // Multidimensional array
            string[,] names = new string[5, 4];

            // Array-of-arrays (jagged array)
            byte[][] scores = new byte[5][];

            // Create the jagged array
            for (int i = 0; i < scores.Length; i++)
            {
                scores[i] = new byte[i + 3];
            }

            // Print length of each row
            for (int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine("Length of row {0} is {1}", i, scores[i].Length);
            }
            */
            Phonebook red = new Phonebook();
            Console.WriteLine(red.toString());
            red.setName("Red");
            red.setNumber(1234567);
            Console.WriteLine(red.toString());
            Console.WriteLine("This: {0}", red.test);

            Phonebook Yifei = new Phonebook("Yifei", 9876543, new DateTime());

            Console.WriteLine(Yifei.toString());
            Console.ReadLine();
            //test

            // all for testing
        }
    }
}
