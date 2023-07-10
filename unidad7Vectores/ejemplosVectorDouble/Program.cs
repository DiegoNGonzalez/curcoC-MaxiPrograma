// See https://aka.ms/new-console-template for more information
//vecores double


double[] muestraMatutina= new double[31];
double[] muestraVespertina= new double[31];
double[] muestraNocturna= new double[31];

int i;

for (i=0;i<31;i++)
{
    Console.WriteLine("Ingrese la muestra matutina del dia #",i+1);
    muestraMatutina[i]=double.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese la muestra vespertina del dia #",i+1);
    muestraVespertina[i]=double.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese la muestra nocturna del dia #",i+1);
    muestraNocturna[i]=double.Parse(Console.ReadLine());
}