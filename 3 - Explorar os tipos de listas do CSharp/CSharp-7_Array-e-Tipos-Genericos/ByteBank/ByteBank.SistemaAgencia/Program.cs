using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaDeContaCorrente lista = new ListaDeContaCorrente();

            ContaCorrente contaDoGui = new ContaCorrente(546, 546546576);

            ContaCorrente[] contas = new ContaCorrente[]
            {
                contaDoGui,
                new ContaCorrente(123, 1111111),
                new ContaCorrente(123, 2222222),
                new ContaCorrente(123, 3333333)
            };

            lista.AdicionarVarios(contas);

            //lista.EscreverListaNaTela();

            //lista.Remover(contaDoGui);

            //Console.WriteLine("Após remover o item");

            //lista.EscreverListaNaTela();

            for(int i = 0; i < lista.Tamanho; i++)
            {
                ContaCorrente itemAtual = lista[i];
                Console.WriteLine($"Item na posição {i} = Conta {itemAtual.Agencia}/{itemAtual.Numero}");
            }


            Console.ReadLine();
        }

        static int SomarVarios(params int [] numeros)
        {
            int acumulador = 0;
            foreach(int numero in numeros)
            {
                acumulador += numero;
            }
            return acumulador;
        }

        static void TestaArrayDeContaCorrente()
        {
            ContaCorrente[] contas = new ContaCorrente[]
{
                new ContaCorrente(123, 1111111),
                new ContaCorrente(123, 2222222),
                new ContaCorrente(123, 3333333)
};

            //contas[0] = new ContaCorrente(123, 1111111);
            //contas[1] = new ContaCorrente(123, 2222222);
            //contas[2] = new ContaCorrente(123, 3333333);

            for (int indice = 0; indice < contas.Length; indice++)
            {
                ContaCorrente contaAtual = contas[indice];
                Console.WriteLine($"Conta {indice} {contaAtual.Numero}");
            }
        }

        static void TestaArrayInt()
        {
            //ARRAY de inteiros, com 5 posições!
            int[] idades = null;
            idades = new int[6];

            idades[0] = 15;
            idades[1] = 28;
            idades[2] = 35;
            idades[3] = 50;
            idades[4] = 21;
            idades[5] = 60;

            Console.WriteLine(idades.Length);

            /*  int indice = 4;
            int idadeNoIndice4 = idades[indice]; 
            //int idadeNoIndice4 = idades[2 + 2];

            Console.WriteLine(idades[4]); */

            int acumulador = 0;
            for (int indice = 0; indice < idades.Length; indice++)
            {
                int idade = idades[indice];

                Console.WriteLine($"Acessando o array idades no índice {indice}");
                Console.WriteLine($"Valor de idades[{indice}] = {idade}");

                acumulador += idade;
            }

            int media = acumulador / idades.Length;
            Console.WriteLine($"Média de idades = {media}");
        }
    }
}
