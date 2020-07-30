using ByteBank.Models;
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SolicitarCredito();
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao Solicitar credito, operação não realizada. Entre em contato com administrador do sistema");
                Console.WriteLine(e.Message);
                Console.WriteLine("Rota para ao erro supramencionado...");
                Console.WriteLine(e.StackTrace);
            }
            Console.ReadLine();
        }

        public static void SolicitarCredito()
        {
            GerenciadorDeCredito gerenciadorDeCredito = new GerenciadorDeCredito();

            try
            {
                Console.WriteLine("Seja bem vindo ao sistema de solicitação de crédito do banco Byte Bank");
                Console.WriteLine("----------------------------------------------------------------------");

                Console.WriteLine("Selecione a opção de crédito desejada:");
                Console.WriteLine("1- Crédito Pessoa Jurídica");
                Console.WriteLine("2- Crédito Direto");
                Console.WriteLine("3- Crédito Imobiliário");
                Console.WriteLine("4- Crédito Pessoa Física");
                Console.WriteLine("5- Crédito Consignado");
                Console.WriteLine("6- SAIR");
                Console.WriteLine("Digite o número correspondente ao crédito desejado e aperte a tecla ENTER...");

                int caseSwitch = Convert.ToInt32(Console.ReadLine());

                switch (caseSwitch)
                {

                    #region CASE 1
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Crédito Pessoa Jurídica");
                        Console.WriteLine("------------------------");

                        Console.WriteLine("Digite a data (dd/MM/YYYY) da primeira parcela de pagamento e aperte a tecla ENTER... ");
                        string date = Console.ReadLine();
                        DateTime primeiroVecimento = DateTime.Parse(date);


                        Console.WriteLine("Digite o valor do crédito desejado ");
                        int valorDoCredito = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite a quantidade de parcelas desejadas");
                        int qtdParcelas = int.Parse(Console.ReadLine());


                        CreditoPessoaJuridica creditoPessoaJuridica = new CreditoPessoaJuridica(valorDoCredito, qtdParcelas, primeiroVecimento);
                        gerenciadorDeCredito.LiberarCredito(creditoPessoaJuridica);
                        break;
                    #endregion

                    #region CASE 2
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Crédito Direto");
                        Console.WriteLine("------------------------");

                        Console.WriteLine("Digite a data (dd/MM/YYYY) da primeira parcela de pagamento e aperte a tecla ENTER... ");
                        date = Console.ReadLine();
                        primeiroVecimento = DateTime.Parse(date);


                        Console.WriteLine("Digite o valor do crédito desejado ");
                        valorDoCredito = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite a quantidade de parcelas desejadas");
                        qtdParcelas = int.Parse(Console.ReadLine());


                        CreditoDireto creditoDireto = new CreditoDireto(valorDoCredito, qtdParcelas, primeiroVecimento);
                        gerenciadorDeCredito.LiberarCredito(creditoDireto);
                        break;
                    #endregion

                    #region CASE 3
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Crédito Imobiliário");
                        Console.WriteLine("------------------------");

                        Console.WriteLine("Digite a data (dd/MM/YYYY) da primeira parcela de pagamento e aperte a tecla ENTER... ");
                        date = Console.ReadLine();
                        primeiroVecimento = DateTime.Parse(date);


                        Console.WriteLine("Digite o valor do crédito desejado ");
                        valorDoCredito = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite a quantidade de parcelas desejadas");
                        qtdParcelas = int.Parse(Console.ReadLine());


                        CreditoImobiliario creditoImobiliario = new CreditoImobiliario(valorDoCredito, qtdParcelas, primeiroVecimento);
                        gerenciadorDeCredito.LiberarCredito(creditoImobiliario);
                        break;
                    #endregion

                    #region CASE 4
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Crédito Pessoa Física");
                        Console.WriteLine("------------------------");

                        Console.WriteLine("Digite a data (dd/MM/YYYY) da primeira parcela de pagamento e aperte a tecla ENTER... ");
                        date = Console.ReadLine();
                        primeiroVecimento = DateTime.Parse(date);


                        Console.WriteLine("Digite o valor do crédito desejado ");
                        valorDoCredito = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite a quantidade de parcelas desejadas");
                        qtdParcelas = int.Parse(Console.ReadLine());


                        CreditoPessoaFisica creditoPessoaFisica = new CreditoPessoaFisica(valorDoCredito, qtdParcelas, primeiroVecimento);
                        gerenciadorDeCredito.LiberarCredito(creditoPessoaFisica);
                        break;

                    #endregion

                    #region CASE 5
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Crédito Consignado");
                        Console.WriteLine("------------------------");

                        Console.WriteLine("Digite a data (dd/MM/YYYY) da primeira parcela de pagamento e aperte a tecla ENTER... ");
                        date = Console.ReadLine();
                        primeiroVecimento = DateTime.Parse(date);


                        Console.WriteLine("Digite o valor do crédito desejado ");
                        valorDoCredito = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite a quantidade de parcelas desejadas");
                        qtdParcelas = int.Parse(Console.ReadLine());


                        CreditoConsignado creditoConsignado = new CreditoConsignado(valorDoCredito, qtdParcelas, primeiroVecimento);
                        gerenciadorDeCredito.LiberarCredito(creditoConsignado);
                        break;
                    #endregion

                    default:
                        Console.WriteLine("Not Known");
                        break;
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Ocorreu uma exceção do tipo ArgumentException");
                Console.WriteLine(ex.Message);
                Console.Write("Argumento com problema: " + ex.ParamName);
            }
        }
    }
}
