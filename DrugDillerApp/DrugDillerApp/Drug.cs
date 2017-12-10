using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugDillerApp
{
    class Drug
    {
        public enum Drugs
        {
            ganja=10,
            cocaine=30
        }
        public Drug(string drugName, int drugPrice)
        {
            this.drugName = drugName;
            this.drugPrice = drugPrice;
        }
        public Drug()
        {

        }
        string drugName;
        public int drugPrice;
        
    }
}
