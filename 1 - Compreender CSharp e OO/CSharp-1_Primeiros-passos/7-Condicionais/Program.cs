using System;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 7");

            int idadeJoao = 16;
            int quantidadePessoas = 2;

            if (idadeJoao >= 18)
            {
                Console.WriteLine("João possui mais de 18 anos de idade");
            }
            else
            {
                if(quantidadePessoas >= 2)
                {
                    Console.WriteLine("João não possui 18 anos, porém está acompanhado. Pode entrar.");
                }
                else
                {
                    Console.WriteLine("João possui menos de 18 anos de idade");
                }
            }

            Console.ReadLine();
        }
    }
}
