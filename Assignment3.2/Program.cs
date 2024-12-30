using System.Threading.Channels;
using System.Xml.Linq;

namespace Assignment3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //part1
                //will see it in The Demo in another Solution 
            //Part2
            #region 1 Define a struct "Person" 
            //Person[] persons = new Person[3];
            //persons[0] = new Person("mostafa",22);
            //persons[1] = new Person("Sameh", 22);
            //persons[2] = new Person("Adham", 22);

            //Array.ForEach(persons, p => Console.WriteLine($"{p.Name} , {p.Age}"));
            #endregion
            #region  2 Create a struct called "Person"
            //Person[] persons = new Person[3];

            //int Age1;
            //int Age2;
            //int Age3;

            //bool Age1Check;
            //bool Age2Check;
            //bool Age3Check;

            //Console.WriteLine("Enter first name");
            //string Name1 = Console.ReadLine();
            //do
            //{
            //    Console.WriteLine("Enter first Age");
            //    Age1Check = int.TryParse(Console.ReadLine(), out Age1);
            //} while (!Age1Check || !(Age1 >= 12 && Age1 < 60));

            //Console.WriteLine("Enter Second name");
            //string Name2 = Console.ReadLine();
            //do
            //{
            //    Console.WriteLine("Enter second Age");
            //    Age2Check = int.TryParse(Console.ReadLine(), out Age2);
            //} while (!Age2Check || !(Age2 >= 12 && Age2 < 60));

            //Console.WriteLine("Enter third name");
            //string Name3 = Console.ReadLine();
            //do
            //{
            //    Console.WriteLine("Enter third Age");
            //    Age3Check = int.TryParse(Console.ReadLine(), out Age3);
            //} while (!Age3Check || !(Age3 >= 12 && Age3 < 60));


            //persons[0] = new Person(Name1, Age1);
            //persons[1] = new Person(Name2, Age2);
            //persons[2] = new Person(Name3, Age3);

            //int oldest = Math.Max(persons[0].Age, Math.Max(persons[1].Age, persons[2].Age));

            //for (int i = 0; i<3; i ++ )
            //{
            //    if (persons[i].Age == oldest) 
            //        Console.WriteLine($"{persons[i].Name} , {persons[i].Age}");
            //}


            //Array.ForEach(persons, p => Console.WriteLine($"{p.Name} , {p.Age}"));

            #endregion
            //part3
            #region 1 Design and implement a Class for the employees 

            #region Employee Class to represent Employee data in a string Form
            //Employee employee = new Employee(1, "Am7", Permissions.developer, 60000, Gender.m, 1, 2, 2002);
            //Console.WriteLine(employee.ToString());
            #endregion
            #region Create an array of Employees 

            //Employee[] employees = new Employee[3];

            //employees[0] = new Employee(2, "DBA", Permissions.dba, 60000, Gender.m, 1, 2, 2002);
            //employees[1] = new Employee(3, "Guest", Permissions.guest, 60000, Gender.m, 1, 2, 2002);
            //employees[2] = new Employee(4, "security officer", (Permissions)15, 60000, Gender.m, 1, 2, 2002);

            ////Array.ForEach(employees, p => Console.WriteLine($"Id : {p.Id} | Name : {p.Name} | Security_Level : {p.Security_Level}  | Salary :{p.Salary:c} | Gender : {(p.Gender.ToString() == Gender.m.ToString() ? " Male " : " Female ")} | Date :{p.Day}/{p.Month}/{p.Year}"));
            //for (int i = 0; i < employees.Length; i++)
            //    Console.WriteLine(employees[i].ToString());
            #endregion

            #endregion
        }
    }
}
