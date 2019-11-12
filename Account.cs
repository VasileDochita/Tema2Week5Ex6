using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2Week5
{
    public abstract class Account : IDeposit
    {
        
        private Client client;
       
        private DateTime openDate;
        public decimal Balance { get; set; }

        public decimal InterestRate { get; set; }


        
        public Account(Client customer, decimal balance, decimal rate, DateTime openDate)
        {
            this.Client = client;
            this.Balance = balance;
            this.InterestRate = rate;
            this.openDate = openDate;
        }

        
        public Client Client
        {
            get { return this.client; }
            set
            {
                if (value == null)
                {
                    Console.WriteLine("invalid");
                }

                this.client = value;
            }
        }

       
        public int Months
        {
            get
            {
                return (DateTime.Now.Year * 12 + DateTime.Now.Month) - (this.openDate.Year * 12 + this.openDate.Month);
            }
        }

        
        public void MakeDeposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit must be positive");
            }

            this.Balance =this.Balance + amount;
        }

        
        public virtual decimal CalculateInterestTotal()
        {
            return (this.Months * this.InterestRate);
        }

        public override string ToString()
        {
            return string.Format("Client: {0}\nAccount type: {1}\n Balance: {2:C}\n Interest: {3:C} ",
                this.Client.Name, this.GetType().Name, this.Balance, this.CalculateInterestTotal());
        }

    }
}
