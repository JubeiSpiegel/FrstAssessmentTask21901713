using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zFrontEndHelperLibrary
{
    public class FrontEndHelperMethods
    {
        public static void ExerciseDetails()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("John Rowley's Class Assessment Tasks");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.Write("Course Name:\t");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Diploma in Visual C# Programming with Visual Studio");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.Write("Student:\t");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Luis Cabezos");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.Write("Student ID:\t");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("21901713");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.Write("Exercise Date:\t");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("31/05/2019");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nFIRST EXERCISE:");
            Console.WriteLine("**************************************");
            Console.WriteLine("Console Program: Courses and Lecturers");
            Console.WriteLine("**************************************");
            Console.ForegroundColor = ConsoleColor.Gray;


            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n1.Create two classes: course and lecturer. " +
                "\nA course has a title and contains a list of  one or more lecturers. " +
                "\nA lecturer has a first name, last name and email. " +
                "\n\n2.Write a console program that requests the name of a course and, once entered, requests the name of one or more lecturers(in a loop" +
                "\n(you can decide how to stop the loop)" +
                "\n\n3.Each time a lecturer is entered, they are added to the listing of lecturers for the course. " +
                "\nOnce all names of lecturers are entered, you will print out the course name and the list of all lecturers associated with the course ");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("");
            Console.WriteLine("Press 'ENTER' key to continue");
            Console.ReadLine();
            Console.Clear();

        }

        public static void Intro()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("What this application doeS?");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("This application asks you for a first time to enter a course with details: " +
                "\n- \tCourse Name" +
                "\n- \tLecturer First Name" +
                "\n- \tLecturer Last Name" +
                "\nOnce entered those details it will ask you three options, all selected with a character key:" +
                "\n\t[C] to enter a new Course with new lecturer's first and last name" +
                "\n\t[L] to enter a new Lecturer for the last course you enetered" +
                "\n\t[F] to finish the app and show all the details entered, with email address created on our Coolege University domain" +
                "\n" +
                "\nSo let's start,");
            Console.WriteLine("");
            Console.WriteLine("Press 'ENTER' key to continue");
            Console.ReadLine();
            Console.Clear();

        }

        public static void Signature()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("21901713 / Luis Cabezos / John Rowley's Class Assessment Tasks / 2019");

        }

        public static void Goodbye()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Thanks for using this app!");
            Console.WriteLine("Press any key to FINISH...");
        }
    }
}
