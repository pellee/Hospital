using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Medicamento
    {
        private string nombre, componentes, uso, efectosSec, precauciones;
        private int stock;

        public Medicamento() { }
        public Medicamento(string nombre, string componentes, string uso, string efectosSec, string precauciones, int stock)
        {
            this.nombre = nombre;
            this.componentes = componentes;
            this.uso = uso;
            this.efectosSec = efectosSec;
            this.precauciones = precauciones;
            this.stock = stock;
        }

        private void VerStock()
        {
            // TODO - Hacer cosas para ver el stock.
        }

        private void DescontarStock()
        {
            // TODO - Hacer cosas para descontar stock.
        }
    }
}
