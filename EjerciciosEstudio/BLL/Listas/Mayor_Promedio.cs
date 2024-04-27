using BLL.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Listas
{
    public class Mayor_Promedio
    {
        public string OperationPromedio()
        {
            Console.WriteLine(string.Format(Constantes.Message.quantyDigit, Constantes.Message.verify));
            var promedio = Console.ReadLine();
            int valuePromedio = 0;

            if (!int.TryParse(promedio, out valuePromedio))
            {
                Console.WriteLine(Constantes.Message.optionNumeric);
                OperationPromedio();
            }

            Console.WriteLine(string.Format(Constantes.Message.digitNumeric, Constantes.Message.verify));
            Console.WriteLine();
            List<double> list = new List<double>();

            for (int i = 1; i <= valuePromedio; i++)
            {
                Console.WriteLine("Numero: " + i);
                var numpromedio = Console.ReadLine();
                double valueNumPromedio = 0;

                if (!double.TryParse(numpromedio, out valueNumPromedio))
                {
                    Console.WriteLine(Constantes.Message.optionNumeric);
                    valueNumPromedio = CorrectionNumeric.CorrecionNum();
                }
                list.Add(valueNumPromedio);
                Console.WriteLine();
            }
            double sumaFinal = 0;
            double promedioFinal = 0;
            int contFinal = 0;
            foreach (var item in list)
            {
                sumaFinal = sumaFinal + item;
            }
            promedioFinal = sumaFinal / valuePromedio;

            foreach (var itemFinal in list)
            {
                if (itemFinal > promedioFinal)
                {
                    contFinal += 1;
                }
            }

            return string.Format(Constantes.Message.resultfinal, "cantidad de datos mayores al promedio") +  contFinal ;
        }
    }
}
