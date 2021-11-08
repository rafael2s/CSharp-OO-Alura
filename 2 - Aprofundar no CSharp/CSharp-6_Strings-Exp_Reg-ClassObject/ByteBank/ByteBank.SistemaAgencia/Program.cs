using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            // "Olá, mundo!" é uma string
            // WriteLine é um método público estático
            // Console é uma classe pública

            Console.WriteLine("Olá, mundo!");
            Console.WriteLine(123);
            Console.WriteLine(10.5);
            Console.WriteLine(true);

            object conta = new ContaCorrente(456, 6465646);
            object desenvolvedor = new Desenvolvedor("123321");
            
            string contaToString = conta.ToString();

            Console.WriteLine("Resultado " + contaToString);
            Console.WriteLine(conta);

            Cliente rafael_1 = new Cliente();
            rafael_1.Nome = "Carlos";
            rafael_1.CPF = "123.456.789-01";
            rafael_1.Profissao = "Programador";

            Cliente rafael_2 = new Cliente();
            rafael_2.Nome = "Carlos";
            rafael_2.CPF = "123.456.789-01";
            rafael_2.Profissao = "Programador";

            ContaCorrente conta_1 = new ContaCorrente(123, 456789);

            if (rafael_1.Equals(conta_1))
            {
                Console.WriteLine("São iguais!");
            }
            else
            {
                Console.WriteLine("Não são iguais!");
            }


            Console.ReadLine();
        }

        static void TestaString()
        {
            // Olá, meu nome é Rafael e você pode entrar em contato comigo
            // atravé do número 9578-5615!

            // Meu nome é Rafael, me ligue em 9451-5452

            //string padrao = "[0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789]";
            //string padrao = "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]";
            //string padrao = "[0-9]{4,5}[-][0-9]{4}";
            //string padrao = "[0-9]{4,5}[-]{0,1}[0-9]{4}";
            //string padrao = "[0-9]{4,5}-{0,1}[0-9]{4}";
            string padrao = "[0-9]{4,5}-?[0-9]{4}";
            string textoDeTeste = "Meu nome é Rafael, me ligue em 99451-5452";

            Match resultado = Regex.Match(textoDeTeste, padrao);

            Console.WriteLine(resultado.Value);
            Console.ReadLine();


            string urlTeste = "https://www.bytebank.com/cambio";
            int indiceByteBank = urlTeste.IndexOf("https://www.bytebank.com");

            Console.WriteLine(urlTeste.StartsWith("https://www.bytebank.com"));
            Console.WriteLine(urlTeste.EndsWith("cambio"));

            Console.WriteLine(urlTeste.Contains("bytebank"));

            Console.ReadLine();

            // pagina?argumentos
            // 012345678

            // moedaOrigem=real&moedaDestino=real
            //                            |
            //          -----------------´

            string urlParametros = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";
            ExtratorValorDeArgumentosURL extradorDeValores = new ExtratorValorDeArgumentosURL(urlParametros);

            //Console.WriteLine("Valor de moedaDestino: " + extradorDeValores.GetValor("moedaDestino"));
            string valorDaMoedaOrigem = extradorDeValores.GetValor("moedaOrigem");
            Console.WriteLine("Valor de moedaOrigem: " + valorDaMoedaOrigem);

            string valorDaMoedaDestino = extradorDeValores.GetValor("moedaDestino");
            Console.WriteLine("Valor de moedaDestino: " + valorDaMoedaDestino);

            Console.WriteLine(extradorDeValores.GetValor("VALOR"));

            Console.ReadLine();

            //Testando ToLower
            string mensagemOrigem = "PALAVRA";
            string termoBusca = "ra";

            Console.WriteLine(mensagemOrigem.ToLower());

            Console.WriteLine(termoBusca.ToUpper());


            // Testando REPLACE
            termoBusca = termoBusca.Replace('r', 'R');
            Console.WriteLine(termoBusca);

            termoBusca = termoBusca.Replace('a', 'A');
            Console.WriteLine(termoBusca);

            Console.WriteLine(mensagemOrigem.IndexOf(termoBusca));
            Console.ReadLine();


            // Testando o método Remove
            string testeRemocao = "primeiraParte&123456789";
            int indiceEComercial = testeRemocao.IndexOf('&');
            Console.WriteLine(testeRemocao.Remove(indiceEComercial, 4));
            Console.ReadLine();

            // <nome>=<valor>
            string palavra = "moedaOrigem=moedaDestino&moedaDestino=dolar";
            string nomeArgumento = "moedaDestino=";

            int indice = palavra.IndexOf(nomeArgumento);
            Console.WriteLine(indice);

            Console.WriteLine("Tamanho da string nomeArgumento: " + nomeArgumento.Length);

            Console.WriteLine(palavra);
            Console.WriteLine(palavra.Substring(indice));
            Console.WriteLine(palavra.Substring(indice + nomeArgumento.Length));
            Console.ReadLine();


            // Testando o IsNullOrEmpty
            string textoVazio = "";
            string textoNulo = null;
            string textoQualquer = "Hahahahahaha";
            Console.WriteLine(String.IsNullOrEmpty(textoVazio));
            Console.WriteLine(String.IsNullOrEmpty(textoNulo));
            Console.WriteLine(String.IsNullOrEmpty(textoQualquer));
            Console.ReadLine();


            ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL("");

            string url = "pagina?moedaOrigem=real&moedaDestino=dolar";

            int indiceInterrogacao = url.IndexOf('?');

            Console.WriteLine(indiceInterrogacao);

            Console.WriteLine(url);
            string argumentos = url.Substring(indiceInterrogacao + 1);
            Console.WriteLine(argumentos);
        }

    }


}
