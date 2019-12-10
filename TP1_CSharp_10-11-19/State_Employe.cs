using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_CSharp_10_11_19
{
    class State_Employe : State
    {

        public override double calculPrime()
        {
            //initilsation des données
            this.Salaire = 35000.0; //initialisation du salaire
            double rslt = this.Salaire * 0.10;
            return rslt;
        }

        public override void promouvoir()
        {
            this._context.TransitionTo(new State_Cadre());
        }

    }
}
