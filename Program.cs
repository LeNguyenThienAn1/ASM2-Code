using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV3
{
        using System;
        using System.Collections.Generic;
        using System.Text;

        public class Program
        {
            public static void Login()
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.WriteLine("------XIN HÃY ĐĂNG NHẬP------");

                bool isLoggedIn = false;

                while (!isLoggedIn)
                {
                    Console.Write("Username: ");
                    string username = Console.ReadLine();
                    Console.Write("Password: ");
                    string password = Console.ReadLine();

                    // Kiểm tra thông tin đăng nhập
                    if (CheckCredentials(username, password))
                    {
                        Console.WriteLine("Login successful!");
                        isLoggedIn = true;
                        MainProgram();
                    }
                    else
                    {
                        Console.WriteLine("Login failed. Please try again.");
                    }
                }
            }

            public static bool CheckCredentials(string username, string password)
            {
                string validUsername = "thienan";
                string validPassword = "123";

                return (username == validUsername && password == validPassword);
            }

            public static void MainProgram()
            {
                Console.OutputEncoding = Encoding.UTF8;

                Console.WriteLine("Nhập thông tin về trường học:");
                Console.Write("Tên trường: ");
                string schoolName = Console.ReadLine();
                Console.Write("ID trường: ");
                string schoolID = Console.ReadLine();

                School school = new School(schoolName, schoolID);

                while (true)
                {
                    Console.WriteLine("\n ||********* MENU PHẦN MỀM QUẢN LÝ SINH VIÊN: *********||");
                    Console.WriteLine("1. ||---Thêm sinh viên---                                ||");
                    Console.WriteLine("2. ||---Xem danh sách sinh viên---                       ||");
                    Console.WriteLine("3. ||---Xóa sinh viên---                                 ||");
                    Console.WriteLine("4. ||---Tìm sinh viên---                                 ||");
                    Console.WriteLine("5. ||---Thoát chương trình---                            ||");

                    Console.Write("Nhập lựa chọn của bạn (1-5): ");
                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            AddStudent(school);
                            break;
                        case "2":
                            PrintAllStudents(school);
                            break;
                        case "3":
                            RemoveStudent(school);
                            break;
                        case "4":
                            SearchStudent(school);
                            break;
                        case "5":
                            Console.WriteLine("Chương trình kết thúc.");
                            return;
                        default:
                            Console.WriteLine("Lựa chọn không hợp lệ.");
                            break;
                    }
                }
            }

            public static void AddStudent(School school)
            {
                Console.Write("Số lượng học sinh bạn muốn thêm vào: ");
                int numberOfStudents = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < numberOfStudents; i++)
                {
                    Console.WriteLine($"\nNhập thông tin cho sinh viên #{i + 1}:");
                    Console.Write("Tên: ");
                    string name = Console.ReadLine();
                    Console.Write("Tuổi: ");
                    int age = Convert.ToInt32(Console.ReadLine());
                    Console.Write("ID: ");
                    string id = Console.ReadLine();
                    Console.Write("Giới tính (y/n): ");
                    string gender = Console.ReadLine();
                    Console.Write("Ngành học (để trống nếu không có): ");
                    string major = Console.ReadLine();
                    Console.Write("Trường trung học: ");
                    string highSchoolName = Console.ReadLine();

                    Student student;
                    if (string.IsNullOrEmpty(major))
                    {
                        student = new HighSchoolStudent();
                        ((HighSchoolStudent)student).HighSchoolName = highSchoolName;
                    }
                    else
                    {
                        student = new MajorStudent();
                        ((MajorStudent)student).Major = major;
                    }

                    student.Name = name;
                    student.Age = age;
                    student.ID = id;
                    student.Gender = gender.ToLower() == "y" ? "Nam" : "Nữ";

                    school.AddStudent(student);
                }
            }

            public static void PrintAllStudents(School school)
            {
                Console.WriteLine("\nThông tin sinh viên trong trường " + school.NameSchool + ":");
                school.PrintAllStudents();
            }

            public static void RemoveStudent(School school)
            {
                Console.Write("\nNhập ID của sinh viên cần xóa: ");
                string idToRemove = Console.ReadLine();
                school.RemoveStudent(idToRemove);
            }

            public static void SearchStudent(School school)
            {
                Console.Write("\nNhập ID của sinh viên cần tìm: ");
                string idToSearch = Console.ReadLine();
                Student student = school.SearchStudent(idToSearch);

                if (student != null)
                {
                    Console.WriteLine("Sinh viên được tìm thấy:");
                    student.PrintInfo();
                }
                else
                {
                    Console.WriteLine("Không tìm thấy sinh viên có ID " + idToSearch);
                }
            }

            public static void Main(string[] args)
            {
                Login();
            }
        }
    }
