/* 
    Autor: Jonatan Amaya
    Universidad: UNAH-VS
    Carrera: Licenciatura en Informatica Administrativa
    Hora: 18:00 - 19:00
    Catedratico: Lic. Billy Fernandez
    Clase: Lenguaje de Programacion II
*/ 

using System;

namespace funciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno a = new Alumno(1, "Juan", "Perez");
            Alumno b = new Alumno(2, "Maria", "Martinez");

            a.inactivarAlumno();

            Console.WriteLine(a.nombreCompleto());
            Console.WriteLine(b.nombreCompleto());

            a.activarAlumno();

            Console.WriteLine("");

            Console.WriteLine(a.nombreCompleto());
            Console.WriteLine(b.nombreCompleto());
        }
    }
}
