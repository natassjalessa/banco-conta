using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bancoConta
{
    public class ContaPoupanca:Conta
    {
        public double reajusteMensal { get; set; }

        public ContaPoupanca(double reajusteMensal, double saldo):base(saldo)
        {
            this.reajusteMensal = reajusteMensal;
        }

        public ContaPoupanca()
        {
            this.reajusteMensal = 0;
            this.saldo = 0; 
        }

        public void mostrarSaldoCP()
        {
            MessageBox.Show($"Seu saldo na sua conta poupança é de R${this.saldo.ToString("0.00")}");
        }

        public void sairCP()
        {
            MessageBox.Show("Conta encerrada!");
            Application.Exit();
        }
    }
}
