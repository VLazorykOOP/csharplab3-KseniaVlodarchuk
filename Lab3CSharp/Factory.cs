using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3CSharp
{
    internal class Factory : Company
    {
        protected string productionSector;
        protected int productionVolume;

        public Factory(string name, int year, string sector, int volume)
            : base(name, year)
        {
            productionSector = sector;
            productionVolume = volume;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Production Sector: {productionSector}, Volume: {productionVolume}");
        }
    }
}
