using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraficadorSeñales
{
    class SeñalParabolica
    {
        public List<Muestra> Muestras
            { get; set; }

        public SeñalParabolica()
        {
            Muestras = 
                new List<Muestra>();
        }

        public double evaluar(double tiempo)
        {
            double resultado;

            resultado = (tiempo * tiempo * tiempo) ;

            return resultado;
        }
    }
}
