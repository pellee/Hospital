using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Historial
    {
        private string analisis, revision, medicamentos, alergias, enfermedades;
        private DateTime fechaHistorial;

        public Historial() { }
        public Historial(string analisis, string revision, string medicamentos, string alergias, string enfermedades, DateTime fechaHistorial)
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
