using System;

public abstract class peces: Animal
{
    public int NumeroAletas { get; set; }
    public string Color { get; set; }

    public void Nadar()
    {
        Console.WriteLine("Nadando");
    }
}