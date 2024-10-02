using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Teste_M_10
{
    public partial class Avaliacao : Form
    {
        public Avaliacao()
        {
            InitializeComponent();

            DesabilitarCampos();
        }

        //1. Ao iniciar o programa todos os campos devem estar desabilitados com exceção dos Botões;
        private void DesabilitarCampos()
        {
            rb_Xbox.Enabled = false;
            rb_Playstation.Enabled = false;
            rb_wii.Enabled = false;
            txt_Categoria.Enabled=false;
            txt_NomeJogo.Enabled=false;
            txt_Preco.Enabled=false;
            txt_Quantidade.Enabled=false;
            chk_Desconto.Enabled =false;
            txt_ValorPagar.Enabled=false;
        }

        //2. Ao clicar no Botão Iniciar devem ser habilitados todos os campos, exceto o campo relativo à “Categoria Selecionada” e “Valor a Pagar”
        private void button_Iniciar_Click(object sender, EventArgs e)
        {
            rb_Xbox.Enabled = true;
            rb_Playstation.Enabled = true;
            rb_wii.Enabled = true;
            txt_NomeJogo.Enabled = true;
            txt_Preco.Enabled = true;
            txt_Quantidade.Enabled = true;
            chk_Desconto.Enabled = true;
        }

        //3. Ao clicar no Botão Limpar” todos os campos devem ficar vazios e/ou desmarcados;
        private void button_Limpar_Click(object sender, EventArgs e)
        {
            rb_Xbox.Checked = false;
            rb_Playstation.Checked = false;
            rb_wii.Checked = false;
            txt_Categoria.Clear();
            txt_NomeJogo.Clear();
            txt_Preco.Clear();
            txt_Quantidade.Clear();
            chk_Desconto.Checked = false;
            txt_ValorPagar.Clear();
        }

        //4. Ao clicar no Botão Valor a Pagar deve ser apresentado no respetivo campo o valor a pagar, tendo em conta o Preço, Quantidade e Desconto(caso esteja selecionado);
        private void button_Valor_Pagar_Click(object sender, EventArgs e)
        {
            try
            {
                decimal valortotal = Convert.ToDecimal(txt_Preco.Text) * Convert.ToDecimal(txt_Quantidade.Text);

                if (chk_Desconto.Checked)
                {
                    valortotal = valortotal - ((valortotal * 10) / 100);
                }
 
                txt_ValorPagar.Text = valortotal.ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Valores válidos. Erro: " + ex.Message);
            }

        }

        //5. O campo relativo à Categoria Selecionada deve apresentar o texto relativo à categoria que foi marcada.
        private void rb_Playstation_CheckedChanged(object sender, EventArgs e)
        {
            txt_Categoria.Text = rb_Playstation.Text;

        }

        //5. O campo relativo à Categoria Selecionada deve apresentar o texto relativo à categoria que foi marcada.
        private void rb_Xbox_CheckedChanged(object sender, EventArgs e)
        {
            txt_Categoria.Text = rb_Xbox.Text;
        }

        //5. O campo relativo à Categoria Selecionada deve apresentar o texto relativo à categoria que foi marcada.
        private void rb_wii_CheckedChanged(object sender, EventArgs e)
        {
            txt_Categoria.Text = rb_wii.Text;
        }
    }
}


    

