using System;

namespace FinalGradeSofiaChumpitazi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What total grade score do you expect in ISM 4300?");

            float gradeLetter;
          
            float gradePercentage;
           
            Console.Write("Your grade score is:");
            gradeLetter = float.Parse(Console.ReadLine());

            Console.Write("Your letter grade is:");
            gradePercentage = (gradeLetter);

            if (gradePercentage >= 98)
            {
                Console.WriteLine("Grade A+");
            }
            else if ((gradePercentage >= 92) && (gradePercentage <= 97))
            {
                Console.WriteLine("Grade A");
            }
            else if ((gradePercentage >= 90) && (gradePercentage == 91))
            {
                Console.WriteLine("Grade A-");
            }
            else if ((gradePercentage >= 88) && (gradePercentage == 89))
            {
                Console.WriteLine("Grade B+");
            }
            else if ((gradePercentage >= 82) && (gradePercentage <= 87))
            {
                Console.WriteLine("Grade B");
            }
            else if ((gradePercentage >= 80) && (gradePercentage == 81))
            {
                Console.WriteLine("Grade B-");
            }
            else if ((gradePercentage >= 78) && (gradePercentage == 79))
            {
                Console.WriteLine("Grade C+");
            }
            else if ((gradePercentage >= 72) && (gradePercentage <= 77 ))
            {
                Console.WriteLine("Grade C");
            }
            else if ((gradePercentage >= 70) && (gradePercentage == 71))
            {
                Console.WriteLine("Grade C-");
            }
            else if ((gradePercentage >= 68) && (gradePercentage == 69))
            {
                Console.WriteLine("Grade D+");
            }
            else if ((gradePercentage >= 62) && (gradePercentage <= 67))
            {
                Console.WriteLine("Grade D");
            }
            else if ((gradePercentage >= 60) && (gradePercentage == 61))
            {
                Console.WriteLine("Grade D-");
            }
            else if (gradePercentage <= 60)
            {
                Console.WriteLine("Grade F");
            }
            else
            {
                Console.WriteLine("Invalid user input");
            }

            Console.ReadLine();
        }
    }
}

      
