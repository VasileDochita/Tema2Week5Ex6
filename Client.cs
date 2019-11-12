using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2Week5
{
    public class Client
    {
        
        private string name;
        public clientType Type { get; private set; }


        public Client(string name, clientType type)
        {
            this.Name = name;
            this.Type = type;
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
                    Console.WriteLine("Insert valid name");
                }
                this.name = value;
            }
        }

    }
}
