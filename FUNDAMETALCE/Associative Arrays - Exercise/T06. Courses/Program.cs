using System;
using System.Collections.Generic;
using System.Linq;

namespace T06._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            string courseName = "";
            string studentName = "";
            bool cmd = false;
            int totalUsers = 0;

            Dictionary<string, string> course = new Dictionary<string, string>();

            while (cmd == false)
            {
                string[] input = Console.ReadLine().Split(" : ");
                courseName = input[0];

                if (input[0] == "end")
                {
                    cmd = true;
                }

                else if (input[0] != "end")
                {
                    studentName = input[1];

                    if (!course.ContainsKey(courseName))
                    {
                        course[courseName] = studentName;
                        totalUsers++;
                    }
                    else if (course.ContainsKey(courseName))
                    {
                        course[courseName] += (", " + studentName);
                    }
                }

            }

            foreach (var student in course.OrderByDescending(x =>x.Key))
            {
                Console.WriteLine($"{course.Keys}: {}");
            }
        }
    }
}
