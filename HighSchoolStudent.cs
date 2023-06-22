using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV3
{
    public class HighSchoolStudent : Student
    {
        public string HighSchoolName { get; set; }

        public override void PrintInfo()
        {
            Console.WriteLine("Name Of Student: " + Name);
            Console.WriteLine("Age Student: " + Age);
            Console.WriteLine("ID Student: " + ID);
            Console.WriteLine("Gender Student: " + Gender);
            Console.WriteLine("Tên trường trung học đã học: " + HighSchoolName);
        }
    }
}
