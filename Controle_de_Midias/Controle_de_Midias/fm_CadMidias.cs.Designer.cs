﻿namespace Controle_de_Midias
{
    partial class fm_CadMidias
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
            this.gb_Midias = new System.Windows.Forms.GroupBox();
            this.bt_Limpar = new System.Windows.Forms.Button();
            this.bt_Salvar = new System.Windows.Forms.Button();
            this.lb_Nota = new System.Windows.Forms.Label();
            this.cb_Nota = new System.Windows.Forms.ComboBox();
            this.lb_Origemcompra = new System.Windows.Forms.Label();
            this.tb_Origemcompra = new System.Windows.Forms.TextBox();
            this.dtp_DataAlbum = new System.Windows.Forms.DateTimePicker();
            this.lb_Dataalbum = new System.Windows.Forms.Label();
            this.cb_Tipomidia = new System.Windows.Forms.ComboBox();
            this.lb_Tipomidia = new System.Windows.Forms.Label();
            this.lb_Datacompra = new System.Windows.Forms.Label();
            this.dtp_DataCompra = new System.Windows.Forms.DateTimePicker();
            this.tb_Nomemusica = new System.Windows.Forms.TextBox();
            this.tb_Album = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_Album = new System.Windows.Forms.Label();
            this.tb_Autor = new System.Windows.Forms.TextBox();
            this.tb_Interprete = new System.Windows.Forms.TextBox();
            this.lb_Autor = new System.Windows.Forms.Label();
            this.lb_Interprete = new System.Windows.Forms.Label();
            this.rtb_Observacao = new System.Windows.Forms.RichTextBox();
            this.lb_Observacao = new System.Windows.Forms.Label();
            this.gb_Midias.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Midias
            // 
            this.gb_Midias.BackColor = System.Drawing.Color.Transparent;
            this.gb_Midias.Controls.Add(this.lb_Observacao);
            this.gb_Midias.Controls.Add(this.rtb_Observacao);
            this.gb_Midias.Controls.Add(this.bt_Limpar);
            this.gb_Midias.Controls.Add(this.bt_Salvar);
            this.gb_Midias.Controls.Add(this.lb_Nota);
            this.gb_Midias.Controls.Add(this.cb_Nota);
            this.gb_Midias.Controls.Add(this.lb_Origemcompra);
            this.gb_Midias.Controls.Add(this.tb_Origemcompra);
            this.gb_Midias.Controls.Add(this.dtp_DataAlbum);
            this.gb_Midias.Controls.Add(this.lb_Dataalbum);
            this.gb_Midias.Controls.Add(this.cb_Tipomidia);
            this.gb_Midias.Controls.Add(this.lb_Tipomidia);
            this.gb_Midias.Controls.Add(this.lb_Datacompra);
            this.gb_Midias.Controls.Add(this.dtp_DataCompra);
            this.gb_Midias.Controls.Add(this.tb_Nomemusica);
            this.gb_Midias.Controls.Add(this.tb_Album);
            this.gb_Midias.Controls.Add(this.label1);
            this.gb_Midias.Controls.Add(this.lb_Album);
            this.gb_Midias.Controls.Add(this.tb_Autor);
            this.gb_Midias.Controls.Add(this.tb_Interprete);
            this.gb_Midias.Controls.Add(this.lb_Autor);
            this.gb_Midias.Controls.Add(this.lb_Interprete);
            this.gb_Midias.Location = new System.Drawing.Point(12, 12);
            this.gb_Midias.Name = "gb_Midias";
            this.gb_Midias.Size = new System.Drawing.Size(550, 420);
            this.gb_Midias.TabIndex = 3;
            this.gb_Midias.TabStop = false;
            this.gb_Midias.Text = "Características";
            // 
            // bt_Limpar
            // 
            this.bt_Limpar.Location = new System.Drawing.Point(387, 385);
            this.bt_Limpar.Name = "bt_Limpar";
            this.bt_Limpar.Size = new System.Drawing.Size(75, 23);
            this.bt_Limpar.TabIndex = 28;
            this.bt_Limpar.Text = "&Limpar";
            this.bt_Limpar.UseVisualStyleBackColor = true;
            // 
            // bt_Salvar
            // 
            this.bt_Salvar.Location = new System.Drawing.Point(468, 385);
            this.bt_Salvar.Name = "bt_Salvar";
            this.bt_Salvar.Size = new System.Drawing.Size(75, 23);
            this.bt_Salvar.TabIndex = 26;
            this.bt_Salvar.Text = "&Salvar";
            this.bt_Salvar.UseVisualStyleBackColor = true;
            this.bt_Salvar.Click += new System.EventHandler(this.bt_Salvar_Click);
            // 
            // lb_Nota
            // 
            this.lb_Nota.AutoSize = true;
            this.lb_Nota.Location = new System.Drawing.Point(407, 227);
            this.lb_Nota.Name = "lb_Nota";
            this.lb_Nota.Size = new System.Drawing.Size(30, 13);
            this.lb_Nota.TabIndex = 25;
            this.lb_Nota.Text = "Nota";
            // 
            // cb_Nota
            // 
            this.cb_Nota.FormattingEnabled = true;
            this.cb_Nota.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cb_Nota.Location = new System.Drawing.Point(410, 243);
            this.cb_Nota.Name = "cb_Nota";
            this.cb_Nota.Size = new System.Drawing.Size(82, 21);
            this.cb_Nota.TabIndex = 24;
            // 
            // lb_Origemcompra
            // 
            this.lb_Origemcompra.AutoSize = true;
            this.lb_Origemcompra.Location = new System.Drawing.Point(7, 180);
            this.lb_Origemcompra.Name = "lb_Origemcompra";
            this.lb_Origemcompra.Size = new System.Drawing.Size(89, 13);
            this.lb_Origemcompra.TabIndex = 23;
            this.lb_Origemcompra.Text = "Origim da compra";
            // 
            // tb_Origemcompra
            // 
            this.tb_Origemcompra.Location = new System.Drawing.Point(10, 196);
            this.tb_Origemcompra.Name = "tb_Origemcompra";
            this.tb_Origemcompra.Size = new System.Drawing.Size(534, 20);
            this.tb_Origemcompra.TabIndex = 22;
            // 
            // dtp_DataAlbum
            // 
            this.dtp_DataAlbum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_DataAlbum.Location = new System.Drawing.Point(303, 244);
            this.dtp_DataAlbum.Name = "dtp_DataAlbum";
            this.dtp_DataAlbum.Size = new System.Drawing.Size(101, 20);
            this.dtp_DataAlbum.TabIndex = 21;
            // 
            // lb_Dataalbum
            // 
            this.lb_Dataalbum.AutoSize = true;
            this.lb_Dataalbum.Location = new System.Drawing.Point(300, 228);
            this.lb_Dataalbum.Name = "lb_Dataalbum";
            this.lb_Dataalbum.Size = new System.Drawing.Size(61, 13);
            this.lb_Dataalbum.TabIndex = 20;
            this.lb_Dataalbum.Text = "Data álbum";
            // 
            // cb_Tipomidia
            // 
            this.cb_Tipomidia.FormattingEnabled = true;
            this.cb_Tipomidia.Items.AddRange(new object[] {
            "Selecione...",
            "Vinil",
            "K7",
            "CD",
            "DVD",
            "Digital"});
            this.cb_Tipomidia.Location = new System.Drawing.Point(10, 243);
            this.cb_Tipomidia.Name = "cb_Tipomidia";
            this.cb_Tipomidia.Size = new System.Drawing.Size(182, 21);
            this.cb_Tipomidia.TabIndex = 19;
            // 
            // lb_Tipomidia
            // 
            this.lb_Tipomidia.AutoSize = true;
            this.lb_Tipomidia.Location = new System.Drawing.Point(7, 226);
            this.lb_Tipomidia.Name = "lb_Tipomidia";
            this.lb_Tipomidia.Size = new System.Drawing.Size(55, 13);
            this.lb_Tipomidia.TabIndex = 18;
            this.lb_Tipomidia.Text = "Tipo midia";
            // 
            // lb_Datacompra
            // 
            this.lb_Datacompra.AutoSize = true;
            this.lb_Datacompra.Location = new System.Drawing.Point(195, 227);
            this.lb_Datacompra.Name = "lb_Datacompra";
            this.lb_Datacompra.Size = new System.Drawing.Size(68, 13);
            this.lb_Datacompra.TabIndex = 17;
            this.lb_Datacompra.Text = "Data compra";
            // 
            // dtp_DataCompra
            // 
            this.dtp_DataCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_DataCompra.Location = new System.Drawing.Point(198, 244);
            this.dtp_DataCompra.Name = "dtp_DataCompra";
            this.dtp_DataCompra.Size = new System.Drawing.Size(99, 20);
            this.dtp_DataCompra.TabIndex = 16;
            // 
            // tb_Nomemusica
            // 
            this.tb_Nomemusica.Location = new System.Drawing.Point(10, 156);
            this.tb_Nomemusica.Name = "tb_Nomemusica";
            this.tb_Nomemusica.Size = new System.Drawing.Size(534, 20);
            this.tb_Nomemusica.TabIndex = 15;
            // 
            // tb_Album
            // 
            this.tb_Album.Location = new System.Drawing.Point(10, 117);
            this.tb_Album.Name = "tb_Album";
            this.tb_Album.Size = new System.Drawing.Size(534, 20);
            this.tb_Album.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nome música";
            // 
            // lb_Album
            // 
            this.lb_Album.AutoSize = true;
            this.lb_Album.Location = new System.Drawing.Point(7, 100);
            this.lb_Album.Name = "lb_Album";
            this.lb_Album.Size = new System.Drawing.Size(36, 13);
            this.lb_Album.TabIndex = 12;
            this.lb_Album.Text = "Álbum";
            // 
            // tb_Autor
            // 
            this.tb_Autor.Location = new System.Drawing.Point(10, 76);
            this.tb_Autor.Name = "tb_Autor";
            this.tb_Autor.Size = new System.Drawing.Size(534, 20);
            this.tb_Autor.TabIndex = 11;
            // 
            // tb_Interprete
            // 
            this.tb_Interprete.Location = new System.Drawing.Point(10, 37);
            this.tb_Interprete.Name = "tb_Interprete";
            this.tb_Interprete.Size = new System.Drawing.Size(534, 20);
            this.tb_Interprete.TabIndex = 9;
            // 
            // lb_Autor
            // 
            this.lb_Autor.AutoSize = true;
            this.lb_Autor.Location = new System.Drawing.Point(7, 60);
            this.lb_Autor.Name = "lb_Autor";
            this.lb_Autor.Size = new System.Drawing.Size(32, 13);
            this.lb_Autor.TabIndex = 1;
            this.lb_Autor.Text = "Autor";
            // 
            // lb_Interprete
            // 
            this.lb_Interprete.AutoSize = true;
            this.lb_Interprete.Location = new System.Drawing.Point(7, 20);
            this.lb_Interprete.Name = "lb_Interprete";
            this.lb_Interprete.Size = new System.Drawing.Size(52, 13);
            this.lb_Interprete.TabIndex = 0;
            this.lb_Interprete.Text = "Intérprete";
            // 
            // rtb_Observacao
            // 
            this.rtb_Observacao.Location = new System.Drawing.Point(10, 283);
            this.rtb_Observacao.Name = "rtb_Observacao";
            this.rtb_Observacao.Size = new System.Drawing.Size(533, 96);
            this.rtb_Observacao.TabIndex = 29;
            this.rtb_Observacao.Text = "";
            // 
            // lb_Observacao
            // 
            this.lb_Observacao.AutoSize = true;
            this.lb_Observacao.Location = new System.Drawing.Point(7, 267);
            this.lb_Observacao.Name = "lb_Observacao";
            this.lb_Observacao.Size = new System.Drawing.Size(65, 13);
            this.lb_Observacao.TabIndex = 30;
            this.lb_Observacao.Text = "Observação";
            // 
            // fm_CadMidias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 437);
            this.Controls.Add(this.gb_Midias);
            this.Name = "fm_CadMidias";
            this.Text = "fm_CadMidias";
            this.gb_Midias.ResumeLayout(false);
            this.gb_Midias.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Midias;
        private System.Windows.Forms.Label lb_Nota;
        private System.Windows.Forms.ComboBox cb_Nota;
        private System.Windows.Forms.Label lb_Origemcompra;
        private System.Windows.Forms.TextBox tb_Origemcompra;
        private System.Windows.Forms.DateTimePicker dtp_DataAlbum;
        private System.Windows.Forms.Label lb_Dataalbum;
        private System.Windows.Forms.ComboBox cb_Tipomidia;
        private System.Windows.Forms.Label lb_Tipomidia;
        private System.Windows.Forms.Label lb_Datacompra;
        private System.Windows.Forms.DateTimePicker dtp_DataCompra;
        private System.Windows.Forms.TextBox tb_Nomemusica;
        private System.Windows.Forms.TextBox tb_Album;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_Album;
        private System.Windows.Forms.TextBox tb_Autor;
        private System.Windows.Forms.TextBox tb_Interprete;
        private System.Windows.Forms.Label lb_Autor;
        private System.Windows.Forms.Label lb_Interprete;
        private System.Windows.Forms.Button bt_Limpar;
        private System.Windows.Forms.Button bt_Salvar;
        private System.Windows.Forms.Label lb_Observacao;
        private System.Windows.Forms.RichTextBox rtb_Observacao;
    }
}