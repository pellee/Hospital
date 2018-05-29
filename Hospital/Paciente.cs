using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Paciente : Persona
    {
        List<Historial> historialMedico = new List<Historial>();
        Medico medico;
        bool turnoSolicitado = false;

        public Paciente() : base() { }

        public Paciente(string dni, string nombre, string apellido, string direccion, Medico medico) : base(dni, nombre, apellido, direccion)
        {
            this.medico = medico;
        }

        public void SolicitarTurno()
        {
            // TODO - Hacer cosas para solicitar el turno con el medico.
        }
    }
}
