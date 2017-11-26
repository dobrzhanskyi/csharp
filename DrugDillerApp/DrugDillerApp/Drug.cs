using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugDillerApp
{
    class Drug
    {
        public Drug(string drugName, int drugPrice)
        {
            this.drugName = drugName;
            this.drugPrice = drugPrice;
        }
        string drugName;
        public int drugPrice;
        
    }
}
