using System;

namespace animales
{
    class Program
    {
        static void Main(string[] args)
        {
            Perro m = new Perro();
            Console.WriteLine("Perro");
            m.Nombre = "MAX";
            m.Patas = 4;
            m.Raza = "Terranova";
            m.Comer();
            m.Caminar();
            m.Ladrar();
            m.EsFurioso = true;

            Console.WriteLine(m.Nombre);
            Console.WriteLine(m.Patas);
            Console.WriteLine(m.Raza);         

            Console.WriteLine();

            Gato l = new Gato();
            Console.WriteLine("Gato");
            l.Nombre = "zimba";
            l.Patas = 4;
            l.Raza = "Maine Coon";
            l.Comer();
            l.Caminar();
            l.Maullar();
            l.Ronronea = true;

            Console.WriteLine(l.Nombre);
            Console.WriteLine(l.Patas);
            Console.WriteLine(l.Raza);         

            Console.WriteLine();

            Mono v = new Mono();
            Console.WriteLine("Mono");
            v.Nombre = "Monqui";
            v.Patas = 4;
            v.Comer();
            v.Maullar = true;
            v.Caminar();

            Console.WriteLine(v.Nombre);
            Console.WriteLine(v.Patas);

            Console.WriteLine();

            Loro c = new Loro();
            Console.WriteLine("Loro");
            c.Nombre = "Loli";
            c.Patas = 2;
            c.ColorPlumaje = "Plumas verdes, plumas rojas y amarillas";
            c.Volar();
            c.Comer();
            c.Hablar();

            Console.WriteLine(c.Nombre);
            Console.WriteLine(c.Patas);
            Console.WriteLine(c.ColorPlumaje);

            Console.WriteLine();

            aguila P = new aguila();
            Console.WriteLine("Aguila");
            P.Nombre = "Motagua";
            P.Patas = 2;
            P.ColorPlumaje = "Negras y Blancas";
            P.Volar();
            P.Comer();
            P.VolarAlto();

            Console.WriteLine(P.Nombre);
            Console.WriteLine(P.Patas);
            Console.WriteLine(P.ColorPlumaje);

            Console.WriteLine();

            PezGlobo t = new PezGlobo();
            Console.WriteLine("PezGlobo");
            t.Nombre = "Globi";
            t.NumeroAletas = 2;
            t.Color = "Cafe con Negro";
            t.Comer();
            t.Nadar();
            t.Inflarse();
 
            Console.WriteLine(t.Nombre);
            Console.WriteLine(t.NumeroAletas);
            Console.WriteLine(t.Color);

            Console.WriteLine();

            }
        }
}