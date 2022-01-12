namespace VariaveisNumericas
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSomar = new System.Windows.Forms.Button();
            this.lblRes = new System.Windows.Forms.Label();
            this.btnSub = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRes2 = new System.Windows.Forms.Label();
            this.btnMultiplicacao = new System.Windows.Forms.Button();
            this.lblRes3 = new System.Windows.Forms.Label();
            this.btnDivisao = new System.Windows.Forms.Button();
            this.lblRes4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero 1";
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(12, 48);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(150, 31);
            this.txtNum1.TabIndex = 1;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(288, 48);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(162, 31);
            this.txtNum2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numero 2";
            // 
            // btnSomar
            // 
            this.btnSomar.Location = new System.Drawing.Point(85, 106);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(291, 34);
            this.btnSomar.TabIndex = 4;
            this.btnSomar.Text = "Somar";
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(12, 149);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(59, 25);
            this.lblRes.TabIndex = 5;
            this.lblRes.Text = "label3";
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(85, 192);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(291, 34);
            this.btnSub.TabIndex = 6;
            this.btnSub.Text = "Subtração";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 7;
            // 
            // lblRes2
            // 
            this.lblRes2.AutoSize = true;
            this.lblRes2.Location = new System.Drawing.Point(18, 239);
            this.lblRes2.Name = "lblRes2";
            this.lblRes2.Size = new System.Drawing.Size(59, 25);
            this.lblRes2.TabIndex = 8;
            this.lblRes2.Text = "label4";
            // 
            // btnMultiplicacao
            // 
            this.btnMultiplicacao.Location = new System.Drawing.Point(85, 275);
            this.btnMultiplicacao.Name = "btnMultiplicacao";
            this.btnMultiplicacao.Size = new System.Drawing.Size(291, 34);
            this.btnMultiplicacao.TabIndex = 9;
            this.btnMultiplicacao.Text = "Multiplicação";
            this.btnMultiplicacao.UseVisualStyleBackColor = true;
            this.btnMultiplicacao.Click += new System.EventHandler(this.btnMultiplicacao_Click);
            // 
            // lblRes3
            // 
            this.lblRes3.AutoSize = true;
            this.lblRes3.Location = new System.Drawing.Point(18, 326);
            this.lblRes3.Name = "lblRes3";
            this.lblRes3.Size = new System.Drawing.Size(59, 25);
            this.lblRes3.TabIndex = 10;
            this.lblRes3.Text = "label5";
            // 
            // btnDivisao
            // 
            this.btnDivisao.Location = new System.Drawing.Point(85, 361);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(291, 34);
            this.btnDivisao.TabIndex = 11;
            this.btnDivisao.Text = "Divisão";
            this.btnDivisao.UseVisualStyleBackColor = true;
            this.btnDivisao.Click += new System.EventHandler(this.btnDivisao_Click);
            // 
            // lblRes4
            // 
            this.lblRes4.AutoSize = true;
            this.lblRes4.Location = new System.Drawing.Point(18, 418);
            this.lblRes4.Name = "lblRes4";
            this.lblRes4.Size = new System.Drawing.Size(59, 25);
            this.lblRes4.TabIndex = 12;
            this.lblRes4.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 490);
            this.Controls.Add(this.lblRes4);
            this.Controls.Add(this.btnDivisao);
            this.Controls.Add(this.lblRes3);
            this.Controls.Add(this.btnMultiplicacao);
            this.Controls.Add(this.lblRes2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private Label label2;
        private Button btnSomar;
        private Label lblRes;
        private Button btnSub;
        private Label label3;
        private Label lblRes2;
        private Button btnMultiplicacao;
        private Label lblRes3;
        private Button btnDivisao;
        private Label lblRes4;
    }
}