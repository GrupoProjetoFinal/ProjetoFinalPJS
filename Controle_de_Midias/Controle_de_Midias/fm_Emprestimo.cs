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



        private void bt_Emprestar_Click(object sender, EventArgs e)
        {

        }

        private void bt_CancelarE_Click(object sender, EventArgs e)
        {
            pn_Principal.Visible = true;
        }

        private void bt_Procurar_Click_1(object sender, EventArgs e)
        {
            List<string> dadosAmigo = new List<string>();
            string nome = tb_NomeEM.Text;

            if (GBD.AbrirConexao())
            {
                //dadosAmigo = GBD.ProcurarAmigo(nome,email,tel);

                //lb_Nome.Text = dadosAmigo[0];
                //lb_tel.Text = dadosAmigo[1];
                //lb_
            }
            else
            {
                MessageBox.Show("Houve um erro ao conectar ao banco de dados","ERRO", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            pn_Principal.Visible = false;
        }

        private void fm_Emprestimo_Load(object sender, EventArgs e)
        {
            List<string> NomesAmigos = new List<string>();
            GBD.AbrirConexao();

            NomesAmigos = GBD.ColetarNomes();

            GBD.FecharConexao();

            foreach(string nome in NomesAmigos)
            {
                tb_NomeEM.AutoCompleteCustomSource.Add(nome);
            }
        }

        private void gr_Amigo_Enter(object sender, EventArgs e)
        {

        }
    }
}
