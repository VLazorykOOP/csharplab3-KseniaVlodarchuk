using System;

namespace Lab3CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lab 3 ");
            Console.WriteLine("Номер завдання: ");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    {
                        Date[] dates = new Date[]
                        {
                            new Date(12, 4, 2021),
                            new Date(15, 8, 2022),
                            new Date(5, 1, 2022),
                            new Date(28, 2, 2021),
                            new Date(7, 12, 2025)
                        };

                        // Сортування дат за зростанням
                        Array.Sort(dates, (x, y) => x.Year != y.Year ? x.Year.CompareTo(y.Year) :
                                                    (x.Month != y.Month ? x.Month.CompareTo(y.Month) :
                                                    x.Day.CompareTo(y.Day)));

                        Console.WriteLine("Відсортовані дати:");
                        Console.WriteLine("Формат вигляду 5 січня 2022 року:");
                        foreach (var date in dates)
                        {
                            date.PrintLongFormat();
                        }
                        Console.WriteLine("Формат вигляду 05.01.2022:");
                        foreach (var date in dates)
                        {
                            date.PrintShortFormat();
                        }
                        int maxDays = 0;
                        for (int i = 0; i < dates.Length - 1; i++)
                        {
                            for (int j = i + 1; j < dates.Length; j++)
                            {
                                int days = dates[i].DaysBetween(dates[j]);
                                if (days > maxDays)
                                    maxDays = days;
                            }
                        }
                        Console.WriteLine($"Найбільша кількість днів між датами: {maxDays}");
                        Console.WriteLine($"Яке Століття: {dates[2].Century}");
                        break;
                    }
                case 2:
                    {
                        Company[] companies = new Company[]
                        {
                            new Organization("Example Org", 2000, "Non-profit", 100),
                            new InsuranceCompany("Insurance Corp", 1995, "Life Insurance", 5000),
                            new OilGasCompany("OilGas Inc", 1978, "Oil and Gas Exploration", 10),
                            new Factory("Example Factory", 2010, "Automotive", 1000000),
                        };
                        // Виводимо масив впорядкований за роком
                        Array.Sort(companies, (x, y) => x.GetYearFounded().CompareTo(y.GetYearFounded()));
                        foreach (var company in companies)
                        {
                            company.Show();
                            Console.WriteLine();
                        }
                        break;
                    }
                default: { Console.WriteLine("Wrong"); break; }
            }
        }
    }
}
