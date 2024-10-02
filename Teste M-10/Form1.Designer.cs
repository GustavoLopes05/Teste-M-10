namespace Teste_M_10
{
    partial class Avaliacao
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_Iniciar = new System.Windows.Forms.Button();
            this.button_Limpar = new System.Windows.Forms.Button();
            this.button_Valor_Pagar = new System.Windows.Forms.Button();
            this.txt_Categoria = new System.Windows.Forms.TextBox();
            this.txt_NomeJogo = new System.Windows.Forms.TextBox();
            this.txt_Quantidade = new System.Windows.Forms.TextBox();
            this.txt_Preco = new System.Windows.Forms.TextBox();
            this.txt_ValorPagar = new System.Windows.Forms.TextBox();
            this.gb_Categoria = new System.Windows.Forms.GroupBox();
            this.rb_Xbox = new System.Windows.Forms.RadioButton();
            this.rb_Playstation = new System.Windows.Forms.RadioButton();
            this.rb_wii = new System.Windows.Forms.RadioButton();
            this.chk_Desconto = new System.Windows.Forms.CheckBox();
            this.gb_Categoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categoria Selecionada ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome Jogo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Preço";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(237, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantidade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(378, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Valor a Pagar";
            // 
            // button_Iniciar
            // 
            this.button_Iniciar.BackColor = System.Drawing.Color.LightGreen;
            this.button_Iniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Iniciar.Location = new System.Drawing.Point(22, 354);
            this.button_Iniciar.Name = "button_Iniciar";
            this.button_Iniciar.Size = new System.Drawing.Size(119, 32);
            this.button_Iniciar.TabIndex = 6;
            this.button_Iniciar.Text = "Iniciar";
            this.button_Iniciar.UseVisualStyleBackColor = false;
            this.button_Iniciar.Click += new System.EventHandler(this.button_Iniciar_Click);
            // 
            // button_Limpar
            // 
            this.button_Limpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_Limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Limpar.Location = new System.Drawing.Point(245, 354);
            this.button_Limpar.Name = "button_Limpar";
            this.button_Limpar.Size = new System.Drawing.Size(119, 32);
            this.button_Limpar.TabIndex = 7;
            this.button_Limpar.Text = "Limpar";
            this.button_Limpar.UseVisualStyleBackColor = false;
            this.button_Limpar.Click += new System.EventHandler(this.button_Limpar_Click);
            // 
            // button_Valor_Pagar
            // 
            this.button_Valor_Pagar.BackColor = System.Drawing.Color.Olive;
            this.button_Valor_Pagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Valor_Pagar.Location = new System.Drawing.Point(468, 354);
            this.button_Valor_Pagar.Name = "button_Valor_Pagar";
            this.button_Valor_Pagar.Size = new System.Drawing.Size(119, 32);
            this.button_Valor_Pagar.TabIndex = 8;
            this.button_Valor_Pagar.Text = "Valor a pagar";
            this.button_Valor_Pagar.UseVisualStyleBackColor = false;
            this.button_Valor_Pagar.Click += new System.EventHandler(this.button_Valor_Pagar_Click);
            // 
            // txt_Categoria
            // 
            this.txt_Categoria.Location = new System.Drawing.Point(174, 133);
            this.txt_Categoria.Name = "txt_Categoria";
            this.txt_Categoria.Size = new System.Drawing.Size(413, 20);
            this.txt_Categoria.TabIndex = 9;
            // 
            // txt_NomeJogo
            // 
            this.txt_NomeJogo.Location = new System.Drawing.Point(115, 194);
            this.txt_NomeJogo.Name = "txt_NomeJogo";
            this.txt_NomeJogo.Size = new System.Drawing.Size(472, 20);
            this.txt_NomeJogo.TabIndex = 10;
            // 
            // txt_Quantidade
            // 
            this.txt_Quantidade.Location = new System.Drawing.Point(325, 255);
            this.txt_Quantidade.Name = "txt_Quantidade";
            this.txt_Quantidade.Size = new System.Drawing.Size(112, 20);
            this.txt_Quantidade.TabIndex = 11;
            this.txt_Quantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_Preco
            // 
            this.txt_Preco.Location = new System.Drawing.Point(75, 255);
            this.txt_Preco.Name = "txt_Preco";
            this.txt_Preco.Size = new System.Drawing.Size(147, 20);
            this.txt_Preco.TabIndex = 12;
            this.txt_Preco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_ValorPagar
            // 
            this.txt_ValorPagar.Location = new System.Drawing.Point(487, 306);
            this.txt_ValorPagar.Name = "txt_ValorPagar";
            this.txt_ValorPagar.Size = new System.Drawing.Size(100, 20);
            this.txt_ValorPagar.TabIndex = 13;
            this.txt_ValorPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gb_Categoria
            // 
            this.gb_Categoria.Controls.Add(this.rb_Xbox);
            this.gb_Categoria.Controls.Add(this.rb_Playstation);
            this.gb_Categoria.Controls.Add(this.rb_wii);
            this.gb_Categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Categoria.Location = new System.Drawing.Point(22, 12);
            this.gb_Categoria.Name = "gb_Categoria";
            this.gb_Categoria.Size = new System.Drawing.Size(565, 86);
            this.gb_Categoria.TabIndex = 14;
            this.gb_Categoria.TabStop = false;
            this.gb_Categoria.Text = "Categoria";
            // 
            // rb_Xbox
            // 
            this.rb_Xbox.AutoSize = true;
            this.rb_Xbox.Location = new System.Drawing.Point(53, 38);
            this.rb_Xbox.Name = "rb_Xbox";
            this.rb_Xbox.Size = new System.Drawing.Size(54, 20);
            this.rb_Xbox.TabIndex = 15;
            this.rb_Xbox.TabStop = true;
            this.rb_Xbox.Text = "xBox";
            this.rb_Xbox.UseVisualStyleBackColor = true;
            this.rb_Xbox.CheckedChanged += new System.EventHandler(this.rb_Xbox_CheckedChanged);
            // 
            // rb_Playstation
            // 
            this.rb_Playstation.AutoSize = true;
            this.rb_Playstation.Location = new System.Drawing.Point(258, 38);
            this.rb_Playstation.Name = "rb_Playstation";
            this.rb_Playstation.Size = new System.Drawing.Size(91, 20);
            this.rb_Playstation.TabIndex = 16;
            this.rb_Playstation.TabStop = true;
            this.rb_Playstation.Text = "Playstation";
            this.rb_Playstation.UseVisualStyleBackColor = true;
            this.rb_Playstation.CheckedChanged += new System.EventHandler(this.rb_Playstation_CheckedChanged);
            // 
            // rb_wii
            // 
            this.rb_wii.AutoSize = true;
            this.rb_wii.Location = new System.Drawing.Point(500, 38);
            this.rb_wii.Name = "rb_wii";
            this.rb_wii.Size = new System.Drawing.Size(40, 20);
            this.rb_wii.TabIndex = 17;
            this.rb_wii.TabStop = true;
            this.rb_wii.Text = "wii";
            this.rb_wii.UseVisualStyleBackColor = true;
            this.rb_wii.CheckedChanged += new System.EventHandler(this.rb_wii_CheckedChanged);
            // 
            // chk_Desconto
            // 
            this.chk_Desconto.AutoSize = true;
            this.chk_Desconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Desconto.Location = new System.Drawing.Point(474, 255);
            this.chk_Desconto.Name = "chk_Desconto";
            this.chk_Desconto.Size = new System.Drawing.Size(113, 20);
            this.chk_Desconto.TabIndex = 15;
            this.chk_Desconto.Text = "Desconto 10%";
            this.chk_Desconto.UseVisualStyleBackColor = true;
            // 
            // Avaliacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 404);
            this.Controls.Add(this.chk_Desconto);
            this.Controls.Add(this.gb_Categoria);
            this.Controls.Add(this.txt_ValorPagar);
            this.Controls.Add(this.txt_Preco);
            this.Controls.Add(this.txt_Quantidade);
            this.Controls.Add(this.txt_NomeJogo);
            this.Controls.Add(this.txt_Categoria);
            this.Controls.Add(this.button_Valor_Pagar);
            this.Controls.Add(this.button_Limpar);
            this.Controls.Add(this.button_Iniciar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Avaliacao";
            this.Text = "Avaliação";
            this.gb_Categoria.ResumeLayout(false);
            this.gb_Categoria.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_Iniciar;
        private System.Windows.Forms.Button button_Limpar;
        private System.Windows.Forms.Button button_Valor_Pagar;
        private System.Windows.Forms.TextBox txt_Categoria;
        private System.Windows.Forms.TextBox txt_NomeJogo;
        private System.Windows.Forms.TextBox txt_Quantidade;
        private System.Windows.Forms.TextBox txt_Preco;
        private System.Windows.Forms.TextBox txt_ValorPagar;
        private System.Windows.Forms.GroupBox gb_Categoria;
        private System.Windows.Forms.RadioButton rb_Xbox;
        private System.Windows.Forms.RadioButton rb_Playstation;
        private System.Windows.Forms.RadioButton rb_wii;
        private System.Windows.Forms.CheckBox chk_Desconto;
    }
}

