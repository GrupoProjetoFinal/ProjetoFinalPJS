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
            this.gr_AmigoE = new System.Windows.Forms.GroupBox();
            this.lb_MidiaEmprestada = new System.Windows.Forms.Label();
            this.lb_SelecioneMidia = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_ObsP = new System.Windows.Forms.Label();
            this.bt_Voltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_Emprestar = new System.Windows.Forms.Button();
            this.lb_EmailP = new System.Windows.Forms.Label();
            this.lb_nomeP = new System.Windows.Forms.Label();
            this.lb_TelP = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lv_AmigosE = new System.Windows.Forms.ListView();
            this.cl_Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_Telefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_Obs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tb_PesquisaParcial = new System.Windows.Forms.TextBox();
            this.img_Sucesso = new System.Windows.Forms.Panel();
            this.gr_AmigoE.SuspendLayout();
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
            this.lv_Midias.FullRowSelect = true;
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
            this.lv_Midias.Location = new System.Drawing.Point(254, 26);
            this.lv_Midias.Name = "lv_Midias";
            this.lv_Midias.Size = new System.Drawing.Size(503, 354);
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
            this.gr_AmigoE.BackColor = System.Drawing.SystemColors.Control;
            this.gr_AmigoE.Controls.Add(this.lb_MidiaEmprestada);
            this.gr_AmigoE.Controls.Add(this.lb_SelecioneMidia);
            this.gr_AmigoE.Controls.Add(this.label2);
            this.gr_AmigoE.Controls.Add(this.lb_ObsP);
            this.gr_AmigoE.Controls.Add(this.bt_Voltar);
            this.gr_AmigoE.Controls.Add(this.label1);
            this.gr_AmigoE.Controls.Add(this.label5);
            this.gr_AmigoE.Controls.Add(this.bt_Emprestar);
            this.gr_AmigoE.Controls.Add(this.lb_EmailP);
            this.gr_AmigoE.Controls.Add(this.lb_nomeP);
            this.gr_AmigoE.Controls.Add(this.lb_TelP);
            this.gr_AmigoE.Location = new System.Drawing.Point(1, 1);
            this.gr_AmigoE.Name = "gr_AmigoE";
            this.gr_AmigoE.Size = new System.Drawing.Size(252, 386);
            this.gr_AmigoE.TabIndex = 10;
            this.gr_AmigoE.TabStop = false;
            this.gr_AmigoE.Text = "Amigo";
            // 
            // lb_MidiaEmprestada
            // 
            this.lb_MidiaEmprestada.AutoSize = true;
            this.lb_MidiaEmprestada.ForeColor = System.Drawing.Color.Red;
            this.lb_MidiaEmprestada.Location = new System.Drawing.Point(5, 343);
            this.lb_MidiaEmprestada.Name = "lb_MidiaEmprestada";
            this.lb_MidiaEmprestada.Size = new System.Drawing.Size(146, 13);
            this.lb_MidiaEmprestada.TabIndex = 18;
            this.lb_MidiaEmprestada.Text = "Essa midia ja foi emprestada !";
            this.lb_MidiaEmprestada.Visible = false;
            // 
            // lb_SelecioneMidia
            // 
            this.lb_SelecioneMidia.AutoSize = true;
            this.lb_SelecioneMidia.ForeColor = System.Drawing.Color.Red;
            this.lb_SelecioneMidia.Location = new System.Drawing.Point(5, 321);
            this.lb_SelecioneMidia.Name = "lb_SelecioneMidia";
            this.lb_SelecioneMidia.Size = new System.Drawing.Size(111, 13);
            this.lb_SelecioneMidia.TabIndex = 17;
            this.lb_SelecioneMidia.Text = "Selecione uma Midia !";
            this.lb_SelecioneMidia.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Não possui email";
            // 
            // lb_ObsP
            // 
            this.lb_ObsP.AutoSize = true;
            this.lb_ObsP.Location = new System.Drawing.Point(8, 144);
            this.lb_ObsP.Name = "lb_ObsP";
            this.lb_ObsP.Size = new System.Drawing.Size(0, 13);
            this.lb_ObsP.TabIndex = 13;
            // 
            // bt_Voltar
            // 
            this.bt_Voltar.Location = new System.Drawing.Point(72, 281);
            this.bt_Voltar.Name = "bt_Voltar";
            this.bt_Voltar.Size = new System.Drawing.Size(75, 23);
            this.bt_Voltar.TabIndex = 0;
            this.bt_Voltar.Text = "&Voltar";
            this.bt_Voltar.UseVisualStyleBackColor = true;
            this.bt_Voltar.Click += new System.EventHandler(this.bt_Voltar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Pesquisa";
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
            this.bt_Emprestar.TabIndex = 1;
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
            // lv_AmigosE
            // 
            this.lv_AmigosE.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cl_Nome,
            this.cl_Telefone,
            this.cl_Email,
            this.cl_Obs});
            this.lv_AmigosE.FullRowSelect = true;
            this.lv_AmigosE.Location = new System.Drawing.Point(254, 29);
            this.lv_AmigosE.Name = "lv_AmigosE";
            this.lv_AmigosE.Size = new System.Drawing.Size(503, 361);
            this.lv_AmigosE.TabIndex = 13;
            this.lv_AmigosE.UseCompatibleStateImageBehavior = false;
            this.lv_AmigosE.View = System.Windows.Forms.View.Details;
            this.lv_AmigosE.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lv_AmigosE_MouseDoubleClick);
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
            this.cl_Email.Width = 73;
            // 
            // cl_Obs
            // 
            this.cl_Obs.Text = "Observação";
            this.cl_Obs.Width = 236;
            // 
            // tb_PesquisaParcial
            // 
            this.tb_PesquisaParcial.Location = new System.Drawing.Point(614, 4);
            this.tb_PesquisaParcial.Name = "tb_PesquisaParcial";
            this.tb_PesquisaParcial.Size = new System.Drawing.Size(110, 20);
            this.tb_PesquisaParcial.TabIndex = 14;
            this.tb_PesquisaParcial.TextChanged += new System.EventHandler(this.tb_PesquisaParcial_TextChanged);
            // 
            // img_Sucesso
            // 
            this.img_Sucesso.BackgroundImage = global::Controle_de_Midias.Properties.Resources.iconePesquisar;
            this.img_Sucesso.Location = new System.Drawing.Point(722, 5);
            this.img_Sucesso.Name = "img_Sucesso";
            this.img_Sucesso.Size = new System.Drawing.Size(23, 18);
            this.img_Sucesso.TabIndex = 11;
            // 
            // fm_Emprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(757, 387);
            this.Controls.Add(this.gr_AmigoE);
            this.Controls.Add(this.tb_PesquisaParcial);
            this.Controls.Add(this.img_Sucesso);
            this.Controls.Add(this.lv_AmigosE);
            this.Controls.Add(this.lv_Midias);
            this.Name = "fm_Emprestimo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Emprestar Midia";
            this.Load += new System.EventHandler(this.fm_Emprestimo_Load);
            this.gr_AmigoE.ResumeLayout(false);
            this.gr_AmigoE.PerformLayout();
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
        private System.Windows.Forms.ListView lv_AmigosE;
        private System.Windows.Forms.ColumnHeader cl_Nome;
        private System.Windows.Forms.ColumnHeader cl_Telefone;
        private System.Windows.Forms.ColumnHeader cl_Email;
        private System.Windows.Forms.ColumnHeader cl_Obs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_PesquisaParcial;
        private System.Windows.Forms.Label lb_SelecioneMidia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_MidiaEmprestada;
    }
}