// DECLARACIÓN DE UN VECTOR
double[,] NOTAS = new double[4,5];

// LLENADO
Random r = new Random();
 for ( int f = 0; f<5; f++)
 {
       for (int c = 0 ; c < 5; c++)
        {
            NOTAS [f, c] = r.Next(100);
        }
 }

 // mMOSTRAR
    for ( int f = 0; f<5; f++)
    {
           for ( int c = 0 ; c < 5; c++)
           {
                Console.WriteLine("F: " + f + " c: "+ NOTAS[f,c] + "**");
           }
    }
global::System.Object value = Console.WriteLine("\n"); 