using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2Week5
{
    public class Deposit : Account, IWithdraw
    {
        
        public Deposit(Client customer, decimal balance, decimal rate, DateTime openDate)
            : base(customer, balance, rate, openDate)
        {

        }

        
        public override decimal CalculateInterestTotal()
        {
            if (this.Balance < 1000)
            {
                return 0;
            }

            return base.CalculateInterestTotal();
        }

        
        public void WithDraw(decimal withdrawedSum)
        {
            if (withdrawedSum <= 0)
            {
                Console.WriteLine("Withdraw sum must pe positive");
            }

            this.Balance = this.Balance - withdrawedSum;
        }
    }
}
