using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericVariables_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            int courseID = 101;
            sbyte lengthInWeeks = 10;
            float myGPA = 1.2F;
            string courseTitle = "CS101";
            string courseDescription = "This course teaches introductory programming topics.";
            string instructorName = "Deepali Kamatkar";
            const sbyte weeksIn3CreditHour = 5;
            const sbyte weeksin6CreditHour = 10;

            Console.WriteLine("You are enrolled in Course {0} ({3}). {4} The course is {1} weeks long. Your instructor is {5}. Your GPA is {2}. The 3 credit hour course is {6} weeks long. The 6 credit hour course is {7} weeks long.", courseID, lengthInWeeks, myGPA,courseTitle,courseDescription,instructorName,weeksIn3CreditHour,weeksin6CreditHour);
            Console.ReadLine();
        }
    }
}
