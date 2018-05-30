using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    abstract class Persona
    {
        protected string dni, nombre, apellido, direccion;

        protected Persona () { }

        protected Persona (string dni, string nombre, string apellido, string direccion)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.direccion = direccion;
        }

        public void SetDni (string dni)
        {
            this.dni = dni;
        }

        public void SetNombre (string nombre)
        {
            this.nombre = nombre;
        }

        public void SetApellido (string apellido)
        {
            this.apellido = apellido;
        }
        public void SetDireccion (string direccion)
        {
            this.direccion = direccion;
        }
    }
}
