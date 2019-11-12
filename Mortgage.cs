using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2Week5
{
    public class Mortgage : Account
    {
        public Mortgage(Client client, decimal balance, decimal rate, DateTime openDate)
            : base(client, balance, rate, openDate)
        {

        }

        
        public override decimal CalculateInterestTotal()
        {
            if (this.Client.Type == clientType.Individual && this.Months < 6)
            {
                return 0;
            }

            if (this.Client.Type == clientType.Company && this.Months <= 12)
            {
                return (base.CalculateInterestTotal() / 2);
            }

            return base.CalculateInterestTotal();
        }
    }
}
