// See https://aka.ms/new-console-template for more information


int prom, acu =0, n;


for (int i = 0; i < 20; i++)
{
    Console.WriteLine("Ingrese la edad: ");
    n = int.Parse(Console.ReadLine());
    acu +=n;
}
prom = acu / 20;
Console.WriteLine("El promedio de edad es: " + prom);