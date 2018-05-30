using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Turno
    {
        private Paciente paciente;
        private DateTime fechaHoraTurno;

        public Paciente Paciente { get => paciente; }
        public DateTime FechaHoraTurno { get => fechaHoraTurno; set => fechaHoraTurno = value; }

        public Turno() { }
        public Turno(Paciente paciente, DateTime fechaHoraTurno)
        {
            this.paciente = paciente;
            this.fechaHoraTurno = fechaHoraTurno;
        }
    }
}
