using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bancoConta
{
    public abstract class Conta
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
            MessageBox.Show("Depósito efetuado com sucesso!");
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
                MessageBox.Show("Saque efetuado com sucesso!");
            }
            
        }

        public abstract void atualizarSaldos();
    }
}
