using System;
using System.Globalization;
using System.Collections.Generic;
using RegisterTaxpayers.Entities;

namespace RegisterTaxpayers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayers> list = new List<TaxPayers>();
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                if (ch == 'i')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Anual Income: ");
                    double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, anualIncome, healthExpenditures));
                }
                else
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Anual Income: ");
                    double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, anualIncome, numberOfEmployees));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID");
            double sum = 0;
            foreach(TaxPayers players in list)
            {
                Console.WriteLine($"{players.Name} $ {players.Tax().ToString("F2", CultureInfo.InvariantCulture)}");
                sum += players.Tax();
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
