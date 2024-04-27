using System.Collections.Generic;
using System;
using BLL.Utilidades;

namespace BLL.OperacionesMatematicas
{
    public class Multiplicacion
    {
        public string OperatioMultiplicar()
        {            
            Console.WriteLine(string.Format(Constantes.Message.quantyDigit, Constantes.Message.multiplicar));
            var multi = Console.ReadLine();
            int valueMulti = 0;

            if (!int.TryParse(multi, out valueMulti))
            {
                Console.WriteLine(Constantes.Message.optionNumeric);
                OperatioMultiplicar();
            }

            Console.WriteLine(string.Format(Constantes.Message.digitNumeric, Constantes.Message.multiplicar));
            Console.WriteLine();
            List<double> list = new List<double>();

            for (int i = 1; i <= valueMulti; i++)
            {
                Console.WriteLine("Numero: " + i);
                var numMulti = Console.ReadLine();
                double valueNumMulti = 0;

                if (!double.TryParse(numMulti, out valueNumMulti))
                {
                    Console.WriteLine(Constantes.Message.optionNumeric);
                    valueNumMulti = CorrectionNumeric.CorrecionNum();
                }
                list.Add(valueNumMulti);
                Console.WriteLine();
            }
            double multiFinal = 1;

            foreach (int num in list)
            {
                multiFinal *= num;
            }

            return string.Format(Constantes.Message.resultfinal, "Multiplicaion") + multiFinal;
        }
      
    }
}
