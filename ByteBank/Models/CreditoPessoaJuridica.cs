using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Models
{
    public class CreditoPessoaJuridica : Credito
    {
        #region Constructor
        public CreditoPessoaJuridica(double ValorDoCredito, int QtdParcelas, DateTime primeiroVecimento) : base(5, ValorDoCredito, QtdParcelas, primeiroVecimento
            )
        {

        }
        #endregion

        #region Methods
        public override bool VerificarValorMinimo()
        {
            if (ValorDoCredito < 15000)
            {
                Console.WriteLine("Crédito não autorizado.");
                Console.WriteLine("Emprestimos para pessoas juridicas devem ser maior que R$15.000,00 (QUINZE MIL REAIS).");
                return false;
            }
            else
            {              
                return true;
            }
        }

        #endregion
    }
}
