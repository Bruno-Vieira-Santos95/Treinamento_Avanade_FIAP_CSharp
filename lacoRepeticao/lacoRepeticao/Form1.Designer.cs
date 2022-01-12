namespace lacoRepeticao
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
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btnTabuada = new System.Windows.Forms.Button();
            this.lstTabuada = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite um número:";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(29, 55);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(180, 31);
            this.txtNum.TabIndex = 1;
            // 
            // btnTabuada
            // 
            this.btnTabuada.Location = new System.Drawing.Point(29, 106);
            this.btnTabuada.Name = "btnTabuada";
            this.btnTabuada.Size = new System.Drawing.Size(180, 34);
            this.btnTabuada.TabIndex = 2;
            this.btnTabuada.Text = "Ver Tabuada";
            this.btnTabuada.UseVisualStyleBackColor = true;
            this.btnTabuada.Click += new System.EventHandler(this.btnTabuada_Click);
            // 
            // lstTabuada
            // 
            this.lstTabuada.FormattingEnabled = true;
            this.lstTabuada.ItemHeight = 25;
            this.lstTabuada.Location = new System.Drawing.Point(29, 263);
            this.lstTabuada.Name = "lstTabuada";
            this.lstTabuada.Size = new System.Drawing.Size(180, 254);
            this.lstTabuada.TabIndex = 3;
            this.lstTabuada.SelectedIndexChanged += new System.EventHandler(this.lstTabuada_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Tabuada - While";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnDo
            // 
            this.btnDo.Location = new System.Drawing.Point(29, 214);
            this.btnDo.Name = "btnDo";
            this.btnDo.Size = new System.Drawing.Size(180, 34);
            this.btnDo.TabIndex = 5;
            this.btnDo.Text = "Tabuada - Do";
            this.btnDo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 529);
            this.Controls.Add(this.btnDo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstTabuada);
            this.Controls.Add(this.btnTabuada);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtNum;
        private Button btnTabuada;
        private ListBox lstTabuada;
        private Button button1;
        private Button btnDo;
    }
}