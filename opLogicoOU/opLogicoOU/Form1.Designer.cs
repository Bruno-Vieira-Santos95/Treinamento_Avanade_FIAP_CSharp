namespace opLogicoOU
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
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCupom = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtCupom = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(12, 22);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(147, 25);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total de Compra:";
            // 
            // lblCupom
            // 
            this.lblCupom.AutoSize = true;
            this.lblCupom.Location = new System.Drawing.Point(0, 75);
            this.lblCupom.Name = "lblCupom";
            this.lblCupom.Size = new System.Drawing.Size(181, 25);
            this.lblCupom.TabIndex = 1;
            this.lblCupom.Text = "Cupom de Desconto:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(188, 19);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(150, 31);
            this.txtTotal.TabIndex = 2;
            // 
            // txtCupom
            // 
            this.txtCupom.Location = new System.Drawing.Point(188, 75);
            this.txtCupom.Name = "txtCupom";
            this.txtCupom.Size = new System.Drawing.Size(150, 31);
            this.txtCupom.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(12, 125);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(326, 34);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular Desconto";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 183);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtCupom);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblCupom);
            this.Controls.Add(this.lblTotal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTotal;
        private Label lblCupom;
        private TextBox txtTotal;
        private TextBox txtCupom;
        private Button btnCalcular;
    }
}