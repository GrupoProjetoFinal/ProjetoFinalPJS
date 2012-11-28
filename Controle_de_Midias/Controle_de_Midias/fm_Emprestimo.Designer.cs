namespace Controle_de_Midias
{
    partial class fm_Emprestimo
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Vinil", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("K7", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("CD", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("DVD", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("Digital", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fm_Emprestimo));
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
            this.lb_Nome = new System.Windows.Forms.Label();
            this.tb_NomeEM = new System.Windows.Forms.TextBox();
            this.gr_Amigo = new System.Windows.Forms.GroupBox();
            this.bt_Procurar = new System.Windows.Forms.Button();
            this.pn_Emprestar = new System.Windows.Forms.Panel();
            this.pn_Principal = new System.Windows.Forms.Panel();
            this.gr_AmigoE = new System.Windows.Forms.GroupBox();
            this.lb_ObsP = new System.Windows.Forms.Label();
            this.bt_CancelarE = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_Emprestar = new System.Windows.Forms.Button();
            this.lb_EmailP = new System.Windows.Forms.Label();
            this.lb_nomeP = new System.Windows.Forms.Label();
            this.lb_TelP = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.img_Sucesso = new System.Windows.Forms.Panel();
            this.img_erro = new System.Windows.Forms.Panel();
            this.gr_Amigo.SuspendLayout();
            this.pn_Emprestar.SuspendLayout();
            this.pn_Principal.SuspendLayout();
            this.gr_AmigoE.SuspendLayout();
            this.img_Sucesso.SuspendLayout();
            this.SuspendLayout();
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
            this.lv_Midias.Location = new System.Drawing.Point(260, 0);
            this.lv_Midias.Name = "lv_Midias";
            this.lv_Midias.Size = new System.Drawing.Size(1002, 389);
            this.lv_Midias.TabIndex = 1;
            this.lv_Midias.UseCompatibleStateImageBehavior = false;
            this.lv_Midias.View = System.Windows.Forms.View.Details;
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
            // lb_Nome
            // 
            this.lb_Nome.AutoSize = true;
            this.lb_Nome.Location = new System.Drawing.Point(6, 31);
            this.lb_Nome.Name = "lb_Nome";
            this.lb_Nome.Size = new System.Drawing.Size(35, 13);
            this.lb_Nome.TabIndex = 3;
            this.lb_Nome.Text = "Nome";
            // 
            // tb_NomeEM
            // 
            this.tb_NomeEM.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tb_NomeEM.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tb_NomeEM.Location = new System.Drawing.Point(9, 62);
            this.tb_NomeEM.Name = "tb_NomeEM";
            this.tb_NomeEM.Size = new System.Drawing.Size(218, 20);
            this.tb_NomeEM.TabIndex = 5;
            this.tb_NomeEM.TextChanged += new System.EventHandler(this.tb_NomeEM_TextChanged);
            // 
            // gr_Amigo
            // 
            this.gr_Amigo.Controls.Add(this.bt_Procurar);
            this.gr_Amigo.Controls.Add(this.lb_Nome);
            this.gr_Amigo.Controls.Add(this.tb_NomeEM);
            this.gr_Amigo.Location = new System.Drawing.Point(5, 3);
            this.gr_Amigo.Name = "gr_Amigo";
            this.gr_Amigo.Size = new System.Drawing.Size(246, 378);
            this.gr_Amigo.TabIndex = 10;
            this.gr_Amigo.TabStop = false;
            this.gr_Amigo.Text = "Amigo";
            // 
            // bt_Procurar
            // 
            this.bt_Procurar.Location = new System.Drawing.Point(149, 141);
            this.bt_Procurar.Name = "bt_Procurar";
            this.bt_Procurar.Size = new System.Drawing.Size(75, 23);
            this.bt_Procurar.TabIndex = 10;
            this.bt_Procurar.Text = "&Procurar";
            this.bt_Procurar.UseVisualStyleBackColor = true;
            this.bt_Procurar.Click += new System.EventHandler(this.bt_Procurar_Click_1);
            // 
            // pn_Emprestar
            // 
            this.pn_Emprestar.Controls.Add(this.pn_Principal);
            this.pn_Emprestar.Controls.Add(this.gr_AmigoE);
            this.pn_Emprestar.Location = new System.Drawing.Point(0, -6);
            this.pn_Emprestar.Name = "pn_Emprestar";
            this.pn_Emprestar.Size = new System.Drawing.Size(253, 381);
            this.pn_Emprestar.TabIndex = 12;
            // 
            // pn_Principal
            // 
            this.pn_Principal.Controls.Add(this.gr_Amigo);
            this.pn_Principal.Location = new System.Drawing.Point(3, 8);
            this.pn_Principal.Name = "pn_Principal";
            this.pn_Principal.Size = new System.Drawing.Size(254, 387);
            this.pn_Principal.TabIndex = 13;
            // 
            // gr_AmigoE
            // 
            this.gr_AmigoE.Controls.Add(this.img_Sucesso);
            this.gr_AmigoE.Controls.Add(this.lb_ObsP);
            this.gr_AmigoE.Controls.Add(this.bt_CancelarE);
            this.gr_AmigoE.Controls.Add(this.label5);
            this.gr_AmigoE.Controls.Add(this.bt_Emprestar);
            this.gr_AmigoE.Controls.Add(this.lb_EmailP);
            this.gr_AmigoE.Controls.Add(this.lb_nomeP);
            this.gr_AmigoE.Controls.Add(this.lb_TelP);
            this.gr_AmigoE.Location = new System.Drawing.Point(8, 8);
            this.gr_AmigoE.Name = "gr_AmigoE";
            this.gr_AmigoE.Size = new System.Drawing.Size(240, 378);
            this.gr_AmigoE.TabIndex = 10;
            this.gr_AmigoE.TabStop = false;
            this.gr_AmigoE.Text = "Amigo";
            // 
            // lb_ObsP
            // 
            this.lb_ObsP.AutoSize = true;
            this.lb_ObsP.Location = new System.Drawing.Point(8, 144);
            this.lb_ObsP.Name = "lb_ObsP";
            this.lb_ObsP.Size = new System.Drawing.Size(0, 13);
            this.lb_ObsP.TabIndex = 13;
            // 
            // bt_CancelarE
            // 
            this.bt_CancelarE.Location = new System.Drawing.Point(72, 281);
            this.bt_CancelarE.Name = "bt_CancelarE";
            this.bt_CancelarE.Size = new System.Drawing.Size(75, 23);
            this.bt_CancelarE.TabIndex = 12;
            this.bt_CancelarE.Text = "&Cancelar";
            this.bt_CancelarE.UseVisualStyleBackColor = true;
            this.bt_CancelarE.Click += new System.EventHandler(this.bt_CancelarE_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Oberservações";
            // 
            // bt_Emprestar
            // 
            this.bt_Emprestar.Location = new System.Drawing.Point(153, 281);
            this.bt_Emprestar.Name = "bt_Emprestar";
            this.bt_Emprestar.Size = new System.Drawing.Size(75, 23);
            this.bt_Emprestar.TabIndex = 10;
            this.bt_Emprestar.Text = "&Emprestar";
            this.bt_Emprestar.UseVisualStyleBackColor = true;
            this.bt_Emprestar.Click += new System.EventHandler(this.bt_Emprestar_Click);
            // 
            // lb_EmailP
            // 
            this.lb_EmailP.AutoSize = true;
            this.lb_EmailP.Location = new System.Drawing.Point(6, 65);
            this.lb_EmailP.Name = "lb_EmailP";
            this.lb_EmailP.Size = new System.Drawing.Size(87, 13);
            this.lb_EmailP.TabIndex = 6;
            this.lb_EmailP.Text = "Não possui email";
            // 
            // lb_nomeP
            // 
            this.lb_nomeP.AutoSize = true;
            this.lb_nomeP.Location = new System.Drawing.Point(6, 42);
            this.lb_nomeP.Name = "lb_nomeP";
            this.lb_nomeP.Size = new System.Drawing.Size(0, 13);
            this.lb_nomeP.TabIndex = 3;
            // 
            // lb_TelP
            // 
            this.lb_TelP.AutoSize = true;
            this.lb_TelP.Location = new System.Drawing.Point(6, 88);
            this.lb_TelP.Name = "lb_TelP";
            this.lb_TelP.Size = new System.Drawing.Size(101, 13);
            this.lb_TelP.TabIndex = 8;
            this.lb_TelP.Text = "Não possui telefone";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "VistoVerde.gif");
            // 
            // img_Sucesso
            // 
            this.img_Sucesso.BackgroundImage = global::Controle_de_Midias.Properties.Resources.VistoVerde;
            this.img_Sucesso.Controls.Add(this.img_erro);
            this.img_Sucesso.Location = new System.Drawing.Point(202, 254);
            this.img_Sucesso.Name = "img_Sucesso";
            this.img_Sucesso.Size = new System.Drawing.Size(26, 21);
            this.img_Sucesso.TabIndex = 11;
            // 
            // img_erro
            // 
            this.img_erro.BackgroundImage = global::Controle_de_Midias.Properties.Resources.x_vermelho;
            this.img_erro.Location = new System.Drawing.Point(3, 0);
            this.img_erro.Name = "img_erro";
            this.img_erro.Size = new System.Drawing.Size(19, 19);
            this.img_erro.TabIndex = 12;
            // 
            // fm_Emprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 387);
            this.Controls.Add(this.pn_Emprestar);
            this.Controls.Add(this.lv_Midias);
            this.Name = "fm_Emprestimo";
            this.Text = "Emprestar Midia";
            this.Load += new System.EventHandler(this.fm_Emprestimo_Load);
            this.gr_Amigo.ResumeLayout(false);
            this.gr_Amigo.PerformLayout();
            this.pn_Emprestar.ResumeLayout(false);
            this.pn_Principal.ResumeLayout(false);
            this.gr_AmigoE.ResumeLayout(false);
            this.gr_AmigoE.PerformLayout();
            this.img_Sucesso.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv_Midias;
        private System.Windows.Forms.ColumnHeader cl_Album;
        private System.Windows.Forms.ColumnHeader cl_Interprete;
        private System.Windows.Forms.ColumnHeader cl_Origem;
        private System.Windows.Forms.ColumnHeader cl_Autor;
        private System.Windows.Forms.ColumnHeader cl_Música;
        private System.Windows.Forms.ColumnHeader cl_Nota;
        private System.Windows.Forms.ColumnHeader cl_DataAlbum;
        private System.Windows.Forms.ColumnHeader cl_DataCompra;
        private System.Windows.Forms.ColumnHeader cl_Observacao;
        private System.Windows.Forms.Label lb_Nome;
        private System.Windows.Forms.TextBox tb_NomeEM;
        private System.Windows.Forms.GroupBox gr_Amigo;
        private System.Windows.Forms.Button bt_Procurar;
        private System.Windows.Forms.Panel pn_Emprestar;
        private System.Windows.Forms.GroupBox gr_AmigoE;
        private System.Windows.Forms.Label lb_ObsP;
        private System.Windows.Forms.Button bt_CancelarE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_Emprestar;
        private System.Windows.Forms.Label lb_EmailP;
        private System.Windows.Forms.Label lb_nomeP;
        private System.Windows.Forms.Label lb_TelP;
        private System.Windows.Forms.Panel pn_Principal;
        private System.Windows.Forms.Panel img_erro;
        private System.Windows.Forms.Panel img_Sucesso;
        private System.Windows.Forms.ImageList imageList1;
    }
}