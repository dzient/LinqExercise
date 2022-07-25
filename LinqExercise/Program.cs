using System;
using System.Collections.Generic;
using System.Linq;
//-----------------------------------------------------------------
// Practice Linq
//
// Name: David Zientara
// Date: 7-25-2022
// Comments: An exercise in using Linq, part 2
// Made changes per the instructions
//-----------------------------------------------------------------

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

       
        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers - DONE
            Console.WriteLine($"Sum of numbers = {numbers.Sum()}");

            //TODO: Print the Average of numbers - DONE
            Console.WriteLine($"Average of numbers = {numbers.Average()}");

            //TODO: Order numbers in ascending order and print to the console
            //Got it down to one line - order by x because it's an array of ints(primitives)
            Console.WriteLine($"Here are numbers, in ascending order:  ");
            numbers.OrderBy(x => x).ToList().ForEach(x => Console.Write(x + "\t"));
            Console.WriteLine("");
            //TODO: Order numbers in decsending order adn print to the console - DONE
            //Again, we got it down to one line; just use OrderByDescending
            Console.WriteLine($"Here are numbers, in descending order:");
            numbers.OrderByDescending(x => x).ToList().ForEach(x => Console.Write(x + "\t"));
            Console.WriteLine("");

           
            //TODO: Print to the console only the numbers greater than 6 - DONE
            // Again we got it down to one line:
            Console.WriteLine($"Here are numbers, where numbers[x] > 6:");
            numbers.Where(x => x > 6).ToList().ForEach(x => Console.Write(x + "\t"));
            Console.WriteLine("");
            //list = numbers.ToList().GetRange(0, 4).ForEach(x => Console.Write(x + "\t");
            //TODO: Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**
            // By using GetRange, we were able to get it down to one line:
            Console.WriteLine($"Here are numbers, but only 4 of them:");
            numbers.ToList().GetRange(0, 4).ForEach(x => Console.Write(x + "\t"));
            Console.WriteLine("");
            //TODO: Change the value at index 4 to your age, then print the numbers in decsending order - DONE
            numbers[4] = 52;
            // Use OrderByDescending:
            Console.WriteLine($"Here are numbers, with one of them replaced:");
            numbers.OrderByDescending(x => x).ToList().ForEach(x => Console.Write(x + "\t"));
            Console.WriteLine("");
            
            //PrintList(list);


            // List of employees ****Do not remove this****
             var employees = CreateEmployees();

           

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in acesnding order by FirstName. - DONE
            Console.WriteLine("Employees whose first name starts with a C or S:");

            employees.Where(x => x.FirstName.ToLower().StartsWith('c') | x.FirstName.ToLower().StartsWith('s')).ToList().ForEach(x => Console.Write(x.FullName + "\t")); //.ForEach(x => Console.Write(x.FullName+"\t"));
            Console.WriteLine("");
            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
           

            Console.WriteLine("Employees whose age is greater than 26:");
            employees.Where(x => x.Age > 26).ToList().ForEach(x => Console.WriteLine(x.FullName));
            Console.WriteLine("");

            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35
            Console.Write("Sum of the employee's years of experience if YOE is less than or equal to 10 AND Age is greater than 30: ");
            Console.WriteLine(employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 30).ToList().Sum(x => x.YearsOfExperience)); //.Where(x => x.Age > 26).ToList();
            Console.Write("Average of the employee's years of experience if YOE is less than or equal to 10 AND Age is greater than 30: ");
            Console.WriteLine(employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 30).ToList().Average(x => x.YearsOfExperience));
            
          
            //TODO: Add an employee to the end of the list without using employees.Add()
            // Not sure what to do here; I just used an Insert:
           
            employees.Insert(employees.Count,new Employee("Homer","Simpson",35,10));
            Console.WriteLine("Here's a list of all employees:");
            employees.ForEach(x =>  Console.WriteLine(x.FullName));
            try
            {
                Console.WriteLine();

                Console.ReadLine();
            }
            finally
            {
                Console.WriteLine("End of program.");
            }
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion



        static void Print(int n)
        {
            Console.Write($"{n} ");
        }
    }
}