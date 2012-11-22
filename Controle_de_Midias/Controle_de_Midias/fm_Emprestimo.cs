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

        GerenciadorDeBanco GBD = new GerenciadorDeBanco();
        List<string> DadosAmigos = new List<string>();
        List<string> DadosMidias = new List<string>();


        private void bt_Emprestar_Click(object sender, EventArgs e)
        {
            DadosMidias.Clear();

            foreach (ListViewItem Midia in lv_Midias.SelectedItems)
                for(int i = 0;i < 9; ++i)
                    DadosMidias.Add(Midia.SubItems[i].Text);
            GBD.AbrirConexao();

            GBD.EmprestarMidia(DadosAmigos[4], DadosMidias);

            GBD.FecharConexao();
        }

        private void bt_CancelarE_Click(object sender, EventArgs e)
        {
            pn_Principal.Visible = true;
        }

        private void bt_Procurar_Click_1(object sender, EventArgs e)
        {
            DadosAmigos.Clear();
            
            string nome = tb_NomeEM.Text;

            if (GBD.AbrirConexao())
            {
                DadosAmigos = GBD.ProcuarAmigo(nome);

                GBD.FecharConexao();

                if (DadosAmigos.Count == 0)
                    tb_NomeEM.Text = "Pesquisa não encontrada";
                else
                {
                    lb_nomeP.Text = DadosAmigos[0];
                    lb_TelP.Text = DadosAmigos[1];
                    lb_EmailP.Text = DadosAmigos[2];
                    lb_ObsP.Text = DadosAmigos[3];
                    pn_Principal.Visible = false;
                }

            }
            else
                MessageBox.Show("Houve um erro ao conectar ao banco de dados","ERRO", MessageBoxButtons.OK,MessageBoxIcon.Error);    
        }

        private void fm_Emprestimo_Load(object sender, EventArgs e)
        {
            DadosAmigos.Clear();

            GBD.AbrirConexao();

            DadosAmigos = GBD.ColetarNomes();

            GBD.PreencherLvMidias(lv_Midias);

            GBD.FecharConexao();

            foreach(string nome in DadosAmigos)
                tb_NomeEM.AutoCompleteCustomSource.Add(nome);
        }

    }
}
