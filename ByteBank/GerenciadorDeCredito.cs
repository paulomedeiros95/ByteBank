using ByteBank.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank
{
    public class GerenciadorDeCredito
    {
        private double _totalJuros;

        #region Methods

        public void LiberarCredito(Credito credito)
        {
            var result = credito.VerificarValorMaximo(credito.ValorDoCredito);
            if (result == true)
            {
                Console.WriteLine("Crédito Aprovado");

                //valor solicitado/
                var jurosAoMes = ((double)credito.Taxa / 100) * credito.ValorDoCredito;
                var ValorTotalDosJuros = credito.QtdParcelas * jurosAoMes;
                var ValorTotalComJuros = ValorTotalDosJuros + credito.ValorDoCredito;


                Console.WriteLine("Resumo do crédito Solicitado:");
                Console.WriteLine("Valor total dos juros:" + ValorTotalDosJuros);
                Console.WriteLine("Valor total com juros:" + ValorTotalComJuros);

                Console.WriteLine("Obrigado por escolher a byte bank!");

            }

        }

        #endregion
    }
}
