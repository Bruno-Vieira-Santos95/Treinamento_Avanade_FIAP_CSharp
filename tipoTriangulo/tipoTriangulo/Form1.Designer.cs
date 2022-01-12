namespace tipoTriangulo
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
            this.lblLadoX = new System.Windows.Forms.Label();
            this.lblLabelY = new System.Windows.Forms.Label();
            this.lblLadoZ = new System.Windows.Forms.Label();
            this.txtLadoX = new System.Windows.Forms.TextBox();
            this.txtLadoY = new System.Windows.Forms.TextBox();
            this.txtLadoZ = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLadoX
            // 
            this.lblLadoX.AutoSize = true;
            this.lblLadoX.Location = new System.Drawing.Point(53, 9);
            this.lblLadoX.Name = "lblLadoX";
            this.lblLadoX.Size = new System.Drawing.Size(67, 25);
            this.lblLadoX.TabIndex = 0;
            this.lblLadoX.Text = "Lado X";
            // 
            // lblLabelY
            // 
            this.lblLabelY.AutoSize = true;
            this.lblLabelY.Location = new System.Drawing.Point(225, 9);
            this.lblLabelY.Name = "lblLabelY";
            this.lblLabelY.Size = new System.Drawing.Size(66, 25);
            this.lblLabelY.TabIndex = 1;
            this.lblLabelY.Text = "Lado Y";
            // 
            // lblLadoZ
            // 
            this.lblLadoZ.AutoSize = true;
            this.lblLadoZ.Location = new System.Drawing.Point(397, 9);
            this.lblLadoZ.Name = "lblLadoZ";
            this.lblLadoZ.Size = new System.Drawing.Size(66, 25);
            this.lblLadoZ.TabIndex = 2;
            this.lblLadoZ.Text = "Lado Z";
            // 
            // txtLadoX
            // 
            this.txtLadoX.Location = new System.Drawing.Point(12, 37);
            this.txtLadoX.Name = "txtLadoX";
            this.txtLadoX.Size = new System.Drawing.Size(150, 31);
            this.txtLadoX.TabIndex = 3;
            // 
            // txtLadoY
            // 
            this.txtLadoY.Location = new System.Drawing.Point(177, 37);
            this.txtLadoY.Name = "txtLadoY";
            this.txtLadoY.Size = new System.Drawing.Size(150, 31);
            this.txtLadoY.TabIndex = 4;
            // 
            // txtLadoZ
            // 
            this.txtLadoZ.Location = new System.Drawing.Point(353, 37);
            this.txtLadoZ.Name = "txtLadoZ";
            this.txtLadoZ.Size = new System.Drawing.Size(150, 31);
            this.txtLadoZ.TabIndex = 5;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(12, 74);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(491, 34);
            this.btnVerificar.TabIndex = 6;
            this.btnVerificar.Text = "Verificar Triângulo";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 126);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.txtLadoZ);
            this.Controls.Add(this.txtLadoY);
            this.Controls.Add(this.txtLadoX);
            this.Controls.Add(this.lblLadoZ);
            this.Controls.Add(this.lblLabelY);
            this.Controls.Add(this.lblLadoX);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblLadoX;
        private Label lblLabelY;
        private Label lblLadoZ;
        private TextBox txtLadoX;
        private TextBox txtLadoY;
        private TextBox txtLadoZ;
        private Button btnVerificar;
    }
}