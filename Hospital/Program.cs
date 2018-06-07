using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Program
    {
        static Medico[] CrearMedicos()
        {
            var medicos = new Medico[3];
            long dni = 41708817L;
            string[,] datos = new string[,] { { "carlos", "alberto", "pedro" },
                { "perez", "coronado", "crabbe" }, { "dire1", "dire2", "dire3" } };

            for (int i = 0; i < medicos.Length; i++) {
                dni += 1;
                medicos[i] = new Medico(dni.ToString(), datos[0, i], datos[1, i], datos[2, i]);
            }

            return medicos;
        }

        static Farmacia CrearFarmacia()
        {
            var enfermeros = new Enfermero[3];
            long dni = 41708820L;
            string[,] datos = new string[,] { { "ernesto", "sebastian", "gustavo" },
                { "chuchi", "chacha", "peque" }, { "dire5", "dire6", "dire7" } };

            for (int i = 0; i < enfermeros.Length; i++)
            {
                dni++;
                enfermeros[i] = new Enfermero(dni.ToString(), datos[0, i], datos[1, i], datos[2, i]);
            }

            return new Farmacia(/*enfermeros*/);
        }

        static Administrador CrearAdmin()
        {
            return new Administrador("417088815", "Joaquin", "Pellegrino", "Mi Casa", "pelle", "pelle1234");
        }

        static void Main(string[] args)
        {
            var hospital = new Hospital(CrearMedicos(), CrearAdmin(), new Farmacia());

            hospital.MenuHospital();
        }
    }
}
