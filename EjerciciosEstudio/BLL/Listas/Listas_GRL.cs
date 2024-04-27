using BLL.OperacionesMatematicas;
using BLL.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Listas
{
    public class Listas_GRL
    {
        public bool operacionesListas()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine(" Seleccione la operacion a realizar:");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("1. Mayores que el promedio");
            Console.WriteLine("2. Salir");
            Console.WriteLine();
            Console.WriteLine("Opción Seleccionada:");
            Mayor_Promedio mp = new Mayor_Promedio();

            var proces = Console.ReadLine();
            int value = 0;
            var valid = true;

            if (string.IsNullOrEmpty(proces))
            {
                Console.WriteLine("Valor inválido.");
                valid = false;
                return valid;
            }

            if (!int.TryParse(proces, out value))
            {
                Console.WriteLine(Constantes.Message.optionNumeric);
                valid = false;
                return valid;
            }

            if (value < 1 || value > 2)
            {
                Console.WriteLine(Constantes.Message.valueDisponible);
                valid = false;
                return valid;
            }

            switch (value)
            {
                case 1:
                    string mayProedio = mp.OperationPromedio();
                    Console.WriteLine(mayProedio);
                    ReinicioListas();
                    break;
                case 2:
                    break;
                default:
                    break;
            }

            return valid;
        }

        public void ReinicioListas()
        {
            Console.WriteLine();
            Console.WriteLine(Constantes.Message.startListas);
            var conti = Console.ReadLine();
            if (conti.ToUpper().Equals("S"))
            {
                operacionesListas();
            }
        }
    }
}
