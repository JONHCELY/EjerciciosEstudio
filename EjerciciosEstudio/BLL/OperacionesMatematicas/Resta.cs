using System.Collections.Generic;
using System;
using BLL.Utilidades;

namespace BLL.OperacionesMatematicas
{
    public class Resta
    {
        public string OperatioResta()
        {
            Console.WriteLine(string.Format(Constantes.Message.quantyDigit, Constantes.Message.restar));
            var resta = Console.ReadLine();
            int valueResta = 0;

            if (!int.TryParse(resta, out valueResta))
            {
                Console.WriteLine(Constantes.Message.optionNumeric);
                OperatioResta();
            }

            Console.WriteLine(string.Format(Constantes.Message.digitNumeric, Constantes.Message.restar));
            Console.WriteLine();
            List<double> list = new List<double>();

            for (int i = 1; i <= valueResta; i++)
            {
                Console.WriteLine("Numero: " + i);
                var numResta = Console.ReadLine();
                double valueNumResta = 0;

                if (!double.TryParse(numResta, out valueNumResta))
                {
                    Console.WriteLine(Constantes.Message.optionNumeric);
                    valueNumResta = CorrectionNumeric.CorrecionNum();
                }
                list.Add(valueNumResta);
                Console.WriteLine();
            }
            double restaFinal = 0;
            foreach (var item in list)
            {
                restaFinal = restaFinal - item;
            }

            return string.Format(Constantes.Message.resultfinal, "Resta") + restaFinal;
        }
    }
}
