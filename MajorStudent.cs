using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV3
{
    public class MajorStudent : Student
    {
        public string Major { get; set; }
        public int Year { get; set; }

        public override void PrintInfo()
        {
            Console.WriteLine("Name Of Student: " + Name);
            Console.WriteLine("Age Student: " + Age);
            Console.WriteLine("ID Student: " + ID);
            Console.WriteLine("Gender Student: " + Gender);
            Console.WriteLine("Major: " + Major);
            Console.WriteLine("Year: " + Year);
        }
    }
}

