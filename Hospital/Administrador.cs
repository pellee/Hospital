using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Administrador : Persona
    {
        private string user, pass;

        public Administrador() : base() { }

        public Administrador(string dni, string nombre, string apellido, string direccion, string user, string pass) : base(dni, nombre, apellido,direccion)
        {
            this.user = user;
            this.pass = pass;
        }

        private bool VerificarUser(string user)
        {
            if (this.user == user)
                return true;

            return false;

        }

        private bool VerificarPass(string pass)
        {
            if (this.pass == pass)
                return true;

            return false;
        }

        public void AgregarPaciente(List<Paciente> pacientes, Medico[] medicos)
        {
            string dni, nombre, apellido, direccion;
            int i = 0;

            Console.WriteLine("Ingrese dni: ");
            dni = Console.ReadLine();
            Console.WriteLine("Ingrese nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese apellido: ");
            apellido = Console.ReadLine();
            Console.WriteLine("Ingrese direccion: ");
            direccion = Console.ReadLine();

            foreach (var m in medicos)
                Console.WriteLine(++i + ">" + m.Nombre);

            Console.WriteLine("Ingrese medico que atiende al paciente: ");
            i = int.Parse(Console.ReadLine());

            pacientes.Add(new Paciente(dni, nombre, apellido, direccion, medicos[i - 1]));

            Console.WriteLine("Paciente agregado.");
        }

        private int BuscarPaciente(List<Paciente> pacientes, string dni)
        {
            for (int i = 0; i < pacientes.Count; i++)
            {
                if (dni == pacientes[i].DNI)
                    return i;
            }

            return -1;
        }

        public void BorrarPaciente(List<Paciente> pacientes)
        {
            string dni;
            int i;

            if(pacientes.Count == 0)
                Console.WriteLine("No hay pacientes para eliminar.");
            else {
                do {
                    Console.WriteLine("Ingrese dni del paciente a eliminar: ");
                    dni = Console.ReadLine();

                    i = BuscarPaciente(pacientes, dni);

                    if (i != -1)
                        pacientes.Remove(pacientes[i]);
                } while (i == -1);
            }

            Console.WriteLine("Paciente eliminado.");
        }

        public void ModificarPaciente(List<Paciente> pacientes)
        {
            char opc;
            string dato;
            int i = 0;

            foreach (var p in pacientes)
                Console.WriteLine(++i + ">" + p.DNI + "  " + p.Nombre);

            Console.WriteLine("Ingrese paciente que quiere modificar: ");
            i = int.Parse(Console.ReadLine());

            Console.WriteLine("Que Quiere Modificar? ");
            Console.WriteLine("1> Dni\n2> Nombre\n3> Apellido\n4> Direccion");
            opc = char.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese nuevo dato: ");
            dato = Console.ReadLine();

            if (opc == '1')
                pacientes[i - 1].SetDni(dato);
            if (opc == '2')
                pacientes[i - 1].SetNombre(dato);
            if (opc == '3')
                pacientes[i - 1].SetApellido(dato);
            if (opc == '4')
                pacientes[i - 1].SetDireccion(dato);
        }

        public void ConsultarPaciente(List<Paciente> pacientes)
        {
            if(pacientes.Count != 0) {
                foreach (var p in pacientes) {
                    Console.WriteLine(p.DNI + "   " + p.Nombre + " Es atendido por " + p.Medico.Nombre);
                }
            }
            else
                Console.WriteLine("No hay pacientes para mostrar");
        }
    }
}
