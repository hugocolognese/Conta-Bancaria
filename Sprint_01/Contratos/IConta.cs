using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint_01.Contratos
{
    public interface IConta
    {
        void Depositar(decimal valor);
        bool Sacar(decimal valor);
        decimal ConsultarSaldo();
        string GetCodigoBanco();
        string GetNumeroAgencia();
        string GetNumeroConta();
    }
}
