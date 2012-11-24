﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Controle_de_Midias
{
    public partial class fm_NovoAmigo : Form
    {
        public fm_NovoAmigo()
        {
            InitializeComponent();
        }

        private void bt_Adicionar_Click(object sender, EventArgs e)
        {
            // O conteúdo dos textBox são parrados para o objeto Amigo.
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
                tb_Nome.Clear();
                tb_Telefone.Clear();
                tb_Email.Clear();
                rtb_Observacao.Clear();
            }
            else
            {
                MessageBox.Show("Não foi possivel se conectar com o banco de dados.","Erro na conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

