using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Farmacia
    {
        private Enfermero enfermero;
        private Medicamento[] medicamentos;

        public Enfermero Enfermero { get => enfermero; }

        public Farmacia() { }

        public Farmacia(Medicamento[] medicamentos, Enfermero enfermero)
        {
            this.medicamentos = medicamentos;
            this.enfermero = enfermero;
        }
    
        public void VenderRemedio(Receta receta)
        {
            var remedios = new List<string>();

            foreach (var m in receta.Medicamentos) {
                foreach (var me in medicamentos) {
                    if(m == me.Nombre) {
                        if (me.HayStock())
                            me.DescontarStock();
                    }
                    else {
                        Console.WriteLine("NO HAY STOCK DE ESE MEDICAMENTO.");

                        remedios.Add(m);
                    }
                        
                }
            }

            Console.WriteLine("Los siguientes remedios los tiene que comprar en otro lado");

            foreach (var r in remedios)
                Console.WriteLine(r);
        }
    }
}
