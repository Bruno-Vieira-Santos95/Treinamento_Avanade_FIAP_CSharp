namespace mediaGasolina
{
    partial class frmGasolina
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
            this.lblKminicial = new System.Windows.Forms.Label();
            this.lblKmfinal = new System.Windows.Forms.Label();
            this.lblGasolina = new System.Windows.Forms.Label();
            this.txtKminicial = new System.Windows.Forms.TextBox();
            this.txtKmfinal = new System.Windows.Forms.TextBox();
            this.txtGasolina = new System.Windows.Forms.TextBox();
            this.lblRes = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKminicial
            // 
            this.lblKminicial.AutoSize = true;
            this.lblKminicial.Location = new System.Drawing.Point(39, 21);
            this.lblKminicial.Name = "lblKminicial";
            this.lblKminicial.Size = new System.Drawing.Size(152, 25);
            this.lblKminicial.TabIndex = 0;
            this.lblKminicial.Text = "Quilômetro Inicial";
            // 
            // lblKmfinal
            // 
            this.lblKmfinal.AutoSize = true;
            this.lblKmfinal.Location = new System.Drawing.Point(319, 21);
            this.lblKmfinal.Name = "lblKmfinal";
            this.lblKmfinal.Size = new System.Drawing.Size(144, 25);
            this.lblKmfinal.TabIndex = 1;
            this.lblKmfinal.Text = "Quilômetro Final";
            // 
            // lblGasolina
            // 
            this.lblGasolina.AutoSize = true;
            this.lblGasolina.Location = new System.Drawing.Point(597, 21);
            this.lblGasolina.Name = "lblGasolina";
            this.lblGasolina.Size = new System.Drawing.Size(202, 25);
            this.lblGasolina.TabIndex = 2;
            this.lblGasolina.Text = "Quantidade de Gasolina";
            // 
            // txtKminicial
            // 
            this.txtKminicial.Location = new System.Drawing.Point(39, 61);
            this.txtKminicial.Name = "txtKminicial";
            this.txtKminicial.Size = new System.Drawing.Size(150, 31);
            this.txtKminicial.TabIndex = 3;
            // 
            // txtKmfinal
            // 
            this.txtKmfinal.Location = new System.Drawing.Point(313, 61);
            this.txtKmfinal.Name = "txtKmfinal";
            this.txtKmfinal.Size = new System.Drawing.Size(150, 31);
            this.txtKmfinal.TabIndex = 4;
            // 
            // txtGasolina
            // 
            this.txtGasolina.Location = new System.Drawing.Point(625, 61);
            this.txtGasolina.Name = "txtGasolina";
            this.txtGasolina.Size = new System.Drawing.Size(150, 31);
            this.txtGasolina.TabIndex = 5;
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(164, 204);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(0, 25);
            this.lblRes.TabIndex = 6;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(209, 139);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(351, 34);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // frmGasolina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 291);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.txtGasolina);
            this.Controls.Add(this.txtKmfinal);
            this.Controls.Add(this.txtKminicial);
            this.Controls.Add(this.lblGasolina);
            this.Controls.Add(this.lblKmfinal);
            this.Controls.Add(this.lblKminicial);
            this.Name = "frmGasolina";
            this.Text = "Média de Gasolina por Quilômetro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblKminicial;
        private Label lblKmfinal;
        private Label lblGasolina;
        private TextBox txtKminicial;
        private TextBox txtKmfinal;
        private TextBox txtGasolina;
        private Label lblRes;
        private Button btnCalcular;
    }
}