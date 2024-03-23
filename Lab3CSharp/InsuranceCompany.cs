using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3CSharp
{
    internal class InsuranceCompany:Company
    {
        protected string insuranceType;
        protected int numberOfClients;

        public InsuranceCompany(string name, int year, string type, int clients)
            : base(name, year)
        {
            insuranceType = type;
            numberOfClients = clients;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Insurance Type: {insuranceType}, Clients: {numberOfClients}");
        }
    }
}
