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
        const string verificador = "fm_Emprestimo";
        GerenciadorDeBanco GBD = new GerenciadorDeBanco();
        List<string> DadosAmigos = new List<string>();
        List<string> DadosMidias;


        private void bt_Emprestar_Click(object sender, EventArgs e)
        {
            DadosMidias = new List<string>();

            foreach (ListViewItem Midia in lv_Midias.SelectedItems)
            {
                System.Media.SystemSounds.Asterisk.Play();
                Midia.ForeColor = System.Drawing.Color.ForestGreen;
                for (int i = 0; i < 9; ++i)
                    DadosMidias.Add(Midia.SubItems[i].Text);
            }
            GBD.AbrirConexao();

            GBD.EmprestarOuDevolverMidia(int.Parse(DadosAmigos[4]), DadosMidias, verificador);
  
            GBD.FecharConexao();
        }

        private void bt_CancelarE_Click(object sender, EventArgs e)
        {
            lv_AmigosE.Dock = System.Windows.Forms.DockStyle.Bottom;
            lv_AmigosE.Visible = true;
            lv_Midias.Visible = false;
            gr_AmigoE.Visible = false;
        }
        private void fm_Emprestimo_Load(object sender, EventArgs e)
        {
            gr_AmigoE.Visible = false;
            lv_AmigosE.Dock = System.Windows.Forms.DockStyle.Bottom;
            lv_Midias.Visible = false;
  

            DadosAmigos.Clear();

            GBD.AbrirConexao();
            GBD.PreecherLvAmigos(lv_AmigosE, "fm_Principal");
        
            GBD.PreencherLvMidias(lv_Midias, 0);

            GBD.FecharConexao();

        }

        private void tb_NomeEM_TextChanged(object sender, EventArgs e)
        {

        }

        private void lv_AmigosE_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            DadosAmigos.Clear();
            
            string nome= null, tel= null, email= null, obs= null;

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
            GBD.AbrirConexao();
            DadosAmigos = GBD.ProcurarAmigo(nome, tel, email, obs);
            GBD.FecharConexao();

            lb_nomeP.Text = DadosAmigos[0];
            lb_TelP.Text = DadosAmigos[1];
            lb_EmailP.Text = DadosAmigos[2];
            lb_ObsP.Text = DadosAmigos[3];
             
        }

        private void lv_AmigosE_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //perguntar ao Alvaro como declarar a varialvel dentro do método e ela iniciar com um valor somente no primeiro disparo
        int qtd_AnteriorCaracter = 0;
        List<ListViewItem> amigos = new List<ListViewItem>();

        fm_Principal principal = new fm_Principal();
        private void tb_PesquisaParcial_TextChanged(object sender, EventArgs e)
        {


        //    principal.PesquisaParcialAmigo(lv_AmigosE, sender.ToString(), qtd_AnteriorCaracter);
        //    qtd_AnteriorCaracter = tb_PesquisaParcial.Text.Count();
            //if (qtd_AnteriorCaracter > tb_PesquisaParcial.Text.Count())
            //{
            //    List<ListViewItem> lixeira = new List<ListViewItem>();
            //    foreach (ListViewItem item in amigos)
            //        if (item.Text.Contains(tb_PesquisaParcial.Text))
            //        {
            //            lv_AmigosE.Items.Add(item);
            //            lixeira.Add(item);
            //        }
            //    foreach (ListViewItem item in lixeira)
            //        amigos.Remove(item);
            //}
            //else
            //    foreach (ListViewItem item in lv_AmigosE.Items)
            //        if (!item.Text.Contains(tb_PesquisaParcial.Text))
            //        {
            //            amigos.Add(item);
            //            item.Remove();
            //        }

            //qtd_AnteriorCaracter = tb_PesquisaParcial.Text.Count();
           
        }
    }
}
