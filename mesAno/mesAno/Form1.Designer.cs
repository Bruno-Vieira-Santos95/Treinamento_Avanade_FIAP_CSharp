namespace mesAno
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
            this.lblMes = new System.Windows.Forms.Label();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.btnMes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Location = new System.Drawing.Point(38, 9);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(161, 25);
            this.lblMes.TabIndex = 0;
            this.lblMes.Text = "Digite um número:";
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(38, 47);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(150, 31);
            this.txtMes.TabIndex = 1;
            // 
            // btnMes
            // 
            this.btnMes.Location = new System.Drawing.Point(23, 93);
            this.btnMes.Name = "btnMes";
            this.btnMes.Size = new System.Drawing.Size(186, 34);
            this.btnMes.TabIndex = 2;
            this.btnMes.Text = "Verificar Mês";
            this.btnMes.UseVisualStyleBackColor = true;
            this.btnMes.Click += new System.EventHandler(this.btnMes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 148);
            this.Controls.Add(this.btnMes);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.lblMes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblMes;
        private TextBox txtMes;
        private Button btnMes;
    }
}