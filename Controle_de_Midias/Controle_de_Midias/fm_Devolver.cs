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

        GerenciadorDeBanco GBD = new GerenciadorDeBanco();

        private void lv_Amigos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lv_AmigosD.Dock = System.Windows.Forms.DockStyle.Right;
            lv_MidiasD.Dock = System.Windows.Forms.DockStyle.Right;


            lv_MidiasD.Visible = true;
            lv_AmigosD.Visible = false;

            gr_AmigoE.Visible = true;
        }

       
        private void fm_Devolver_Load(object sender, EventArgs e)
        {
            lv_AmigosD.Visible = true;
            lv_MidiasD.Visible = false;
            gr_AmigoE.Visible = false;
            GBD.AbrirConexao();
            
            GBD.PreecherLvAmigos(lv_AmigosD);
            GBD.PreencherLvMidias(lv_MidiasD);

            GBD.FecharConexao();
    
            lv_AmigosD.Dock = System.Windows.Forms.DockStyle.Fill;
            lv_MidiasD.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void bt_CancelarE_Click(object sender, EventArgs e)
        {
            fm_Devolver_Load(sender,e);
            //lv_MidiasD.Visible = false;
            //gr_AmigoE.Visible = false;
            //lv_AmigosD.Visible = true;
            //lv_AmigosD.Dock = System.Windows.Forms.DockStyle.Fill;
        }

    }
}
