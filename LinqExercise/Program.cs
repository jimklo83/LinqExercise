using System;
using System.Collections.Generic;
using System.Linq;

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

            //TODO: Print the Sum of numbers

            var sum = numbers.Sum();
            Console.WriteLine(sum);

            //TODO: Print the Average of numbers
            var average = numbers.Average();
            Console.WriteLine(average);

            //TODO: Order numbers in ascending order and print to the console
            var ascending = numbers.OrderBy(x => x).ToList();
            ascending.ForEach(x => Console.WriteLine(x));

            //TODO: Order numbers in descending order and print to the console
            var descending = numbers.OrderByDescending(x => x).ToList();
            descending.ForEach(x => Console.WriteLine(x));

            //TODO: Print to the console only the numbers greater than 6
            var greater6 = numbers.Where(x => x > 6).ToList();
            greater6.ForEach(x => Console.WriteLine(x));

            //TODO: Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!**
            var ascending4 = numbers.OrderBy(x => x).ToList();

            foreach (var number in ascending4) 
            {
                if (number <= ascending4[3]) 
                {
                    Console.WriteLine(number);
                }
            }

            //TODO: Change the value at index 4 to your age, then print the numbers in descending order

            var myAge = numbers.OrderByDescending(x => x).ToList();
            myAge[3] = 40;
            myAge.ForEach(x => Console.WriteLine(x));

            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.

            var employeesCS = employees.Where(x => x.FirstName.StartsWith("C") || x.FirstName.StartsWith("S")).OrderBy(x => x.FirstName).ToList();

            employeesCS.ForEach(x => Console.WriteLine(x.FullName));
            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.

            var employeesAge = employees.Where(x => x.Age > 26).OrderBy(x => x.Age).ThenBy(x => x.FirstName).ToList();

            employeesAge.ForEach(x => Console.WriteLine($"{x.FullName}: {x.Age}"));

            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.

            var eligibleEmployees = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35).ToList();
            var expSum = eligibleEmployees.Sum(x => x.YearsOfExperience);
            var expAvg = eligibleEmployees.Average(x => x.YearsOfExperience);

            Console.WriteLine($"The sum of experience of employees that are 35 or older is {expSum} years and the average is {expAvg}.");

            //TODO: Add an employee to the end of the list without using employees.Add()

            var joe = new Employee("Joe", "Blow", 100, 1);
            
            var updatedEmployees = employees.Append(joe).ToList();
            updatedEmployees.ForEach(x => Console.WriteLine(x.FullName));

            
            
            Console.WriteLine();

            Console.ReadLine();
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
    }
}
