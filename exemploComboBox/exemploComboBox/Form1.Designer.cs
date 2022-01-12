namespace exemploComboBox
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
            this.cmdEscolha = new System.Windows.Forms.ComboBox();
            this.btnEscolha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdEscolha
            // 
            this.cmdEscolha.FormattingEnabled = true;
            this.cmdEscolha.Items.AddRange(new object[] {
            "Ferrari",
            "Mercedes",
            "RedBull",
            "McLaren"});
            this.cmdEscolha.Location = new System.Drawing.Point(22, 12);
            this.cmdEscolha.Name = "cmdEscolha";
            this.cmdEscolha.Size = new System.Drawing.Size(257, 33);
            this.cmdEscolha.TabIndex = 0;
            // 
            // btnEscolha
            // 
            this.btnEscolha.Location = new System.Drawing.Point(22, 65);
            this.btnEscolha.Name = "btnEscolha";
            this.btnEscolha.Size = new System.Drawing.Size(257, 34);
            this.btnEscolha.TabIndex = 1;
            this.btnEscolha.Text = "Confirmar Escolha";
            this.btnEscolha.UseVisualStyleBackColor = true;
            this.btnEscolha.Click += new System.EventHandler(this.btnEscolha_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 110);
            this.Controls.Add(this.btnEscolha);
            this.Controls.Add(this.cmdEscolha);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox cmdEscolha;
        private Button btnEscolha;
    }
}