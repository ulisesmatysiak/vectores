using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
        //    2. Hacer un programa que solicite 10  números enteros y los guarde en un vector. Luego recorrer ese vector para calcular el promedio. Mostrar por pantalla los valores que son mayores al promedio.

        int [] numeros = new int [10];
        int acu = 0, prom;

        for (int x = 0; x < 10; x++)
        {
            Console.WriteLine("Ingrese un numero ");
            numeros [x] = int.Parse(Console.ReadLine());
        }

        for (int x = 0; x < 10; x++)
        {
            acu += numeros [x];
            
        }

        prom = acu / 10;

        for (int x = 0; x < 10; x++)
        {
            if (numeros [x] > prom)
            {
                Console.WriteLine( "Este elemento fue mayor al promedio " + numeros[x]);          
            }
            
        }

        

        

       

        

        }
    }
}
