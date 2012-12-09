using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Controle_de_Midias
{
    public partial class fm_Emprestimo : Form
    {
        public fm_Emprestimo()
        {
            InitializeComponent();
        }

        public bool verificador = false;

        // caso lvAmigoVisivel for falso a pesquisa parcial sera feita no listview Midia
        private bool lvAmigoVisivel = true;

        //essa constante é passada por paramentro para o método na classe GBD assim verifica qual ação deve ser tomada
        const string formulario = "fm_Emprestimos";

        int qtd_AnteriorCaracter = 0;

        GerenciadorDeBanco GBD = new GerenciadorDeBanco();
        List<string> DadosAmigos = new List<string>();
        List<string> DadosMidias;


        private void bt_Emprestar_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lv_Midias.SelectedItems)
            {
                if (GBD.AbrirConexao())
                {
                    GBD.EmprestarOuDevolverMidia(int.Parse(DadosAmigos[4]), DadosMidias, formulario);
                    GBD.FecharConexao();

                    DadosMidias = new List<string>();
                    if (item.ForeColor == System.Drawing.Color.ForestGreen)
                    {
                        item.Remove();
                        lb_MidiaEmprestada.Visible = true;
                        return;
                    }

                    for (int i = 0; i < 9; ++i)
                        DadosMidias.Add(item.SubItems[i].Text);

                    System.Media.SystemSounds.Asterisk.Play();
                    lb_MidiaEmprestada.Visible = false;
                    lb_SelecioneMidia.Visible = false;
                    item.ForeColor = System.Drawing.Color.ForestGreen;
                    verificador = true;
                }
                else
                    GBD.MensagemDeErro();
            }
           }

        private void bt_Voltar_Click(object sender, EventArgs e)
        {
            // como a midia emprestada não esta masi disponivel ela é removida do listview
            foreach (ListViewItem item in lv_Midias.SelectedItems)
                if (item.ForeColor == System.Drawing.Color.ForestGreen)
                    item.Remove();            
            lv_AmigosE.Dock = System.Windows.Forms.DockStyle.Bottom;
            lv_AmigosE.Visible = true;
            lv_Midias.Visible = false;
            gr_AmigoE.Visible = false;
            lvAmigoVisivel = true;
            tb_PesquisaParcial.Text = string.Empty;
        }

        private void fm_Emprestimo_Load(object sender, EventArgs e)
        {
            gr_AmigoE.Visible = false;
            lv_AmigosE.Dock = System.Windows.Forms.DockStyle.Bottom;
            lv_Midias.Visible = false;
  

            DadosAmigos.Clear();

            if (GBD.AbrirConexao())
            {
                GBD.PreecherLvAmigos(lv_AmigosE, formulario);
                GBD.PreencherLvMidias(lv_Midias, 0);
                GBD.VerificarMidiasEmprestadas(lv_Midias);
                GBD.FecharConexao();
            }
            else
                GBD.MensagemDeErro();
        }

        private void lv_AmigosE_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tb_PesquisaParcial.Text = string.Empty;
            lvAmigoVisivel = false;
            DadosAmigos.Clear();
            
            string nome= string.Empty, tel= string.Empty, email= string.Empty, obs= string.Empty;

            foreach (ListViewItem item in lv_AmigosE.SelectedItems)
            {
                nome = item.SubItems[0].Text;
                tel = item.SubItems[1].Text;
                email = item.SubItems[2].Text;
                obs = item.SubItems[3].Text;
            }
            lv_AmigosE.Visible = false;
            lv_Midias.Visible = true;
            gr_AmigoE.Visible = true;
            if (GBD.AbrirConexao())
            {
                DadosAmigos = GBD.ProcurarAmigo(nome, tel, email, obs);
                GBD.FecharConexao();
            }
            else
                GBD.MensagemDeErro();

            lb_nomeP.Text = DadosAmigos[0];
            lb_TelP.Text = DadosAmigos[1];
            lb_EmailP.Text = DadosAmigos[2];
            lb_ObsP.Text = DadosAmigos[3];
             
        }

        private void tb_PesquisaParcial_TextChanged(object sender, EventArgs e)
        {
            if (lvAmigoVisivel)
                qtd_AnteriorCaracter = GBD.PesquisaParcialAmigo(lv_AmigosE, tb_PesquisaParcial.Text, qtd_AnteriorCaracter);
            else
                qtd_AnteriorCaracter = GBD.PesquisaParcialMidia(lv_Midias, tb_PesquisaParcial.Text, qtd_AnteriorCaracter);
        }

      
    }
}
