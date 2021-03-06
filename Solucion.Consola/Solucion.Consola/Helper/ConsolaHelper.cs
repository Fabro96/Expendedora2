﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.Consola
{
    public static class ConsolaHelper
    {
        public static int OpcionMenu(int min, int max, string msj)
        {
            int res;
            Console.WriteLine(msj);
            do
            {
                if (!int.TryParse(Console.ReadLine(), out res))
                {
                    Console.WriteLine("\nIngrese una opción válida por favor.\n" +
                        "Recuerde que tiene que ser un número entre " + min + " y " + max + ".");
                    res = -1;
                }
            } while (res < min || res > max);
            return res;
        }
    }
}
