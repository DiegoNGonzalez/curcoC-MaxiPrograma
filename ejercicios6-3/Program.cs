//  Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero. El fin de la carga se notifica con un número negativo. Luego mostrar cuántos números tiene cada lista.

int numero, contadorLista=0, contadorNumeros=0;

Console.WriteLine("Ingrese un numero");
numero = int.Parse(Console.ReadLine());
while(numero >= 0){
    while(numero != 0){
        contadorNumeros++;
        Console.WriteLine("Ingrese un numero");
        numero = int.Parse(Console.ReadLine());
    }
    contadorLista++;
    Console.WriteLine("La cantidad de numeros de la lista #" + contadorLista + " es: " + contadorNumeros);
    contadorNumeros = 0;
    Console.WriteLine("Ingrese un numero");
    numero = int.Parse(Console.ReadLine());
}
