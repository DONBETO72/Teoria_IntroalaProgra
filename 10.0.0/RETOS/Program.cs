using System;
class program
{

    public static int Numeros()
    {
      
        int sumando1;
        int sumando2;
        int resultado0;

        Console.WriteLine("Ingrese el primer sumando: ");
        sumando1=Int32.Parse(Console.ReadLine());


        Console.WriteLine("Ingrese el segundo sumando: ");
        sumando2 = Int32.Parse(Console.ReadLine());

        resultado0 = sumando1 + sumando2;

        return resultado0;
    }
    public static int NumerosResultados(int sumando1, int sumando2)
    {
        int resultado0;
        resultado0=sumando1 + sumando2;
        return (resultado0);    
    }



    static void Main()
    {
        int resultadoreal = Numeros();
        int numeroingresado;
        Console.WriteLine("Ingrese el valor que considera que es el resultado de la suma entre los números previamente ingresados");
        numeroingresado = Int32.Parse(Console.ReadLine());




        if (numeroingresado == resultadoreal)
        {
            Console.WriteLine("Felicidades, el resultado es correcto.");

        }
    

        else 
        {
            Console.WriteLine("Intente de nuevo con otro resultado reiniciando el programa");
        }
    }

}