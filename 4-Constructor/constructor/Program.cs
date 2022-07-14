/* 
    Autor: Jonatan Amaya
    Universidad: UNAH-VS
    Carrera: Licenciatura en Informatica Administrativa
    Hora: 18:00 - 19:00
    Catedratico: Lic. Billy Fernandez
    Clase: Lenguaje de Programacion II
*/ 

using System;

namespace constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Producto producto1 = new Producto("Mouse", 200);
            Producto producto2 = new Producto("Teclado", 300);
            Producto producto3 = new Producto("Laptop", 10000);

            Console.WriteLine(producto2.Descripcion + " " + producto2.Precio.ToString());
        }
    }
}
