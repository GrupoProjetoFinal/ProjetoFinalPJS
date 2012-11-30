namespace Controle_de_Midias
{
    partial class fm_AlterarMidia
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
            this.lb_Observacao = new System.Windows.Forms.Label();
            this.rtb_altObservacao = new System.Windows.Forms.RichTextBox();
            this.bt_Apagar = new System.Windows.Forms.Button();
            this.bt_Alterar = new System.Windows.Forms.Button();
            this.lb_Nota = new System.Windows.Forms.Label();
            this.cb_altNota = new System.Windows.Forms.ComboBox();
            this.lb_Origemcompra = new System.Windows.Forms.Label();
            this.tb_altOrigemcompra = new System.Windows.Forms.TextBox();
            this.dtp_altDataAlbum = new System.Windows.Forms.DateTimePicker();
            this.lb_Dataalbum = new System.Windows.Forms.Label();
            this.cb_altTipomidia = new System.Windows.Forms.ComboBox();
            this.lb_Tipomidia = new System.Windows.Forms.Label();
            this.lb_Datacompra = new System.Windows.Forms.Label();
            this.dtp_altDataCompra = new System.Windows.Forms.DateTimePicker();
            this.tb_altNomemusica = new System.Windows.Forms.TextBox();
            this.tb_altAlbum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_Album = new System.Windows.Forms.Label();
            this.tb_altAutor = new System.Windows.Forms.TextBox();
            this.tb_altInterprete = new System.Windows.Forms.TextBox();
            this.lb_Autor = new System.Windows.Forms.Label();
            this.lb_Interprete = new System.Windows.Forms.Label();
            this.gb_Midias.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Midias
            // 
            this.gb_Midias.BackColor = System.Drawing.Color.Transparent;
            this.gb_Midias.Controls.Add(this.lb_Observacao);
            this.gb_Midias.Controls.Add(this.rtb_altObservacao);
            this.gb_Midias.Controls.Add(this.bt_Apagar);
            this.gb_Midias.Controls.Add(this.bt_Alterar);
            this.gb_Midias.Controls.Add(this.lb_Nota);
            this.gb_Midias.Controls.Add(this.cb_altNota);
            this.gb_Midias.Controls.Add(this.lb_Origemcompra);
            this.gb_Midias.Controls.Add(this.tb_altOrigemcompra);
            this.gb_Midias.Controls.Add(this.dtp_altDataAlbum);
            this.gb_Midias.Controls.Add(this.lb_Dataalbum);
            this.gb_Midias.Controls.Add(this.cb_altTipomidia);
            this.gb_Midias.Controls.Add(this.lb_Tipomidia);
            this.gb_Midias.Controls.Add(this.lb_Datacompra);
            this.gb_Midias.Controls.Add(this.dtp_altDataCompra);
            this.gb_Midias.Controls.Add(this.tb_altNomemusica);
            this.gb_Midias.Controls.Add(this.tb_altAlbum);
            this.gb_Midias.Controls.Add(this.label1);
            this.gb_Midias.Controls.Add(this.lb_Album);
            this.gb_Midias.Controls.Add(this.tb_altAutor);
            this.gb_Midias.Controls.Add(this.tb_altInterprete);
            this.gb_Midias.Controls.Add(this.lb_Autor);
            this.gb_Midias.Controls.Add(this.lb_Interprete);
            this.gb_Midias.Location = new System.Drawing.Point(12, 5);
            this.gb_Midias.Name = "gb_Midias";
            this.gb_Midias.Size = new System.Drawing.Size(550, 420);
            this.gb_Midias.TabIndex = 4;
            this.gb_Midias.TabStop = false;
            this.gb_Midias.Text = "Características";
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
            // rtb_altObservacao
            // 
            this.rtb_altObservacao.Location = new System.Drawing.Point(10, 283);
            this.rtb_altObservacao.Name = "rtb_altObservacao";
            this.rtb_altObservacao.Size = new System.Drawing.Size(533, 96);
            this.rtb_altObservacao.TabIndex = 29;
            this.rtb_altObservacao.Text = "";
            // 
            // bt_Apagar
            // 
            this.bt_Apagar.Location = new System.Drawing.Point(387, 385);
            this.bt_Apagar.Name = "bt_Apagar";
            this.bt_Apagar.Size = new System.Drawing.Size(75, 23);
            this.bt_Apagar.TabIndex = 28;
            this.bt_Apagar.Text = "&Apagar";
            this.bt_Apagar.UseVisualStyleBackColor = true;
            // 
            // bt_Alterar
            // 
            this.bt_Alterar.Location = new System.Drawing.Point(468, 385);
            this.bt_Alterar.Name = "bt_Alterar";
            this.bt_Alterar.Size = new System.Drawing.Size(75, 23);
            this.bt_Alterar.TabIndex = 26;
            this.bt_Alterar.Text = "&Alterar";
            this.bt_Alterar.UseVisualStyleBackColor = true;
            this.bt_Alterar.Click += new System.EventHandler(this.bt_Alterar_Click);
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
            // cb_altNota
            // 
            this.cb_altNota.FormattingEnabled = true;
            this.cb_altNota.Items.AddRange(new object[] {
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
            this.cb_altNota.Location = new System.Drawing.Point(410, 243);
            this.cb_altNota.Name = "cb_altNota";
            this.cb_altNota.Size = new System.Drawing.Size(82, 21);
            this.cb_altNota.TabIndex = 24;
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
            // tb_altOrigemcompra
            // 
            this.tb_altOrigemcompra.Location = new System.Drawing.Point(10, 196);
            this.tb_altOrigemcompra.Name = "tb_altOrigemcompra";
            this.tb_altOrigemcompra.Size = new System.Drawing.Size(534, 20);
            this.tb_altOrigemcompra.TabIndex = 22;
            // 
            // dtp_altDataAlbum
            // 
            this.dtp_altDataAlbum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_altDataAlbum.Location = new System.Drawing.Point(303, 244);
            this.dtp_altDataAlbum.Name = "dtp_altDataAlbum";
            this.dtp_altDataAlbum.Size = new System.Drawing.Size(101, 20);
            this.dtp_altDataAlbum.TabIndex = 21;
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
            // cb_altTipomidia
            // 
            this.cb_altTipomidia.FormattingEnabled = true;
            this.cb_altTipomidia.Items.AddRange(new object[] {
            "Selecione...",
            "Vinil",
            "K7",
            "CD",
            "DVD",
            "Digital"});
            this.cb_altTipomidia.Location = new System.Drawing.Point(10, 243);
            this.cb_altTipomidia.Name = "cb_altTipomidia";
            this.cb_altTipomidia.Size = new System.Drawing.Size(182, 21);
            this.cb_altTipomidia.TabIndex = 19;
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
            // dtp_altDataCompra
            // 
            this.dtp_altDataCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_altDataCompra.Location = new System.Drawing.Point(198, 244);
            this.dtp_altDataCompra.Name = "dtp_altDataCompra";
            this.dtp_altDataCompra.Size = new System.Drawing.Size(99, 20);
            this.dtp_altDataCompra.TabIndex = 16;
            // 
            // tb_altNomemusica
            // 
            this.tb_altNomemusica.Location = new System.Drawing.Point(10, 156);
            this.tb_altNomemusica.Name = "tb_altNomemusica";
            this.tb_altNomemusica.Size = new System.Drawing.Size(534, 20);
            this.tb_altNomemusica.TabIndex = 15;
            // 
            // tb_altAlbum
            // 
            this.tb_altAlbum.Location = new System.Drawing.Point(10, 117);
            this.tb_altAlbum.Name = "tb_altAlbum";
            this.tb_altAlbum.Size = new System.Drawing.Size(534, 20);
            this.tb_altAlbum.TabIndex = 14;
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
            // tb_altAutor
            // 
            this.tb_altAutor.Location = new System.Drawing.Point(10, 76);
            this.tb_altAutor.Name = "tb_altAutor";
            this.tb_altAutor.Size = new System.Drawing.Size(534, 20);
            this.tb_altAutor.TabIndex = 11;
            // 
            // tb_altInterprete
            // 
            this.tb_altInterprete.Location = new System.Drawing.Point(10, 37);
            this.tb_altInterprete.Name = "tb_altInterprete";
            this.tb_altInterprete.Size = new System.Drawing.Size(534, 20);
            this.tb_altInterprete.TabIndex = 9;
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
            // fm_AlterarMidia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 437);
            this.Controls.Add(this.gb_Midias);
            this.Name = "fm_AlterarMidia";
            this.Text = "fm_AlterarMidia";
            this.gb_Midias.ResumeLayout(false);
            this.gb_Midias.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Midias;
        private System.Windows.Forms.Label lb_Observacao;
        private System.Windows.Forms.RichTextBox rtb_altObservacao;
        private System.Windows.Forms.Button bt_Apagar;
        private System.Windows.Forms.Button bt_Alterar;
        private System.Windows.Forms.Label lb_Nota;
        private System.Windows.Forms.ComboBox cb_altNota;
        private System.Windows.Forms.Label lb_Origemcompra;
        private System.Windows.Forms.TextBox tb_altOrigemcompra;
        private System.Windows.Forms.DateTimePicker dtp_altDataAlbum;
        private System.Windows.Forms.Label lb_Dataalbum;
        private System.Windows.Forms.ComboBox cb_altTipomidia;
        private System.Windows.Forms.Label lb_Tipomidia;
        private System.Windows.Forms.Label lb_Datacompra;
        private System.Windows.Forms.DateTimePicker dtp_altDataCompra;
        private System.Windows.Forms.TextBox tb_altNomemusica;
        private System.Windows.Forms.TextBox tb_altAlbum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_Album;
        private System.Windows.Forms.TextBox tb_altAutor;
        private System.Windows.Forms.TextBox tb_altInterprete;
        private System.Windows.Forms.Label lb_Autor;
        private System.Windows.Forms.Label lb_Interprete;
    }
}