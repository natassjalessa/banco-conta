using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bancoConta
{
    public class contaCorrente:Conta
    {
        public double limiteEspecial { get; set; }

        public contaCorrente(double limiteEspecial, double saldo):base(saldo)
        {
            this.limiteEspecial = limiteEspecial;
        }

        public contaCorrente()
        {
            this.limiteEspecial = 0;
            this.saldo = 0;
        }

        public void mostrarSaldoCC()
        {
            MessageBox.Show($"O valor do saldo da sua conta corrente é de R${this.saldo.ToString("0.00")}");
        }

        public void sairCC()
        {
            MessageBox.Show("Conta encerrada!");
            Application.Exit();
        }
    }
}
