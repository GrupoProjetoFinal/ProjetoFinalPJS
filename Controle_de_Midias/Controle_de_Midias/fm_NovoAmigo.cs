﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Controle_de_Midias
{
    public partial class fm_NovoAmigo : Form
    {
        ListView lvAmigo;
        public fm_NovoAmigo(ListView fmAmigoLista)
        {
            //Recebe a referencia do listView vinda do fm_pricipal e passa para o listview lvMidias
            lvAmigo = fmAmigoLista;
            InitializeComponent();
        }

        private void bt_Adicionar_Click(object sender, EventArgs e)
        {
            if (tb_Nome.Text == string.Empty)
            {
                lb_InfoUsuario.Visible = true;
                Erro.SetError(lb_InfoUsuario, "O campo nome é obrigatório");
                return;
            }

            // O conteúdo dos textBox são passados para o objeto Amigo.
            Amigo novoAmigo = new Amigo();
            novoAmigo.nome = tb_Nome.Text;
            novoAmigo.telefone = tb_Telefone.Text;
            novoAmigo.email = tb_Email.Text;
            novoAmigo.observacao = rtb_Observacao.Text;

            GerenciadorDeBanco GBD = new GerenciadorDeBanco();

            //verifica se a conecção foi aberta, se sim insere os dados
            if (GBD.AbrirConexao())
            {
                GBD.InserirAmigo(novoAmigo);
                GBD.FecharConexao();

                //Limpa os textBox
                bt_Limpar_Click(sender, e);
                //Adiciona a nova midia no ListView lvMidias.
                ListViewItem item;

                item = new ListViewItem(novoAmigo.nome);
                lvAmigo.Items.Add(item);
                item.SubItems.Add(novoAmigo.telefone);
                item.SubItems.Add(novoAmigo.email);
                item.SubItems.Add(novoAmigo.observacao);
                System.Media.SystemSounds.Asterisk.Play();
                
            }
            else
            {
                MessageBox.Show("Não foi possivel se conectar com o banco de dados.","Erro na conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void tb_Nome_Enter(object sender, EventArgs e)
        {
            lb_InfoUsuario.Visible = false;
        }

        private void bt_Limpar_Click(object sender, EventArgs e)
        {
            tb_Email.Clear();
            tb_Nome.Clear();
            tb_Telefone.Clear();
            rtb_Observacao.Clear();
        }

    }
}

