using System;


namespace Atividade
{
    public class Contador
    {
        static void Main(string[] args)
        {
            int Numero;
            Console.WriteLine("Contando de 1 ao 10");
            for (Numero = 1; Numero < 11; Numero ++)
            {
                Console.WriteLine("Número: {0}", Numero);
            } 
        }    
    }
}

