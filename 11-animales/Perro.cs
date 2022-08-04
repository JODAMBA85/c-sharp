using System;
public class Perro: Mamifero
{
    public string Raza { get; set; }
    public bool EsFurioso { get; set; }

    public Perro() // Polimorfismo
    {
        EsFurioso = true;
    }

    public Perro(bool esFurioso) // Polimorfismo
    {
        EsFurioso = esFurioso;
    }
    public void Ladrar()
    {
        Console.WriteLine("aqui le agregas tu lo que quieras");

    }

}