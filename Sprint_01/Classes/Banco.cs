using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint_01.Classes
{
    public abstract class Banco
    {
        public Banco()
        {
            this.NomeBanco = "Banco Padrão";
            this.CodigoBanco = "027";
        }

        public string NomeBanco { get; private set; }
        public string CodigoBanco { get; private set; }
    }
}
