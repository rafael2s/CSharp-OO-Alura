using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime dataCorrente = DateTime.Now;
            Console.WriteLine(dataCorrente);

            DateTime dataFimPagamento = new DateTime(2021, 12, 26);
            Console.WriteLine(dataFimPagamento);

            TimeSpan diferenca = dataFimPagamento - dataCorrente;

            string mensagem = "Vencimento em " + GetIntervaloDeTempoLegivel(diferenca);

            Console.WriteLine(mensagem);

            Console.ReadLine();
        }

        static string GetIntervaloDeTempoLegivel(TimeSpan timeSpan)
        {
            if(timeSpan.Days > 30)
            {
                int quantidadeMeses = timeSpan.Days / 30;
                if(quantidadeMeses == 1)
                {
                    return "1 mês";
                }
                return quantidadeMeses + " meses";
            }
            return timeSpan.Days + " dias";
        }
    }
}
