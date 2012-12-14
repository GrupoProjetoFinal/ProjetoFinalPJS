namespace Controle_de_Midias
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Vinil", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("K7", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("CD", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("DVD", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("Digital", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fm_Principal));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp_Midias = new System.Windows.Forms.TabPage();
            this.img_Sucesso = new System.Windows.Forms.Panel();
            this.tb_PesquisaParcialM = new System.Windows.Forms.TextBox();
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
            this.rb_Individual = new System.Windows.Forms.RadioButton();
            this.rb_Lista = new System.Windows.Forms.RadioButton();
            this.pn_Amigo = new System.Windows.Forms.Panel();
            this.bt_Anterior = new System.Windows.Forms.Button();
            this.bt_Proximo = new System.Windows.Forms.Button();
            this.gb_menu = new System.Windows.Forms.GroupBox();
            this.pb_Amigo = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lb_Nome = new System.Windows.Forms.Label();
            this.lb_Telefone = new System.Windows.Forms.Label();
            this.lb_observacao = new System.Windows.Forms.Label();
            this.lb_email = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_PesquisaParcial = new System.Windows.Forms.TextBox();
            this.lv_Amigos = new System.Windows.Forms.ListView();
            this.cl_Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_Telefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_Obs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_Alterar = new System.Windows.Forms.Button();
            this.bt_Configurar = new System.Windows.Forms.Button();
            this.bt_Devolver = new System.Windows.Forms.Button();
            this.bt_Emprestar = new System.Windows.Forms.Button();
            this.bt_Pesquisa = new System.Windows.Forms.Button();
            this.bt_NovoAmigo = new System.Windows.Forms.Button();
            this.bt_NovaMidia = new System.Windows.Forms.Button();
            this.tp_Imagem = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tp_Midias.SuspendLayout();
            this.tp_Amigos.SuspendLayout();
            this.pn_Amigo.SuspendLayout();
            this.gb_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Amigo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tp_Midias);
            this.tabControl1.Controls.Add(this.tp_Amigos);
            this.tabControl1.Location = new System.Drawing.Point(98, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(783, 423);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tp_Midias
            // 
            this.tp_Midias.Controls.Add(this.img_Sucesso);
            this.tp_Midias.Controls.Add(this.tb_PesquisaParcialM);
            this.tp_Midias.Controls.Add(this.lv_Midias);
            this.tp_Midias.Location = new System.Drawing.Point(4, 22);
            this.tp_Midias.Name = "tp_Midias";
            this.tp_Midias.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Midias.Size = new System.Drawing.Size(775, 397);
            this.tp_Midias.TabIndex = 0;
            this.tp_Midias.Text = "Mídias";
            this.tp_Midias.UseVisualStyleBackColor = true;
            // 
            // img_Sucesso
            // 
            this.img_Sucesso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.img_Sucesso.BackgroundImage = global::Controle_de_Midias.Properties.Resources.iconePesquisar;
            this.img_Sucesso.Location = new System.Drawing.Point(748, 6);
            this.img_Sucesso.Name = "img_Sucesso";
            this.img_Sucesso.Size = new System.Drawing.Size(23, 18);
            this.img_Sucesso.TabIndex = 12;
            this.tp_Imagem.SetToolTip(this.img_Sucesso, "Pesquisa Rápida");
            // 
            // tb_PesquisaParcialM
            // 
            this.tb_PesquisaParcialM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_PesquisaParcialM.Location = new System.Drawing.Point(637, 6);
            this.tb_PesquisaParcialM.Name = "tb_PesquisaParcialM";
            this.tb_PesquisaParcialM.Size = new System.Drawing.Size(110, 20);
            this.tb_PesquisaParcialM.TabIndex = 5;
            this.tb_PesquisaParcialM.TextChanged += new System.EventHandler(this.tb_PesquisaParcialM_TextChanged);
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
            this.lv_Midias.GridLines = true;
            listViewGroup1.Header = "Vinil";
            listViewGroup1.Name = "VINIL";
            listViewGroup2.Header = "K7";
            listViewGroup2.Name = "K7";
            listViewGroup3.Header = "CD";
            listViewGroup3.Name = "CD";
            listViewGroup4.Header = "DVD";
            listViewGroup4.Name = "DVD";
            listViewGroup5.Header = "Digital";
            listViewGroup5.Name = "DIGITAL";
            this.lv_Midias.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4,
            listViewGroup5});
            this.lv_Midias.Location = new System.Drawing.Point(3, 28);
            this.lv_Midias.Name = "lv_Midias";
            this.lv_Midias.Size = new System.Drawing.Size(765, 366);
            this.lv_Midias.TabIndex = 2;
            this.lv_Midias.UseCompatibleStateImageBehavior = false;
            this.lv_Midias.View = System.Windows.Forms.View.Details;
            this.lv_Midias.DoubleClick += new System.EventHandler(this.lv_Midias_DoubleClick);
            this.lv_Midias.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lv_Midias_MouseClick);
            // 
            // cl_Album
            // 
            this.cl_Album.Text = "Álbum";
            this.cl_Album.Width = 195;
            // 
            // cl_Interprete
            // 
            this.cl_Interprete.Text = "Intérprete";
            this.cl_Interprete.Width = 133;
            // 
            // cl_Autor
            // 
            this.cl_Autor.DisplayIndex = 3;
            this.cl_Autor.Text = "Autor";
            this.cl_Autor.Width = 149;
            // 
            // cl_Música
            // 
            this.cl_Música.DisplayIndex = 4;
            this.cl_Música.Text = "Música";
            this.cl_Música.Width = 160;
            // 
            // cl_Nota
            // 
            this.cl_Nota.DisplayIndex = 5;
            this.cl_Nota.Text = "Nota";
            this.cl_Nota.Width = 41;
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
            this.cl_Origem.Width = 96;
            // 
            // cl_Observacao
            // 
            this.cl_Observacao.Text = "Observação";
            this.cl_Observacao.Width = 156;
            // 
            // tp_Amigos
            // 
            this.tp_Amigos.Controls.Add(this.rb_Individual);
            this.tp_Amigos.Controls.Add(this.rb_Lista);
            this.tp_Amigos.Controls.Add(this.pn_Amigo);
            this.tp_Amigos.Controls.Add(this.panel1);
            this.tp_Amigos.Controls.Add(this.tb_PesquisaParcial);
            this.tp_Amigos.Controls.Add(this.lv_Amigos);
            this.tp_Amigos.Location = new System.Drawing.Point(4, 22);
            this.tp_Amigos.Name = "tp_Amigos";
            this.tp_Amigos.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Amigos.Size = new System.Drawing.Size(775, 397);
            this.tp_Amigos.TabIndex = 1;
            this.tp_Amigos.Text = "Amigos";
            this.tp_Amigos.UseVisualStyleBackColor = true;
            // 
            // rb_Individual
            // 
            this.rb_Individual.AutoSize = true;
            this.rb_Individual.Location = new System.Drawing.Point(94, 7);
            this.rb_Individual.Name = "rb_Individual";
            this.rb_Individual.Size = new System.Drawing.Size(70, 17);
            this.rb_Individual.TabIndex = 18;
            this.rb_Individual.TabStop = true;
            this.rb_Individual.Text = "Individual";
            this.rb_Individual.UseVisualStyleBackColor = true;
            this.rb_Individual.Click += new System.EventHandler(this.rb_Individual_Click);
            // 
            // rb_Lista
            // 
            this.rb_Lista.AutoSize = true;
            this.rb_Lista.Location = new System.Drawing.Point(3, 7);
            this.rb_Lista.Name = "rb_Lista";
            this.rb_Lista.Size = new System.Drawing.Size(47, 17);
            this.rb_Lista.TabIndex = 17;
            this.rb_Lista.TabStop = true;
            this.rb_Lista.Text = "Lista";
            this.rb_Lista.UseVisualStyleBackColor = true;
            this.rb_Lista.Click += new System.EventHandler(this.rb_Lista_Click);
            // 
            // pn_Amigo
            // 
            this.pn_Amigo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_Amigo.Controls.Add(this.bt_Anterior);
            this.pn_Amigo.Controls.Add(this.bt_Proximo);
            this.pn_Amigo.Controls.Add(this.gb_menu);
            this.pn_Amigo.Location = new System.Drawing.Point(1, 30);
            this.pn_Amigo.Name = "pn_Amigo";
            this.pn_Amigo.Size = new System.Drawing.Size(768, 367);
            this.pn_Amigo.TabIndex = 14;
            this.pn_Amigo.Visible = false;
            // 
            // bt_Anterior
            // 
            this.bt_Anterior.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt_Anterior.Location = new System.Drawing.Point(70, 139);
            this.bt_Anterior.Name = "bt_Anterior";
            this.bt_Anterior.Size = new System.Drawing.Size(50, 59);
            this.bt_Anterior.TabIndex = 12;
            this.bt_Anterior.Text = "<<";
            this.bt_Anterior.UseVisualStyleBackColor = true;
            this.bt_Anterior.Click += new System.EventHandler(this.bt_Anterior_Click);
            // 
            // bt_Proximo
            // 
            this.bt_Proximo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Proximo.Location = new System.Drawing.Point(651, 139);
            this.bt_Proximo.Name = "bt_Proximo";
            this.bt_Proximo.Size = new System.Drawing.Size(50, 59);
            this.bt_Proximo.TabIndex = 11;
            this.bt_Proximo.Text = ">>";
            this.bt_Proximo.UseVisualStyleBackColor = true;
            this.bt_Proximo.Click += new System.EventHandler(this.bt_Proximo_Click);
            // 
            // gb_menu
            // 
            this.gb_menu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_menu.Controls.Add(this.pb_Amigo);
            this.gb_menu.Controls.Add(this.panel4);
            this.gb_menu.Controls.Add(this.lb_Nome);
            this.gb_menu.Controls.Add(this.lb_Telefone);
            this.gb_menu.Controls.Add(this.lb_observacao);
            this.gb_menu.Controls.Add(this.lb_email);
            this.gb_menu.Location = new System.Drawing.Point(145, 20);
            this.gb_menu.Name = "gb_menu";
            this.gb_menu.Size = new System.Drawing.Size(482, 326);
            this.gb_menu.TabIndex = 10;
            this.gb_menu.TabStop = false;
            this.gb_menu.Text = "Amigo";
            // 
            // pb_Amigo
            // 
            this.pb_Amigo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_Amigo.Location = new System.Drawing.Point(16, 19);
            this.pb_Amigo.Name = "pb_Amigo";
            this.pb_Amigo.Size = new System.Drawing.Size(270, 230);
            this.pb_Amigo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Amigo.TabIndex = 22;
            this.pb_Amigo.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel4.BackgroundImage = global::Controle_de_Midias.Properties.Resources.lgn_usuario;
            this.panel4.Location = new System.Drawing.Point(6, 272);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(49, 47);
            this.panel4.TabIndex = 21;
            // 
            // lb_Nome
            // 
            this.lb_Nome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Nome.AutoSize = true;
            this.lb_Nome.Location = new System.Drawing.Point(292, 41);
            this.lb_Nome.Name = "lb_Nome";
            this.lb_Nome.Size = new System.Drawing.Size(35, 13);
            this.lb_Nome.TabIndex = 0;
            this.lb_Nome.Text = "Nome";
            // 
            // lb_Telefone
            // 
            this.lb_Telefone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Telefone.AutoSize = true;
            this.lb_Telefone.Location = new System.Drawing.Point(292, 119);
            this.lb_Telefone.Name = "lb_Telefone";
            this.lb_Telefone.Size = new System.Drawing.Size(49, 13);
            this.lb_Telefone.TabIndex = 2;
            this.lb_Telefone.Text = "Telefone";
            // 
            // lb_observacao
            // 
            this.lb_observacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_observacao.AutoSize = true;
            this.lb_observacao.Location = new System.Drawing.Point(292, 164);
            this.lb_observacao.Name = "lb_observacao";
            this.lb_observacao.Size = new System.Drawing.Size(65, 13);
            this.lb_observacao.TabIndex = 6;
            this.lb_observacao.Text = "Observação";
            // 
            // lb_email
            // 
            this.lb_email.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_email.AutoSize = true;
            this.lb_email.Location = new System.Drawing.Point(292, 80);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(35, 13);
            this.lb_email.TabIndex = 4;
            this.lb_email.Text = "E-mail";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImage = global::Controle_de_Midias.Properties.Resources.iconePesquisar;
            this.panel1.Location = new System.Drawing.Point(748, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(23, 18);
            this.panel1.TabIndex = 13;
            this.tp_Imagem.SetToolTip(this.panel1, "Pesquisa Rápida");
            // 
            // tb_PesquisaParcial
            // 
            this.tb_PesquisaParcial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_PesquisaParcial.Location = new System.Drawing.Point(637, 6);
            this.tb_PesquisaParcial.Name = "tb_PesquisaParcial";
            this.tb_PesquisaParcial.Size = new System.Drawing.Size(110, 20);
            this.tb_PesquisaParcial.TabIndex = 3;
            this.tb_PesquisaParcial.TextChanged += new System.EventHandler(this.PesquisaParcial_TextChanged);
            // 
            // lv_Amigos
            // 
            this.lv_Amigos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_Amigos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cl_Nome,
            this.cl_Telefone,
            this.cl_Email,
            this.cl_Obs});
            this.lv_Amigos.FullRowSelect = true;
            this.lv_Amigos.Location = new System.Drawing.Point(3, 30);
            this.lv_Amigos.Name = "lv_Amigos";
            this.lv_Amigos.Size = new System.Drawing.Size(770, 366);
            this.lv_Amigos.TabIndex = 2;
            this.lv_Amigos.UseCompatibleStateImageBehavior = false;
            this.lv_Amigos.View = System.Windows.Forms.View.Details;
            this.lv_Amigos.DoubleClick += new System.EventHandler(this.lv_Amigos_DoubleClick);
            this.lv_Amigos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lv_Midias_MouseClick);
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
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.bt_Alterar);
            this.groupBox1.Controls.Add(this.bt_Configurar);
            this.groupBox1.Controls.Add(this.bt_Devolver);
            this.groupBox1.Controls.Add(this.bt_Emprestar);
            this.groupBox1.Controls.Add(this.bt_Pesquisa);
            this.groupBox1.Controls.Add(this.bt_NovoAmigo);
            this.groupBox1.Controls.Add(this.bt_NovaMidia);
            this.groupBox1.Location = new System.Drawing.Point(8, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(84, 407);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackgroundImage = global::Controle_de_Midias.Properties.Resources.musica1;
            this.panel2.Location = new System.Drawing.Point(6, 364);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(33, 37);
            this.panel2.TabIndex = 20;
            // 
            // bt_Alterar
            // 
            this.bt_Alterar.Enabled = false;
            this.bt_Alterar.Location = new System.Drawing.Point(3, 217);
            this.bt_Alterar.Name = "bt_Alterar";
            this.bt_Alterar.Size = new System.Drawing.Size(75, 23);
            this.bt_Alterar.TabIndex = 5;
            this.bt_Alterar.Text = "&Alterar";
            this.bt_Alterar.UseVisualStyleBackColor = true;
            this.bt_Alterar.Click += new System.EventHandler(this.bt_Alterar_Click);
            // 
            // bt_Configurar
            // 
            this.bt_Configurar.Location = new System.Drawing.Point(4, 256);
            this.bt_Configurar.Name = "bt_Configurar";
            this.bt_Configurar.Size = new System.Drawing.Size(75, 23);
            this.bt_Configurar.TabIndex = 6;
            this.bt_Configurar.Text = "&Configurar";
            this.bt_Configurar.UseVisualStyleBackColor = true;
            this.bt_Configurar.Click += new System.EventHandler(this.bt_Configrar_Click);
            // 
            // bt_Devolver
            // 
            this.bt_Devolver.Location = new System.Drawing.Point(4, 178);
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
            this.bt_Pesquisa.Click += new System.EventHandler(this.bt_Pesquisa_Click);
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
            // fm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(882, 422);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Collectors medias";
            this.Load += new System.EventHandler(this.fm_Principal_Load);
            this.tabControl1.ResumeLayout(false);
            this.tp_Midias.ResumeLayout(false);
            this.tp_Midias.PerformLayout();
            this.tp_Amigos.ResumeLayout(false);
            this.tp_Amigos.PerformLayout();
            this.pn_Amigo.ResumeLayout(false);
            this.gb_menu.ResumeLayout(false);
            this.gb_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Amigo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tp_Midias;
        private System.Windows.Forms.TabPage tp_Amigos;
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
        private System.Windows.Forms.TextBox tb_PesquisaParcial;
        private System.Windows.Forms.TextBox tb_PesquisaParcialM;
        private System.Windows.Forms.Panel img_Sucesso;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_Alterar;
        private System.Windows.Forms.Button bt_Configurar;
        private System.Windows.Forms.Button bt_Devolver;
        private System.Windows.Forms.Button bt_Emprestar;
        private System.Windows.Forms.Button bt_Pesquisa;
        private System.Windows.Forms.Button bt_NovoAmigo;
        private System.Windows.Forms.Button bt_NovaMidia;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolTip tp_Imagem;
        private System.Windows.Forms.Panel pn_Amigo;
        private System.Windows.Forms.Button bt_Anterior;
        private System.Windows.Forms.Button bt_Proximo;
        private System.Windows.Forms.GroupBox gb_menu;
        private System.Windows.Forms.PictureBox pb_Amigo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lb_Nome;
        private System.Windows.Forms.Label lb_Telefone;
        private System.Windows.Forms.Label lb_observacao;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.RadioButton rb_Individual;
        private System.Windows.Forms.RadioButton rb_Lista;

    }
}

