﻿namespace Controle_de_Midias
{
    partial class fm_Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Vinil", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("K7", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("CD", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("DVD", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("Digital", System.Windows.Forms.HorizontalAlignment.Left);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_Devolver = new System.Windows.Forms.Button();
            this.bt_Emprestar = new System.Windows.Forms.Button();
            this.bt_Pesquisa = new System.Windows.Forms.Button();
            this.bt_NovoAmigo = new System.Windows.Forms.Button();
            this.bt_NovaMidia = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp_Midias = new System.Windows.Forms.TabPage();
            this.lv_Midias = new System.Windows.Forms.ListView();
            this.cl_Album = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_Interprete = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_Autor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_Música = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_Nota = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_DataAlbum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_DataCompra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_Origem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_Observacao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tp_Amigos = new System.Windows.Forms.TabPage();
            this.lv_Amigos = new System.Windows.Forms.ListView();
            this.cl_Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_Telefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_Obs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tp_Midias.SuspendLayout();
            this.tp_Amigos.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_Devolver);
            this.groupBox1.Controls.Add(this.bt_Emprestar);
            this.groupBox1.Controls.Add(this.bt_Pesquisa);
            this.groupBox1.Controls.Add(this.bt_NovoAmigo);
            this.groupBox1.Controls.Add(this.bt_NovaMidia);
            this.groupBox1.Location = new System.Drawing.Point(8, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(84, 438);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // bt_Devolver
            // 
            this.bt_Devolver.Location = new System.Drawing.Point(4, 177);
            this.bt_Devolver.Name = "bt_Devolver";
            this.bt_Devolver.Size = new System.Drawing.Size(75, 23);
            this.bt_Devolver.TabIndex = 4;
            this.bt_Devolver.Text = "&Devolver";
            this.bt_Devolver.UseVisualStyleBackColor = true;
            this.bt_Devolver.Click += new System.EventHandler(this.bt_Devolver_Click);
            // 
            // bt_Emprestar
            // 
            this.bt_Emprestar.Location = new System.Drawing.Point(4, 139);
            this.bt_Emprestar.Name = "bt_Emprestar";
            this.bt_Emprestar.Size = new System.Drawing.Size(75, 23);
            this.bt_Emprestar.TabIndex = 3;
            this.bt_Emprestar.Text = "&Emprestar";
            this.bt_Emprestar.UseVisualStyleBackColor = true;
            this.bt_Emprestar.Click += new System.EventHandler(this.bt_Emprestar_Click);
            // 
            // bt_Pesquisa
            // 
            this.bt_Pesquisa.Location = new System.Drawing.Point(3, 100);
            this.bt_Pesquisa.Name = "bt_Pesquisa";
            this.bt_Pesquisa.Size = new System.Drawing.Size(75, 23);
            this.bt_Pesquisa.TabIndex = 2;
            this.bt_Pesquisa.Text = "&Pesquisa";
            this.bt_Pesquisa.UseVisualStyleBackColor = true;
            // 
            // bt_NovoAmigo
            // 
            this.bt_NovoAmigo.Location = new System.Drawing.Point(3, 61);
            this.bt_NovoAmigo.Name = "bt_NovoAmigo";
            this.bt_NovoAmigo.Size = new System.Drawing.Size(75, 23);
            this.bt_NovoAmigo.TabIndex = 1;
            this.bt_NovoAmigo.Text = "Novo &Amigo";
            this.bt_NovoAmigo.UseVisualStyleBackColor = true;
            this.bt_NovoAmigo.Click += new System.EventHandler(this.bt_NovoAmigo_Click);
            // 
            // bt_NovaMidia
            // 
            this.bt_NovaMidia.Location = new System.Drawing.Point(4, 22);
            this.bt_NovaMidia.Name = "bt_NovaMidia";
            this.bt_NovaMidia.Size = new System.Drawing.Size(75, 23);
            this.bt_NovaMidia.TabIndex = 0;
            this.bt_NovaMidia.Text = "Nova &Mídia";
            this.bt_NovaMidia.UseVisualStyleBackColor = true;
            this.bt_NovaMidia.Click += new System.EventHandler(this.bt_NovaMidia_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp_Midias);
            this.tabControl1.Controls.Add(this.tp_Amigos);
            this.tabControl1.Location = new System.Drawing.Point(98, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1096, 438);
            this.tabControl1.TabIndex = 1;
            // 
            // tp_Midias
            // 
            this.tp_Midias.Controls.Add(this.lv_Midias);
            this.tp_Midias.Location = new System.Drawing.Point(4, 22);
            this.tp_Midias.Name = "tp_Midias";
            this.tp_Midias.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Midias.Size = new System.Drawing.Size(1088, 412);
            this.tp_Midias.TabIndex = 0;
            this.tp_Midias.Text = "Mídias";
            this.tp_Midias.UseVisualStyleBackColor = true;
            // 
            // lv_Midias
            // 
            this.lv_Midias.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cl_Album,
            this.cl_Interprete,
            this.cl_Autor,
            this.cl_Música,
            this.cl_Nota,
            this.cl_DataAlbum,
            this.cl_DataCompra,
            this.cl_Origem,
            this.cl_Observacao});
            listViewGroup1.Header = "Vinil";
            listViewGroup1.Name = "Gp_Vinil";
            listViewGroup2.Header = "K7";
            listViewGroup2.Name = "Gp_k7";
            listViewGroup3.Header = "CD";
            listViewGroup3.Name = "Gp_Cd";
            listViewGroup4.Header = "DVD";
            listViewGroup4.Name = "Gp_Dvd";
            listViewGroup5.Header = "Digital";
            listViewGroup5.Name = "Gp_Digital";
            this.lv_Midias.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4,
            listViewGroup5});
            this.lv_Midias.Location = new System.Drawing.Point(6, 17);
            this.lv_Midias.Name = "lv_Midias";
            this.lv_Midias.Size = new System.Drawing.Size(1056, 389);
            this.lv_Midias.TabIndex = 2;
            this.lv_Midias.UseCompatibleStateImageBehavior = false;
            this.lv_Midias.View = System.Windows.Forms.View.Details;
            this.lv_Midias.DoubleClick += new System.EventHandler(this.lv_Midias_DoubleClick);
            // 
            // cl_Album
            // 
            this.cl_Album.Text = "Álbum";
            this.cl_Album.Width = 80;
            // 
            // cl_Interprete
            // 
            this.cl_Interprete.Text = "Intérprete";
            this.cl_Interprete.Width = 91;
            // 
            // cl_Autor
            // 
            this.cl_Autor.DisplayIndex = 3;
            this.cl_Autor.Text = "Autor";
            this.cl_Autor.Width = 102;
            // 
            // cl_Música
            // 
            this.cl_Música.DisplayIndex = 4;
            this.cl_Música.Text = "Música";
            this.cl_Música.Width = 137;
            // 
            // cl_Nota
            // 
            this.cl_Nota.DisplayIndex = 5;
            this.cl_Nota.Text = "Nota";
            this.cl_Nota.Width = 117;
            // 
            // cl_DataAlbum
            // 
            this.cl_DataAlbum.DisplayIndex = 6;
            this.cl_DataAlbum.Text = "Data do Álbum";
            this.cl_DataAlbum.Width = 107;
            // 
            // cl_DataCompra
            // 
            this.cl_DataCompra.DisplayIndex = 7;
            this.cl_DataCompra.Text = "Data da Compra";
            this.cl_DataCompra.Width = 109;
            // 
            // cl_Origem
            // 
            this.cl_Origem.DisplayIndex = 2;
            this.cl_Origem.Text = "Origem";
            this.cl_Origem.Width = 94;
            // 
            // cl_Observacao
            // 
            this.cl_Observacao.Text = "Observação";
            this.cl_Observacao.Width = 116;
            // 
            // tp_Amigos
            // 
            this.tp_Amigos.Controls.Add(this.lv_Amigos);
            this.tp_Amigos.Location = new System.Drawing.Point(4, 22);
            this.tp_Amigos.Name = "tp_Amigos";
            this.tp_Amigos.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Amigos.Size = new System.Drawing.Size(1088, 412);
            this.tp_Amigos.TabIndex = 1;
            this.tp_Amigos.Text = "Amigos";
            this.tp_Amigos.UseVisualStyleBackColor = true;
            // 
            // lv_Amigos
            // 
            this.lv_Amigos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cl_Nome,
            this.cl_Telefone,
            this.cl_Email,
            this.cl_Obs});
            this.lv_Amigos.Location = new System.Drawing.Point(3, 29);
            this.lv_Amigos.Name = "lv_Amigos";
            this.lv_Amigos.Size = new System.Drawing.Size(1043, 366);
            this.lv_Amigos.TabIndex = 2;
            this.lv_Amigos.UseCompatibleStateImageBehavior = false;
            this.lv_Amigos.View = System.Windows.Forms.View.Details;
            this.lv_Amigos.DoubleClick += new System.EventHandler(this.lv_Amigos_DoubleClick);
            // 
            // cl_Nome
            // 
            this.cl_Nome.Text = "Nome";
            this.cl_Nome.Width = 247;
            // 
            // cl_Telefone
            // 
            this.cl_Telefone.Text = "Telefone";
            this.cl_Telefone.Width = 93;
            // 
            // cl_Email
            // 
            this.cl_Email.Text = "E-mail";
            this.cl_Email.Width = 265;
            // 
            // cl_Obs
            // 
            this.cl_Obs.Text = "Observação";
            this.cl_Obs.Width = 257;
            // 
            // fm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 462);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Name = "fm_Principal";
            this.Text = "Collectors medias";
            this.Load += new System.EventHandler(this.fm_Principal_Load);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tp_Midias.ResumeLayout(false);
            this.tp_Amigos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_Emprestar;
        private System.Windows.Forms.Button bt_Pesquisa;
        private System.Windows.Forms.Button bt_NovoAmigo;
        private System.Windows.Forms.Button bt_NovaMidia;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tp_Midias;
        private System.Windows.Forms.TabPage tp_Amigos;
        private System.Windows.Forms.Button bt_Devolver;
        private System.Windows.Forms.ListView lv_Amigos;
        private System.Windows.Forms.ColumnHeader cl_Nome;
        private System.Windows.Forms.ColumnHeader cl_Telefone;
        private System.Windows.Forms.ColumnHeader cl_Email;
        private System.Windows.Forms.ColumnHeader cl_Obs;
        private System.Windows.Forms.ListView lv_Midias;
        private System.Windows.Forms.ColumnHeader cl_Album;
        private System.Windows.Forms.ColumnHeader cl_Interprete;
        private System.Windows.Forms.ColumnHeader cl_Autor;
        private System.Windows.Forms.ColumnHeader cl_Música;
        private System.Windows.Forms.ColumnHeader cl_Nota;
        private System.Windows.Forms.ColumnHeader cl_DataAlbum;
        private System.Windows.Forms.ColumnHeader cl_DataCompra;
        private System.Windows.Forms.ColumnHeader cl_Origem;
        private System.Windows.Forms.ColumnHeader cl_Observacao;

    }
}

