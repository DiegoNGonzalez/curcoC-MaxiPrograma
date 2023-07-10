//1. Hacer un programa para ingresar 10 números. El mismo debe analizar y mostrar por pantalla cuántos de esos números son primos.

int i, numero, contador=0, j, primos=0;

for (i=1; i<=10; i++)
{
    Console.WriteLine("Ingrese un numero");
    numero = int.Parse(Console.ReadLine());
    contador = 0;
    for (j=1; j<=numero; j++)
    {
        if (numero % j == 0)
        {
            contador++;
        }
    }
    if (contador == 2)
    {
        primos++;
    }
}
Console.WriteLine("La cantidad de numeros primos es: " + primos);