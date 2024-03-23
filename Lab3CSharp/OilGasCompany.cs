using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3CSharp
{
    internal class OilGasCompany:Company
    {
        protected string businessArea;
        protected int numberOfBranches;

        public OilGasCompany(string name, int year, string area, int branches)
            : base(name, year)
        {
            businessArea = area;
            numberOfBranches = branches;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Business Area: {businessArea}, Branches: {numberOfBranches}");
        }
    }
}
