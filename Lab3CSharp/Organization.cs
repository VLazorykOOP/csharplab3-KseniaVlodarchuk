using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3CSharp
{
    internal class Organization:Company
    {
        protected string organizationType;
        protected int numberOfEmployees;

        public Organization(string name, int year, string type, int employees)
            : base(name, year)
        {
            organizationType = type;
            numberOfEmployees = employees;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Type: {organizationType}, Employees: {numberOfEmployees}");
        }
    }
}
