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
            System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("Vinil", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup7 = new System.Windows.Forms.ListViewGroup("K7", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup8 = new System.Windows.Forms.ListViewGroup("CD", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup9 = new System.Windows.Forms.ListViewGroup("DVD", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup10 = new System.Windows.Forms.ListViewGroup("Digital", System.Windows.Forms.HorizontalAlignment.Left);
            this.lv_Midias = new System.Windows.Forms.ListView();
            this.cl_imagem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_Album = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_Interprete = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_Origem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_Autor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_Música = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_Obeservacao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_Nota = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_DataAlbum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_DataCompra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lb_Nome = new System.Windows.Forms.Label();
            this.tb_NomeEM = new System.Windows.Forms.TextBox();
            this.gr_Amigo = new System.Windows.Forms.GroupBox();
            this.bt_Procurar = new System.Windows.Forms.Button();
            this.pn_Emprestar = new System.Windows.Forms.Panel();
            this.gr_AmigoE = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bt_CancelarE = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_Emprestar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pn_Principal = new System.Windows.Forms.Panel();
            this.gr_Amigo.SuspendLayout();
            this.pn_Emprestar.SuspendLayout();
            this.gr_AmigoE.SuspendLayout();
            this.pn_Principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv_Midias
            // 
            this.lv_Midias.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cl_imagem,
            this.cl_Album,
            this.cl_Interprete,
            this.cl_Origem,
            this.cl_Autor,
            this.cl_Música,
            this.cl_Obeservacao,
            this.cl_Nota,
            this.cl_DataAlbum,
            this.cl_DataCompra});
            listViewGroup6.Header = "Vinil";
            listViewGroup6.Name = "Gp_Vinil";
            listViewGroup7.Header = "K7";
            listViewGroup7.Name = "Gp_k7";
            listViewGroup8.Header = "CD";
            listViewGroup8.Name = "Gp_Cd";
            listViewGroup9.Header = "DVD";
            listViewGroup9.Name = "Gp_Dvd";
            listViewGroup10.Header = "Digital";
            listViewGroup10.Name = "Gp_Digital";
            this.lv_Midias.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup6,
            listViewGroup7,
            listViewGroup8,
            listViewGroup9,
            listViewGroup10});
            this.lv_Midias.Location = new System.Drawing.Point(256, -1);
            this.lv_Midias.Name = "lv_Midias";
            this.lv_Midias.Size = new System.Drawing.Size(522, 389);
            this.lv_Midias.TabIndex = 1;
            this.lv_Midias.UseCompatibleStateImageBehavior = false;
            this.lv_Midias.View = System.Windows.Forms.View.Details;
            // 
            // cl_imagem
            // 
            this.cl_imagem.Text = "Visualização";
            this.cl_imagem.Width = 80;
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
            // cl_Origem
            // 
            this.cl_Origem.Text = "Origem";
            this.cl_Origem.Width = 94;
            // 
            // cl_Autor
            // 
            this.cl_Autor.Text = "Autor";
            this.cl_Autor.Width = 102;
            // 
            // cl_Música
            // 
            this.cl_Música.Text = "Música";
            this.cl_Música.Width = 137;
            // 
            // cl_Obeservacao
            // 
            this.cl_Obeservacao.Text = "Observação";
            this.cl_Obeservacao.Width = 117;
            // 
            // cl_Nota
            // 
            this.cl_Nota.Text = "Nota";
            this.cl_Nota.Width = 107;
            // 
            // cl_DataAlbum
            // 
            this.cl_DataAlbum.Text = "Data do Álbum";
            this.cl_DataAlbum.Width = 109;
            // 
            // cl_DataCompra
            // 
            this.cl_DataCompra.Text = "Data da Compra";
            this.cl_DataCompra.Width = 116;
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
            this.tb_NomeEM.Location = new System.Drawing.Point(9, 47);
            this.tb_NomeEM.Name = "tb_NomeEM";
            this.tb_NomeEM.Size = new System.Drawing.Size(218, 20);
            this.tb_NomeEM.TabIndex = 5;
            // 
            // gr_Amigo
            // 
            this.gr_Amigo.Controls.Add(this.bt_Procurar);
            this.gr_Amigo.Controls.Add(this.lb_Nome);
            this.gr_Amigo.Controls.Add(this.tb_NomeEM);
            this.gr_Amigo.Location = new System.Drawing.Point(4, 2);
            this.gr_Amigo.Name = "gr_Amigo";
            this.gr_Amigo.Size = new System.Drawing.Size(246, 378);
            this.gr_Amigo.TabIndex = 10;
            this.gr_Amigo.TabStop = false;
            this.gr_Amigo.Text = "Amigo";
            this.gr_Amigo.Enter += new System.EventHandler(this.gr_Amigo_Enter);
            // 
            // bt_Procurar
            // 
            this.bt_Procurar.Location = new System.Drawing.Point(165, 88);
            this.bt_Procurar.Name = "bt_Procurar";
            this.bt_Procurar.Size = new System.Drawing.Size(75, 23);
            this.bt_Procurar.TabIndex = 10;
            this.bt_Procurar.Text = "&Procurar";
            this.bt_Procurar.UseVisualStyleBackColor = true;
            this.bt_Procurar.Click += new System.EventHandler(this.bt_Procurar_Click_1);
            // 
            // pn_Emprestar
            // 
            this.pn_Emprestar.Controls.Add(this.gr_AmigoE);
            this.pn_Emprestar.Location = new System.Drawing.Point(1, 1);
            this.pn_Emprestar.Name = "pn_Emprestar";
            this.pn_Emprestar.Size = new System.Drawing.Size(253, 381);
            this.pn_Emprestar.TabIndex = 12;
            // 
            // gr_AmigoE
            // 
            this.gr_AmigoE.Controls.Add(this.label6);
            this.gr_AmigoE.Controls.Add(this.bt_CancelarE);
            this.gr_AmigoE.Controls.Add(this.label5);
            this.gr_AmigoE.Controls.Add(this.bt_Emprestar);
            this.gr_AmigoE.Controls.Add(this.label2);
            this.gr_AmigoE.Controls.Add(this.label3);
            this.gr_AmigoE.Controls.Add(this.label4);
            this.gr_AmigoE.Location = new System.Drawing.Point(9, 2);
            this.gr_AmigoE.Name = "gr_AmigoE";
            this.gr_AmigoE.Size = new System.Drawing.Size(240, 378);
            this.gr_AmigoE.TabIndex = 10;
            this.gr_AmigoE.TabStop = false;
            this.gr_AmigoE.Text = "Amigo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Mora em Campos do Jordão";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "diego_germano28@yahoo.com.br";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Diego Germano";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "(12)3660-3000";
            // 
            // pn_Principal
            // 
            this.pn_Principal.Controls.Add(this.gr_Amigo);
            this.pn_Principal.Location = new System.Drawing.Point(0, 1);
            this.pn_Principal.Name = "pn_Principal";
            this.pn_Principal.Size = new System.Drawing.Size(254, 387);
            this.pn_Principal.TabIndex = 13;
            // 
            // fm_Emprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 387);
            this.Controls.Add(this.pn_Principal);
            this.Controls.Add(this.pn_Emprestar);
            this.Controls.Add(this.lv_Midias);
            this.Name = "fm_Emprestimo";
            this.Text = "Emprestar Midia";
            this.Load += new System.EventHandler(this.fm_Emprestimo_Load);
            this.gr_Amigo.ResumeLayout(false);
            this.gr_Amigo.PerformLayout();
            this.pn_Emprestar.ResumeLayout(false);
            this.gr_AmigoE.ResumeLayout(false);
            this.gr_AmigoE.PerformLayout();
            this.pn_Principal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv_Midias;
        private System.Windows.Forms.ColumnHeader cl_imagem;
        private System.Windows.Forms.ColumnHeader cl_Album;
        private System.Windows.Forms.ColumnHeader cl_Interprete;
        private System.Windows.Forms.ColumnHeader cl_Origem;
        private System.Windows.Forms.ColumnHeader cl_Autor;
        private System.Windows.Forms.ColumnHeader cl_Música;
        private System.Windows.Forms.ColumnHeader cl_Obeservacao;
        private System.Windows.Forms.ColumnHeader cl_Nota;
        private System.Windows.Forms.ColumnHeader cl_DataAlbum;
        private System.Windows.Forms.ColumnHeader cl_DataCompra;
        private System.Windows.Forms.Label lb_Nome;
        private System.Windows.Forms.TextBox tb_NomeEM;
        private System.Windows.Forms.GroupBox gr_Amigo;
        private System.Windows.Forms.Button bt_Procurar;
        private System.Windows.Forms.Panel pn_Emprestar;
        private System.Windows.Forms.GroupBox gr_AmigoE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bt_CancelarE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_Emprestar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pn_Principal;
    }
}