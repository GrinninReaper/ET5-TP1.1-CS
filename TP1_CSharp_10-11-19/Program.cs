using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_CSharp_10_11_19
{
    class Program
    {
        static void Main(string[] args)
        {

            var Morningstar = new Context(new State_Employe());
            Console.Write(Morningstar.calculPrime() + "\n");
            //Cadre
            Morningstar.promouvoir();
            Console.Write(Morningstar.calculPrime() + "\n");
            //Directeur
            Morningstar.promouvoir();
            Console.Write(Morningstar.calculPrime() + "\n");
            //Esssai verif
            Morningstar.promouvoir();
        }
    }
}
