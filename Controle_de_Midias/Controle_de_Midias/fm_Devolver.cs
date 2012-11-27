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
    public partial class fm_Devolver : Form
    {
        public fm_Devolver()
        {
            InitializeComponent();
        }
        const string frm = "fm_Devolver";
        private int idAmigo;
        Amigo amigo = new Amigo();
        List<string> DadosMidia = new List<string>();
        GerenciadorDeBanco GBD = new GerenciadorDeBanco();
       
        private void fm_Devolver_Load(object sender, EventArgs e)
        {
            lv_AmigosD.Visible = true;
            lv_MidiasD.Visible = false;
            gr_AmigoE.Visible = false;

            //                                           VAI TER QUE ARRUMAR ISSO QUANDO EMPRESTA UMA MIDIA O COUNT DO LV_AMIGOS PODE SER > 1
            //                                           ASSIM NAUM IRA ATUALIZA-LO
            if (lv_AmigosD.Items.Count == 0)
            {
                GBD.AbrirConexao();
                GBD.PreecherLvAmigos(lv_AmigosD, frm);
                GBD.FecharConexao();
            }
            
            //Maximiza listView
            lv_AmigosD.Dock = System.Windows.Forms.DockStyle.Fill;
            lv_MidiasD.Dock = System.Windows.Forms.DockStyle.Fill;
            lv_AmigosD.SelectedItems.Clear();
        }

        private void bt_CancelarE_Click(object sender, EventArgs e)
        {
            lv_AmigosD.Visible = true;
            lv_MidiasD.Visible = false;
            gr_AmigoE.Visible = false;

            //Maximiza listView
            lv_AmigosD.Dock = System.Windows.Forms.DockStyle.Fill;
            lv_MidiasD.Dock = System.Windows.Forms.DockStyle.Fill;
            
        }

        private void bt_Devolver_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lv_MidiasD.SelectedItems)
                for (int i = 0; i < 9;++i )
                    DadosMidia.Add(item.SubItems[i].Text);

            GBD.AbrirConexao();
            GBD.EmprestarOuDevolverMidia(idAmigo, DadosMidia, null);
            GBD.FecharConexao();
        }

        private void lv_AmigosD_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //O listView Midias volta ao seu tamanho original a direita e fica visivel 
            lv_MidiasD.Dock = System.Windows.Forms.DockStyle.Right;
            lv_MidiasD.Visible = true;
            lv_AmigosD.Visible = false;
            gr_AmigoE.Visible = true;

            foreach (ListViewItem item in lv_AmigosD.SelectedItems)
            {
                lb_nomeD.Text = item.SubItems[0].Text;
                amigo.nome = item.SubItems[0].Text;
                lb_TelD.Text = item.SubItems[1].Text;
                amigo.telefone = item.SubItems[1].Text;
                lb_EmailD.Text = item.SubItems[2].Text;
                amigo.email = item.SubItems[2].Text;
                lb_ObsD.Text = item.SubItems[3].Text;
                amigo.observacao = item.SubItems[3].Text;
            }

            GBD.AbrirConexao();
            idAmigo = GBD.ProcurarAmigo(amigo);
            lv_MidiasD.Items.Clear();
            GBD.PreencherLvMidias(lv_MidiasD, idAmigo);
            GBD.FecharConexao();
        }

    


    }
}
