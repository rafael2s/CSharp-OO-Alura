﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ContaCorrente conta = new ContaCorrente(500, 10);
                ContaCorrente conta2 = new ContaCorrente(510, 10005);

                conta2.Transferir(-10, conta);


                conta.Depositar(50);
                Console.WriteLine(conta.Saldo);
                conta.Sacar(-500);
                Console.WriteLine(conta.Saldo);
            }
            catch (ArgumentException ex)
            {
                if (ex.ParamName == "numero")
                {

                }  
                Console.WriteLine("Argumento com problema: " + ex.ParamName);
                Console.WriteLine("Ocorreru uma exceção do tipo ArgumentException");
                Console.WriteLine(ex.Message);
            }
            catch (SaldoInsuficienteException ex)
            {

                Console.WriteLine(ex.Message);
                Console.WriteLine("Exceção do tipo SaldoInsuficienteException");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            {

                Metodo();

                Console.WriteLine("Execução finalizada. Tecle enter para sair");
                Console.ReadLine();
            }
   
        }
        //Teste com a cadeia de chamada:
        //Metodo -> TestaDivisao -> Dividir
        private static void Metodo()
        {
            TestaDivisao(0);
            //TestaDivisao(2);
        }

        private static void TestaDivisao(int divisor)
        {
            try
            {
                Dividir(10, divisor);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Fui capturado pelo (NullReferenceException ex)");
                Console.WriteLine(ex.StackTrace);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Fui capturado pelo (Exception ex)");
                Console.WriteLine(ex.StackTrace);
            }

            //catch(DivideByZeroException ex)
            //{
            //    Console.WriteLine(ex.StackTrace);
            //}

            //Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);                
        }

        private static int Dividir(int numero, int divisor)
        {
            try
            {
                return numero / divisor;
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Exceção com numero=" + numero + " e divisor=" + divisor);
                throw;
            }
        }
    }
}
