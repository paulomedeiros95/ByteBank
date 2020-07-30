using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Models
{
    public abstract class Credito
    {
        #region Constructor
        public Credito(int taxa, double valorDoCredito, int qtdParcelas, DateTime primeiroVecimento)
        {
            if (valorDoCredito <= 0)
            {
                throw new ArgumentException("O argumento valor do credito não pode ser nulo ou negativo", nameof(ValorDoCredito));
            }

            if (qtdParcelas <= 0)
            {
                throw new ArgumentException("O argumento quantida de parcelas não pode ser nulo ou negativo", nameof(QtdParcelas));
            }

            Taxa = taxa;
            ValorDoCredito = valorDoCredito;
            QtdParcelas = qtdParcelas;
            PrimeiroVencimento = primeiroVecimento;
        }
        #endregion

        #region Properties

        public double ValorDoCredito { get; private set; }
        public int QtdParcelas { get; private set; }
        public DateTime PrimeiroVencimento { get; private set; }
        public int Taxa { get; private set; }

        #endregion

        #region Methods

        public bool VerificarValorMaximo(double valorDoCredito)
        {
            bool result;

            if (ValorDoCredito > 1000000)
            {
                Console.WriteLine("Crédito não autorizado.");
                Console.WriteLine("O limite de crédito para empréstimos é de R$1.000.000,00 (UM MILHÃO DE REAIS).");
                return false;
            }
            else
            {
                result = VerificarQuantidadeDeParcelas(this.QtdParcelas);
            }
            return result;
        }
        public bool VerificarQuantidadeDeParcelas(int qtdParcelas)
        {
            bool result;

            if (qtdParcelas > 72 || qtdParcelas < 5)
            {
                Console.WriteLine("Crédito não autorizado.");
                Console.WriteLine("O valor total de parcelas deve ser menor que 72 e maior que 5.");
                return false;
            }
            else
            {
                result = VerificarDataVencimento();
            }
            return result;
        }
        public bool VerificarDataVencimento()
        {
            //A data do primeiro vencimento sempre será no MINIMO d+15 ( dia atual + 15 dias).
            // E NO MAXIMO, D+40 (Dia atual + 40 dias)
            DateTime dataHoje = DateTime.Now;
            TimeSpan diasParaOPagamento = PrimeiroVencimento - dataHoje;
            int qtdDias = diasParaOPagamento.Days;
            var result = false;

            if (qtdDias < 15 || qtdDias > 40)
            {
                Console.WriteLine("Crédito não autorizado");
                Console.WriteLine("A parcela do primeiro pagamento deve ser feita no MÍNIMO 15 dias após a solicitação e no MAXIMO 40 dias após a data de solicitação.");
                return false;
            }
            else
            {
                result= VerificarValorMinimo();
            }
            return result;
        }
        public abstract bool VerificarValorMinimo();

        #endregion
    }
}
