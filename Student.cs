using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Student
    {
        public Student(string fullname, double point)
        {
            
            Fullname = fullname;
            Point = point;

            Id = 0;
            Id++;
        }

        public int Id { get; set; }
        public string Fullname { get; set; }
        public double Point { get; set; }

        public void StudentInfo()
        {
            Console.WriteLine($"Fullname:{Fullname}, Point:{Point}, Id:{Id}");

        }
    }
}
