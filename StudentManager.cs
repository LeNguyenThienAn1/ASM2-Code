using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV3
{
    public class StudentManager
    {
        private List<Student> students;

        public StudentManager()
        {
            students = new List<Student>();
        }

        // Thêm sinh viên vào danh sách
        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        // Xóa sinh viên khỏi danh sách dựa trên ID
        public void RemoveStudent(string id)
        {
            Student studentToRemove = students.Find(s => s.ID == id);
            if (studentToRemove != null)
            {
                students.Remove(studentToRemove);
                Console.WriteLine("Student with ID " + id + " has been removed.");
            }
            else
            {
                Console.WriteLine("Student with ID " + id + " does not exist.");
            }
        }
        public void UpdateStudent(string id)
        {
            Student studentToUpdate = students.Find(s => s.ID == id);
            if (studentToUpdate != null)
            {
                Console.WriteLine("Enter new information for student with ID " + id + ":");

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Age: ");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.Write("Gender (y/n): ");
                string gender = Console.ReadLine();

                studentToUpdate.Name = name;
                studentToUpdate.Age = age;
                studentToUpdate.Gender = gender;

                if (studentToUpdate is MajorStudent)
                {
                    Console.Write("Major: ");
                    string major = Console.ReadLine();
                    ((MajorStudent)studentToUpdate).Major = major;
                }

                Console.WriteLine("Student with ID " + id + " has been updated.");
            }
            else
            {
                Console.WriteLine("Student with ID " + id + " does not exist.");
            }
        }

        // Tìm kiếm sinh viên dựa trên ID
        public void SearchStudent(string id)
        {
            Student student = students.Find(s => s.ID == id);
            if (student != null)
            {
                Console.WriteLine("Student found:");
                student.PrintInfo();
            }
            else
            {
                Console.WriteLine("Student with ID " + id + " does not exist.");
            }
        }

        // In thông tin của tất cả sinh viên
        public void PrintAllStudents()
        {
            foreach (var student in students)
            {
                student.PrintInfo();
                Console.WriteLine("************************************"); 
            }
        }
    }

}
