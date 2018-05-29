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
        private List<Medicamento> medicamentos;

        public Receta() { }
        public Receta(Paciente paciente, List<Medicamento> medicamentos)
        {
            this.paciente = paciente;
            this.medicamentos = medicamentos;
        }
    }
}
