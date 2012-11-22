namespace Controle_de_Midias
{
    partial class fm_Devolver
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
            System.Windows.Forms.ListViewGroup listViewGroup11 = new System.Windows.Forms.ListViewGroup("Vinil", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup12 = new System.Windows.Forms.ListViewGroup("K7", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup13 = new System.Windows.Forms.ListViewGroup("CD", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup14 = new System.Windows.Forms.ListViewGroup("DVD", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup15 = new System.Windows.Forms.ListViewGroup("Digital", System.Windows.Forms.HorizontalAlignment.Left);
            this.lv_AmigosD = new System.Windows.Forms.ListView();
            this.cl_Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_Telefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_Obs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gr_AmigoE = new System.Windows.Forms.GroupBox();
            this.lb_ObsP = new System.Windows.Forms.Label();
            this.bt_CancelarE = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_Emprestar = new System.Windows.Forms.Button();
            this.lb_EmailP = new System.Windows.Forms.Label();
            this.lb_nomeP = new System.Windows.Forms.Label();
            this.lb_TelP = new System.Windows.Forms.Label();
            this.lv_MidiasD = new System.Windows.Forms.ListView();
            this.cl_Album = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_Interprete = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_Origem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_Autor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_Música = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_Obeservacao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_Nota = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_DataAlbum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_DataCompra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gr_AmigoE.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv_AmigosD
            // 
            this.lv_AmigosD.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cl_Nome,
            this.cl_Telefone,
            this.cl_Email,
            this.cl_Obs});
            this.lv_AmigosD.Location = new System.Drawing.Point(211, 0);
            this.lv_AmigosD.Name = "lv_AmigosD";
            this.lv_AmigosD.Size = new System.Drawing.Size(526, 323);
            this.lv_AmigosD.TabIndex = 3;
            this.lv_AmigosD.UseCompatibleStateImageBehavior = false;
            this.lv_AmigosD.View = System.Windows.Forms.View.Details;
            this.lv_AmigosD.SelectedIndexChanged += new System.EventHandler(this.lv_Amigos_SelectedIndexChanged);
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
            // gr_AmigoE
            // 
            this.gr_AmigoE.Controls.Add(this.lb_ObsP);
            this.gr_AmigoE.Controls.Add(this.bt_CancelarE);
            this.gr_AmigoE.Controls.Add(this.label5);
            this.gr_AmigoE.Controls.Add(this.bt_Emprestar);
            this.gr_AmigoE.Controls.Add(this.lb_EmailP);
            this.gr_AmigoE.Controls.Add(this.lb_nomeP);
            this.gr_AmigoE.Controls.Add(this.lb_TelP);
            this.gr_AmigoE.Location = new System.Drawing.Point(2, 0);
            this.gr_AmigoE.Name = "gr_AmigoE";
            this.gr_AmigoE.Size = new System.Drawing.Size(203, 323);
            this.gr_AmigoE.TabIndex = 11;
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
            this.bt_CancelarE.Location = new System.Drawing.Point(43, 225);
            this.bt_CancelarE.Name = "bt_CancelarE";
            this.bt_CancelarE.Size = new System.Drawing.Size(75, 23);
            this.bt_CancelarE.TabIndex = 12;
            this.bt_CancelarE.Text = "&Voltar";
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
            this.bt_Emprestar.Location = new System.Drawing.Point(124, 225);
            this.bt_Emprestar.Name = "bt_Emprestar";
            this.bt_Emprestar.Size = new System.Drawing.Size(75, 23);
            this.bt_Emprestar.TabIndex = 10;
            this.bt_Emprestar.Text = "&Devolver";
            this.bt_Emprestar.UseVisualStyleBackColor = true;
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
            // lv_MidiasD
            // 
            this.lv_MidiasD.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cl_Album,
            this.cl_Interprete,
            this.cl_Origem,
            this.cl_Autor,
            this.cl_Música,
            this.cl_Obeservacao,
            this.cl_Nota,
            this.cl_DataAlbum,
            this.cl_DataCompra});
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
            this.lv_MidiasD.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup11,
            listViewGroup12,
            listViewGroup13,
            listViewGroup14,
            listViewGroup15});
            this.lv_MidiasD.Location = new System.Drawing.Point(211, 0);
            this.lv_MidiasD.Name = "lv_MidiasD";
            this.lv_MidiasD.Size = new System.Drawing.Size(526, 323);
            this.lv_MidiasD.TabIndex = 12;
            this.lv_MidiasD.UseCompatibleStateImageBehavior = false;
            this.lv_MidiasD.View = System.Windows.Forms.View.Details;
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
            // fm_Devolver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 325);
            this.Controls.Add(this.lv_MidiasD);
            this.Controls.Add(this.gr_AmigoE);
            this.Controls.Add(this.lv_AmigosD);
            this.Name = "fm_Devolver";
            this.Text = "fm_Devolver";
            this.Load += new System.EventHandler(this.fm_Devolver_Load);
            this.gr_AmigoE.ResumeLayout(false);
            this.gr_AmigoE.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv_AmigosD;
        private System.Windows.Forms.ColumnHeader cl_Nome;
        private System.Windows.Forms.ColumnHeader cl_Telefone;
        private System.Windows.Forms.ColumnHeader cl_Email;
        private System.Windows.Forms.ColumnHeader cl_Obs;
        private System.Windows.Forms.GroupBox gr_AmigoE;
        private System.Windows.Forms.Label lb_ObsP;
        private System.Windows.Forms.Button bt_CancelarE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_Emprestar;
        private System.Windows.Forms.Label lb_EmailP;
        private System.Windows.Forms.Label lb_nomeP;
        private System.Windows.Forms.Label lb_TelP;
        private System.Windows.Forms.ListView lv_MidiasD;
        private System.Windows.Forms.ColumnHeader cl_Album;
        private System.Windows.Forms.ColumnHeader cl_Interprete;
        private System.Windows.Forms.ColumnHeader cl_Origem;
        private System.Windows.Forms.ColumnHeader cl_Autor;
        private System.Windows.Forms.ColumnHeader cl_Música;
        private System.Windows.Forms.ColumnHeader cl_Obeservacao;
        private System.Windows.Forms.ColumnHeader cl_Nota;
        private System.Windows.Forms.ColumnHeader cl_DataAlbum;
        private System.Windows.Forms.ColumnHeader cl_DataCompra;
    }
}