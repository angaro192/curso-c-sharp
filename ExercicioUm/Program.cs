using ExercicioUm.Entities;
using ExercicioUm.Entities.Enums;
using System;
using System.Globalization;

namespace ExercicioUm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com nome do departamento: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter worker data: ");
            Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.WriteLine("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.WriteLine("Quantos contratos para esse trabalhador?");
            int n = int.Parse(Console.ReadLine());
            for(int i=1; i <= n; i++)
            {
                Console.WriteLine($"Entre com os dados do contrato n° #{i}");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Valor por hora:");
                double valuePerHour = double.Parse(Console.ReadLine());
                Console.WriteLine("Duração em horas: ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);
            }
            Console.WriteLine("Entre com o mês e ano para calcular os gastos (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));
            Console.WriteLine("Nome: " + worker.Name);
            Console.WriteLine("Departamento: " + worker.Department.Name);
            Console.WriteLine("Calculo de " + monthAndYear + ": " + worker.Income(year, month));
        }
    }
}
