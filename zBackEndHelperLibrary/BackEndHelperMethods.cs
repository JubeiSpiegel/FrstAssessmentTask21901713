using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zBackEndHelperLibrary
{
    public class BackEndHelperMethods
    {
        public static List<Lecturer> instancesList = new List<Lecturer>();

        public static void CourseLecturerBackground()
        {
            string inputCN;
            string inputFN;
            string inputLN;
            string lastCourseEntered;
            char secondChoice;
            int conditionNumber = 0;

            Console.ForegroundColor = ConsoleColor.White;

            inputCN = InputCourseDetails();
            InputLecturerDetails(out inputFN, out inputLN);

            do
            {
                AddInputsToList(inputCN, inputFN, inputLN);

                ConditionLabel:
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\tDo you want to continue?" +
                    "\n\t[C] to enter a new COURSE with Lecturer" +
                    $"\n\t[L] for enter a new LECTURER for current course ({LastCourseEntered(inputCN).TrimStart().TrimEnd()})" +
                    "\n\t[F] to Finish");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n\tPlease choose one: ");
                Console.ForegroundColor = ConsoleColor.White;
                try
                {
                    secondChoice = Char.Parse(Console.ReadLine().ToUpper());
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("***ERROR***: Input not recognized. Please enter a Character input.\nErrorCode: {0}", e);
                    Console.ForegroundColor = ConsoleColor.White;
                    goto ConditionLabel;
                    throw;
                }


                if (secondChoice == 'C')
                {
                    //Doing [C] >>> Adding a Course with lecturer, storing the course name in the function LastCourseEntered() for later use
                    inputCN = InputCourseDetails();
                    InputLecturerDetails(out inputFN, out inputLN);

                    lastCourseEntered = LastCourseEntered(inputCN);

                    conditionNumber++;
                }

                else if (secondChoice == 'L')
                {
                    //Doing [C] >>> Adding a new Lecturer for current course (course stored in function LastCourseEntered();
                    inputCN = LastCourseEntered(inputCN);
                    Console.WriteLine($"Course Name = \t{LastCourseEntered(inputCN)}");
                    InputLecturerDetails(out inputFN, out inputLN);

                    conditionNumber++;
                }

                else if (secondChoice == 'F')
                {
                    //Doing [F] >>> Final, showing the display with all the courses and breaking the if conditions, finishing the program
                    DisplayData();
                    conditionNumber = -1;
                }

                else
                {
                    //For other character entered, showing error message and going to the first question by a label-goto method
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("***ERROR***: Character not recognized, please enter proper Character to continue");
                    Console.ForegroundColor = ConsoleColor.White;
                    goto ConditionLabel;
                }

            } while (conditionNumber != -1);

        }


        private static string InputCourseDetails()
        {
            string inputCN;
            ConditionCN:
            Console.Write("Please enter Course Name: ");
            try
            {
                inputCN = Console.ReadLine().TrimStart().TrimEnd();
                return inputCN;
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("***ERROR***\nErrorCode: {0}", e);
                Console.ForegroundColor = ConsoleColor.White;
                goto ConditionCN;
                throw;
            }

        }

        private static void InputLecturerDetails(out string inputFN, out string inputLN)
        {
            ConditionFN:
            Console.Write("Please enter First Name: ");
            try
            {
                inputFN = Console.ReadLine();
            }
            catch (Exception eFN)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("***ERROR***\nErrorCode: {0}", eFN);
                Console.ForegroundColor = ConsoleColor.White;
                goto ConditionFN;
                throw;
            }

            ConditionLN:
            Console.Write("Please enter Last Name: ");
            try
            {
                inputLN = Console.ReadLine();
            }
            catch (Exception eLN)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("***ERROR***\nErrorCode: {0}", eLN);
                Console.ForegroundColor = ConsoleColor.White;
                goto ConditionLN;
                throw;
            }

        }

        private static string LastCourseEntered(string inputCN)
        {
            return inputCN;
        }

        private static void AddInputsToList(string inputCN, string inputFN, string inputLN)
        {
            instancesList.Add(new Lecturer
            {
                CourseName = inputCN.TrimStart().TrimEnd(),
                FirstName = inputFN.TrimStart().TrimEnd(),
                LastName = inputLN.TrimStart().TrimEnd(),
                EmailAddress = ($"{inputFN.Substring(0, 1).TrimStart().TrimEnd()}.{inputLN.Replace(" ", String.Empty).TrimStart().TrimEnd()}@{LastCourseEntered(inputCN).TrimStart().TrimEnd()}.CoolegeUniversity.org").ToLower()
            });
        }


        public static void DisplayData()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Showing results for the courses entered: \n");


            foreach (var instance in instancesList)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Course Name = \t\t{instance.CourseName.TrimStart().TrimEnd()}");
                Console.WriteLine($"Lecturer's Name = \t{instance.FirstName.TrimStart().TrimEnd()} {instance.LastName.TrimStart().TrimEnd()}");
                Console.WriteLine($"Lecturer's Email = \t{instance.EmailAddress.TrimStart().TrimEnd()}\n");

            }


        }






    }
}
