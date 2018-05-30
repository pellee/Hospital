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

        private int BuscarPaciente(string dni)
        {
            for (int i = 0; i < pacientes.Count; i++)
            {
                if (pacientes[i].Equals(dni))
                    return i;
            }

            return -1;
        }

        public bool IngresoMenuADM()
        {
            string user, pass;

            do {
                Console.WriteLine("Ingrese el nombre de usuario: ");
                user = Console.ReadLine();
                Console.WriteLine("Ingrese pass: ");
                pass = Console.ReadLine();
            } while (!admin.VerificarUser(user) || !VerificarPass(pass));

            Console.WriteLine();

            return true;
        }

        public void MenuADM()
        {
            char opc;

            do {
                Console.WriteLine("1> Crear Paciente\n2> Borrar Paciente\n3> Modificar Paciente\n4> Consultar Paciente\n5> Salir");
                opc = char.Parse(Console.ReadLine());

                if (opc == '1')
                    AgregarPaciente(pacientes, medicos);

                if (opc == '2')
                    BorrarPaciente(pacientes);

                if (opc == '3')
                    ModificarPaciente(pacientes);

                if (opc == '4')
                    ConsultarPaciente(pacientes);
            } while (opc != '5');
        }

        public void MenuHospital()
        {
            char opc;

            do {
                Console.WriteLine("1> Pacientes\n2> Medicos\n3> Farmacia\n4> Admin\n5> Salir");
                opc = char.Parse(Console.ReadLine());

                if (opc == '1') {
                    string dni;
                    int i;

                    Console.WriteLine("Ingrese dni del paciente que quiere solicitar el turno: ");
                    dni = Console.ReadLine();

                    i = BuscarPaciente(dni);

                    if (i == -1)
                        Console.WriteLine("No se encontro el paciente.");
                    else
                        pacientes[i].SolicitarTurno(true);
                }

                if (opc == '2')
                {
                    // TODO - llamar menu medicos.
                    
                    AsignarTurnos(CrearTurnos());
                }

                if (opc == '3')
                {
                    // TODO - llamar menu farmacia.
                }

                if (opc == '4') {
                    if (admin.IngresoMenu())
                        admin.Menu(ref pacientes, ref medicos);

                }
            } while (opc != '5');

        }

        private void AsignarTurnos(List<Turno> turnos)
        {
            foreach (var m in medicos) {
                foreach (var t in turnos) {
                    if(m == t.Paciente.Medico)
                        m.AgregarTurno(t);
                }
            }
        }

        private List<Turno> CrearTurnos()
        {
            var turnos = new List<Turno>();

            foreach (var p in pacientes) {
                DateTime fhora;
                if(p.TurnoSolicitado) {
                    Console.WriteLine("fecha y hora para el turno: ");
                    fhora = DateTime.Parse(Console.ReadLine());

                    turnos.Add(new Turno(p, fhora));
                }
            }

            return turnos;
        }
    }
}
