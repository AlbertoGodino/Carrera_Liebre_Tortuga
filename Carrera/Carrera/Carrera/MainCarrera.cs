using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Carrera
{
    // Para definir variables constantes. Se meten todas aquí
    static class Constants
    {
        public const int TAM = 70;
    }



    class MainCarrera
    {
        static void Main(string[] args)
        {
            // Creamos la semilla para el ramdom
            int seed = Environment.TickCount;
            Random rm = new Random(seed);

            char[] carreraliebre = new char[Constants.TAM];
            char[] carreratortuga = new char[Constants.TAM];

            int final;
            int i;

            for (i = 0; i < Constants.TAM; i++)
            {
                carreraliebre[i] = '_';
                carreratortuga[i] = '_';
            }

            Console.WriteLine("BANG !!!!! ");
            Console.WriteLine("Y ARRANCAN !!!!!!!\n");

            ImprimeCarrera c = new ImprimeCarrera();

            final = c.imprimeCarrera(ref carreraliebre, ref carreratortuga, Constants.TAM);

            if (final == 1)
                Console.WriteLine("\nGANA LA TORTUGA\n");
            else if (final == 2)
                Console.WriteLine("\nGANA LA LIEBRE\n");
            else
                Console.WriteLine("\nES UN EMPATE\n");

        }
    }
}
