using BLL.Utilidades;
using System;

namespace BLL.OperacionesMatematicas
{
    public class GRL
    {
        public static bool operacionesAritmeticas()
        {               
            Console.WriteLine("-------------------------------------");
            Console.WriteLine(" Seleccione la operacion a realizar:");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicacion");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Salir");
            Console.WriteLine();
            Console.WriteLine("Opción Seleccionada:");

            Suma suma = new Suma();
            Resta resta = new Resta();
            Multiplicacion multiplicacion = new Multiplicacion();
            Division division = new Division();
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

            if (value < 1 || value > 5)
            {
                Console.WriteLine(Constantes.Message.valueDisponible);
                valid = false;
                return valid;
            }

            switch (value)
            {
                case 1:
                    var sum = suma.OperatioSuma();
                    Console.WriteLine(sum);
                    ReinicioAritmetico();
                    break;
                case 2:
                    var res = resta.OperatioResta();
                    Console.WriteLine(res);
                    ReinicioAritmetico();
                    break;
                case 3:
                    var mul = multiplicacion.OperatioMultiplicar();
                    Console.WriteLine(mul);
                    ReinicioAritmetico();
                    break;
                case 4:
                    var div = division.operationDivision();
                    Console.WriteLine(div);
                    ReinicioAritmetico();
                    break;
                case 5:                    
                    break;
                default:
                    break;
            }

            return valid;
        }

        public static void ReinicioAritmetico()
        {
            Console.WriteLine();
            Console.WriteLine(Constantes.Message.startAritmetica);
            var conti = Console.ReadLine();
            if (conti.ToUpper().Equals("S"))
            {
                operacionesAritmeticas();
            }
        }
    }
}
