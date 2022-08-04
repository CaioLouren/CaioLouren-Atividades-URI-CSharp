using System;
using System.Globalization;

namespace ConsoleApp4
{
    public class Program
    {
        static void Main(string[] args)
        {
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double salarioComReajuste = salario;

            if (salario < 400.01)
            {
                salario = ((salario * 15) / 100) + salario;
                Console.WriteLine("Novo salario: " + salario.ToString("F2", CultureInfo.InvariantCulture));
                salario = salario - salarioComReajuste;
                Console.WriteLine("Reajuste ganho: " + salario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 15 %");
            }
            else if (salario < 800.01)
            {
                salario = ((salario * 12) / 100) + salario;
                Console.WriteLine("Novo salario: " + salario.ToString("F2", CultureInfo.InvariantCulture));
                salario = salario - salarioComReajuste;
                Console.WriteLine("Reajuste ganho: " + salario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 12 %");
            }
            else if (salario < 1200.01)
            {
                salario = ((salario * 10) / 100) + salario;
                Console.WriteLine("Novo salario: " + salario.ToString("F2", CultureInfo.InvariantCulture));
                salario = salario - salarioComReajuste;
                Console.WriteLine("Reajuste ganho: " + salario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 10 %");
            }
            else if (salario <= 2000.00)
            {
                salario = ((salario * 7) / 100) + salario;
                Console.WriteLine("Novo salario: " + salario.ToString("F2", CultureInfo.InvariantCulture));
                salario = salario - salarioComReajuste;
                Console.WriteLine("Reajuste ganho: " + salario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 7 %");
            }
            else if (salario > 2000.00)
            {
                salario = ((salario * 4) / 100) + salario;
                Console.WriteLine("Novo salario: " + salario.ToString("F2", CultureInfo.InvariantCulture));
                salario = salario - salarioComReajuste;
                Console.WriteLine("Reajuste ganho: " + salario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: 4 %");
            }
        }
    }
}