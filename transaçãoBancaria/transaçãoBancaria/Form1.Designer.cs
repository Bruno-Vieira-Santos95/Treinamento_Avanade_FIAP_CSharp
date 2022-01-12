namespace transaçãoBancaria
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
            this.lblDeposito = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnTransacao = new System.Windows.Forms.Button();
            this.cmbOpcao = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblDeposito
            // 
            this.lblDeposito.AutoSize = true;
            this.lblDeposito.Location = new System.Drawing.Point(12, 11);
            this.lblDeposito.Name = "lblDeposito";
            this.lblDeposito.Size = new System.Drawing.Size(227, 25);
            this.lblDeposito.TabIndex = 0;
            this.lblDeposito.Text = "Digite o Valor da Transação";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(12, 39);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(227, 31);
            this.txtValor.TabIndex = 2;
            // 
            // btnTransacao
            // 
            this.btnTransacao.Location = new System.Drawing.Point(12, 160);
            this.btnTransacao.Name = "btnTransacao";
            this.btnTransacao.Size = new System.Drawing.Size(227, 34);
            this.btnTransacao.TabIndex = 4;
            this.btnTransacao.Text = "Transação Bancária";
            this.btnTransacao.UseVisualStyleBackColor = true;
            this.btnTransacao.Click += new System.EventHandler(this.btnTransacao_Click);
            // 
            // cmbOpcao
            // 
            this.cmbOpcao.FormattingEnabled = true;
            this.cmbOpcao.Items.AddRange(new object[] {
            "Depósito",
            "Saque",
            "Ver Saldo"});
            this.cmbOpcao.Location = new System.Drawing.Point(12, 94);
            this.cmbOpcao.Name = "cmbOpcao";
            this.cmbOpcao.Size = new System.Drawing.Size(227, 33);
            this.cmbOpcao.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 207);
            this.Controls.Add(this.cmbOpcao);
            this.Controls.Add(this.btnTransacao);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblDeposito);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblDeposito;
        private TextBox txtValor;
        private Button btnTransacao;
        private ComboBox cmbOpcao;
    }
}