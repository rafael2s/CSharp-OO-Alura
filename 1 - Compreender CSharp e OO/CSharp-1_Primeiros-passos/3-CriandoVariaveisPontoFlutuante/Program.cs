using System;

namespace _3_CriandoVariaveisPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 3 - Criando variaveis ponto flutuante");

            double salario;
            salario = 1250.70;
            Console.WriteLine(salario);

            double idade;
            idade = 15.0 / 2;
            Console.WriteLine(idade);

            idade = 5 / 3;
            Console.WriteLine("5 / 3: " + idade);   // Resultado: 1

            idade = 5.0 / 3;
            Console.WriteLine("5.0 / 3: " + idade); // Resultado: 1,666666666666667



            Console.WriteLine("Execução finalizada, Tecle enter para sair....");
            Console.ReadLine();
        }
    }
}
