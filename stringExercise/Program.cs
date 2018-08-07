using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //1) concatenate three strings
            
            string one = "Hello, ";
            string two = "and welcome";
            string three = " to Earth.";
            Console.WriteLine(one + two + three);
            Console.ReadLine();
            

            //2) convert a string to uppercase

            string four = "godzilla!";
            Console.WriteLine(four.ToUpper());
            Console.ReadLine();
            

            //3) create a stringbuilder and build a paragraph of text, one sentence at a time

            StringBuilder sb = new StringBuilder();

            sb.Append("Hello, and welcome to Earth. ");
            sb.Append("This is the third planet from the sun. ");
            sb.Append("It was formed approximately 4.54 billion years ago and is the only known planet to support life. ");
            sb.Append("70% of the Earth's surface is covered in water which is why it is also known as the Blue Planet.");

            Console.WriteLine(sb);
            Console.ReadLine();

        }
    }
}
