using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint_01.Classes
{
    public class ContaCorrente : Conta
    {
        public ContaCorrente()
        {
            this.NumeroConta = "00" + Conta.NumeroContaSequencial;
        }
    }
}
