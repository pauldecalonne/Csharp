using System;

namespace pdcCsharpeV2
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
            string characterName = "John";
            int characterAge;
            characterAge = 25;

            Console.WriteLine("He is named " + characterName);
            Console.WriteLine("He is " + characterAge + " years old");

            characterName = "Mike";

            Console.WriteLine("He likes the name " + characterName);
            Console.WriteLine("He doesn't like to be " + characterAge);
            Console.WriteLine("/");

            string pluralNoun;

            Console.Write("Enter a plural noun:");
            pluralNoun = Console.ReadLine();

            Console.WriteLine("Roses are");
            Console.WriteLine(pluralNoun + "are blue");


            int[] luckynumbers = { 4, 8, 15, 16, 23, 42 };
            string[] friends = new string[5];
            friends[0] = "Jim";
            friends[1] = "Ken";

            luckynumbers[1] = 900;
            Console.WriteLine(luckynumbers[1]);
            

            SayHi("Mike", 23);
            
            double cubedNumber = cube(5);
            Console.WriteLine(cubedNumber);

            bool isMale = false;
            bool isTall = true;
            if (isMale && isTall)
            {
                Console.WriteLine("You are a tall male");
            }
            else if (isMale && !isTall)
            {
                Console.WriteLine("You are a small male");
            }
            else
            {
                Console.WriteLine("You're not mal");
            }
            
            Console.WriteLine(GetMax(2, 10,17));
            
            Console.Write("Enter a number:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Operator:");
            string op = Console.ReadLine();

            Console.Write("Enter a number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (op == "+")
            {
                Console.WriteLine(num1 + num2);
            } else if (op == "-")
            {
                Console.WriteLine(num1 - num2);
            }
            else
            {
                Console.WriteLine("Invalid Operator");
            }
            
            Console.WriteLine(GetDay(5));
            
            int index = 2;
            while (index <= 5) ;
            {
                Console.WriteLine(index);
                index++;
            } 
            
            string secretWord = "giraffe";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;

            while(guess != secretWord && !outOfGuesses)
            {
                if(guessCount < guessLimit)
                {
                    Console.Write("Enter guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuesses = true;
                }   
            }
            if (outOfGuesses)
            {
                Console.Write("You lose!");
            }
            else
            {
                Console.Write("You win!");

            }
            

            for(int i = 1; i<=5; i++)
            {
                Console.WriteLine(i);
            }
            

            int[,] numberGrid =
            {
                {1,2},
                {5,6},
            };
            Console.WriteLine(numberGrid[0, 1]);
            
            try
            {

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            


            //CLASSES used to model real world entities. Blueprint for a new data type in our programm


            Book book1 = new Book("Harry Potter", "uih", "G");
            Console.WriteLine(Book.songCount);
            Book book2 = new Book("Harry poy", "uhini", "PG");
            Console.WriteLine(book1.getSongCount());

            Console.WriteLine(book1.Pages);
            

            Console.WriteLine(Math.Sqrt(144));
            UsefulTools.SayHi("Mike");
            */


            Console.ReadLine();
        }












        static string GetDay (int dayNum)
        {
            string dayName;

            switch(dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wenesday";
                    break;
                default:
                    dayName = "Invalid";
                    break;
            }
            return dayName;
        }

        static void SayHi(string name, int age)
        {  
            Console.WriteLine("Hello " + name + " you are "+ age);
        }

        static double cube(int num)
        {
            int result = num * num * num;
            return result;
        }

        static int GetMax(int num1, int num2, int num3)
        {
            int result;
            if(num1>= num2 && num1>= num3)
            {
                result = num1;
            }
            else if (num2 >= num3 && num2>=num1 )
            {
                result = num2;
            }
            else
            {
                result = num3;
            }

            return result;
        }
    }
}
