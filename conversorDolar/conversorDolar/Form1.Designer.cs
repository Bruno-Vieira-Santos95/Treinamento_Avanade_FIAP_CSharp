namespace conversorDolar
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
            this.txtDolar = new System.Windows.Forms.TextBox();
            this.lblDolar = new System.Windows.Forms.Label();
            this.btnConverter = new System.Windows.Forms.Button();
            this.lblReal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDolar
            // 
            this.txtDolar.Location = new System.Drawing.Point(94, 61);
            this.txtDolar.Name = "txtDolar";
            this.txtDolar.Size = new System.Drawing.Size(150, 31);
            this.txtDolar.TabIndex = 0;
            // 
            // lblDolar
            // 
            this.lblDolar.AutoSize = true;
            this.lblDolar.Location = new System.Drawing.Point(78, 19);
            this.lblDolar.Name = "lblDolar";
            this.lblDolar.Size = new System.Drawing.Size(206, 25);
            this.lblDolar.TabIndex = 1;
            this.lblDolar.Text = "Digite o valor em Dólar: ";
            // 
            // btnConverter
            // 
            this.btnConverter.Location = new System.Drawing.Point(56, 122);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(242, 34);
            this.btnConverter.TabIndex = 2;
            this.btnConverter.Text = "Converter em Real";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // lblReal
            // 
            this.lblReal.AutoSize = true;
            this.lblReal.Location = new System.Drawing.Point(142, 187);
            this.lblReal.Name = "lblReal";
            this.lblReal.Size = new System.Drawing.Size(59, 25);
            this.lblReal.TabIndex = 3;
            this.lblReal.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 261);
            this.Controls.Add(this.lblReal);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.lblDolar);
            this.Controls.Add(this.txtDolar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtDolar;
        private Label lblDolar;
        private Button btnConverter;
        private Label lblReal;
    }
}