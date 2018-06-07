using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Receta
    {
        private Paciente paciente;
        private List<string> medicamentos;

        public List<string> Medicamentos { get => medicamentos; }

        public Receta() { }
        public Receta(Paciente paciente, List<string> medicamentos)
        {
            this.paciente = paciente;
            this.medicamentos = medicamentos;
        }
    }
}
