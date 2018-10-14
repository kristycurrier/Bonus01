using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Letter Grader Converter!\n");
            bool ynAnswer = true;

            do
            {

                Console.Write("Enter a numerical grade: ");
                bool input = int.TryParse(Console.ReadLine(), out int grade);

                do
                {
                    Console.Write("Sorry, that is not between 0 and 100. \n\nPlease enter a grade between 0 - 100: ");
                    input = int.TryParse(Console.ReadLine(), out grade);

                    if(grade < 0 || grade > 100)
                    {
                        input = false;
                    }

                } while (input == false);

                if (grade > 100)
                {
                    Console.WriteLine("\nThat is not a valid grade!");
                }
                if (grade <= 100 && grade >= 88)
                {
                    Console.WriteLine("Letter Grade: A");
                }
                if (grade <= 87 && grade >= 80)
                {
                    Console.WriteLine("Letter Grade: B");
                }
                if (grade <= 79 && grade >= 67)
                {
                    Console.WriteLine("Letter Grade: C");
                }
                if (grade <= 66 && grade >= 60)
                {
                    Console.WriteLine("Letter Grade: D");
                }
                if (grade < 60 && grade >= 0)
                {
                    Console.WriteLine("Letter Grade: F");
                }
                if (grade < 0)
                {
                    Console.WriteLine("That is not a valid grade!");
                }

                bool validInput = false;
                do
                {

                    Console.Write("\nContinue? (y/n) ");
                    string answer = Console.ReadLine();
                    if (answer.Equals("y", StringComparison.OrdinalIgnoreCase))
                    {
                        ynAnswer = true;
                        validInput = true;
                    }
                    else if (answer.Equals("n", StringComparison.OrdinalIgnoreCase))
                    {
                        ynAnswer = false;
                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, that is not a valid answer.");
                        validInput = false;

                    }
                } while (validInput == false);

            } while (ynAnswer == true);



            Console.ReadKey();
        }
    }
}
