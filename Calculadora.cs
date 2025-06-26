using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade
{
    public class Calculadora
    {
        static void Main(string[] args)
        {
            double Numero1, Numero2, resultado = 0;
            int opcao;

            Console.WriteLine("=========================");
            Console.WriteLine("       CALCULADORA       ");
            Console.WriteLine("=========================");

            Console.WriteLine("Digite um número para realizar as operações matemáticas.");
            Numero1 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Agora, Digite o seu segundo número");
            Numero2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nEscolha a operação:");
            Console.WriteLine("1 - Soma (+)");
            Console.WriteLine("2 - Subtração (-)");
            Console.WriteLine("3 - Multiplicação (*)");
            Console.WriteLine("4 - Divisão (/)");
            Console.Write("Opção: ");

            opcao = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("=========================");

            switch (opcao)
            {
                case 1:
                    resultado = Numero1 + Numero2;
                    Console.WriteLine("O resultado da soma: {Numero1} + {Numero2} = {resultado}");
                    break;

                case 2:
                    resultado = Numero1 - Numero2;
                    Console.WriteLine("O resultado da subtração: {Numero1} - {Numero2} = {resultado}");
                    break;

                case 3:
                    resultado = Numero1 * Numero2;
                    Console.WriteLine("O resultado da multiplicação: {Numero1} * {Numero2} = {resultado}");
                    break;

                case 4:
                    if (Numero2 != 0)
                    {
                        resultado = Numero1 / Numero2;
                        Console.WriteLine("O resultado da divisão: {Numero1} / {Numero2} = {resultado}");
                    }
                    else
                    {
                        Console.WriteLine("Erro: Divisão por zero não é permitida: ");
                    }
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }


        }
    }
}