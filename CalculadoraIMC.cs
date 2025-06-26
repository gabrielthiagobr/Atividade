using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculadorIMC
{
    public class IMC
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===================================");
            Console.WriteLine("       CALCULADORA DE IMC");
            Console.WriteLine("===================================\n");

            // Entrada do peso
            Console.Write("Digite o seu peso (em kg): ");
            float peso = float.Parse(Console.ReadLine());

            // Entrada da altura
            Console.Write("Digite a sua altura (em metros): ");
            float altura = float.Parse(Console.ReadLine());

            // Cálculo do IMC
            float imc = peso / (altura * altura);

            // Exibição do resultado com classificação
            Console.WriteLine($"\nSeu IMC é: {imc:F2}");

            if (imc < 17)
            {
                Console.WriteLine("Classificação: Muito abaixo do peso");
            }
            else if (imc < 18.5)
            {
                Console.WriteLine("Classificação: Abaixo do peso");
            }
            else if (imc < 25)
            {
                Console.WriteLine("Classificação: Peso ideal");
            }
            else if (imc < 30)
            {
                Console.WriteLine("Classificação: Sobrepeso");
            }
            else if (imc < 35)
            {
                Console.WriteLine("Classificação: Obesidade grau I");
            }
            else if (imc < 40)
            {
                Console.WriteLine("Classificação: Obesidade grau II (severa)");
            }
            else
            {
                Console.WriteLine("Classificação: Obesidade grau III (mórbida)");
            }


            // Encerramento
            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
