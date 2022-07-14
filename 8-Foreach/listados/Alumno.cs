public class Alumno
{
    public int Id { get; set; }
    public string Nombre { get; set; }

    public Alumno(int id, string nombre)
    {
        Id = id;
        Nombre = nombre;
    }
}