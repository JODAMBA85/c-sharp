using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuienQuiereSerMillonario.Clases
{
    public class Respuesta
    {
        public int Id { get; set; }
        public string Texto { get; set; }
        public bool EsCorrecto { get; set; }

        public void ImprimirRespuesta()
        {
            Console.WriteLine("{0}. {1}",Id.ToString(),Texto);
        }
    }
}
