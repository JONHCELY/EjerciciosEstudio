using BLL.Utilidades;
using System;

namespace BLL.OperacionesMatematicas
{
    public class Division
    {
        public string operationDivision() 
        {
            Console.WriteLine(string.Format(Constantes.Message.dividendoOperation, Constantes.Message.dividir));
            var dividendo = Console.ReadLine();
            int valueDividendo = 0;
            var residuo = 0;
            var cociente = 0;

            if (!int.TryParse(dividendo, out valueDividendo))
            {
                Console.WriteLine(Constantes.Message.optionNumeric);
                operationDivision();
            }
            Console.WriteLine(Constantes.Message.divisorOperation);
            var divisor = Console.ReadLine();
            int valuedivisor = 0;

            if (!int.TryParse(divisor, out valuedivisor))
            {
                Console.WriteLine(Constantes.Message.optionNumeric);
                valuedivisor = CorrectionNumeric.CorrecionNumInt();
            }            

            cociente = valueDividendo / valuedivisor;
            residuo = valueDividendo % valuedivisor;
            return Constantes.Message.residuo + residuo + "\n" + Constantes.Message.cociente + cociente;
        }
    }
}
