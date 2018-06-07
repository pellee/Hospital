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

        public string Nombre { get => nombre; }
        public string Componentes { get => componentes; }
        public string Uso { get => uso; }
        public string EfectosSec { get => efectosSec; }
        public string Precauciones { get => precauciones; }

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

        public bool HayStock()
        {
            if (stock > 0)
                return true;

            return false;
        }

        public void DescontarStock()
        {
            stock --;
        }
    }
}
