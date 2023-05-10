using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baterias_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int lineaP, fallados=0, correctos=0, totalBatNoF, mayorErrorB, totalBatF, cantLineasP=0, cantBaterias=0, baterias, numBat;
            double voltajeN, voltajeEsp, errorV,mayorE;

            mayorErrorB = 0;
            mayorE = 0;
            totalBatNoF = 0;
            totalBatF = 0;
            baterias = 0;

            Console.WriteLine("Ingrese linea de produccion: ");
            lineaP = Convert.ToInt32(Console.ReadLine());


            while (lineaP > 0)
            {
                cantLineasP++;

                Console.WriteLine("Ingrese cantidad de baterias de la linea: ");
                cantBaterias = Convert.ToInt32(Console.ReadLine());
                baterias = baterias + cantBaterias;

                for (int i = 1; i < cantBaterias; i++)
                {
                    Console.WriteLine("Ingrese voltaje nominal de la bateria: ");
                    voltajeN = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Ingrese numero de identificacion de la bateria: ");
                    numBat = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese el voltaje esperado de la bateria: ");
                    voltajeEsp = Convert.ToDouble(Console.ReadLine());
                    errorV = voltajeEsp - voltajeN;
                    if (voltajeN == voltajeEsp)
                    {
                        correctos++;
                        totalBatNoF = totalBatNoF + correctos;
                    }
                    else if (voltajeN < voltajeEsp)
                    {
                        fallados++;
                        totalBatF = totalBatF + fallados;
                        mayorErrorB = numBat;
                    }

                    if (errorV > mayorE)
                    {
                        mayorE = errorV;
                    }
                }
                Console.WriteLine("Ingrese otra linea de produccion o 0 para terminar: ");
                lineaP = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("lineas de produccion: "+cantLineasP);
            Console.WriteLine("Cantidad de baterias: "+baterias);
            Console.WriteLine("total de baterias no falladas: {0}", totalBatNoF);
            Console.WriteLine("total de baterias falladas: {0}", totalBatF);
            Console.WriteLine("mayor error: "+ mayorE);
            Console.ReadKey();
        }
    }
}
