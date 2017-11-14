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
        int quantityOfGanja;
        int quantityOfCocain;

        public Guid guid = Guid.NewGuid();
       
        public void BuyDrugs(int quantityOfCocain, int quantityOfGanja)
        {
            this.quantityOfCocain = quantityOfCocain;
            this.quantityOfGanja = quantityOfGanja;
        }
        
    }
}
