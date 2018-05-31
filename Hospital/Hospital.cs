using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Hospital
    {
        private List<Paciente> pacientes = new List<Paciente>();
        private Medico[] medicos;
        private Administrador admin;
        private Farmacia farmacia;

        public Hospital() { }
        public Hospital(Medico[] medicos, Administrador admin, Farmacia farmacia)
        {
            this.medicos = medicos;
            this.admin = admin;
            this.farmacia = farmacia;
        }

        private void ActualizarPaciente(Paciente paciente)
        {
            for (int i = 0; i < pacientes.Count; i++)
            {
                if (pacientes[i].Equals(paciente))
                    pacientes[i] = paciente;
            }
        }

        public void MenuHospital()
        {
            char opc;

            do {
                Console.WriteLine("1> Pacientes\n2> Medicos\n3> Farmacia\n4> Admin\n5> Salir");
                opc = char.Parse(Console.ReadLine());

                if (opc == '1') {
                    Menu.MenuPaciente(ref pacientes);

                    AsignarTurnos(CrearTurno());
                }

                if (opc == '2') {
                    var paciente = Menu.MenuMedico(ref medicos);

                    ActualizarPaciente(paciente);
                }

                if (opc == '3')
                {
                    // TODO - llamar menu farmacia.
                }

                if (opc == '4') {
                    if (Menu.IngresoMenuADM(admin))
                        Menu.MenuADM(admin, ref pacientes, medicos);
                }
            } while (opc != '5');

        }

        private void AsignarTurnos(Turno turno)
        {
            foreach (var m in medicos) {
                if (m == turno.Paciente.Medico)
                    m.AgregarTurno(turno);
            }
        }

        private Turno CrearTurno()
        {
            Turno turno = null;

            foreach (var p in pacientes) {
                DateTime fhora;

                if(p.TurnoSolicitado) {
                    Console.WriteLine("fecha y hora para el turno: ");
                    fhora = DateTime.Parse(Console.ReadLine());

                    turno = new Turno(p, fhora);
                }
            }

            return turno;
        }
    }
}
