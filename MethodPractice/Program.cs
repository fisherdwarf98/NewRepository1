using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Method without a peramater and return.
            HelloWorld();

            //Method without a peramater but includes a return.
            string nameGet;
            nameGet = enterName();

            //Method without a return but inculdes a peramater.
            string message1 = "below you'll see two numbers get Multiplied together by a method.";
            shownMessage(message1);

            //Method with both a peramater and return.
            int total1;
            total1 = multipliedNumbers(8,9);
            Console.WriteLine("Total sum: " + total1 + ". See how cool that was.");
            Console.ReadLine();
            

        }

        //Method without a peramater and return.
        static void HelloWorld()
        {
            Console.WriteLine("Hello User!");
            Console.ReadLine();
        }

        //Method without a peramater but includes a return.
        static string enterName()
        {
            Console.WriteLine("What is your name?");
            string getName = Console.ReadLine();
            return getName;
        }

        //Method without a return but inculdes a peramater.
        static void shownMessage(string message)
        {
            Console.WriteLine(message);
            Console.ReadLine();
        }

        //Method with both a peramater and return.
        static int multipliedNumbers(int num1, int num2)
        {
            int sum = num1 * num2;
            return sum;
        }


    }
}
