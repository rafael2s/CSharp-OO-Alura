using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario
    {
        public static int TotalDeFuncionairos { get; private set; }
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        public Funcionario(double salario, string cpf)
        {
            Console.WriteLine("Criando Funcionario!");

            CPF = cpf;
            Salario = salario;

            TotalDeFuncionairos++;
        }

        public abstract void AumentarSalario();
        public abstract double GetBonificacao();
    }
}
