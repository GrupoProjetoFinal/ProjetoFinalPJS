using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Controle_de_Midias
{
    public partial class Devolver : Form
    {
        public Devolver()
        {
            InitializeComponent();
        }

        //caso LvVazio for verdadeiro o botão DEVOLVER no fm_principal sera desabilitado
        public bool LvVazio = false;
        //essa constante é passada por paramentro para o método na classe GBD assim verifica qual ação deve ser tomada
        const string formulario = "fm_Devolver";
        private int idAmigo;
        Amigo amigo = new Amigo();
        List<string> dadosMidia;
        List<string> dadosAmigos;
        GerenciadorDeBanco GBD = new GerenciadorDeBanco();
       
        private void fm_Devolver_Load(object sender, EventArgs e)
        {
            lv_AmigosD.Visible = true;
            lv_MidiasD.Visible = false;
            gr_AmigoE.Visible = false;

            if (GBD.AbrirConexao())
            {
                GBD.PreecherLvAmigos(lv_AmigosD, formulario);
                GBD.FecharConexao();

                //Maximiza listView
                lv_AmigosD.Dock = System.Windows.Forms.DockStyle.Fill;
                lv_AmigosD.SelectedItems.Clear();
            }
            else
                GBD.MensagemDeErro();
        }

        private void bt_CancelarE_Click(object sender, EventArgs e)
        {
            lv_AmigosD.Visible = true;
            lv_MidiasD.Visible = false;
            gr_AmigoE.Visible = false;

            //Maximiza listView
            lv_AmigosD.Dock = System.Windows.Forms.DockStyle.Fill;
            
        }

        private void bt_Devolver_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lv_MidiasD.SelectedItems)
            {
                dadosMidia = new List<string>();
                
                dadosMidia.Add(GBD.RetiraIcone(item.SubItems[0].Text));
                for (int i = 1; i < 9; ++i)
                    dadosMidia.Add(item.SubItems[i].Text);
                
                GBD.AbrirConexao();
                GBD.EmprestarOuDevolverMidia(idAmigo, dadosMidia, null);
                GBD.FecharConexao();

                item.Remove();
                System.Media.SystemSounds.Asterisk.Play();
            }

            //Se lv_MidiasD estiver vazio apaga amigo do lv_AmigosD, pois ele não possui midia emprestado 
            if (lv_MidiasD.Items.Count == 0)
                foreach (ListViewItem item in lv_AmigosD.SelectedItems)
                    item.Remove();


            if (lv_MidiasD.Items.Count == 0)
            {
                lv_AmigosD.Items.Clear();
                fm_Devolver_Load(null, null);
            }

            if (lv_AmigosD.Items.Count == 0)
            {
                LvVazio = true;
                Close();
            }
        }

        //Quando esse evento for disparado o Listview Midias e preenchido coma as Midias emprestadas pelo amigo selecionado.
        private void lv_AmigosD_MouseDoubleClick(object sender, MouseEventArgs e)
        {
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

            if (GBD.AbrirConexao())
            {
                dadosAmigos = new List<string>();
                dadosAmigos = GBD.ProcurarAmigo(amigo.nome,amigo.telefone, amigo.email, amigo.observacao);
                idAmigo = GBD.PegarIdentificadorAmigo(amigo);
                lv_MidiasD.Items.Clear();
                GBD.PreencherLvMidias(lv_MidiasD, idAmigo);
                GBD.FecharConexao();
                if (dadosAmigos[5] == string.Empty)
                    dadosAmigos[5] = Application.StartupPath.ToString() + "\\FotosAmigos\\Desconhecido.png";
                
                if(File.Exists(dadosAmigos[5]))
                    pb_Amigo.Image = new Bitmap(dadosAmigos[5]);
                else
                    pb_Amigo.Image = new Bitmap(Application.StartupPath.ToString() + "\\FotosAmigos\\Desconhecido.png");
            }
            else
                GBD.MensagemDeErro();


        }
    }
}
