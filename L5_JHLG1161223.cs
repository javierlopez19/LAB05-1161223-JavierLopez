class Class
{
    static void Main()
    {
        Console.WriteLine("Ingrese el ID de usuario:");
        int id = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el PIN: ");
        int pin = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el Token: ");
        int token = int.Parse(Console.ReadLine());

        if ( id == 2026)
        { Console.WriteLine("Usuario reconocido"); }
        else { Console.WriteLine("usuario no reconocido"); }
        if ( pin == 1234)
        { Console.WriteLine("PIN correcto"); }
        else { Console.WriteLine("PIN incorrecto"); }
        if (token == 777)
        { Console.WriteLine("Token válido"); }
        else { Console.WriteLine("inválido"); } 



    }
}



