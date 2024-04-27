using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Utilidades
{
    public static class Constantes
    {
        #region mensajes
        public static class Message
        {
            public const string optionNumeric = "Debe ser un valor numérico.";
            public const string bienvenido = "Bienvenido, acaba de iniciar el proceso de {0} ";
            public const string startServices = "Desea volver a Inicar el Servicio? S/N:";
            public const string startAritmetica = "Desea realizar otra operacion Aritmetica? S/N:";
            public const string startListas = "Desea realizar otra operacion de Listas? S/N:";
            public const string valueDisponible = "La opción seleccionada no corresponde con una opción disponible.";
            internal const string quantyDigit = "Favor digite la cantidad de numeros a {0}";            
            internal const string digitNumeric = "Favor digite los numeros a {0}";
            internal const string digitNumericUnic = "Favor digite de nuevo el numero a {0}";
            internal const string sumar = "Sumar.";
            internal const string restar = "Restar.";
            internal const string multiplicar = "Multiplicar.";
            internal const string dividir = "Dividir.";
            internal const string verify = "Verificar.";
            internal const string resultfinal = "La {0} de los numeros digitados es: ";            
            internal const string dividendoOperation = "Favor digite el numero a {0}";
            internal const string divisorOperation = "Favor digite el numero por el cual quiere dividir el numero anterior";
            internal const string residuo = "El residuo de la division es: ";
            internal const string cociente = "El cociente de la division es: ";
        }
        #endregion

    }
}
