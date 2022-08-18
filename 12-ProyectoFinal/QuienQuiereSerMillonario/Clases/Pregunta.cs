using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuienQuiereSerMillonario.Clases
{
    public class Pregunta
    {
        public int Id { get; set; }
        public string Texto { get; set; }
        public List<Respuesta> Respuestas { get; set; }

        public void ImprimirPregunta(Juego jugador)
        {
            Console.WriteLine(Texto);
            foreach(var respuesta in Respuestas)
            {
                respuesta.ImprimirRespuesta();
            }
            if (jugador.ComodinesUtilizados < 3)
                Console.WriteLine("5. Utilizar comodin");
            Console.Write("\nFavor seleccione una respuesta:");
        }

        public bool ValidarRespuesta(int resp)
        {
            foreach(var respuesta in Respuestas)
            {
                if (respuesta.EsCorrecto && respuesta.Id == resp)
                    return true;
            }
            return false;
        }

        public void UtilizarComodin(string comodin)
        {
            if(comodin=="llamada" || comodin=="publico") //muestro la respuesta correcta
            {
                foreach(var respuesta in Respuestas)
                {
                    if (respuesta.EsCorrecto)
                    {
                        respuesta.ImprimirRespuesta();
                        Console.Write("\nFavor seleccione una respuesta:");
                        break;
                    }

                }
            }
            else
            {
                int respuestasIncorrecta = 0;
                foreach(var respuesta in Respuestas)
                {
                    if (respuesta.EsCorrecto)
                        respuesta.ImprimirRespuesta();

                    if (respuestasIncorrecta < 1 && respuesta.EsCorrecto==false)
                    {
                        respuestasIncorrecta++;
                        respuesta.ImprimirRespuesta();
                    }                    
                }
                Console.Write("\nFavor seleccione una respuesta:");
            }
        }
       
    }
}
