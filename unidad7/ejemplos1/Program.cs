using System;

namespace ejemplos
{
    class Program
    {
        static void Main(string[] args)
        {
            // VECTORES ( array / arreglo )

            // int a;
            // int [] numeros = new int [10];

            //  0 1 2 3 4 5 6 7 8 9 
            // |7| | | | |1| | | | |


            // numeros [6] = 1
            // numeros [0] = 7
            // variable [indice] = asignacion
            // a = numeros [0] + numeros {6}

            int n;
            int [] numeros = new int [10];

            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese  la nota.. ");
                n = int.Parse(Console.ReadLine());
                numeros[x] = n ;
                
            }

            int acu = 0;

            for (int x = 0; x < 10; x++)
            {
                acu += numeros[x];
            }

            int prom = acu / 10;

            Console.WriteLine ("El promedio de las notas es " + prom);


        }
    }
}
