// See https://aka.ms/new-console-template for more information

namespace COMP003AL03.LectureActivity3
{





    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("SECTION A - Academic Term Identification");
            int currentMonth;
            currentMonth = DateTime.Now.Month;
            
            Console.WriteLine("Current Month:" + currentMonth);

            // currentMonth = DateTime.Now.Month;

            if (currentMonth >= 1 && currentMonth <= 5)
            {
                Console.WriteLine("Spring Term");

            }
            else if (currentMonth >= 6 && currentMonth <= 7)
            {
                Console.WriteLine("Summer Term");
            }
            else
            {
                Console.WriteLine("Fall Term");
            }




            Console.WriteLine("SECTION B - Campus Access Check");
            
            Console.WriteLine("Enter your age:");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Are you currently enrolled? (yes/no)");
            string userEnrollment = Console.ReadLine();
            bool isEnrolled = userEnrollment == "yes" ? true : false;

            Console.WriteLine("Do you have a valid student ID? (yes/no):");
            string studentID = Console.ReadLine();
            bool hasStudentID = studentID == "yes" ? true : false;

            if (age >= 18)
            {
                if (isEnrolled || hasStudentID)
                {
                    Console.WriteLine("Campus Access Granted");
                }
                else
                {
                    Console.WriteLine("Campus Access Denied");
                }

            }
            else
            {
                Console.WriteLine("Too young to be enrolled!!");
            }



            Console.WriteLine("SECTION C - Semester Code Lookup");
            Console.WriteLine("Enter a semester code (SP, SU, FA)");
            string semesterCode = Console.ReadLine();



        }

    }

}