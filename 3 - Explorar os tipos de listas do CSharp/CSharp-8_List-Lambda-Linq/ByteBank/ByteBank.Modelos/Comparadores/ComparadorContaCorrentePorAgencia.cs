using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos.Comparadores
{
    public class ComparadorContaCorrentePorAgencia : IComparer<ContaCorrente>
    {
        public int Compare(ContaCorrente x, ContaCorrente y)
        {
            if (x == y)
            {
                return 0;
            }

            if (x == null)
            {
                return 1;
            }

            if (y == null)
            {
                return -1;
            }

            return x.Agencia.CompareTo(y.Agencia);


            // Logica escrita manualmente, o CompareTo faz exatamente a mesma coisa.
            /*if (x.Agencia < y.Agencia)
            {
                return -1; // x fica na frente de y
            }

            if (x.Agencia == y.Agencia)
            {
                return 0; // São equivalente
            }

            return 1; // y fica na frente de x */
        }
    }
}
