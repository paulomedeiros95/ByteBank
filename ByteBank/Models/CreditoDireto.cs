using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Models
{
    public class CreditoDireto : Credito
    {
        #region Constructor
        public CreditoDireto(double ValorDoCredito, int QtdParcelas, DateTime primeiroVecimento) : base(2, ValorDoCredito, QtdParcelas, primeiroVecimento)
        {

        }
        #endregion

        #region Methods

        public override bool VerificarValorMinimo()
        {
            //Valor Minimo de crédito não definido para essa categoria.           
            return true;
        }

        #endregion
    }
}
