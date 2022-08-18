using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuienQuiereSerMillonario.Clases
{
    public class Juego
    {
        public string NombreParticipante { get; set; }
        public double PremioAcumulado { get; set; }
        public bool UtilizoComodinLLamada { get; set; }
        public bool UtilizoComodin5050 { get; set; }
        public bool UtilizoComodinPublico { get; set; }
        public int NivelActual { get; set; }
        public int ComodinesUtilizados { get; set; }

        public Juego(string _participante)
        {
            NombreParticipante = _participante;
            UtilizoComodinLLamada = false;
            UtilizoComodin5050 = false;
            UtilizoComodinPublico = false;
            PremioAcumulado = 0;
            NivelActual = 0;
            ComodinesUtilizados = 0;
        }

        public void ImprimirBienvenida()
        {
            Console.WriteLine("Bienvenido:" + NombreParticipante + "\n\n");            
        }

        public void ImprimirAcumualdo()
        {
            Console.WriteLine("El premio acumulado es: " + String.Format("{0:C}", PremioAcumulado) + "\n");
        }

        public string ImprimirComodines()
        {
            int noLlamada = 0;
            int noPublico = 0; 
            int no5050 = 0;
            if (ComodinesUtilizados < 3)
            {
                Console.WriteLine("");
                int i = 1;
                if(!UtilizoComodinLLamada)
                {
                    Console.WriteLine(String.Format("{0}. Utilizar Comodin Llamada", i));
                    noLlamada = i;
                    i++;
                }
                if (!UtilizoComodinPublico)
                {
                    Console.WriteLine(String.Format("{0}. Utilizar Comodin Publico", i));
                    noPublico = i;
                    i++;
                }
                if (!UtilizoComodin5050)
                {
                    Console.WriteLine(String.Format("{0}. Utilizar Comodin 5050", i));
                    no5050 = i;
                    i++;
                }
                Console.Write("Favor seleccione un comodin: ");
                var comodin = Console.ReadLine();
                if (comodin == noLlamada.ToString())
                {
                    UtilizoComodinLLamada = true;
                    ComodinesUtilizados++;
                    return "llamada";
                }
                else if (comodin == noPublico.ToString())
                {
                    UtilizoComodinPublico = true;
                    ComodinesUtilizados++;
                    return "publico";
                }
                else if (comodin == no5050.ToString())
                {
                    UtilizoComodin5050 = true;
                    ComodinesUtilizados++;
                    return "5050";
                }
            
            }
            return String.Empty;
        }
    }
}
