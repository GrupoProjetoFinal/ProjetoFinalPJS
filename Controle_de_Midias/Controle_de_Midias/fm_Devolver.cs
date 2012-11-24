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

        Amigo amigo = new Amigo();
        GerenciadorDeBanco GBD = new GerenciadorDeBanco();

        private void lv_Amigos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //O listView Midias volta ao seu tamanho original a direita e fica visivel 
            lv_MidiasD.Dock = System.Windows.Forms.DockStyle.Right;
            lv_MidiasD.Visible = true;
            lv_AmigosD.Visible = false;
            gr_AmigoE.Visible = true;

            foreach (ListViewItem item in lv_AmigosD.SelectedItems)
            {
                lb_nomeD.Text    = item.SubItems[0].Text;
                amigo.nome       = item.SubItems[0].Text;
                lb_TelD.Text     = item.SubItems[1].Text;
                amigo.telefone   = item.SubItems[1].Text;
                lb_EmailD.Text   = item.SubItems[2].Text;
                amigo.email      = item.SubItems[2].Text;
                lb_ObsD.Text     = item.SubItems[3].Text;
                amigo.observacao = item.SubItems[3].Text;
            }

            GBD.AbrirConexao();
            int idAmigo = GBD.ProcurarAmigo(amigo);
            lv_MidiasD.Items.Clear();
            GBD.PreencherLvMidias(lv_MidiasD, idAmigo);
            GBD.FecharConexao();
        }

       
        private void fm_Devolver_Load(object sender, EventArgs e)
        {
            lv_AmigosD.Visible = true;
            lv_MidiasD.Visible = false;
            gr_AmigoE.Visible = false;


            if (lv_AmigosD.Items.Count == 0)
            {
                GBD.AbrirConexao();
                GBD.PreecherLvAmigos(lv_AmigosD, "fm_Devolver");
                GBD.FecharConexao();
            }
            
            //Maximiza listView
            lv_AmigosD.Dock = System.Windows.Forms.DockStyle.Fill;
            lv_MidiasD.Dock = System.Windows.Forms.DockStyle.Fill;
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


    }
}
