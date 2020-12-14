using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurbujaAlgoritmo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arreglo = new int[10];
            int apuntador1 = 0;
            int apuntador2 = 1;
            int auxiliar = 0;
            int vueltas = 0;




            do
            {
                Console.WriteLine("Dime el numero #{0} que deseas ordenar", apuntador2);

                arreglo[apuntador1] = Convert.ToInt32(Console.ReadLine());


                apuntador1 = apuntador1 + 1;
                apuntador2 = apuntador2 + 1;
                if (apuntador1 >= 10)
                {
                    break;
                }
            } while (true);
            apuntador1 = 0;
            apuntador2 = 1;

            do
            {
                Console.Write("[{0}]", arreglo[apuntador1]);
                apuntador1 += apuntador2;
                if (apuntador1 >= 10)
                {
                    apuntador1 = 0;
                    break;
                }
            } while (true);
            do
            {
                if (vueltas >= 10)
                {
                    break;
                }
                do
                {
                    if (apuntador2 >= 10)
                    {

                        apuntador2 = 1;
                        apuntador1 = 0;
                        break;
                    }

                    if (arreglo[apuntador1] > arreglo[apuntador2])
                    {

                        auxiliar = arreglo[apuntador1];
                        arreglo[apuntador1] = arreglo[apuntador2];
                        arreglo[apuntador2] = auxiliar;

                        apuntador1 = apuntador1 + 1;
                        apuntador2 = apuntador2 + 1;
                    }
                    apuntador1 = apuntador1 + 1;
                    apuntador2 = apuntador2 + 1;



                } while (true);
                vueltas = vueltas + 1;
                apuntador1 = 0;
                apuntador2 = 1;
            } while (true);
            apuntador1 = 0;
            Console.Write(" ===> ");
            do
            {
                Console.Write("[{0}]", arreglo[apuntador1]);
                apuntador1 += apuntador2;
                if (apuntador1 >= 10)
                {
                    apuntador1 = 0;
                    break;
                }
            } while (true);
            Console.WriteLine("");
        }
    }
}
