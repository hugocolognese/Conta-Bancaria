using Sprint_01.Contratos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint_01.Classes
{
    public abstract class Conta : Banco, IConta
    {
        public Conta()
        {
            this.NumeroAgencia = "0001";
            Conta.NumeroContaSequencial++;
        }

        public decimal Saldo { get; protected set; }
        public string NumeroAgencia { get; private set; }
        public string NumeroConta { get; protected set; }
        public static int NumeroContaSequencial { get; private set; }

        public decimal ConsultarSaldo()
        {
            return this.Saldo;
        }

        public void Depositar(decimal valor)
        {
            this.Saldo += valor;
        }

        public bool Sacar(decimal valor)
        {
            if(valor > this.ConsultarSaldo())
                return false;

            this.Saldo -= valor;
            return true;
        }

        public string GetCodigoBanco()
        {
            return this.CodigoBanco;
        }

        public string GetNumeroAgencia()
        {
            return this.NumeroAgencia;
        }

        public string GetNumeroConta()
        {
            return this.NumeroConta;
        }
    }
}
