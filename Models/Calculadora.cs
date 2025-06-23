using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bootcamp.Models
{
    public class Calculadora
    {
        public void Somar(double a, double b)
        {
            double resultado = a + b;
            Console.WriteLine($"Resultado da soma: {resultado}");
        }
        public void Subtrair(double a, double b)
        {
            double resultado = a - b;
            Console.WriteLine($"Resultado da subtração: {resultado}");
        }
        public void Multiplicar(double a, double b)
        {
            double resultado = a * b;
            Console.WriteLine($"Resultado da multiplicação: {resultado}");
        }
        public void Dividir(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Erro: Divisão por zero não é permitida.");
                return;
            }
            double resultado = a / b;
            Console.WriteLine($"Resultado da divisão: {resultado}");
        }
    }
}