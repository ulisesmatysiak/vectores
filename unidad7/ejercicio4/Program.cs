using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4. Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro con çlos siguientes datos:
            // - Número de Artículo (1 a 15)
            // - Cantidad Vendida 

            // Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
            // Se pide determinar e informar:
            // a) El número de artículo que más se vendió en total.
            // b) Los números de artículos que no registraron ventas.
            // c) Cuantas unidades se vendieron del número de artículo 10.

            int nroArticulo, cantidad;
            int [] totalCantidadvendida = new int [15];

            for (int x = 0; x < 15; x++)
            {
                // acumulador
                totalCantidadvendida [x] = 0;
            }

            Console.WriteLine("Ingrese numero de articulo");
            nroArticulo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese cantidad vendida");
            cantidad = int.Parse(Console.ReadLine());

            while (nroArticulo != 0)
            {
                totalCantidadvendida [nroArticulo - 1] += cantidad;



                Console.WriteLine("Ingrese numero de articulo");
                nroArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese cantidad vendida");
                cantidad = int.Parse(Console.ReadLine());


            }

            // punto a 

            int maxCantidad = totalCantidadvendida[0];
            int nroMaximo = 1;
            for (int x = 0; x < 15; x++)
            {
                if (totalCantidadvendida [x] > maxCantidad )
                {
                    maxCantidad = totalCantidadvendida[x];
                    nroArticulo = x + 1;
                }
            }

            Console.WriteLine("El articulo mas vendido es " + nroArticulo + " con la cantidad de " + maxCantidad );


            // punto b

            for (int x = 0; x < 15; x++)
            {
                if (totalCantidadvendida = 0)
                {
                    Console.WriteLine("El producto " + (x + 1) + " no registra ventas");
                    
                }
                
            }

            // punto c

            Console.WriteLine("La cantidad vendia del articulo 10 es " + totalCantidadvendida[9]);







        }
    }
}
