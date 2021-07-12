using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterTaxpayers.Entities
{
    class Company : TaxPayers
    {
        public int NumberOfEmployees { get; set; }

        public Company(string name, double anualIncome, int numberOfEmployees) 
            : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            double func = 0;
            if (NumberOfEmployees > 10) 
            {
                func = AnualIncome * 0.14;
            }
            else
            {
                func = AnualIncome * 0.16;
            }

            return func;
        }
    }
}
