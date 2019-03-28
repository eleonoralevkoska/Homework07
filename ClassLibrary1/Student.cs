using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public EnumGender Gender { get; set; }
        public double AverageGrade { get; set; }

        public Student(string firstname, string lastname, EnumGender gender, double averagegrade)
        {
            FirstName = firstname;
            LastName = lastname;
            Gender = gender;
            AverageGrade = averagegrade;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Firstname:{FirstName} Lastname:{LastName}");
            
        }

    }
}
