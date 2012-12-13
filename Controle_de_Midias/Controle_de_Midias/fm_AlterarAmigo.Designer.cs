namespace Controle_de_Midias
{
    partial class fm_AlterarAmigo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fm_AlterarAmigo));
            this.bt_Excluir = new System.Windows.Forms.Button();
            this.bt_Alterar = new System.Windows.Forms.Button();
            this.erroP = new System.Windows.Forms.ErrorProvider(this.components);
            this.gb_menu = new System.Windows.Forms.GroupBox();
            this.pb_Amigo = new System.Windows.Forms.PictureBox();
            this.bt_InserirImagem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_InformaUsuario = new System.Windows.Forms.Label();
            this.tb_TelefoneAlt = new System.Windows.Forms.MaskedTextBox();
            this.rtb_ObservacaoAlt = new System.Windows.Forms.RichTextBox();
            this.lb_Nome = new System.Windows.Forms.Label();
            this.tb_NomeAlt = new System.Windows.Forms.TextBox();
            this.lb_Telefone = new System.Windows.Forms.Label();
            this.lb_observacao = new System.Windows.Forms.Label();
            this.tb_EmailAlt = new System.Windows.Forms.TextBox();
            this.lb_email = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.erroP)).BeginInit();
            this.gb_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Amigo)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_Excluir
            // 
            this.bt_Excluir.Location = new System.Drawing.Point(265, 257);
            this.bt_Excluir.Name = "bt_Excluir";
            this.bt_Excluir.Size = new System.Drawing.Size(75, 23);
            this.bt_Excluir.TabIndex = 6;
            this.bt_Excluir.Text = "&Apagar";
            this.bt_Excluir.UseVisualStyleBackColor = true;
            this.bt_Excluir.Click += new System.EventHandler(this.bt_Excluir_Click);
            // 
            // bt_Alterar
            // 
            this.bt_Alterar.Location = new System.Drawing.Point(346, 257);
            this.bt_Alterar.Name = "bt_Alterar";
            this.bt_Alterar.Size = new System.Drawing.Size(75, 23);
            this.bt_Alterar.TabIndex = 5;
            this.bt_Alterar.Text = "&Alterar";
            this.bt_Alterar.UseVisualStyleBackColor = true;
            this.bt_Alterar.Click += new System.EventHandler(this.bt_Alterar_Click);
            // 
            // erroP
            // 
            this.erroP.ContainerControl = this;
            // 
            // gb_menu
            // 
            this.gb_menu.Controls.Add(this.pb_Amigo);
            this.gb_menu.Controls.Add(this.bt_InserirImagem);
            this.gb_menu.Controls.Add(this.bt_Excluir);
            this.gb_menu.Controls.Add(this.panel1);
            this.gb_menu.Controls.Add(this.bt_Alterar);
            this.gb_menu.Controls.Add(this.lb_InformaUsuario);
            this.gb_menu.Controls.Add(this.tb_TelefoneAlt);
            this.gb_menu.Controls.Add(this.rtb_ObservacaoAlt);
            this.gb_menu.Controls.Add(this.lb_Nome);
            this.gb_menu.Controls.Add(this.tb_NomeAlt);
            this.gb_menu.Controls.Add(this.lb_Telefone);
            this.gb_menu.Controls.Add(this.lb_observacao);
            this.gb_menu.Controls.Add(this.tb_EmailAlt);
            this.gb_menu.Controls.Add(this.lb_email);
            this.gb_menu.Location = new System.Drawing.Point(3, 3);
            this.gb_menu.Name = "gb_menu";
            this.gb_menu.Size = new System.Drawing.Size(427, 311);
            this.gb_menu.TabIndex = 11;
            this.gb_menu.TabStop = false;
            this.gb_menu.Text = "Amigo";
            // 
            // pb_Amigo
            // 
            this.pb_Amigo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_Amigo.Location = new System.Drawing.Point(292, 16);
            this.pb_Amigo.Name = "pb_Amigo";
            this.pb_Amigo.Size = new System.Drawing.Size(123, 131);
            this.pb_Amigo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Amigo.TabIndex = 22;
            this.pb_Amigo.TabStop = false;
            // 
            // bt_InserirImagem
            // 
            this.bt_InserirImagem.Location = new System.Drawing.Point(340, 153);
            this.bt_InserirImagem.Name = "bt_InserirImagem";
            this.bt_InserirImagem.Size = new System.Drawing.Size(75, 23);
            this.bt_InserirImagem.TabIndex = 10;
            this.bt_InserirImagem.Text = "&Escolher";
            this.bt_InserirImagem.UseVisualStyleBackColor = true;
            this.bt_InserirImagem.Click += new System.EventHandler(this.bt_InserirImagem_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Controle_de_Midias.Properties.Resources.lgn_usuario;
            this.panel1.Location = new System.Drawing.Point(6, 257);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(49, 47);
            this.panel1.TabIndex = 21;
            // 
            // lb_InformaUsuario
            // 
            this.lb_InformaUsuario.AutoSize = true;
            this.lb_InformaUsuario.ForeColor = System.Drawing.Color.Red;
            this.lb_InformaUsuario.Location = new System.Drawing.Point(3, 229);
            this.lb_InformaUsuario.Name = "lb_InformaUsuario";
            this.lb_InformaUsuario.Size = new System.Drawing.Size(146, 13);
            this.lb_InformaUsuario.TabIndex = 10;
            this.lb_InformaUsuario.Text = "O campo nome é obrigatório !";
            this.lb_InformaUsuario.Visible = false;
            // 
            // tb_TelefoneAlt
            // 
            this.tb_TelefoneAlt.Location = new System.Drawing.Point(6, 110);
            this.tb_TelefoneAlt.Mask = "(00) - 0000-0000";
            this.tb_TelefoneAlt.Name = "tb_TelefoneAlt";
            this.tb_TelefoneAlt.Size = new System.Drawing.Size(100, 20);
            this.tb_TelefoneAlt.TabIndex = 3;
            // 
            // rtb_ObservacaoAlt
            // 
            this.rtb_ObservacaoAlt.Location = new System.Drawing.Point(6, 155);
            this.rtb_ObservacaoAlt.Name = "rtb_ObservacaoAlt";
            this.rtb_ObservacaoAlt.Size = new System.Drawing.Size(207, 71);
            this.rtb_ObservacaoAlt.TabIndex = 4;
            this.rtb_ObservacaoAlt.Text = "";
            // 
            // lb_Nome
            // 
            this.lb_Nome.AutoSize = true;
            this.lb_Nome.Location = new System.Drawing.Point(3, 16);
            this.lb_Nome.Name = "lb_Nome";
            this.lb_Nome.Size = new System.Drawing.Size(35, 13);
            this.lb_Nome.TabIndex = 0;
            this.lb_Nome.Text = "Nome";
            // 
            // tb_NomeAlt
            // 
            this.tb_NomeAlt.Location = new System.Drawing.Point(6, 32);
            this.tb_NomeAlt.Name = "tb_NomeAlt";
            this.tb_NomeAlt.Size = new System.Drawing.Size(266, 20);
            this.tb_NomeAlt.TabIndex = 1;
            // 
            // lb_Telefone
            // 
            this.lb_Telefone.AutoSize = true;
            this.lb_Telefone.Location = new System.Drawing.Point(3, 94);
            this.lb_Telefone.Name = "lb_Telefone";
            this.lb_Telefone.Size = new System.Drawing.Size(49, 13);
            this.lb_Telefone.TabIndex = 2;
            this.lb_Telefone.Text = "Telefone";
            // 
            // lb_observacao
            // 
            this.lb_observacao.AutoSize = true;
            this.lb_observacao.Location = new System.Drawing.Point(3, 139);
            this.lb_observacao.Name = "lb_observacao";
            this.lb_observacao.Size = new System.Drawing.Size(65, 13);
            this.lb_observacao.TabIndex = 6;
            this.lb_observacao.Text = "Observação";
            // 
            // tb_EmailAlt
            // 
            this.tb_EmailAlt.Location = new System.Drawing.Point(6, 71);
            this.tb_EmailAlt.Name = "tb_EmailAlt";
            this.tb_EmailAlt.Size = new System.Drawing.Size(266, 20);
            this.tb_EmailAlt.TabIndex = 2;
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Location = new System.Drawing.Point(3, 55);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(35, 13);
            this.lb_email.TabIndex = 4;
            this.lb_email.Text = "E-mail";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fm_AlterarAmigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(434, 318);
            this.Controls.Add(this.gb_menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fm_AlterarAmigo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar dados do amigo";
            this.Load += new System.EventHandler(this.fm_AlterarAmigo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erroP)).EndInit();
            this.gb_menu.ResumeLayout(false);
            this.gb_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Amigo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_Excluir;
        private System.Windows.Forms.Button bt_Alterar;
        private System.Windows.Forms.ErrorProvider erroP;
        private System.Windows.Forms.GroupBox gb_menu;
        private System.Windows.Forms.PictureBox pb_Amigo;
        private System.Windows.Forms.Button bt_InserirImagem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_InformaUsuario;
        private System.Windows.Forms.MaskedTextBox tb_TelefoneAlt;
        private System.Windows.Forms.RichTextBox rtb_ObservacaoAlt;
        private System.Windows.Forms.Label lb_Nome;
        private System.Windows.Forms.TextBox tb_NomeAlt;
        private System.Windows.Forms.Label lb_Telefone;
        private System.Windows.Forms.Label lb_observacao;
        private System.Windows.Forms.TextBox tb_EmailAlt;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}