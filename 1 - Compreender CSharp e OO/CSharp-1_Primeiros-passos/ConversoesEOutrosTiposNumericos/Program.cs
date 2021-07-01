using System;

namespace ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 4 - Conversoes e outro tipos numericos");

            double salario;
            salario = 2400.50;

            int salarioEmInteiro;
            salarioEmInteiro = (int)salario; // "(int)" Forcando a conversão de salario (double) para int - tambem conhecida com "Casting"

            Console.WriteLine(salarioEmInteiro); //Resultado: 2400 - Perdeu a precisão pois agora a variavel é INT

            long idade;                                            // Diferença do INT, LONG e SHORT:
            idade = 26000000000000000;                             // INT Armazena em 32bits (limita o numero em pouco mais de 2 bilhoes)
            Console.WriteLine(idade);                              // LONG Armazena em 64bits (Aumentando em muito o limite)

            short quantidadeDeProdutos;                            // SHORT Armazena em 16bits (Diminui bastante o limite, proximo a 16mil)
            quantidadeDeProdutos = 150;                            // Os três são INTEIROS
            Console.WriteLine(quantidadeDeProdutos);

            float altura = 1.80f;           // FLOAT não é muito usual no C#, normalemteo se usa "DOUBLE" pois é mais preciso. (Mas queira usar tem que por o sufixo "f"
            Console.WriteLine(altura);
            
            Console.WriteLine("Execução finalizada, Tecle enter para sair....");
            Console.ReadLine();
        }
    }
}
