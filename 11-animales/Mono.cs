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
        Console.WriteLine("no se como maullan los monos por eso pongo uuh");

    }

}