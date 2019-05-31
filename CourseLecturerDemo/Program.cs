using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zBackEndHelperLibrary;
using zFrontEndHelperLibrary;


namespace CourseLecturerAppDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            FrontEndHelperMethods.ExerciseDetails();
            FrontEndHelperMethods.Intro();

            BackEndHelperMethods.CourseLecturerBackground();

            FrontEndHelperMethods.Signature();
            FrontEndHelperMethods.Goodbye();

            Console.ReadKey();
        }
    }
}
