using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    class ClasseTeste
    {
        public ClasseTeste()
        {
            ModificadoresTeste teste = new ModificadoresTeste();
            teste.MetodoPublico();
            //teste.MetodoPrivado();
            //teste.MetodoProtegido();
            teste.MetodoInterno();
        }
    }

    public class ModificadoresTeste
    {
        public void MetodoPublico()
        {
            // Visível fora da classe "ModificadoresTeste"
        }
        public void MetodoPrivado()
        {
            // Visível apenas na classe "ModificadoresTeste"
        }
        public void MetodoProtegido()
        {
            // Visível fora da classe "ModificadoresTeste" e derivados
        }

        internal void MetodoInterno()
        {
            // Visível apenas para o projeto ByteBank,odelos!
        }
    }
}
