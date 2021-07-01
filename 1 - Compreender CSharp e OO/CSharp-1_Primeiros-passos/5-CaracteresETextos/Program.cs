using System;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 5");

            char primeiraLetra = ' ';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)61;
            Console.WriteLine(primeiraLetra);   // Resultado: "=" (CODIGO ASCII 65 = '=')

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);   // Resultado: ">" (CODIGO ASCII 66 = '>')

            string titulo = "Alura Cursos de tecnolocia " + 2021;
            string cursosProgramacao = 
@"- .NET + 
- Java 
- JavaScript";
            Console.WriteLine(titulo);
            Console.WriteLine(cursosProgramacao);
       

            

            Console.ReadLine();
        }
    }
}
