using System;

namespace _2_CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 2 - Criando variaveis");

            int idade;
            idade = 32;

            Console.WriteLine(idade);

            idade = 10;
            Console.WriteLine(idade);

            idade = 10 + 5;
            Console.Write(idade);

            idade = 10 + 5 * 2;
            Console.WriteLine(idade);

            idade = (10 + 5) * 2;
            Console.WriteLine("Sua idade é: " + idade + "!");
            
            //Diferença entre Write      (Write somente escreve na tela)
            //                e
            //                WriteLine  (WriteLine escreve na tela e pula a linha)

            Console.WriteLine("Execução finalizada, Tecle enter para sair....");
            Console.ReadLine();
        }
    }
}
