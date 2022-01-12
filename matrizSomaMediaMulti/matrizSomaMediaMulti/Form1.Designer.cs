namespace matrizSomaMediaMulti
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
            this.btnMatriz = new System.Windows.Forms.Button();
            this.btnSoma = new System.Windows.Forms.Button();
            this.btnMedia = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.lstResultado = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnMatriz
            // 
            this.btnMatriz.Location = new System.Drawing.Point(30, 3);
            this.btnMatriz.Name = "btnMatriz";
            this.btnMatriz.Size = new System.Drawing.Size(367, 30);
            this.btnMatriz.TabIndex = 0;
            this.btnMatriz.Text = "Matriz";
            this.btnMatriz.UseVisualStyleBackColor = true;
            this.btnMatriz.Click += new System.EventHandler(this.btnMatriz_Click);
            // 
            // btnSoma
            // 
            this.btnSoma.Location = new System.Drawing.Point(30, 39);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(367, 30);
            this.btnSoma.TabIndex = 1;
            this.btnSoma.Text = "Soma";
            this.btnSoma.UseVisualStyleBackColor = true;
            this.btnSoma.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // btnMedia
            // 
            this.btnMedia.Location = new System.Drawing.Point(30, 75);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(367, 30);
            this.btnMedia.TabIndex = 2;
            this.btnMedia.Text = "Média";
            this.btnMedia.UseVisualStyleBackColor = true;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // btnMult
            // 
            this.btnMult.Location = new System.Drawing.Point(30, 111);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(367, 30);
            this.btnMult.TabIndex = 3;
            this.btnMult.Text = "Multiplicação";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // lstResultado
            // 
            this.lstResultado.FormattingEnabled = true;
            this.lstResultado.ItemHeight = 20;
            this.lstResultado.Location = new System.Drawing.Point(30, 157);
            this.lstResultado.Name = "lstResultado";
            this.lstResultado.Size = new System.Drawing.Size(367, 264);
            this.lstResultado.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 433);
            this.Controls.Add(this.lstResultado);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnMedia);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.btnMatriz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMatriz;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Button btnMedia;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.ListBox lstResultado;
    }
}

