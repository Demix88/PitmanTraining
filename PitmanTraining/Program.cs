using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PitmanTraining
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Pitman Training. \nStudent Daily Report");
            
            Console.WriteLine("What course are you in?");
            string yourCourse = ("Web Developer");
            Console.WriteLine(yourCourse);


            Console.WriteLine("What page number");


            int pageNum = 4;
            Console.WriteLine("I am on  a page  : "+pageNum+" .");
            
            Console.WriteLine("Do you need help with anything? Please answer with \"true\" or \"false\" .");
            
            bool needHelp = false;
            string helpStatus = Convert.ToString(needHelp);
            Console.WriteLine(helpStatus+" .");
            


            Console.WriteLine("Were there any positive experiences you'd like to share? Please provide specifics.");
            string posExp = ("\nI really enjoyed SQL Course. I liked creating queries and creating tables with specific information.\n ");
            Console.WriteLine(posExp);

            Console.WriteLine("Is there any other feedback you’d like to provide?  Please be specific.");
            string othFeedback=("\nI'm not happy that some of the course materials are not up to date.\n for example using visual studio 2019 instead of Visual Studio 2022. I think people in IT should work with latest technology!");
            Console.WriteLine(othFeedback);


            Console.WriteLine("How many hours did you study today?");
            string qtyHours = "2";
            int qHours = Convert.ToInt32(qtyHours);
            Console.WriteLine("I studied for: \n" + qHours + " hours.");
            

            Console.WriteLine("Thank you for your responses.  An Instructor will respond shortly.  Have a great day!\nPress \"Enter\" Close ");
            Console.ReadLine();


        }
    }
}
