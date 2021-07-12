using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterTaxpayers.Entities
{
    abstract class TaxPayers
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public TaxPayers(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Tax();
    }
}
