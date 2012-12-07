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
        const string formulario = "fm_Emprestimos";
        GerenciadorDeBanco GBD = new GerenciadorDeBanco();
        List<string> DadosAmigos = new List<string>();
        List<string> DadosMidias;


        private void bt_Emprestar_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lv_Midias.SelectedItems)
            {
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
                item.ForeColor = System.Drawing.Color.ForestGreen;
                verificador = true;
                GBD.AbrirConexao();
                GBD.EmprestarOuDevolverMidia(int.Parse(DadosAmigos[4]), DadosMidias, formulario);
                GBD.FecharConexao();
        
            }
           }

        private void bt_Voltar_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lv_Midias.SelectedItems)
                if (item.ForeColor == System.Drawing.Color.ForestGreen)
                    item.Remove();            
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

            GBD.PreecherLvAmigos(lv_AmigosE, formulario);
            
            GBD.PreencherLvMidias(lv_Midias,0);
            GBD.VerificarMidiasEmprestadas(lv_Midias);
        
            GBD.FecharConexao();

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
