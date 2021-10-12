using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraComplejo
{
     struct Complejo
    {
        public double Real { get; }
        public double Imaginario { get; }

        public Complejo (double real , double imaginario) : this()
        {
            Real = real; 
            Imaginario = imaginario;

        }

        public double suma(Complejo otro)
        {
            return new Complejo(Real + otro.Real);
        }

    }
}
