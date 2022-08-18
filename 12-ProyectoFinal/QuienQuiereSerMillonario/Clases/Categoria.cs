using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuienQuiereSerMillonario.Clases
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public double ValorPremio { get; set; }
        public List<Pregunta> Preguntas { get; set; }

        public void ImprimirCategoria()
        {
            Console.WriteLine("Comenzamos jugando {0}", Descripcion);
        }

        public bool MostrarPregunta(Juego jugador)
        {
            var rand = new Random();
            var noPregunta = rand.Next(1, 8);
            var pregunta = this.Preguntas[noPregunta];
            pregunta.ImprimirPregunta(jugador);                       
            var resp = Console.ReadLine();
            if (resp == "5")
            {
                var comodin = jugador.ImprimirComodines();
                pregunta.UtilizarComodin(comodin);
                resp = Console.ReadLine();
            }
                

            return pregunta.ValidarRespuesta(Convert.ToInt32(resp));
        }

        public List<Categoria> CrearCategoriasPreguntas()
        {
            string archivo = File.ReadAllText("C:\\preguntas.json");
            return JsonConvert.DeserializeObject<List<Categoria>>(archivo);            
        }

        
    }
}
