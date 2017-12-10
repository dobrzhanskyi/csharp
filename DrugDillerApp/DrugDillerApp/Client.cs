using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DrugDillerApp
{
    class Client
    {
        public string clientName;
        bool isAlive;
       public int quantityOfGanja=0;
        public int quantityOfCocain=0;
       public  int quantityOfMoney = 100;

        public Guid guid = Guid.NewGuid();


         
        public Client(string name = "") {
            this.clientName = name;
        }
         
        public void BuyDrugs(int quantityOfCocain, int quantityOfGanja)
        {
            this.quantityOfCocain = quantityOfCocain;
            this.quantityOfGanja = quantityOfGanja;
        }

        public override string ToString()
        {
            return this.clientName;
        }

    }
}
