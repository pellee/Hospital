using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    static class Menu
    {
        public static bool IngresoMenuADM(Administrador admin)
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

        public static void MenuADM(Administrador admin, ref List<Paciente> pacientes, Medico[] medicos)
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

        private static  int BuscarPaciente(string dni, List<Paciente> pacientes)
        {
            for (int i = 0; i < pacientes.Count; i++)
            {
                if (pacientes[i].DNI.Equals(dni))
                    return i;
            }

            return -1;
        }

        public static void MenuPaciente(ref List<Paciente> pacientes)
        {
            string dni;
            int i;

            Console.WriteLine("Ingrese dni del paciente que quiere solicitar el turno: ");
            dni = Console.ReadLine();

            i = BuscarPaciente(dni, pacientes);

            if (i == -1)
                Console.WriteLine("No se encontro el paciente.");
            else
                pacientes[i].SolicitarTurno(true);
        }

        private static int BuscarMedico(string dni, Medico[] medicos)
        {
            for (int i = 0; i < medicos.Length; i++)
            {
                if (medicos[i].DNI.Equals(dni))
                    return i;
            }

            return -1;
        }

        public static Paciente MenuMedico(ref Medico[] medicos)
        {
            // TODO probar que esto funcione

            string dni;
            int i;
            Paciente paciente = null;

            Console.WriteLine("Ingrese dni del medico: ");
            dni = Console.ReadLine();

            i = BuscarMedico(dni, medicos);

            if (i != -1) {
                paciente = medicos[i].AtenderPaciente(medicos[i].ConsultarTurnos());
            }

            return paciente;
        }

    }
}
