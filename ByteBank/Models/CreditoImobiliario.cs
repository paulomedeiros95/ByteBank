﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Models
{
    public class CreditoImobiliario : Credito
    {
        #region Constructor
        public CreditoImobiliario(double ValorDoCredito, int QtdParcelas, DateTime primeiroVecimento) : base(9, ValorDoCredito, QtdParcelas, primeiroVecimento)
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
