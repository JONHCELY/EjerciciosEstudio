using BLL.Utilidades;
using EjercicioTablas.Tablas;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace BLL.OperacionesMatematicas
{
    public class Suma
    {
        public string OperatioSuma() 
        {
            Console.WriteLine(string.Format(Constantes.Message.quantyDigit, Constantes.Message.sumar));
            var suma = Console.ReadLine();
            int valueSuma = 0; 

            if (!int.TryParse(suma, out valueSuma))
            {
                Console.WriteLine(Constantes.Message.optionNumeric);
                OperatioSuma();                
            }

            Console.WriteLine(string.Format(Constantes.Message.digitNumeric, Constantes.Message.sumar));
            Console.WriteLine();
            List<double> list = new List<double>();
            
            for (int i = 1; i <= valueSuma; i++)
            {
                Console.WriteLine("Numero: " + i);
                var numSuma = Console.ReadLine();
                double valueNumSuma = 0; 

                if (!double.TryParse(numSuma, out valueNumSuma))
                {
                    Console.WriteLine(Constantes.Message.optionNumeric);
                    valueNumSuma = CorrectionNumeric.CorrecionNum();
                }
                list.Add(valueNumSuma);
                Console.WriteLine();                
            }
            double sumaFinal = 0;
            foreach (var item in list)
            {
                sumaFinal = sumaFinal + item;
            }

            return string.Format(Constantes.Message.resultfinal, "Suma") + sumaFinal;
        }




    }
}
