    class program
    {

        static void Main()
        {
            // ingreso de datos
            int[] nivel = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(" Ingrese la cantidad de personas en el nivel " + (i +1)  +" :" );
                nivel[i] = int.Parse(Console.ReadLine());   
            }
            // ESPACIO
            Console.WriteLine("");
        
            // reporte de datos
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("En el nivel "+ ( i +1)+ " hay un total de " + nivel[i] + " personas.");
            }

            // ESPACIO
            Console.WriteLine("");

            // COMPARACIÓN//


           if (nivel[0]< nivel[1] && nivel[0]< nivel[2] && nivel[0] < nivel[3] && nivel[0] < nivel[4])
           {
                Console.WriteLine("El nivel con menos personas es el primer nivel. ");
           }

            if (nivel[1] < nivel[0] && nivel[1] < nivel[2] && nivel[1] < nivel[3] && nivel[1] < nivel[4])
            {
                Console.WriteLine("El nivel con menos personas es el segundo nivel.");
            }

            if (nivel[2] < nivel[0] && nivel[2] < nivel[1] && nivel[2] < nivel[3] && nivel[2] < nivel[4])
            {
                Console.WriteLine("El nivel con menos personas es el tercer nivel.");
            }

            if (nivel[3] < nivel[0] && nivel[3] < nivel[1] && nivel[3] < nivel[2] && nivel[3] < nivel[4])
            {
                Console.WriteLine("El nivel con menos personas es el cuarto nivel.");
            }

            if (nivel[4] < nivel[0] && nivel[4] < nivel[1] && nivel[4] < nivel[2] && nivel[4] < nivel[3])
            {
                Console.WriteLine("El nivel con menos personas es el quinto nivel.");
            }
        }
    }