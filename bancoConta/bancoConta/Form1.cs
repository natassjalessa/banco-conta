using Microsoft.VisualBasic;
namespace bancoConta
{
    public partial class Form1 : Form
    {
        contaCorrente cc = new contaCorrente(limiteEspecial: 1000, saldo: 500);
        ContaPoupanca cp = new ContaPoupanca(reajusteMensal: 0.01, saldo: 5000);
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDepositarCorrente_Click(object sender, EventArgs e)
        {
            double valor = double.Parse(Interaction.InputBox("Digite um valor para depositar"));
            cc.creditarConta(valor);
            
        }

        private void btnSacarCorrente_Click(object sender, EventArgs e)
        {
            double valor = double.Parse(Interaction.InputBox("Digite um valor para sacar"));
            cc.debitarConta(valor);
        }

        private void btnSaldoCorrente_Click(object sender, EventArgs e)
        {
            cc.mostrarSaldoCC();
        }

        private void btnSairCC_Click(object sender, EventArgs e)
        {
            cc.sairCC();
        }

        private void btnDepositarPoupanca_Click(object sender, EventArgs e)
        {
            double valor = double.Parse(Interaction.InputBox("Digite um valor para depositar"));
            cp.creditarConta(valor);
        }

        private void btnSacarPoupanca_Click(object sender, EventArgs e)
        {
            double valor = double.Parse(Interaction.InputBox("Digite um valor para sacar"));
            cp.debitarConta(valor);
        }

        private void btnSaldoPoupanca_Click(object sender, EventArgs e)
        {
            cp.mostrarSaldoCP();
        }

        private void btnSairCP_Click(object sender, EventArgs e)
        {
            cp.sairCP();
        }

        
    }
}