using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Carrera
{
    class ImprimeCarrera
    {
        public int imprimeCarrera(ref char[] ptrCL, ref char[] ptrCT, int size)
        {
            int [] movimientotortuga = { 2, 2, 2, 2, 2, 2, 1, 1, 0, 0 };
            int [] movimientoliebre = { 4, 4, 4, 4, 2, 2, 0, 0, -2, -2 };
            int i, j;
            int t = 0;
            int l = 0;

            while(t < size && l < size)
            {
                for(i = 0; i < size; i++)
                {
                    if(t == i)
                    {
                        Console.Write("T");
                    }
                    else
                    {
                        Console.Write(ptrCL[i]);
                    }
                } // fin del for
                Console.WriteLine();

                for(j = 0; j < size; j++)
                {
                    if (l == j)
                    {
                        Console.Write("L");
                        if (l != 0 && l == t)
                        {
                            Console.Write("OUCH!!!");
                        }
                    }
                    else
                    {
                        Console.Write(ptrCT[j]);
                    }
                } // fin del for
                Console.WriteLine();

                // Creamos la semilla para el ramdom
                int seed = Environment.TickCount;
                Random rm = new Random(seed);

                t += movimientotortuga[rm.Next(0, 9)];
                l += movimientoliebre[rm.Next(0, 9)];

                if (t < 1)
                    t = 1;
                if (l < 1)
                    l = 1;
                if (t > size)
                    t = size;
                if (l > size)
                    l = size;

                System.Threading.Thread.Sleep(250);
                Console.Clear();
            } // fin del while

            if (t == size && l == size)
                return 0;
            else if (t == size)
                return 1;
            else
                return 2;

        } // Fin del método imprimeCarrara
    } // Fin de la clase ImprimeCarrera
}
