using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Medico : Persona
    {
        public Medico() : base() { }
        public Medico(string dni, string nombre, string apellido, string direccion) : base(dni, nombre, apellido, direccion) { }

        public void CrearHistorial()
        {
            // TODO - Hacer cosas para crear el historial.
        }

        public void AgregarAlHistorial()
        {
            // TODO - Hacer cosas para agregar cosas al historial.
        }

        public void HacerReceta()
        {
            // TODO - Hacer cosas para crear la receta.
        }
    }
}
