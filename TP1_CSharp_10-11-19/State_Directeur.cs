using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_CSharp_10_11_19
{
    class State_Directeur : State
    {
        public double FixedBonus
        {
            get; set;
        }

        public double Benef
        {
            get; set;
        }

        public double Pourcentage
        {
            get;set;
        }

        public override double calculPrime()
        {
            //initilisation des donnéées
            this.Salaire = 35000.0;
            this.FixedBonus = 50.0;
            this.Benef = 100000.0;
            this.Pourcentage = 0.10;
            double rslt = this.Salaire * 0.1;
            rslt += this.FixedBonus;
            rslt += this.Benef * this.Pourcentage;

            return rslt;
        }

        public override void promouvoir()
        {
            Console.Write("Cannot promote a director\n");
        }

    }
}
