using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Paciente : Persona
    {
        private List<Historial> historialMedico = new List<Historial>();
        private Medico medico;
        private bool turnoSolicitado;
        private Receta receta;

        public string DNI { get => dni; }
        public string Nombre { get => nombre; }
        public string Apellido { get => apellido; }
        public string Direccion { get => direccion; }
        public bool TurnoSolicitado { get => turnoSolicitado; }
        public Medico Medico { get => medico; }
        public Receta Receta { get => receta; set => receta = value; }
        public List<Historial> Historial { get => historialMedico; set => historialMedico = value; }

        public Paciente() : base() { }

        public Paciente(string dni, string nombre, string apellido, string direccion, Medico medico) : base(dni, nombre, apellido, direccion)
        {
            this.medico = medico;
            this.turnoSolicitado = false;
        }

        public void SolicitarTurno(bool estado)
        {
            turnoSolicitado = estado;
        }

        public void MostrarDatosPaciente()
        {
            Console.WriteLine(DNI + " " + Nombre + " " + " " + Apellido + " " + Direccion + " lo atiende el medico " + medico.Nombre);

            if(Historial.Count != 0) {
                foreach (var h in Historial) {
                    Console.WriteLine("El dia " + h.Fecha + " en la hora " + h.Hora + " se hizo esta entrada al historial");
                    Console.WriteLine("Analisis: " + h.Analisis + "\nRevision: " + h.Revision + "\nAlergias: " + h.Alergias);
                    Console.WriteLine("Enfermedades: " + h.Enfermedades);

                    if(h.Medicamentos.Count != 0) {
                        Console.WriteLine("Lista de medicamentos: ");

                        foreach (var m in h.Medicamentos)
                            Console.WriteLine(m);
                    }
                }
            }
        }
    }
}
