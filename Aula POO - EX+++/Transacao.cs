using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_POO___ex__
{
    internal class Transacao
    {
        private double precoProduto;
        private double valorPago;

        public double PrecoProduto
        {
            get { return precoProduto; }
            set
            {
                if (valorPago > 0 && value < 1000)
                {
                    precoProduto = value;
                }
            }
        }

        public double ValorPago
        {
            get { return valorPago; }
            set { valorPago = value; }
        }

        public void GravarDados(double precoProduto, double valorPago)
        {
            this.precoProduto = precoProduto;
            this.valorPago = valorPago;
        }

        public double CalcularTroco()
        {
            if (valorPago >= precoProduto)
            {
                return valorPago - precoProduto;
            }
            else
            {
                return -1;
            }
        }

        public string MostraDados()
        {
            string aux = "";
            aux = $"Valor do Produto {precoProduto.ToString("0.00")}";
            aux += $"\nValor Pago {valorPago.ToString("0.00")}";
            if (CalcularTroco() >= 0)
            {
                aux += $"\nTroco {CalcularTroco().ToString("0.00")}";
            }
            else
            {
                aux += "\nValor Insuficiente";
            }

            return aux;
        }
    }
}
