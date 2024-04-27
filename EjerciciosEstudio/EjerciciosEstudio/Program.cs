using BLL.Figuras;
using BLL.OperacionesMatematicas;
using EjercicioTablas.Tablas;
using System;
using BLL.Utilidades;
using BLL.Listas;

namespace Ejercicios
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine(" Seleccione el Numero del servicio que desea ejecutar");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("1. Figuras de asteriscos");
            Console.WriteLine("2. Tablas de Multiplicar");
            Console.WriteLine("3. Operaciones Aritmeticas");
            Console.WriteLine("4. Listas");
            Console.WriteLine();
            Console.WriteLine("Opción Seleccionada:");

            var proces = Console.ReadLine();
            int value = 0;

            if (string.IsNullOrEmpty(proces))
            {
                Console.WriteLine("Valor inválido.");
                Reinicio();
                return;
            }

            if (!int.TryParse(proces, out value))
            {
                Console.WriteLine(Constantes.Message.optionNumeric);
                Reinicio();
                return;
            }

            if (value < 1 || value > 4)
            {
                Console.WriteLine(Constantes.Message.valueDisponible);
                Reinicio();
                return;
            }

            switch (value)
            {
                case 1:
                    var v = Asteriscos.figura1();
                    var n = v.n;
                    var f1 = v.f;
                    Asteriscos.figura2(f1, n);
                    Asteriscos.figura3(f1, n);
                    Asteriscos.figura4(f1, n);                                        
                    break;
                case 2:
                    Tablas t = new Tablas();
                    Console.WriteLine();
                    Console.WriteLine(string.Format(Constantes.Message.bienvenido, "Tablas de Multiplicar"));
                    t.tablasMhltiplicar();
                    break;
                case 3:
                    Console.WriteLine();
                    Console.WriteLine(string.Format(Constantes.Message.bienvenido, "Operaciones aritmeticas"));
                    bool validOperacionesrimeticas = true;
                    validOperacionesrimeticas = GRL.operacionesAritmeticas();
                    if (!validOperacionesrimeticas) { Reinicio(); }
                    break;
                case 4:
                    Console.WriteLine();
                    Console.WriteLine(string.Format(Constantes.Message.bienvenido, "Operaciones de Listas"));
                    Listas_GRL li = new Listas_GRL();                    
                    bool validListas = true;
                    validListas = li.operacionesListas();
                    if (!validListas) { Reinicio(); }
                    break;
                default:
                    break;
            }
            Reinicio();
        }

        public static void Reinicio()
        {
            Console.WriteLine();
            Console.WriteLine(Constantes.Message.startServices);
            var conti = Console.ReadLine();
            if (conti.ToUpper().Equals("S"))
            {
                Main(null);
            }            
        }


    }
}
