using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_CSharp_10_11_19
{
    class State_Cadre : State
    {

        public double FixedBonus
        {
            get; set;
        }

        public override double calculPrime()
        {
            //initilisation des données
            this.Salaire = 35000.0;
            this.FixedBonus = 500.0; // initialisation du salaire
            double rslt = this.Salaire * 0.10;
            rslt += this.FixedBonus;
            return rslt;
        }

        public override void promouvoir()
        {
            this._context.TransitionTo(new State_Directeur());
        }

    }
}
