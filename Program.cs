
bool continuar = true;

while (continuar)
{
    MostrarMenuPrincipal();

    string opt = Console.ReadLine();

    switch (opt)
    {
        case "1":
            SumarNumeros();
            break;

        case "2":
            RestarNumeros();
            break;

        case "3":
            MultiplicarNumeros();
            break;

        case "4":
            DividirNumeros();
            break;

        case "5":
            Console.WriteLine("Finalizando proceso...");
            continuar = false;
            break;

        default:
            Console.WriteLine("Opcion no valida, intente nuevamente.");
            break;
    }

    Console.WriteLine("\nPresione cualquier tecla para finalizar...");
    Console.ReadKey();

}

void MostrarMenuPrincipal()
{
    Console.Clear();
    Console.WriteLine("==== Calculadora ====");
    Console.WriteLine("1. Sumar 2 numeros");
    Console.WriteLine("2. Restar 2 numeros");
    Console.WriteLine("3. Multiplicar 2 numeros");
    Console.WriteLine("4. Dividir 2 numeros");
    Console.WriteLine("5. Salir");
    Console.Write("\nSeleccione una opcion: ");
}

void SumarNumeros()
{
    //Se escribe en consola el titulo
    Console.WriteLine("=== Sumatoria de Numeros ===");

    //Pedimos valores al usuario
    Console.Write("Ingrese un numero: ");
    var entrada1 = Console.ReadLine(); // Captura como un String

    //Pedimos otro valor al usuario
    Console.Write("Ingrese otro numero: ");
    var entrada2 = Console.ReadLine();

    if (double.TryParse(entrada1, out double n1) && double.TryParse(entrada2, out double n2))
    {
        var suma = n1 + n2;
        Console.WriteLine($"La Suma final es = {suma}");
    }
    else
    {
        Console.WriteLine("Hubo un error en la suma, verifique que valores ingreso.");
    }
}

void RestarNumeros()
{     //Se escribe en consola el titulo
    Console.WriteLine("=== Resta de Numeros ===");
    //Pedimos valores al usuario
    Console.Write("Ingrese un numero: ");
    var numero1 = Console.ReadLine();

    //Pedimos otro valor al usuario
    Console.Write("Ingrese otro numero: ");
    var numero2 = Console.ReadLine();
    if (double.TryParse(numero1, out double n3) && double.TryParse(numero2, out double n4))
    {
        var resta = n3 - n4;
        Console.WriteLine($"La Resta final es = {resta}");
    }
    else
    {
        Console.WriteLine("Hubo un error en la resta, verifique que valores ingreso.");
    }
}

void MultiplicarNumeros()
{
    Console.WriteLine("=== Resta de Numeros ===");
    //Pedimos valores al usuario
    Console.Write("Ingrese un numero: ");
    var numero3 = Console.ReadLine();

    //Pedimos otro valor al usuario
    Console.Write("Ingrese otro numero: ");
    var numero4 = Console.ReadLine();
    if (double.TryParse(numero3, out double n5) && double.TryParse(numero4, out double n6))
    {
        var multi = n5 * n6;
        Console.WriteLine($"La Multiplicacion final es = {multi}");
    }
    else
    {
        Console.WriteLine("Hubo un error en la multiplicacion, verifique que valores ingreso.");
    }
}

void DividirNumeros()
{
    Console.WriteLine("=== Resta de Numeros ===");
    //Pedimos valores al usuario
    Console.Write("Ingrese un numero: ");
    var numero5 = Console.ReadLine();

    //Pedimos otro valor al usuario
    Console.Write("Ingrese otro numero: ");
    var numero6 = Console.ReadLine();
    if (double.TryParse(numero5, out double n7) && double.TryParse(numero6, out double n8))
    {
        var div = n7 / n8;
        Console.WriteLine($"La Division final es = {div}");
    }
    else
    {
        Console.WriteLine("Hubo un error en la division, verifique que valores ingreso.");
    }
}







