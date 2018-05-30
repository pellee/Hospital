using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Medico : Persona
    {
        private List<Turno> turnos= new List<Turno>();

        public string DNI { get => dni; }
        public string Nombre { get => nombre; }
        public string Apellido { get => apellido; }
        public string Direccion { get => direccion; }

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

        public void CrearReceta()
        {
            // TODO - Hacer cosas para crear la receta.
        }

        public void AgregarTurno(Turno turno)
        {
            turnos.Add(turno);
        }

        public void ConsultarTurnos()
        {
            foreach (var t in turnos)
                Console.WriteLine("1> El paciente " + t.Paciente.Nombre + " tiene turno el dia " + t.FechaHoraTurno.ToShortDateString() + " a las " + t.FechaHoraTurno.ToShortTimeString());
        }
    }
}
