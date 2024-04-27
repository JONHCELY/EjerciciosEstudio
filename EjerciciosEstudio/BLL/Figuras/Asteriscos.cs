using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Figuras
{
    public class Asteriscos
    {
        public static (string f, int n) figura1()
        {
            var f = "*";
            var f2 = "*";
            Console.WriteLine("Digite la cantidad de lineas que desea observar en la pantalla.");
            var n = Console.ReadLine();
            if (string.IsNullOrEmpty(n))
            {
                return (" ", 0);
            }
            var n2 = Convert.ToInt32(n);
            Console.WriteLine();
            for (int i = 1; i <= n2; i++)
            {
                Console.WriteLine(f);
                f += f2;
            }
            return (f, n2);
        }

        public static void figura2(string f1, int n)
        {
            Console.WriteLine();
            for (int i = n; i >= 1; i--)
            {
                f1 = f1.Remove(i, 1);
                Console.WriteLine(f1);
            }
        }

        public static void figura3(string f2, int n)
        {
            f2 = f2.Replace("*", " ");
            string f3 = "*";
            string f4 = "*";
            Console.WriteLine();
            for (int i = n; i >= 1; i--)
            {
                f2 = f2.Remove(i, 1);
                Console.WriteLine(f2 + f3);
                f3 += f4;
            }
        }

        public static void figura4(string f3, int n)
        {
            var f = " ";
            var f2 = " ";
            var n2 = n;
            Console.WriteLine();
            for (int i = 1; i <= n; i++)
            {
                f3 = f3.Remove(n2, 1);
                Console.WriteLine(f + f3);
                f += f2;
                n2 -= 1;
            }
        }
    }
}
