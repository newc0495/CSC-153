using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class Employee
    {
        // Fields
        private string _name;
        private string _phone;
        private int _age;

        // Properties
        public string Name { get => _name; set => _name = value; }
        public string Phone { get => _phone; set => _phone = value; }
        public int Age { get => _age; set => _age = value; }

        // Constructor
        public Employee()
        {
            Name = "";
            Phone = "";
            Age = 0;
        }

        public Employee(string name, string phone, int age)
        {
            Name = name;
            Phone = phone;
            Age = age;
        }

        // Methods
        public static void BuildEmployee(List<Employee> employeeList)
        {
            Employee thisEmployee = new Employee();
            bool error = false;
            do
            {
                Console.WriteLine("Employee's first name: ");
                string firstName = Util.UserPrompt();
                Console.WriteLine("Employee's last name: ");
                string lastName = Util.UserPrompt();
                thisEmployee.Name = $"{lastName}, {firstName}";
                Console.WriteLine($"You've entered {thisEmployee.Name}");

                Console.WriteLine("Employee's Phone #: ");
                thisEmployee.Phone = Util.UserPrompt();
                Console.WriteLine($"You've entered {thisEmployee.Phone}");

                Console.WriteLine("Employee's Age: ");
                thisEmployee.Age = Util.MakeInt(Util.UserPrompt());
                if (thisEmployee.Age < 18)
                {
                    error = true;
                    Console.WriteLine("Something went wrong. Please start over.");
                }
                else
                {
                    error = false;
                }
            } while (error == true);

            employeeList.Add(thisEmployee);
            Console.WriteLine($"The Employee's reference ID is {employeeList.IndexOf(thisEmployee)}");
        }

        public static string ShowEmployee(Employee selectedEmployee)
        {
            return $"Employee Name: {selectedEmployee.Name}" +
                $"\nEmployee Phone #: {selectedEmployee.Phone}" +
                $"\nEmployee Age: {selectedEmployee.Age}";
        }
    }
}
