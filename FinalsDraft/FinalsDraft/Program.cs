using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalsDraft
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            !!! NOT ACTUAL SCHEDULES JUST FOR PROJECT PURPOSES !!!

             APPSTAT
                - XTBI1 | T | 11:20 - 14:20 | R806
                - XTBI2 | W | 11:20 - 14:20 | R806
                - XTBI3 | H | 11:20 - 14:20 | R806
                - XTBI4 | F | 11:20 - 14:20 | R806

            ARTAPRI
                - PCBA1 | T | 8:00 - 11:00 | R202
                - PCBA2 | H | 8:00 - 11:00 | R202
                - PCBA3 | M | 8:00 - 11:00 | R202
                - PCBA4 | S | 8:00 - 11:00 | R202

            DATSEC2
                - TCS1 | M | 18:00 - 21:00 | R807
                - TCS2 | F | 18:00 - 21:00 | R802
                - TCS3 | W | 18:00 - 21:00 | R807
                - TCS4 | H | 18:00 - 21:00 | R807

            INFOMGT
                - TCS1 | M | 8:00 - 11:00 | R807
                - TCS2 | F | 8:00 - 11:00 | R807
                - TCS3 | W | 8:00 - 11:00 | R807
                - TCS4 | T | 8:00 - 11:00 | R807

            SOFSEC1
                - TCS1 | S | 8:00 - 11:00  | R807
                - TCS2 | S | 11:20 - 14:20 | R807
                - TCS3 | S | 14:40 - 17:40 | R807
                - TCS4 | F | 18:00 - 21:00 | R807

            SYSSEC1
                - TCS1 | S | 11:20 - 14:20 | R805
                - TCS2 | S | 14:40 - 17:40 | R801
                - TCS3 | S | 18:00 - 21:00 | R806
                - TCS4 | F | 14:40 - 17:40 | R807
            */



            CourseList approvedCourses = new CourseList();
            approvedCourses.Add("APPSTAT");
            approvedCourses.Add("ARTAPRI");
            approvedCourses.Add("INFOMGT");
            approvedCourses.Add("DATSEC2");
            approvedCourses.Add("SOFSEC1");
            approvedCourses.Add("SYSSEC1");

            bool isValid = false;
            while (isValid == false) //looping function to catch invalid inputs
            {
                Console.Write("Juan Dela Cruz\nID No. 12312312\n\nWelcome to SIS Pre-Adjustment System\n");
                Console.Write("\nYou have 6 approved courses!\n\nWould you like to begin Pre-adjustment? (y/n): ");
                string openQ = Console.ReadLine().ToLower(); //to accept lower or uppercase 
                if (openQ == "y")
                {
                    string option;
                    isValid = true;
                    do
                    {
                        Console.Clear();
                        userMenu(approvedCourses); //displays user menu
                        option = Console.ReadLine();
                        switch (option)
                        {
                            case "1":
                                //method to add course from course list to priority queue based on user input
                                //must remove selected course from available approved courses 
                                //must display available sections and time slots for selected course
                                //must ask for top 3 sections
                                break;
                            case "2":
                                //method to remove course added to priority queue
                                //must put it back to array of available approved courses
                                break;
                            case "3":
                                //method to confirm priority queue
                                //array of available approved courses must be empty to proceed to confirmation
                                //must ask user for confirmation
                                //must show user sequential order of course and section enlistment along with its specific schedule 
                                break;
                            case "4":
                                Console.WriteLine("Ending Program! Press any button to leave!");
                                Console.ReadLine();
                                break;
                            default: 
                                Console.WriteLine("Invalid! Choose from options 1 to 4 only");
                                Console.ReadLine();
                                break;
                        }
                    } while (option != "4"); //looping function until user selects 4 which exits the code
                }

                else if (openQ == "n")
                    return;

                else
                {
                    Console.WriteLine("Invalid! y/n only");
                    Console.ReadLine();
                    isValid = false;
                    Console.Clear();
                }
            }   
        }

        static void userMenu(CourseList courses)
        {
            Console.WriteLine("~~~~~ONLINE PRE-ADJUSTMENT~~~~~\n\nOptions:");
            Console.WriteLine("[1] - Add to Queue");
            Console.WriteLine("[2] - Remove from Queue");
            Console.WriteLine("[3] - Confirm Queue");
            Console.WriteLine("[4] - Exit\n");
            Console.WriteLine("Priority Queue:");
            //insert method to display queue of course that have been prioritized
            Console.WriteLine();
            Console.WriteLine("Available Approved Course:");
            //insert method to display list of courses available for pre-adjustment
            courses.PrintCourseList();
            Console.Write("\nSelect an option: ");
        }

    }

    class Course
    {
        public string CourseName { get; set; }

        public Course(string courseCode)
        {
            CourseName = courseCode;
        }
    }

    class CourseList
    {
        private Course[] courses; //Derived from Course Class
        private int index;

        public CourseList() //Initializes the array Course
        {
           courses = new Course[6];
            index = -1;
        }

        public void Add(string courseName) //This just adds a course into the list
        {
            index++;
            courses[index] = new Course(courseName);
        }

        public void PrintCourseList() //This just prints the course list
        {
            for (int i = 0; i < courses.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " +courses[i].CourseName);
            }
        }
    }
}
