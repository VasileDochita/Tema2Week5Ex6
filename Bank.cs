using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2Week5
{
    public class Bank
    {
        private string name;
        private IList<Account> allAccounts;

       
        public Bank(string name)
        {
            this.Name = name;
            this.allAccounts = new List<Account>();
        }

        
        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("insert valid name");
                }

                this.name = value;
            }
        }

        internal IList<Account> AllAccounts
        {
            get
            {
                return new List<Account>(this.allAccounts);
            }
        }

        
        public void AddAccount(Account newAccount)
        {
            this.allAccounts.Add(newAccount);
        }

        public override string ToString()
        {
            return string.Format("Bank \"{0}\"\n Opened accounts: {1}", this.Name, this.AllAccounts.Count);
        }
    }
}
