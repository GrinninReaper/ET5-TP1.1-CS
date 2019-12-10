using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_CSharp_10_11_19
{
    class Context
    {

        private State _state = null;

        public State State
        {
            get; set;
        }

        public Context(State state)
        {
            this.TransitionTo(state);
        }

        public void TransitionTo(State state)
        {
            Console.WriteLine($"Context: Transition to {state.GetType().Name}.");
            this._state = state;
            this._state.SetContext(this);
        }

        public double calculPrime()
        {
            return this._state.calculPrime();
        }

        public void promouvoir()
        {
            this._state.promouvoir();
        }

    }
}
