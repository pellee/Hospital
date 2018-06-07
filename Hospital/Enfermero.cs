using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Enfermero : Persona
    {
        public Enfermero() : base () { }
        public Enfermero(string dni, string nombre, string apellido, string direccion) : base(dni, nombre, apellido, direccion) { }

        public void ConsultarPaciente(Paciente paciente)
        {
            paciente.MostrarDatosPaciente();
        }
    }
}
