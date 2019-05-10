using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E15_DivisiblesEntre2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;
            int[] arreglo = null;
            string opcion;

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                arreglo = rellenarConEnterosAleatorios(10, 10, 50);

                if(arreglo!=null)
                {
                    Console.WriteLine("Estos son los elementeos del arreglo:");
                    foreach (int v in arreglo)
                        Console.WriteLine(" [{0}] ", v);

                    Console.WriteLine("\n{0} son divisibles entre 2", ContarDivisiblesEntre2(arreglo));

                    var resultado = arreglo.Where(v => v % 2 == 0).Count();
                    Console.WriteLine("Resultado con LINQ: {0}", resultado);

                }
                else
                {
                    Console.WriteLine("Error, arreglo nulo");
                }

                do
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("n : nuevo, s : salir");
                    opcion = Console.ReadLine();

                    if (opcion.Equals("s"))
                    {
                        salir = true;
                        break;
                    }
                    else if (!opcion.Equals("n"))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("No se reconoce opción...");
                    }
                    else
                        break;
                } while (true);
            } while (!salir);
        }

        public static int ContarDivisiblesEntre2(int[] array)
        {
            int contador = 0;
            if( array != null )
                foreach (int v in array)
                    if (v % 2 == 0)
                        contador++; 

            return contador;
        }

        public static int[] rellenarConEnterosAleatorios(int size, int min, int max)
        {
            Random random = new Random();
            int[] resultado = null;
            if (size > 0 && min < max )
            {
                resultado = new int[size];
                for (int i = 0; i < resultado.Length; i++)
                    resultado[i] = random.Next(min, max);
            }
                
            return resultado;
        }
    }
}
