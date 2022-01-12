namespace livraria_heranca
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.txtGênero = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnVender = new System.Windows.Forms.Button();
            this.btnComprar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtEdicao = new System.Windows.Forms.TextBox();
            this.txtEditora = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnVenderCD = new System.Windows.Forms.Button();
            this.btnComprarCD = new System.Windows.Forms.Button();
            this.btnCadCD = new System.Windows.Forms.Button();
            this.txtOrigem = new System.Windows.Forms.TextBox();
            this.txtGravadora = new System.Windows.Forms.TextBox();
            this.txtArtista = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnVenderDVD = new System.Windows.Forms.Button();
            this.btnComprarDVD = new System.Windows.Forms.Button();
            this.btnCadDVD = new System.Windows.Forms.Button();
            this.txtCensura = new System.Windows.Forms.TextBox();
            this.txtDuracao = new System.Windows.Forms.TextBox();
            this.txtDiretor = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCompraVenda = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnListarCD = new System.Windows.Forms.Button();
            this.btnListarDVD = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição do Produto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gênero:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Qtde em Estoque:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Preço:";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(12, 37);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(444, 31);
            this.txtDesc.TabIndex = 5;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(262, 186);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(194, 31);
            this.txtPreco.TabIndex = 7;
            // 
            // txtEstoque
            // 
            this.txtEstoque.Location = new System.Drawing.Point(12, 186);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(189, 31);
            this.txtEstoque.TabIndex = 8;
            // 
            // txtGênero
            // 
            this.txtGênero.Location = new System.Drawing.Point(12, 112);
            this.txtGênero.Name = "txtGênero";
            this.txtGênero.Size = new System.Drawing.Size(444, 31);
            this.txtGênero.TabIndex = 9;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 296);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(444, 350);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnListar);
            this.tabPage1.Controls.Add(this.btnVender);
            this.tabPage1.Controls.Add(this.btnComprar);
            this.tabPage1.Controls.Add(this.btnCadastrar);
            this.tabPage1.Controls.Add(this.txtEdicao);
            this.tabPage1.Controls.Add(this.txtEditora);
            this.tabPage1.Controls.Add(this.txtAutor);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(436, 312);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Livro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(326, 247);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(85, 34);
            this.btnListar.TabIndex = 9;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(221, 247);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(85, 34);
            this.btnVender.TabIndex = 8;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(127, 247);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(88, 34);
            this.btnComprar.TabIndex = 7;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(6, 247);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(106, 34);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtEdicao
            // 
            this.txtEdicao.Location = new System.Drawing.Point(6, 184);
            this.txtEdicao.Name = "txtEdicao";
            this.txtEdicao.Size = new System.Drawing.Size(405, 31);
            this.txtEdicao.TabIndex = 5;
            // 
            // txtEditora
            // 
            this.txtEditora.Location = new System.Drawing.Point(6, 110);
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.Size = new System.Drawing.Size(405, 31);
            this.txtEditora.TabIndex = 4;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(6, 36);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(405, 31);
            this.txtAutor.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Edição:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Editora:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Autor:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnListarCD);
            this.tabPage2.Controls.Add(this.btnVenderCD);
            this.tabPage2.Controls.Add(this.btnComprarCD);
            this.tabPage2.Controls.Add(this.btnCadCD);
            this.tabPage2.Controls.Add(this.txtOrigem);
            this.tabPage2.Controls.Add(this.txtGravadora);
            this.tabPage2.Controls.Add(this.txtArtista);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(436, 312);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CD";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnVenderCD
            // 
            this.btnVenderCD.Location = new System.Drawing.Point(225, 246);
            this.btnVenderCD.Name = "btnVenderCD";
            this.btnVenderCD.Size = new System.Drawing.Size(81, 34);
            this.btnVenderCD.TabIndex = 17;
            this.btnVenderCD.Text = "Vender";
            this.btnVenderCD.UseVisualStyleBackColor = true;
            this.btnVenderCD.Click += new System.EventHandler(this.btnVenderCD_Click);
            // 
            // btnComprarCD
            // 
            this.btnComprarCD.Location = new System.Drawing.Point(109, 246);
            this.btnComprarCD.Name = "btnComprarCD";
            this.btnComprarCD.Size = new System.Drawing.Size(94, 34);
            this.btnComprarCD.TabIndex = 16;
            this.btnComprarCD.Text = "Comprar";
            this.btnComprarCD.UseVisualStyleBackColor = true;
            this.btnComprarCD.Click += new System.EventHandler(this.btnComprarCD_Click);
            // 
            // btnCadCD
            // 
            this.btnCadCD.Location = new System.Drawing.Point(6, 246);
            this.btnCadCD.Name = "btnCadCD";
            this.btnCadCD.Size = new System.Drawing.Size(97, 34);
            this.btnCadCD.TabIndex = 15;
            this.btnCadCD.Text = "Cadastrar";
            this.btnCadCD.UseVisualStyleBackColor = true;
            this.btnCadCD.Click += new System.EventHandler(this.btnCadCD_Click);
            // 
            // txtOrigem
            // 
            this.txtOrigem.Location = new System.Drawing.Point(6, 183);
            this.txtOrigem.Name = "txtOrigem";
            this.txtOrigem.Size = new System.Drawing.Size(405, 31);
            this.txtOrigem.TabIndex = 14;
            // 
            // txtGravadora
            // 
            this.txtGravadora.Location = new System.Drawing.Point(6, 109);
            this.txtGravadora.Name = "txtGravadora";
            this.txtGravadora.Size = new System.Drawing.Size(405, 31);
            this.txtGravadora.TabIndex = 13;
            // 
            // txtArtista
            // 
            this.txtArtista.Location = new System.Drawing.Point(6, 35);
            this.txtArtista.Name = "txtArtista";
            this.txtArtista.Size = new System.Drawing.Size(405, 31);
            this.txtArtista.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "País de Origem:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "Gravadora:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 25);
            this.label10.TabIndex = 9;
            this.label10.Text = "Artista:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnListarDVD);
            this.tabPage3.Controls.Add(this.btnVenderDVD);
            this.tabPage3.Controls.Add(this.btnComprarDVD);
            this.tabPage3.Controls.Add(this.btnCadDVD);
            this.tabPage3.Controls.Add(this.txtCensura);
            this.tabPage3.Controls.Add(this.txtDuracao);
            this.tabPage3.Controls.Add(this.txtDiretor);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(436, 312);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "DVD";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnVenderDVD
            // 
            this.btnVenderDVD.Location = new System.Drawing.Point(216, 248);
            this.btnVenderDVD.Name = "btnVenderDVD";
            this.btnVenderDVD.Size = new System.Drawing.Size(104, 34);
            this.btnVenderDVD.TabIndex = 17;
            this.btnVenderDVD.Text = "Vender";
            this.btnVenderDVD.UseVisualStyleBackColor = true;
            this.btnVenderDVD.Click += new System.EventHandler(this.btnVenderDVD_Click);
            // 
            // btnComprarDVD
            // 
            this.btnComprarDVD.Location = new System.Drawing.Point(109, 248);
            this.btnComprarDVD.Name = "btnComprarDVD";
            this.btnComprarDVD.Size = new System.Drawing.Size(97, 34);
            this.btnComprarDVD.TabIndex = 16;
            this.btnComprarDVD.Text = "Comprar";
            this.btnComprarDVD.UseVisualStyleBackColor = true;
            this.btnComprarDVD.Click += new System.EventHandler(this.btnComprarDVD_Click);
            // 
            // btnCadDVD
            // 
            this.btnCadDVD.Location = new System.Drawing.Point(6, 248);
            this.btnCadDVD.Name = "btnCadDVD";
            this.btnCadDVD.Size = new System.Drawing.Size(97, 34);
            this.btnCadDVD.TabIndex = 15;
            this.btnCadDVD.Text = "Cadastrar";
            this.btnCadDVD.UseVisualStyleBackColor = true;
            this.btnCadDVD.Click += new System.EventHandler(this.btnCadDVD_Click);
            // 
            // txtCensura
            // 
            this.txtCensura.Location = new System.Drawing.Point(6, 185);
            this.txtCensura.Name = "txtCensura";
            this.txtCensura.Size = new System.Drawing.Size(405, 31);
            this.txtCensura.TabIndex = 14;
            // 
            // txtDuracao
            // 
            this.txtDuracao.Location = new System.Drawing.Point(6, 111);
            this.txtDuracao.Name = "txtDuracao";
            this.txtDuracao.Size = new System.Drawing.Size(405, 31);
            this.txtDuracao.TabIndex = 13;
            // 
            // txtDiretor
            // 
            this.txtDiretor.Location = new System.Drawing.Point(6, 37);
            this.txtDiretor.Name = "txtDiretor";
            this.txtDiretor.Size = new System.Drawing.Size(405, 31);
            this.txtDiretor.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 157);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 25);
            this.label11.TabIndex = 11;
            this.label11.Text = "Censura:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 25);
            this.label12.TabIndex = 10;
            this.label12.Text = "Duração:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 25);
            this.label13.TabIndex = 9;
            this.label13.Text = "Diretor:";
            // 
            // txtCompraVenda
            // 
            this.txtCompraVenda.Location = new System.Drawing.Point(12, 249);
            this.txtCompraVenda.Name = "txtCompraVenda";
            this.txtCompraVenda.Size = new System.Drawing.Size(189, 31);
            this.txtCompraVenda.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 221);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(144, 25);
            this.label14.TabIndex = 11;
            this.label14.Text = "Compra e Venda";
            // 
            // btnListarCD
            // 
            this.btnListarCD.Location = new System.Drawing.Point(326, 246);
            this.btnListarCD.Name = "btnListarCD";
            this.btnListarCD.Size = new System.Drawing.Size(85, 34);
            this.btnListarCD.TabIndex = 18;
            this.btnListarCD.Text = "Listar";
            this.btnListarCD.UseVisualStyleBackColor = true;
            this.btnListarCD.Click += new System.EventHandler(this.btnListarCD_Click);
            // 
            // btnListarDVD
            // 
            this.btnListarDVD.Location = new System.Drawing.Point(326, 248);
            this.btnListarDVD.Name = "btnListarDVD";
            this.btnListarDVD.Size = new System.Drawing.Size(85, 34);
            this.btnListarDVD.TabIndex = 19;
            this.btnListarDVD.Text = "Listar";
            this.btnListarDVD.UseVisualStyleBackColor = true;
            this.btnListarDVD.Click += new System.EventHandler(this.btnListarDVD_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 649);
            this.Controls.Add(this.txtCompraVenda);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtGênero);
            this.Controls.Add(this.txtEstoque);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtDesc;
        private TextBox txtPreco;
        private TextBox txtEstoque;
        private TextBox txtGênero;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button btnVender;
        private Button btnComprar;
        private Button btnCadastrar;
        private TextBox txtEdicao;
        private TextBox txtEditora;
        private TextBox txtAutor;
        private Label label7;
        private Label label6;
        private Label label5;
        private TabPage tabPage2;
        private Button btnVenderCD;
        private Button btnComprarCD;
        private Button btnCadCD;
        private TextBox txtOrigem;
        private TextBox txtGravadora;
        private TextBox txtArtista;
        private Label label8;
        private Label label9;
        private Label label10;
        private TabPage tabPage3;
        private Button btnVenderDVD;
        private Button btnComprarDVD;
        private Button btnCadDVD;
        private TextBox txtCensura;
        private TextBox txtDuracao;
        private TextBox txtDiretor;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox txtCompraVenda;
        private Label label14;
        private Button btnListar;
        private Button btnListarCD;
        private Button btnListarDVD;
    }
}