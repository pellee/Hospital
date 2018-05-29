using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Hospital
    {
        List<Paciente> pacientes = new List<Paciente>();
        Medico[] medicos;
        Administrador admin;
        Farmacia farmacia;

        public Hospital() { }
        public Hospital(Medico[] medicos, Administrador admin, Farmacia farmacia)
        {
            this.medicos = medicos;
            this.admin = admin;
            this.farmacia = farmacia;
        }

        public void Menu()
        {
            // TODO - Hacer cosas para viajar entre pacientes, medicos, admin y farmacia.
        }

    }
}
