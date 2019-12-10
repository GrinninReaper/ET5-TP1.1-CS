using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_CSharp_10_11_19
{
    abstract class State
    {

        protected Context _context;

        public double Salaire
        {
            get; set;
        }

        public void SetContext(Context context)
        {
            this._context = context;
        }

        public abstract double calculPrime();

        public abstract void promouvoir();

    }
}
