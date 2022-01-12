namespace vetorInverso
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInverter = new System.Windows.Forms.Button();
            this.lstVB = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnInverter
            // 
            this.btnInverter.Location = new System.Drawing.Point(45, 29);
            this.btnInverter.Name = "btnInverter";
            this.btnInverter.Size = new System.Drawing.Size(248, 36);
            this.btnInverter.TabIndex = 0;
            this.btnInverter.Text = "Ler e Inverter";
            this.btnInverter.UseVisualStyleBackColor = true;
            this.btnInverter.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // lstVB
            // 
            this.lstVB.FormattingEnabled = true;
            this.lstVB.ItemHeight = 20;
            this.lstVB.Location = new System.Drawing.Point(106, 81);
            this.lstVB.Name = "lstVB";
            this.lstVB.Size = new System.Drawing.Size(120, 264);
            this.lstVB.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 400);
            this.Controls.Add(this.lstVB);
            this.Controls.Add(this.btnInverter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInverter;
        private System.Windows.Forms.ListBox lstVB;
    }
}

