double nota = 0;
string respuesta;
double suma = 0;
double cant=0;
double promedio = 0;

// PEDIR NOTA
do
{
    Console.WriteLine("Ingrese nota");
    nota = Double.Parse(Console.ReadLine());
    Console.WriteLine("Desea ingresar otra nota? Si/No");
    respuesta = Console.ReadLine();

    // NOTA ACUMULADA
    suma = suma + nota;
    cant++;
}
while (respuesta == "S");
// salida
promedio = suma / cant;

Console.WriteLine("El promedio es de " + promedio );