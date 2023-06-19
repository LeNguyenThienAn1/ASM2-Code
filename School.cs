using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV3
{
    public class School
    {
        public string NameSchool { get; set; }
        public string IDSchool { get; set; }

        private List<Student> students;

        public School(string name, string id)
        {
            NameSchool = name;
            IDSchool = id;
            students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void RemoveStudent(string id)
        {
            Student studentToRemove = students.Find(s => s.ID == id);
            if (studentToRemove != null)
            {
                students.Remove(studentToRemove);
                Console.WriteLine("Student with ID " + id + " has been removed from " + NameSchool + ".");
            }
            else
            {
                Console.WriteLine("Student with ID " + id + " does not exist in " + NameSchool + ".");
            }
        }

        public Student SearchStudent(string id)
        {
            return students.Find(s => s.ID == id);
        }

        public void PrintAllStudents()
        {
            Console.WriteLine("School: " + NameSchool);
            Console.WriteLine("School ID: " + IDSchool);
            Console.WriteLine("Student List:");
            foreach (var student in students)
            {
                student.PrintInfo();
                Console.WriteLine("************************************");
            }
        }
    }
}