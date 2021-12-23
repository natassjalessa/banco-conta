namespace bancoConta
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageContaCorrente = new System.Windows.Forms.TabPage();
            this.btnSairCC = new System.Windows.Forms.Button();
            this.btnSacarCorrente = new System.Windows.Forms.Button();
            this.btnSaldoCorrente = new System.Windows.Forms.Button();
            this.btnDepositarCorrente = new System.Windows.Forms.Button();
            this.tabPageContaPoupanca = new System.Windows.Forms.TabPage();
            this.btnSairCP = new System.Windows.Forms.Button();
            this.btnSacarPoupanca = new System.Windows.Forms.Button();
            this.btnSaldoPoupanca = new System.Windows.Forms.Button();
            this.btnDepositarPoupanca = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageContaCorrente.SuspendLayout();
            this.tabPageContaPoupanca.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageContaCorrente);
            this.tabControl1.Controls.Add(this.tabPageContaPoupanca);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(515, 136);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageContaCorrente
            // 
            this.tabPageContaCorrente.Controls.Add(this.btnSairCC);
            this.tabPageContaCorrente.Controls.Add(this.btnSacarCorrente);
            this.tabPageContaCorrente.Controls.Add(this.btnSaldoCorrente);
            this.tabPageContaCorrente.Controls.Add(this.btnDepositarCorrente);
            this.tabPageContaCorrente.Location = new System.Drawing.Point(4, 34);
            this.tabPageContaCorrente.Name = "tabPageContaCorrente";
            this.tabPageContaCorrente.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageContaCorrente.Size = new System.Drawing.Size(507, 98);
            this.tabPageContaCorrente.TabIndex = 0;
            this.tabPageContaCorrente.Text = "Conta Corrente";
            this.tabPageContaCorrente.UseVisualStyleBackColor = true;
            // 
            // btnSairCC
            // 
            this.btnSairCC.Location = new System.Drawing.Point(361, 25);
            this.btnSairCC.Name = "btnSairCC";
            this.btnSairCC.Size = new System.Drawing.Size(112, 34);
            this.btnSairCC.TabIndex = 3;
            this.btnSairCC.Text = "Sair";
            this.btnSairCC.UseVisualStyleBackColor = true;
            this.btnSairCC.Click += new System.EventHandler(this.btnSairCC_Click);
            // 
            // btnSacarCorrente
            // 
            this.btnSacarCorrente.Location = new System.Drawing.Point(125, 25);
            this.btnSacarCorrente.Name = "btnSacarCorrente";
            this.btnSacarCorrente.Size = new System.Drawing.Size(112, 34);
            this.btnSacarCorrente.TabIndex = 2;
            this.btnSacarCorrente.Text = "Sacar";
            this.btnSacarCorrente.UseVisualStyleBackColor = true;
            this.btnSacarCorrente.Click += new System.EventHandler(this.btnSacarCorrente_Click);
            // 
            // btnSaldoCorrente
            // 
            this.btnSaldoCorrente.Location = new System.Drawing.Point(243, 25);
            this.btnSaldoCorrente.Name = "btnSaldoCorrente";
            this.btnSaldoCorrente.Size = new System.Drawing.Size(112, 34);
            this.btnSaldoCorrente.TabIndex = 1;
            this.btnSaldoCorrente.Text = "Saldo";
            this.btnSaldoCorrente.UseVisualStyleBackColor = true;
            this.btnSaldoCorrente.Click += new System.EventHandler(this.btnSaldoCorrente_Click);
            // 
            // btnDepositarCorrente
            // 
            this.btnDepositarCorrente.Location = new System.Drawing.Point(7, 25);
            this.btnDepositarCorrente.Name = "btnDepositarCorrente";
            this.btnDepositarCorrente.Size = new System.Drawing.Size(112, 34);
            this.btnDepositarCorrente.TabIndex = 0;
            this.btnDepositarCorrente.Text = "Depositar";
            this.btnDepositarCorrente.UseVisualStyleBackColor = true;
            this.btnDepositarCorrente.Click += new System.EventHandler(this.btnDepositarCorrente_Click);
            // 
            // tabPageContaPoupanca
            // 
            this.tabPageContaPoupanca.Controls.Add(this.btnSairCP);
            this.tabPageContaPoupanca.Controls.Add(this.btnSacarPoupanca);
            this.tabPageContaPoupanca.Controls.Add(this.btnSaldoPoupanca);
            this.tabPageContaPoupanca.Controls.Add(this.btnDepositarPoupanca);
            this.tabPageContaPoupanca.Location = new System.Drawing.Point(4, 34);
            this.tabPageContaPoupanca.Name = "tabPageContaPoupanca";
            this.tabPageContaPoupanca.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageContaPoupanca.Size = new System.Drawing.Size(507, 98);
            this.tabPageContaPoupanca.TabIndex = 1;
            this.tabPageContaPoupanca.Text = "Conta Poupança";
            this.tabPageContaPoupanca.UseVisualStyleBackColor = true;
            // 
            // btnSairCP
            // 
            this.btnSairCP.Location = new System.Drawing.Point(361, 32);
            this.btnSairCP.Name = "btnSairCP";
            this.btnSairCP.Size = new System.Drawing.Size(112, 34);
            this.btnSairCP.TabIndex = 6;
            this.btnSairCP.Text = "Sair";
            this.btnSairCP.UseVisualStyleBackColor = true;
            this.btnSairCP.Click += new System.EventHandler(this.btnSairCP_Click);
            // 
            // btnSacarPoupanca
            // 
            this.btnSacarPoupanca.Location = new System.Drawing.Point(125, 32);
            this.btnSacarPoupanca.Name = "btnSacarPoupanca";
            this.btnSacarPoupanca.Size = new System.Drawing.Size(112, 34);
            this.btnSacarPoupanca.TabIndex = 5;
            this.btnSacarPoupanca.Text = "Sacar";
            this.btnSacarPoupanca.UseVisualStyleBackColor = true;
            this.btnSacarPoupanca.Click += new System.EventHandler(this.btnSacarPoupanca_Click);
            // 
            // btnSaldoPoupanca
            // 
            this.btnSaldoPoupanca.Location = new System.Drawing.Point(243, 32);
            this.btnSaldoPoupanca.Name = "btnSaldoPoupanca";
            this.btnSaldoPoupanca.Size = new System.Drawing.Size(112, 34);
            this.btnSaldoPoupanca.TabIndex = 4;
            this.btnSaldoPoupanca.Text = "Saldo";
            this.btnSaldoPoupanca.UseVisualStyleBackColor = true;
            this.btnSaldoPoupanca.Click += new System.EventHandler(this.btnSaldoPoupanca_Click);
            // 
            // btnDepositarPoupanca
            // 
            this.btnDepositarPoupanca.Location = new System.Drawing.Point(7, 32);
            this.btnDepositarPoupanca.Name = "btnDepositarPoupanca";
            this.btnDepositarPoupanca.Size = new System.Drawing.Size(112, 34);
            this.btnDepositarPoupanca.TabIndex = 3;
            this.btnDepositarPoupanca.Text = "Depositar";
            this.btnDepositarPoupanca.UseVisualStyleBackColor = true;
            this.btnDepositarPoupanca.Click += new System.EventHandler(this.btnDepositarPoupanca_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 158);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPageContaCorrente.ResumeLayout(false);
            this.tabPageContaPoupanca.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageContaCorrente;
        private Button btnSacarCorrente;
        private Button btnSaldoCorrente;
        private Button btnDepositarCorrente;
        private TabPage tabPageContaPoupanca;
        private Button btnSacarPoupanca;
        private Button btnSaldoPoupanca;
        private Button btnDepositarPoupanca;
        private Button btnSairCC;
        private Button btnSairCP;
    }
}