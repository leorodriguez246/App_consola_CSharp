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

Console.WriteLine("\nPresione cualquier tecla para finalizar...");
Console.ReadKey();






