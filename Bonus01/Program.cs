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

            while(ynAnswer == true)
            {
                Console.Write("Enter a numerical grade: ");
                bool input = int.TryParse(Console.ReadLine(), out int grade);

                while (input == false)
                {
                    Console.Write("Sorry, that is not between 0 and 100. \n\nPlease enter a grade between 0 - 100: ");
                    input = int.TryParse(Console.ReadLine(), out grade);

                    if (grade < 0 || grade > 100)
                    {
                        input = false;
                    }
                }
                PrintGrade(grade);
                ynAnswer = ContinueProgram();
            } 
            Console.ReadKey();
        }

        public static void PrintGrade(int grade)
        {
            if (grade <= 100 && grade >= 88)
            {
                Console.WriteLine("Letter Grade: A");
            }
            else if (grade <= 87 && grade >= 80)
            {
                Console.WriteLine("Letter Grade: B");
            }
            else if (grade <= 79 && grade >= 67)
            {
                Console.WriteLine("Letter Grade: C");
            }
            else if (grade <= 66 && grade >= 60)
            {
                Console.WriteLine("Letter Grade: D");
            }
            else if (grade < 60 && grade >= 0)
            {
                Console.WriteLine("Letter Grade: F");
            }
            else
            {
                Console.WriteLine("That is not a valid grade!");
            }
        }

        public static bool ContinueProgram()
        {
            bool validInput = false;
            bool yesNoAnswer = true;
            while(validInput == false)
            {
                Console.Write("\nContinue? (y/n) ");
                string answer = Console.ReadLine();
                if (answer.Equals("y", StringComparison.OrdinalIgnoreCase))
                {
                    yesNoAnswer = true;
                    validInput = true;
                }
                else if (answer.Equals("n", StringComparison.OrdinalIgnoreCase))
                {
                    yesNoAnswer = false;
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Sorry, that is not a valid answer.");
                    validInput = false;
                }
            }
            return yesNoAnswer;
        }
    }
}
