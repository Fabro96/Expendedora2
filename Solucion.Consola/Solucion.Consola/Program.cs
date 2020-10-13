using System;
using Solucion.LibreriaNegocio;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Expendedora exp = new Expendedora();

            Console.WriteLine("Bienvenido a la Expendedora!");
            Console.WriteLine("\nIngrese una tecla para pasar al Menú de Usuario.");
            Console.ReadKey();
            Console.Clear();

            bool continuarActivo = true;

            do
            {
                Console.Clear();
                Console.WriteLine("MENÚ DE USUARIO");
                Console.WriteLine("\n 0 - ENCENDER MÁQUINA" +
                                  "\n 1 - LATAS DISPONIBLES" +
                                  "\n 2 - INGRESAR LATA" +
                                  "\n 3 - EXTRAER LATA" +
                                  "\n 4 - OBTENER BALANCE" +
                                  "\n 5 - MOSTRAR STOCK" +
                                  "\n 6 - EXIT");

                try
                {
                    int opcion = ConsolaHelper.OpcionMenu(0, 6, "\nIndique la opción a la que desee ingresar: ");
                    Console.Clear();

                    switch (opcion)
                    {
                        case 0:
                            exp.EncenderMaquina();
                            break;
                        case 1:
                            //LISTAR LATAS
                            break;
                        case 2:
                            IngresarLata(exp);
                            break;
                        case 3:
                            ExtraerLata(exp);
                            break;
                        case 4:
                            ObtenerBalance(exp);
                            break;
                        case 5:
                            MostrarStock(exp);
                            break;
                        case 6:
                            Exit();
                            continuarActivo = false;
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\nLo sentimos, ha ocurrido un error en el sistema. " + ex.Message);
                    Console.WriteLine("\nIngrese una tecla para continuar.");
                    Console.ReadKey();
                    Console.Clear();
                }

            } while (continuarActivo is true);

        }
        public static void IngresarLata(Expendedora exp)
        {
            throw new NotImplementedException();
        }
        public static void ExtraerLata(Expendedora exp)
        {
            throw new NotImplementedException();
        }
        public static void ObtenerBalance(Expendedora exp)
        {
            throw new NotImplementedException();
        }
        public static void MostrarStock(Expendedora exp)
        {
            throw new NotImplementedException();
        }
        public static void Exit()
        {
            Console.WriteLine("Gracias por haber usado nuestro sistema! Nos vemos la próxima!");
            Console.WriteLine("\nIngrese una tecla para continuar.");
            Console.ReadKey();
            Console.Clear();
        }

    }
}
