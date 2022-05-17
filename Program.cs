while (true)
{
    Console.Clear();

    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("*************************************");
    Console.WriteLine("*       Bienvenido a la             *");
    Console.WriteLine("*            clase 5                *");
    Console.WriteLine("*************************************\n");


    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("~Ingrese su nombre porfavor: ");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"~¡Hola {Console.ReadLine()}!\n");

    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("~ ¿Quieres continuar en un bucle infinito? Ingrese (~S~ o ~N~): ");
    Console.ForegroundColor = ConsoleColor.Green;
    string opcionElegida = Console.ReadLine().ToUpper();

    if (opcionElegida != "S")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(
            opcionElegida == "N" ?
            "\n~Programa finalizado correctamente\n\n" :
            "\n~Opcion no valida\n\n"
        );

        Console.ResetColor();

        break;
    }
}