using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Group
    {
        public string GroupNo { get; set; }
        Student[] students;
        private int _studentlimit;

        public Group(string groupNo, int studentLimit)
        {
            GroupNo = groupNo;
            StudentLimit = studentLimit;
            students=new Student[0];
        }

        public int StudentLimit 
        {
            get 
            {
                return _studentlimit;
            } 
            set 
            { 
                if(_studentlimit >=3 && _studentlimit<=18) 
                {
                    _studentlimit = value;
                }
                else
                {
                    Console.WriteLine("Studentlimiy can be only betweem 3 and 18");
                }
            } 
        }

        public bool CheckGroupNo(string groupNo)
        {
          if(groupNo == @"^[A-Z]{2}\d{3}$") //I search from Internet this regex
            {
                return true;
            }
          return false;
        }

        public void AddStudent(Student student)
        {
            if(students.Length>StudentLimit)
            {
                Console.WriteLine("You cannot add new student!");
                return;
            }

            Array.Resize(ref students, students.Length+1);
            students[students.Length-1] = student;
        }

        public Student GetStudent(int id)
        {
            for(int i=0; i<students.Length; i++)
            {
                if (students[i].Id == id)
                {
                    return students[i];
                }
            }
            Console.WriteLine("No student found.");
            return null;
        }

        public Student[] GetAllStudents()
        {
            return students;
        }

    }
}
