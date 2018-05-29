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

        protected void SetDni (string dni)
        {
            this.dni = dni;
        }

        protected void SetNombre (string nombre)
        {
            this.nombre = nombre;
        }

        protected void SetApellido (string apellido)
        {
            this.apellido = apellido;
        }
        protected void SetDireccion (string direccion)
        {
            this.direccion = direccion;
        }
    }
}
