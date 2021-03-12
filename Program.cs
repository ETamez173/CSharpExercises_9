using System;


// Building a Calculator | C# | Tutorial 9

namespace CSharpExercises_9
{
    class Program
    {
        static void Main(string[] args)
        {

            //   "45.80" need to convert to an int
            //   Console.WriteLine("43" + "56");

            //int num = Convert.ToInt32("45");
            //Console.WriteLine(num + 6);


            // Readline() gives us the user entry as a string so we must convert
            // to an int or a double etc.

            Console.Write("Enter a number:  ");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter another number:  ");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The answer is  " + (num1 + num2));

            Console.ReadLine();

        }
    }
}
