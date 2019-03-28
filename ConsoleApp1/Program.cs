using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Student student1 = new Student("Kristijan", "Spirov", EnumGender.Male, 9.5);
            Student student2 = new Student("Bojan", "Ilev", EnumGender.Male, 6.2);
            Student student3 = new Student("Ivana", "Nakeva", EnumGender.Female, 8.5);
            Student student4 = new Student("Antonio", "Delev", EnumGender.Male, 2.9);
            Student student5 = new Student("Biljana", "Arsova", EnumGender.Female, 7.2);
            Student student6 = new Student("Angelina", "Gerovska", EnumGender.Female, 4.7);
            Student student7 = new Student("Silvija", "Bashovska", EnumGender.Female, 7.0);
            Student student8 = new Student("Adrijan", "Gigov", EnumGender.Male, 9.0);
            Student student9 = new Student("Simona", "Aneva", EnumGender.Female, 10.0);
            Student student10 = new Student("Ilina", "Spirkovska", EnumGender.Female, 5.6);

            List<Student> class1 = new List<Student>() { student1, student2, student3, student4,
                                                         student5, student6, student7, student8,
                                                           student9, student10 };

            Student student11 = new Student("Gorjan", "Kirov", EnumGender.Male, 8.0);
            Student student12 = new Student("Vasko", "Pecov", EnumGender.Male, 7.6);
            Student student13 = new Student("Ivona", "Zdravevska", EnumGender.Female, 9.0);
            Student student14 = new Student("Lara", "Ivevska", EnumGender.Female, 5.9);
            Student student15 = new Student("Boris", "Savevski", EnumGender.Male, 7.0);
            Student student16 = new Student("Slavko", "Topuzov", EnumGender.Male, 3.5);
            Student student17 = new Student("Tijana", "Ickovska", EnumGender.Female, 4.6);
            Student student18 = new Student("Gorjan", "Petrevski", EnumGender.Male, 8.4);
            Student student19 = new Student("Vedran", "Mackov", EnumGender.Male, 9.8);
            Student student20 = new Student("Mirka", "Andreevska", EnumGender.Female, 6.0);

            List<Student> class2 = new List<Student>() { student11, student12, student13, student14,
                                                        student15, student16, student17, student18,
                                                        student19, student20 };

            
           try
            {
                Console.WriteLine("Choose class:");
                Console.WriteLine("1.Class1");
                Console.WriteLine("2.Class2");
                int classinput = int.Parse(Console.ReadLine());

                if (classinput == 1)
                {
                    Console.WriteLine("You choose Class1, now you can choose one of this:");
                    Console.WriteLine("1. Print all female students");
                    Console.WriteLine("2. Print all male students");
                    Console.WriteLine("3. Print all students with first letter of name");
                    Console.WriteLine("4. Print all students with higher grade than your number input");
                    Console.WriteLine("5. Print the average grade of all students in this class");
                    int inputfunc = int.Parse(Console.ReadLine());

                    switch (inputfunc)
                    {
                        case 1:
                            Console.WriteLine("All female students:");
                            var allfemale = class1.Where(x => x.Gender == EnumGender.Female).ToList();
                        foreach (var fstudent in allfemale)
                        {
                            fstudent.PrintInfo();                            
                        }                        
                            break;
                    case 2:
                        Console.WriteLine("All male students:");
                        var allmale = class1.Where(x => x.Gender == EnumGender.Male).ToList();
                        foreach (var mstudent in allmale)
                        {
                            mstudent.PrintInfo();
                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter letter to print the students with names that starts with entered letter:");
                        string nameletter = Console.ReadLine().ToUpper();

                        var firstletter = class1.Where(x => x.FirstName.StartsWith(nameletter)).ToList();
                        foreach (var item in firstletter)
                        {
                            item.PrintInfo();

                        }
                            throw new ArgumentException("This input was not letter:" + nameletter.ToString());
                        case 4:
                        Console.WriteLine("Enter number to print the students with grades higher than entered number:");
                        int number = int.Parse(Console.ReadLine());

                        var inputnumber = class1.Where(x => x.AverageGrade>=number).ToList();
                        foreach (var num in inputnumber)
                        {
                            num.PrintInfo();
                        }
                        break;
                    case 5:
                        Console.WriteLine("Average grade of all students in this class:");
                        var averagenumber = class1.Average(x => x.AverageGrade);
                        Console.WriteLine(averagenumber);
                        break;
                    default:
                            throw new Exception("Wrong input, you can enter 1,2,3,4 or 5");                            
                    }
                }
                else if (classinput == 2) {

                Console.WriteLine("You choose Class2, now you can choose one of this:");
                Console.WriteLine("1. Print all female students");
                Console.WriteLine("2. Print all male students");
                Console.WriteLine("3. Print all students with first letter of name");
                Console.WriteLine("4. Print all students with higher grade than your number input");
                Console.WriteLine("5. Print the average grade of all students in this class");
                int inputfunc = int.Parse(Console.ReadLine());

                switch (inputfunc)
                {
                    case 1:
                        Console.WriteLine("All female students:");
                        var allfemale = class2.Where(x => x.Gender == EnumGender.Female).ToList();
                        foreach (var fstudent in allfemale)
                        {
                            fstudent.PrintInfo();
                        }
                            break;
                    case 2:
                        Console.WriteLine("All male students:");
                        var allmale = class2.Where(x => x.Gender == EnumGender.Male).ToList();
                        foreach (var mstudent in allmale)
                        {
                            mstudent.PrintInfo();
                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter letter to print the students with names that starts with entered letter:");
                         
                                string nameletter = Console.ReadLine().ToUpper();

                                var firstletter = class2.Where(x => x.FirstName.StartsWith(nameletter)).ToList();
                                foreach (var item in firstletter)
                                {
                                    item.PrintInfo();
                                }
                            throw new ArgumentException("This input was not letter:" +nameletter.ToString());
                            
                    case 4:
                        Console.WriteLine("Enter number to print the students with grades higher than entered number:");
                        int number = int.Parse(Console.ReadLine());

                        var inputnumber = class2.Where(x => x.AverageGrade >= number).ToList();
                        foreach (var num in inputnumber)
                        {
                            num.PrintInfo();
                        }
                            
                            break;
                        case 5:
                        Console.WriteLine("Average grade of all students in this class:");
                        var averagenumber = class2.Average(x => x.AverageGrade);
                        Console.WriteLine(averagenumber);
                        break;
                    default:
                            throw new Exception("Wrong input, you can enter 1,2,3,4 or 5");
                    }

            }
                else
                {
                    throw new Exception("Wrong input, you can enter 1 or 2");

                }
           }          
           

            catch (FormatException)
            {
                Console.WriteLine("You have entered something other");
            }

            catch (Exception ex)
            {
              Console.WriteLine(ex.Message);
            }
            Console.ReadLine();

        }
    }
}
