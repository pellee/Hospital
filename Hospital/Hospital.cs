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

        private bool IngresoMenuADM()
        {
            string user, pass;

            do {
                Console.WriteLine("Ingrese el nombre de usuario: ");
                user = Console.ReadLine();
                Console.WriteLine("Ingrese pass: ");
                pass = Console.ReadLine();
            } while (!admin.VerificarUser(user) || !admin.VerificarPass(pass));

            Console.WriteLine();

            return true;
        }

        private void MenuADM()
        {
            char opc;

            do {
                Console.WriteLine("1> Crear Paciente\n2> Borrar Paciente\n3> Modificar Paciente\n4> Consultar Paciente\n5> Salir");
                opc = char.Parse(Console.ReadLine());

                if (opc == '1')
                    admin.AgregarPaciente(ref pacientes, ref medicos);

                if (opc == '2')
                    admin.BorrarPaciente(ref pacientes);

                if (opc == '3')
                    admin.ModificarPaciente(ref pacientes);

                if (opc == '4')
                    admin.ConsultarPaciente(pacientes);
            } while (opc != '5');
        }

        private int BuscarMedico(string dni)
        {
            for (int i = 0; i < medicos.Length; i++)
            {
                if (medicos[i].DNI.Equals(dni))
                    return i;
            }

            return -1;
        }

        private void ActualizarPaciente(Paciente paciente)
        {
            for (int i = 0; i < pacientes.Count; i++)
            {
                if (pacientes[i].Equals(paciente))
                    pacientes[i] = paciente;
            }
        }

        private void MenuMedico()
        {
            string dni;
            int i;
            Paciente paciente;

            Console.WriteLine("Ingrese dni del medico: ");
            dni = Console.ReadLine();

            i = BuscarMedico(dni);

            if (i != -1) {
                paciente = medicos[i].AtenderPaciente(medicos[i].ConsultarTurnos());

                ActualizarPaciente(paciente);
            }
        }

        private void MenuPaciente()
        {
            string dni;
            int i;

            Console.WriteLine("Ingrese dni del paciente que quiere solicitar el turno: ");
            dni = Console.ReadLine();

            i = BuscarPaciente(dni);

            if (i == -1)
                Console.WriteLine("No se encontro el paciente.");
            else {
                pacientes[i].SolicitarTurno(true);

                AsignarTurnos(CrearTurno());
            }
        }

        public void MenuHospital()
        {
            char opc;

            do {
                Console.WriteLine("1> Pacientes\n2> Medicos\n3> Farmacia\n4> Admin\n5> Salir");
                opc = char.Parse(Console.ReadLine());

                if (opc == '1')
                    MenuPaciente();

                if (opc == '2')
                    MenuMedico(); 

                if (opc == '3')
                {
                    // TODO - llamar menu farmacia.
                }

                if (opc == '4') {
                    if (IngresoMenuADM())
                        MenuADM();

                }
            } while (opc != '5');

        }

        private int BuscarPaciente(string dni)
        {
            for (int i = 0; i < pacientes.Count; i++)
            {
                if (pacientes[i].DNI.Equals(dni))
                    return i;
            }

            return -1;
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
