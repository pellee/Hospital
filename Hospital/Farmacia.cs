using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Farmacia
    {
        private Enfermero[] enfermeros;

        public Farmacia() { }

        public Farmacia(Enfermero[] enfermeros)
        {
            this.enfermeros = enfermeros;
        }

        public void VenderRemedio()
        {
            // TODO - Hacer cosas para vender el remedio.
        }
        
        public void VerStock()
        {
            // TODO - Hacer cosas para ver el stock del remedio.
        }
    }
}
