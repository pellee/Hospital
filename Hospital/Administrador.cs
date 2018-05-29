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

        private bool VerificarUser()
        {

            // TODO - Hacer cosas para que verifique el user.

            return true;
        }

        private bool VerificarPass()
        {

            // TODO - Hacer cosas para que verifique la pass.

            return true;
        }

        public void AgregarPaciente()
        {
            // TODO - Hacer cosas para agregar el paciente.
        }

        public void BorrarPaciente()
        {
            // TODO - Hacer cosas para borrar el paciente.
        }

        public void ModificarPaciente()
        {
            // TODO - Hacer cosas para modificar el paciente.
        }

        public void ConsultarPaciente()
        {
            // TODO - Hacer cosas para consultar el paciente.
        }
    }
}
