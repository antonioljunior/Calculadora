using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero1, numero2;
            string msgErro = "O valor informado não é um numero válido.";

            Console.WriteLine("Numero 1: ");

            while (!double.TryParse(Console.ReadLine(), out numero1))
                Console.WriteLine(msgErro);

            Console.WriteLine("Numero 2: ");
            while (!double.TryParse(Console.ReadLine(), out numero2))
                Console.WriteLine(msgErro);

            Console.WriteLine("Operação: + - * / ");
            string operacao = Console.ReadLine();

            switch (operacao)
            {
                case "+":
                    Console.WriteLine(string.Format("Soma: {0}",
                        numero1 + numero2));
                    break;
                case "-":
                    Console.WriteLine(string.Format("Subtração: {0}",
                        numero1 - numero2));
                    break;
                default:
                    break;
            }

            Console.ReadLine();
        }
    }
}