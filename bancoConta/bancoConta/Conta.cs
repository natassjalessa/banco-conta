using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bancoConta
{
    public class Conta
    {
        public double saldo { get; set; }

        public Conta(double saldo)
        {
            this.saldo = saldo;
        }

        public Conta()
        {
            this.saldo=0;
        }

        public void creditarConta(double valor)
        {
            this.saldo += valor; 
        }

        public void debitarConta(double valor)
        {
            if (valor > saldo)
            {
                MessageBox.Show("Atenção, verificar o saldo da sua conta", "BANCO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                this.saldo -= valor;
            }
            
        }
    }
}
