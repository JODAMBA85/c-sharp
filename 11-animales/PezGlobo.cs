using System;

public class PezGlobo: peces
{
    public string venenoso { get; set; }

    public void Inflarse()
    {
        Console.WriteLine("Por medio de proteccion se infla y tiene veneno muy venenoso");
    }

}