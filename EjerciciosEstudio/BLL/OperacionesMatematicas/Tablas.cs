using BLL.Utilidades;
using System;

namespace EjercicioTablas.Tablas
{
    public class Tablas
    {
        public void tablasMhltiplicar()
        {

            Console.WriteLine("Informe la Tabla de multiplicar que desea ver en pantalla");
            var tabla = Console.ReadLine();
            int valueTabla = 0;
            Console.WriteLine();
            Console.WriteLine("Tabla a mostrar " + tabla); Console.WriteLine();
            if (!int.TryParse(tabla, out valueTabla))
            {
                Console.WriteLine(Constantes.Message.optionNumeric);
                return;
            }
            Console.WriteLine("Hasta que numero quiere que se realice las operaciones:");
            var operacion = Console.ReadLine();Console.WriteLine();
            int valueOperacion = 0;            

            if (!int.TryParse(operacion, out valueOperacion))
            {
                Console.WriteLine(Constantes.Message.optionNumeric);
                return;
            }

            for (int i = 0; i <= valueOperacion; i++)
            {
                Console.WriteLine($"{tabla} x {i} = " + i * valueTabla);
            }            
        }
    }
}
