using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2Week5
{
    public class Loan : Account
    {
     
        public Loan(Client customer, decimal balance, decimal rate, DateTime openDate)
            : base(customer, balance, rate, openDate)
        {

        }

       
        public override decimal CalculateInterestTotal()
        {
            if (this.Client.Type == clientType.Individual && this.Months < 3)
            {
                return 0;
            }

            if (this.Client.Type == clientType.Company && this.Months < 2)
            {
                return 0;
            }

            return base.CalculateInterestTotal();
        }

    }
}
