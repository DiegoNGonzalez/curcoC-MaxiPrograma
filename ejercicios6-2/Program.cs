/* 2. Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. Se pide determinar e informar:

El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
Informar cuántos grupos están formados por todos números ordenados de mayor a menor.
*/

int i, numero, impares=0, contadorNros=0, grupoMayorImpares=0, contadorGruposOrdenados=0,mayor=0, banderaMayor=0, noOrdenado=0, menor=0, banderaMenor=0;
float porcentaje, porcentajeMax=0;

for(i=0; i<3;i++){
    bool ordenado = false;

    Console.WriteLine("Ingrese un numero");
    numero = int.Parse(Console.ReadLine());
    while(numero!= 0){
        contadorNros++;
        if(numero % 2 != 0){
            impares++;
        }

        if(banderaMayor==0 && banderaMenor==0){
            mayor = numero;
            menor = numero;
            banderaMayor = 1;
        }else if(numero > mayor){
            noOrdenado++;
        }else if(numero < menor){
            ordenado = true;
        }else{
            ordenado = false;
        }

        Console.WriteLine("Ingrese un numero");
        numero = int.Parse(Console.ReadLine());
    }
    if(noOrdenado>0){
        ordenado = false;
    }else if(ordenado == true){
        contadorGruposOrdenados++;
    }
    porcentaje = ((float)impares * 100) / contadorNros;
    if(porcentajeMax == 0){
        porcentajeMax=porcentaje;
        grupoMayorImpares = i+1;
    }else if(porcentaje > porcentajeMax){
        porcentajeMax = porcentaje;
        grupoMayorImpares = i+1;
    }
    impares = 0;
    contadorNros = 0;
    noOrdenado = 0;
    banderaMayor = 0;
    banderaMenor = 0;
}
Console.WriteLine("El grupo con mayor porcentaje de numeros impares es: " + grupoMayorImpares);
Console.WriteLine("La cantidad de grupos ordenados es: " + contadorGruposOrdenados);