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
               
        private static void AddEmployee(List<Employee> employees)
        {
            int id = 0;
            double salary = 0;

            Console.Write("Skriv namn: ");
            string name = Console.ReadLine();

            Console.Write("Skriv lön: ");
            double.TryParse(Console.ReadLine(), out salary);

            if (string.IsNullOrWhiteSpace(name) || salary < 0)
            {
                Console.WriteLine("* Ogiltig namn eller lön!");
            }
            else
            {
                id++;
                employees.Add(new Employee(id, name, salary));
            }
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
                foreach (Employee emp in employees)
                {
                    Console.WriteLine($"ID: {emp.ID} - Namn: {emp.name} - Lön: {emp.salary}");
                }
            }
        }
    }
}
