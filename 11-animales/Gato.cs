using System;
public class Gato: Mamifero
{
    public string Raza { get; set; }
    public bool Ronronea { get; set; }

    public Gato() // Polimorfismo
    {
        Ronronea = true;
    }

    public Gato(bool ronronea) // Polimorfismo
    {
        Ronronea = ronronea;
    }
    public void Maullar()
    {
        Console.WriteLine("Miau Miau");

    }

}