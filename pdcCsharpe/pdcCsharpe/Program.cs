using System;

namespace pdcCsharpe
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "giraffe";
            char grade = 'C';
            int age = 30;
            age--;
            double gpa = 3.2;
            bool isMale = true;

            string phrase1 = "  giraffe\n  pdc" + "  is cool";
            Console.WriteLine(phrase1.Substring(phrase1.IndexOf("giraffe")));

            Console.WriteLine( -45 + age);
            Console.WriteLine(Math.Max(13,62));

            Console.Write("enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("enter a number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(num1 + num2);
            Console.ReadLine();

        }
    }
}
