// See https://aka.ms/new-console-template for more information


// vectores arrays arreglos 

int[] vectorNumeros = new int[10]; 

int i;

for (i = 0; i < 10; i++)
{
    Console.WriteLine("Ingrese un numero");
    vectorNumeros[i] = int.Parse(Console.ReadLine());
}

for(i=0;i<10;i++)
{
    Console.WriteLine(vectorNumeros[i]);
}
