public class Producto
{
    public int Codigo { get; set; }
    public string Descripcion { get; set; }
    public double Precio { get; set; }


    public Producto(string descripcion, double precio)
    {
        Descripcion = descripcion;
        Precio = precio;
    }
}