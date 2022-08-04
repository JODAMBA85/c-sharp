using System;
public class Mono: Mamifero
{
    public bool Maullar { get; set; }

    public Mono() // Polimorfismo
    {
        Maullar = true;
    }

    public Mono(bool maullar) // Polimorfismo
    {
        Maullar = maullar;
    }
    public void Uuuuuh()
    {
        Console.WriteLine("Gritos territoriales y para apareamiento");

    }

}