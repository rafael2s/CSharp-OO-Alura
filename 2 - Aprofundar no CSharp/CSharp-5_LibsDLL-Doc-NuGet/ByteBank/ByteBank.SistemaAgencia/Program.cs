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

            TimeSpan diferenca = TimeSpan.FromMinutes(40);//dataFimPagamento - dataCorrente;

            //string mensagem = "Vencimento em " + GetIntervaloDeTempoLegivel(diferenca);
            //string mensagem = "Vencimento em " + TimeSpanHumanizeExtensions.Humanize(diferenca);

            Console.WriteLine(mensagem);

            Console.ReadLine();
        }
    }
}
