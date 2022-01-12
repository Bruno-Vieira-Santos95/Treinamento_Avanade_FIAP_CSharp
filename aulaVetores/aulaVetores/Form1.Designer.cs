namespace aulaVetores
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
            this.txtV1 = new System.Windows.Forms.TextBox();
            this.txtV2 = new System.Windows.Forms.TextBox();
            this.txtV3 = new System.Windows.Forms.TextBox();
            this.txtV4 = new System.Windows.Forms.TextBox();
            this.txtV5 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o valor das vendas de cada vendedor:";
            // 
            // txtV1
            // 
            this.txtV1.Location = new System.Drawing.Point(96, 37);
            this.txtV1.Name = "txtV1";
            this.txtV1.Size = new System.Drawing.Size(150, 31);
            this.txtV1.TabIndex = 1;
            // 
            // txtV2
            // 
            this.txtV2.Location = new System.Drawing.Point(96, 83);
            this.txtV2.Name = "txtV2";
            this.txtV2.Size = new System.Drawing.Size(150, 31);
            this.txtV2.TabIndex = 2;
            // 
            // txtV3
            // 
            this.txtV3.Location = new System.Drawing.Point(96, 129);
            this.txtV3.Name = "txtV3";
            this.txtV3.Size = new System.Drawing.Size(150, 31);
            this.txtV3.TabIndex = 3;
            // 
            // txtV4
            // 
            this.txtV4.Location = new System.Drawing.Point(96, 178);
            this.txtV4.Name = "txtV4";
            this.txtV4.Size = new System.Drawing.Size(150, 31);
            this.txtV4.TabIndex = 4;
            // 
            // txtV5
            // 
            this.txtV5.Location = new System.Drawing.Point(96, 227);
            this.txtV5.Name = "txtV5";
            this.txtV5.Size = new System.Drawing.Size(150, 31);
            this.txtV5.TabIndex = 5;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(96, 276);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(150, 34);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 344);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtV5);
            this.Controls.Add(this.txtV4);
            this.Controls.Add(this.txtV3);
            this.Controls.Add(this.txtV2);
            this.Controls.Add(this.txtV1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtV1;
        private TextBox txtV2;
        private TextBox txtV3;
        private TextBox txtV4;
        private TextBox txtV5;
        private Button btnCalcular;
    }
}