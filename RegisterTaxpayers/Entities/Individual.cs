using System;
using System.Collections.Generic;
using System.Globalization;


namespace RegisterTaxpayers.Entities
{
    class Individual : TaxPayers
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double anualIncome, double healthExpenditures)
            : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            double total = 0;
            if (AnualIncome < 20000.00 && HealthExpenditures < 0)
            {
                total = AnualIncome * 0.15;
            } else if (AnualIncome > 20000.00 && HealthExpenditures > 0)
            {
                total = (AnualIncome * 0.25) - (HealthExpenditures * 0.5);
            }
            else
            {
                total = AnualIncome * 0.25;
            }

            return total;
        }
    }
}
