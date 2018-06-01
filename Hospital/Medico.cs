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

        private Historial AgregarAlHistorial()
        {
            string analisis, revision, alergias, enfermedades;
            char opc;
            var medicamentos = new List<string>();

            Console.WriteLine("Ingrese analisis del paciente: ");
            analisis = Console.ReadLine();
            Console.WriteLine("Ingrese revision del paciente: ");
            revision = Console.ReadLine();

            Console.WriteLine("Necesita medicamentos? S/N");
            opc = char.Parse(Console.ReadLine());
            opc = char.ToUpper(opc);

            if (opc != 'N') {
                do {
                    Console.WriteLine("Ingrese medicamentos: ");
                    medicamentos.Add(Console.ReadLine());

                    Console.WriteLine("Desea continuar? S/N");
                    opc = char.Parse(Console.ReadLine());
                    opc = char.ToUpper(opc);
                } while (opc!= 'N');
            }

            Console.WriteLine("Ingrese alergias del paciente: ");
            alergias = Console.ReadLine();
            Console.WriteLine("Ingrese enfermedades del paciente: ");
            enfermedades = Console.ReadLine();

            return new Historial(analisis, revision, medicamentos, alergias, enfermedades, DateTime.Now);
        }

        public void AgregarTurno(Turno turno)
        {
            turnos.Add(turno);
        }

        private void BorrarTurno(Turno turno)
        {
            turnos.Remove(turno);
        }

        public Paciente AtenderPaciente(Turno turno)
        {
            var historial = AgregarAlHistorial();
            Receta receta = null;

            if (historial.Medicamentos.Count != 0)
            {
                receta = new Receta(turno.Paciente, historial.Medicamentos);

                turno.Paciente.Receta = receta;
                turno.Paciente.Historial.Add(historial);
                turno.Paciente.SolicitarTurno(false);
            }
            else {
                turno.Paciente.Historial.Add(historial);
                turno.Paciente.SolicitarTurno(false);
            }
                

            var paciente = turno.Paciente;

            BorrarTurno(turno);

            return paciente;
                
        }

        public Turno ConsultarTurnos()
        {
            int i = 0;

            if (turnos.Count != 0) {
                foreach (var t in turnos)
                    Console.WriteLine(++i + "> El paciente " + t.Paciente.Nombre + " tiene turno el dia " + t.FechaHoraTurno.ToShortDateString() + " a las " + t.FechaHoraTurno.ToShortTimeString());

                Console.WriteLine("Seleccione al paciente que va a atender: ");
                i = int.Parse(Console.ReadLine());

                return turnos[i - 1];
            }
            else {
                Console.WriteLine("No tiene pacientes para atender.");

                return null;
            }
        }
    }
}
