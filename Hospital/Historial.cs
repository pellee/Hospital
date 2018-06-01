using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Historial
    {
        private string analisis, revision, alergias, enfermedades;
        private List<string> medicamentos = new List<string>();
        private DateTime fechaHistorial;

        public string Analisis { get => analisis; }
        public string Revision { get => revision; }
        public string Alergias { get => alergias; }
        public string Enfermedades { get => enfermedades; }
        public string Fecha { get => fechaHistorial.ToShortDateString(); }
        public string Hora { get => fechaHistorial.ToShortTimeString(); }
        public List<string> Medicamentos { get => medicamentos; }

        public Historial() { }
        public Historial(string analisis, string revision, List<string> medicamentos, string alergias, string enfermedades, DateTime fechaHistorial)
        {
            this.analisis = analisis;
            this.revision = revision;
            this.medicamentos = medicamentos;
            this.alergias = alergias;
            this.enfermedades = enfermedades;
            this.fechaHistorial = fechaHistorial;
        }
    }
}
