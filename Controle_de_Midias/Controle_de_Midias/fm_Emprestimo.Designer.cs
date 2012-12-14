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
            System.Windows.Forms.ListViewGroup listViewGroup11 = new System.Windows.Forms.ListViewGroup("Vinil", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup12 = new System.Windows.Forms.ListViewGroup("K7", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup13 = new System.Windows.Forms.ListViewGroup("CD", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup14 = new System.Windows.Forms.ListViewGroup("DVD", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup15 = new System.Windows.Forms.ListViewGroup("Digital", System.Windows.Forms.HorizontalAlignment.Left);
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
            this.gr_AmigoE = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pb_Amigo = new System.Windows.Forms.PictureBox();
            this.lb_MidiaEmprestada = new System.Windows.Forms.Label();
            this.lb_SelecioneMidia = new System.Windows.Forms.Label();
            this.lb_ObsP = new System.Windows.Forms.Label();
            this.bt_Voltar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_Emprestar = new System.Windows.Forms.Button();
            this.lb_EmailP = new System.Windows.Forms.Label();
            this.lb_nomeP = new System.Windows.Forms.Label();
            this.lb_TelP = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tb_PesquisaParcial = new System.Windows.Forms.TextBox();
            this.img_Sucesso = new System.Windows.Forms.Panel();
            this.lv_AmigosE = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gr_AmigoE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Amigo)).BeginInit();
            this.SuspendLayout();
            // 
            // lv_Midias
            // 
            this.lv_Midias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
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
            this.lv_Midias.FullRowSelect = true;
            listViewGroup11.Header = "Vinil";
            listViewGroup11.Name = "Gp_Vinil";
            listViewGroup12.Header = "K7";
            listViewGroup12.Name = "Gp_k7";
            listViewGroup13.Header = "CD";
            listViewGroup13.Name = "Gp_Cd";
            listViewGroup14.Header = "DVD";
            listViewGroup14.Name = "Gp_Dvd";
            listViewGroup15.Header = "Digital";
            listViewGroup15.Name = "Gp_Digital";
            this.lv_Midias.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup11,
            listViewGroup12,
            listViewGroup13,
            listViewGroup14,
            listViewGroup15});
            this.lv_Midias.Location = new System.Drawing.Point(254, 26);
            this.lv_Midias.Name = "lv_Midias";
            this.lv_Midias.Size = new System.Drawing.Size(628, 389);
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
            // gr_AmigoE
            // 
            this.gr_AmigoE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.gr_AmigoE.BackColor = System.Drawing.SystemColors.Window;
            this.gr_AmigoE.Controls.Add(this.panel2);
            this.gr_AmigoE.Controls.Add(this.pb_Amigo);
            this.gr_AmigoE.Controls.Add(this.lb_MidiaEmprestada);
            this.gr_AmigoE.Controls.Add(this.lb_SelecioneMidia);
            this.gr_AmigoE.Controls.Add(this.lb_ObsP);
            this.gr_AmigoE.Controls.Add(this.bt_Voltar);
            this.gr_AmigoE.Controls.Add(this.label5);
            this.gr_AmigoE.Controls.Add(this.bt_Emprestar);
            this.gr_AmigoE.Controls.Add(this.lb_EmailP);
            this.gr_AmigoE.Controls.Add(this.lb_nomeP);
            this.gr_AmigoE.Controls.Add(this.lb_TelP);
            this.gr_AmigoE.Location = new System.Drawing.Point(12, 4);
            this.gr_AmigoE.Name = "gr_AmigoE";
            this.gr_AmigoE.Size = new System.Drawing.Size(236, 411);
            this.gr_AmigoE.TabIndex = 10;
            this.gr_AmigoE.TabStop = false;
            this.gr_AmigoE.Text = "Amigo";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackgroundImage = global::Controle_de_Midias.Properties.Resources.musica1;
            this.panel2.Location = new System.Drawing.Point(6, 368);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(33, 37);
            this.panel2.TabIndex = 21;
            // 
            // pb_Amigo
            // 
            this.pb_Amigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_Amigo.Location = new System.Drawing.Point(102, 19);
            this.pb_Amigo.Name = "pb_Amigo";
            this.pb_Amigo.Size = new System.Drawing.Size(123, 131);
            this.pb_Amigo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Amigo.TabIndex = 20;
            this.pb_Amigo.TabStop = false;
            // 
            // lb_MidiaEmprestada
            // 
            this.lb_MidiaEmprestada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_MidiaEmprestada.AutoSize = true;
            this.lb_MidiaEmprestada.ForeColor = System.Drawing.Color.Red;
            this.lb_MidiaEmprestada.Location = new System.Drawing.Point(84, 381);
            this.lb_MidiaEmprestada.Name = "lb_MidiaEmprestada";
            this.lb_MidiaEmprestada.Size = new System.Drawing.Size(158, 13);
            this.lb_MidiaEmprestada.TabIndex = 18;
            this.lb_MidiaEmprestada.Text = "✘Essa midia ja foi emprestada !";
            this.lb_MidiaEmprestada.Visible = false;
            // 
            // lb_SelecioneMidia
            // 
            this.lb_SelecioneMidia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_SelecioneMidia.AutoSize = true;
            this.lb_SelecioneMidia.ForeColor = System.Drawing.Color.Red;
            this.lb_SelecioneMidia.Location = new System.Drawing.Point(84, 368);
            this.lb_SelecioneMidia.Name = "lb_SelecioneMidia";
            this.lb_SelecioneMidia.Size = new System.Drawing.Size(123, 13);
            this.lb_SelecioneMidia.TabIndex = 17;
            this.lb_SelecioneMidia.Text = "✘Selecione uma Midia !";
            this.lb_SelecioneMidia.Visible = false;
            // 
            // lb_ObsP
            // 
            this.lb_ObsP.AutoSize = true;
            this.lb_ObsP.Location = new System.Drawing.Point(8, 254);
            this.lb_ObsP.Name = "lb_ObsP";
            this.lb_ObsP.Size = new System.Drawing.Size(0, 13);
            this.lb_ObsP.TabIndex = 13;
            // 
            // bt_Voltar
            // 
            this.bt_Voltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Voltar.Location = new System.Drawing.Point(74, 319);
            this.bt_Voltar.Name = "bt_Voltar";
            this.bt_Voltar.Size = new System.Drawing.Size(75, 23);
            this.bt_Voltar.TabIndex = 0;
            this.bt_Voltar.Text = "&Voltar";
            this.bt_Voltar.UseVisualStyleBackColor = true;
            this.bt_Voltar.Click += new System.EventHandler(this.bt_Voltar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Oberservações";
            // 
            // bt_Emprestar
            // 
            this.bt_Emprestar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Emprestar.Location = new System.Drawing.Point(155, 319);
            this.bt_Emprestar.Name = "bt_Emprestar";
            this.bt_Emprestar.Size = new System.Drawing.Size(75, 23);
            this.bt_Emprestar.TabIndex = 1;
            this.bt_Emprestar.Text = "&Emprestar";
            this.bt_Emprestar.UseVisualStyleBackColor = true;
            this.bt_Emprestar.Click += new System.EventHandler(this.bt_Emprestar_Click);
            // 
            // lb_EmailP
            // 
            this.lb_EmailP.AutoSize = true;
            this.lb_EmailP.Location = new System.Drawing.Point(6, 175);
            this.lb_EmailP.Name = "lb_EmailP";
            this.lb_EmailP.Size = new System.Drawing.Size(87, 13);
            this.lb_EmailP.TabIndex = 6;
            this.lb_EmailP.Text = "Não possui email";
            // 
            // lb_nomeP
            // 
            this.lb_nomeP.AutoSize = true;
            this.lb_nomeP.Location = new System.Drawing.Point(6, 149);
            this.lb_nomeP.Name = "lb_nomeP";
            this.lb_nomeP.Size = new System.Drawing.Size(0, 13);
            this.lb_nomeP.TabIndex = 3;
            // 
            // lb_TelP
            // 
            this.lb_TelP.AutoSize = true;
            this.lb_TelP.Location = new System.Drawing.Point(6, 198);
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
            // tb_PesquisaParcial
            // 
            this.tb_PesquisaParcial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_PesquisaParcial.Location = new System.Drawing.Point(739, 4);
            this.tb_PesquisaParcial.Name = "tb_PesquisaParcial";
            this.tb_PesquisaParcial.Size = new System.Drawing.Size(110, 20);
            this.tb_PesquisaParcial.TabIndex = 14;
            this.tb_PesquisaParcial.TextChanged += new System.EventHandler(this.tb_PesquisaParcial_TextChanged);
            // 
            // img_Sucesso
            // 
            this.img_Sucesso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.img_Sucesso.BackgroundImage = global::Controle_de_Midias.Properties.Resources.iconePesquisar;
            this.img_Sucesso.Location = new System.Drawing.Point(847, 5);
            this.img_Sucesso.Name = "img_Sucesso";
            this.img_Sucesso.Size = new System.Drawing.Size(23, 18);
            this.img_Sucesso.TabIndex = 11;
            // 
            // lv_AmigosE
            // 
            this.lv_AmigosE.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lv_AmigosE.FullRowSelect = true;
            this.lv_AmigosE.Location = new System.Drawing.Point(1, 29);
            this.lv_AmigosE.Name = "lv_AmigosE";
            this.lv_AmigosE.Size = new System.Drawing.Size(881, 399);
            this.lv_AmigosE.TabIndex = 15;
            this.lv_AmigosE.UseCompatibleStateImageBehavior = false;
            this.lv_AmigosE.View = System.Windows.Forms.View.Details;
            this.lv_AmigosE.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lv_AmigosE_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nome";
            this.columnHeader1.Width = 247;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Telefone";
            this.columnHeader2.Width = 93;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "E-mail";
            this.columnHeader3.Width = 265;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Observação";
            this.columnHeader4.Width = 257;
            // 
            // fm_Emprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(882, 422);
            this.Controls.Add(this.lv_AmigosE);
            this.Controls.Add(this.gr_AmigoE);
            this.Controls.Add(this.tb_PesquisaParcial);
            this.Controls.Add(this.img_Sucesso);
            this.Controls.Add(this.lv_Midias);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(773, 425);
            this.Name = "fm_Emprestimo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Emprestar Midia";
            this.Load += new System.EventHandler(this.fm_Emprestimo_Load);
            this.gr_AmigoE.ResumeLayout(false);
            this.gr_AmigoE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Amigo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.GroupBox gr_AmigoE;
        private System.Windows.Forms.Label lb_ObsP;
        private System.Windows.Forms.Button bt_Voltar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_Emprestar;
        private System.Windows.Forms.Label lb_EmailP;
        private System.Windows.Forms.Label lb_nomeP;
        private System.Windows.Forms.Label lb_TelP;
        private System.Windows.Forms.Panel img_Sucesso;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox tb_PesquisaParcial;
        private System.Windows.Forms.Label lb_SelecioneMidia;
        private System.Windows.Forms.Label lb_MidiaEmprestada;
        private System.Windows.Forms.PictureBox pb_Amigo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lv_AmigosE;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}