/* 
    Autor: Jonatan Amaya
    Universidad: UNAH-VS
    Carrera: Licenciatura en Informatica Administrativa
    Hora: 18:00 - 19:00
    Catedratico: Lic. Billy Fernandez
    Clase: Lenguaje de Programacion II
*/ 
using System;

namespace propiedades
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno a = new Alumno();
            a.PrimerNombre = "Juan";
            a.SegundoNombre = "Perez";

            Alumno b = new Alumno();
            b.Id = 2;
            b.PrimerNombre = "Maria";
            b.SegundoNombre = "Martinez";

            Alumno c = new Alumno(3);
            b.PrimerNombre = "Pedro";

            Alumno d = new Alumno("Juan", "Jimenez");

            Console.WriteLine(a.Id);
            Console.WriteLine(b.Id);
            Console.WriteLine(c.Id);
            Console.WriteLine(d.PrimerNombre + " " + d.SegundoNombre);
        }
    }
}
