/* 
    Autor: Jonatan Amaya
    Universidad: UNAH-VS
    Carrera: Licenciatura en Informatica Administrativa
    Hora: 18:00 - 19:00
    Catedratico: Lic. Billy Fernandez
    Clase: Lenguaje de Programacion II
    
*/ 

using QuienQuiereSerMillonario.Clases;

Console.ForegroundColor = ConsoleColor.Green;
Console.Title = "ASCII Art";
            string titulo = @"
   _     ____        _               ____        _                  _____             __  __ _ _ _                        _          _  
  | |   / __ \      (_)             / __ \      (_)                / ____|           |  \/  (_) | |                      (_)        | | 
 / __) | |  | |_   _ _  ___ _ __   | |  | |_   _ _  ___ _ __ ___  | (___   ___ _ __  | \  / |_| | | ___  _ __   __ _ _ __ _  ___   / __)
 \__ \ | |  | | | | | |/ _ \ '_ \  | |  | | | | | |/ _ \ '__/ _ \  \___ \ / _ \ '__| | |\/| | | | |/ _ \| '_ \ / _` | '__| |/ _ \  \__ \
 (   / | |__| | |_| | |  __/ | | | | |__| | |_| | |  __/ | |  __/  ____) |  __/ |    | |  | | | | | (_) | | | | (_| | |  | | (_) | (   /
  |_|   \___\_\\__,_|_|\___|_| |_|  \___\_\\__,_|_|\___|_|  \___| |_____/ \___|_|    |_|  |_|_|_|_|\___/|_| |_|\__,_|_|  |_|\___/   |_|                                                                                                                                    
  ";
Console.WriteLine(titulo);
Console.ForegroundColor = ConsoleColor.White;

Console.Write("Ingrese Su Nombre: ");
string? nombreparticipante = String.Empty;
nombreparticipante = Console.ReadLine();


Juego jugador = new Juego(nombreparticipante);
jugador.ImprimirBienvenida();

Categoria categorias = new Categoria();

var listaCategorias = categorias.CrearCategoriasPreguntas();

foreach(var categoria in listaCategorias)
{
    jugador.NivelActual++;

    Console.ForegroundColor = ConsoleColor.Green;
    categoria.ImprimirCategoria();
    Console.ForegroundColor = ConsoleColor.White;
    
    var continuar = categoria.MostrarPregunta(jugador);

    if (continuar)
    {
        jugador.PremioAcumulado = categoria.ValorPremio;

        Console.ForegroundColor = ConsoleColor.Green;
        jugador.ImprimirAcumualdo();
        Console.ForegroundColor = ConsoleColor.White;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(nombreparticipante);
        Console.WriteLine("Lo siento respuesta incorrecta, el juego ha terminado.");

        Console.Title = "ASCII Art";
        string perdio = @"
             _____             _ _       
            |  __ \           | (_)      
            | |__) |__ _ __ __| |_  ___  
            |  ___/ _ \ '__/ _` | |/ _ \ 
            | |  |  __/ | | (_| | | (_) |
            |_|   \___|_|  \__,_|_|\___/ 
        ";
        Console.WriteLine(perdio);

        Console.ForegroundColor = ConsoleColor.White;

        Console.ForegroundColor = ConsoleColor.Green;
        jugador.ImprimirAcumualdo();
        Console.ForegroundColor = ConsoleColor.White;

        break;
    }
}

if (jugador.NivelActual == 12)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(nombreparticipante);
    Console.WriteLine("Felicidades eres un millonario");

    Console.Title = "ASCII Art";
        string gano = @"
          _____                   
         / ____|                  
        | |  __  __ _ _ __   ___  
        | | |_ |/ _` | '_ \ / _ \ 
        | |__| | (_| | | | | (_) |
         \_____|\__,_|_| |_|\___/           
        ";
    Console.WriteLine(gano);

    jugador.ImprimirAcumualdo();
    Console.ForegroundColor = ConsoleColor.White;
}

Console.WriteLine("El juego ha terminado");

