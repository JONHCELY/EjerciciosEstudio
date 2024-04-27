using System;

namespace BLL.Utilidades
{
    public class CorrectionNumeric
    {
        public static double CorrecionNum()
        {
            Console.WriteLine(Constantes.Message.digitNumericUnic);
            var num = Console.ReadLine();
            double valueNum = 0;

            if (!double.TryParse(num, out valueNum))
            {
                Console.WriteLine(Constantes.Message.optionNumeric);
                valueNum = CorrecionNum();
                return valueNum;
            }

            return valueNum;
        }

        public static int CorrecionNumInt()
        {
            Console.WriteLine(Constantes.Message.divisorOperation);
            var num = Console.ReadLine();
            int valueNum = 0;

            if (!int.TryParse(num, out valueNum))
            {
                Console.WriteLine(Constantes.Message.optionNumeric);
                valueNum = CorrecionNumInt();
                return valueNum;
            }

            return valueNum;
        }
    }
}
