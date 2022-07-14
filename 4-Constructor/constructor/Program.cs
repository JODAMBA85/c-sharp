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
