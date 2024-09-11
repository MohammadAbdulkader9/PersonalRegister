using System;

namespace PersonalRegister
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            int choice;

            Console.WriteLine("Personal Register");
            Console.WriteLine("----------------------------");
            do
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine("1. Lägg till personal");
                Console.WriteLine("2. Visa personal");
                Console.WriteLine("0. Avsluta");
                Console.WriteLine("----------------------------");

                Console.Write("Val: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddEmployee(employees);
                        break;

                    case 2:
                        ViewEmployee(employees);
                        break;

                    case 0:
                        Console.WriteLine("Avslut");
                        break;
                }
            } while (choice != 0);
        }

        private static void ViewEmployee(List<Employee> employees)
        {
            if (employees.Count == 0)
            {
                Console.WriteLine("Tom");
            }
            else
            {
                Console.WriteLine("Personal:");
                int id = 0;
                foreach (Employee emp in employees)
                {
                    id++;
                    Console.WriteLine($"ID: {id} - Namn: {emp.name} - Lön: {emp.salary}");
                }
            }
        }

        private static void AddEmployee(List<Employee> employees)
        {
            Console.Write("Skriv namn: ");
            string name = Console.ReadLine();

            Console.Write("Skriv lön: ");
            string salaryInput = Console.ReadLine();

            if (string.IsNullOrEmpty(name) || !double.TryParse(salaryInput, out double salary) || salary < 0)
            {
                Console.WriteLine("* Ogiltig namn eller lön!");
            }
            else
            {
                employees.Add(new Employee(name, salary));
            }

        }
    }
}
