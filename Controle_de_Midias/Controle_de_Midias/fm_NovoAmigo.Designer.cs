namespace Controle_de_Midias
{
    partial class fm_NovoAmigo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fm_NovoAmigo));
            this.lb_Nome = new System.Windows.Forms.Label();
            this.tb_Nome = new System.Windows.Forms.TextBox();
            this.lb_Telefone = new System.Windows.Forms.Label();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.lb_email = new System.Windows.Forms.Label();
            this.lb_observacao = new System.Windows.Forms.Label();
            this.rtb_Observacao = new System.Windows.Forms.RichTextBox();
            this.gb_menu = new System.Windows.Forms.GroupBox();
            this.pn_imgDesconecido = new System.Windows.Forms.Panel();
            this.pb_Amigo = new System.Windows.Forms.PictureBox();
            this.bt_InserirImagem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_InfoUsuario = new System.Windows.Forms.Label();
            this.bt_Limpar = new System.Windows.Forms.Button();
            this.bt_Adicionar = new System.Windows.Forms.Button();
            this.tb_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.Erro = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gb_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Amigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Erro)).BeginInit();
            this.SuspendLayout();
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
            // tb_Nome
            // 
            this.tb_Nome.Location = new System.Drawing.Point(6, 32);
            this.tb_Nome.Name = "tb_Nome";
            this.tb_Nome.Size = new System.Drawing.Size(266, 20);
            this.tb_Nome.TabIndex = 1;
            this.tb_Nome.Enter += new System.EventHandler(this.tb_Nome_Enter);
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
            // tb_Email
            // 
            this.tb_Email.Location = new System.Drawing.Point(6, 71);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(266, 20);
            this.tb_Email.TabIndex = 2;
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
            // lb_observacao
            // 
            this.lb_observacao.AutoSize = true;
            this.lb_observacao.Location = new System.Drawing.Point(3, 139);
            this.lb_observacao.Name = "lb_observacao";
            this.lb_observacao.Size = new System.Drawing.Size(65, 13);
            this.lb_observacao.TabIndex = 6;
            this.lb_observacao.Text = "Observação";
            // 
            // rtb_Observacao
            // 
            this.rtb_Observacao.Location = new System.Drawing.Point(6, 155);
            this.rtb_Observacao.Name = "rtb_Observacao";
            this.rtb_Observacao.Size = new System.Drawing.Size(207, 71);
            this.rtb_Observacao.TabIndex = 4;
            this.rtb_Observacao.Text = "";
            // 
            // gb_menu
            // 
            this.gb_menu.Controls.Add(this.pn_imgDesconecido);
            this.gb_menu.Controls.Add(this.pb_Amigo);
            this.gb_menu.Controls.Add(this.bt_InserirImagem);
            this.gb_menu.Controls.Add(this.panel1);
            this.gb_menu.Controls.Add(this.lb_InfoUsuario);
            this.gb_menu.Controls.Add(this.bt_Limpar);
            this.gb_menu.Controls.Add(this.bt_Adicionar);
            this.gb_menu.Controls.Add(this.tb_Telefone);
            this.gb_menu.Controls.Add(this.rtb_Observacao);
            this.gb_menu.Controls.Add(this.lb_Nome);
            this.gb_menu.Controls.Add(this.tb_Nome);
            this.gb_menu.Controls.Add(this.lb_Telefone);
            this.gb_menu.Controls.Add(this.lb_observacao);
            this.gb_menu.Controls.Add(this.tb_Email);
            this.gb_menu.Controls.Add(this.lb_email);
            this.gb_menu.Location = new System.Drawing.Point(9, 12);
            this.gb_menu.Name = "gb_menu";
            this.gb_menu.Size = new System.Drawing.Size(427, 311);
            this.gb_menu.TabIndex = 9;
            this.gb_menu.TabStop = false;
            this.gb_menu.Text = "Amigo";
            // 
            // pn_imgDesconecido
            // 
            this.pn_imgDesconecido.BackgroundImage = global::Controle_de_Midias.Properties.Resources.user;
            this.pn_imgDesconecido.Location = new System.Drawing.Point(292, 16);
            this.pn_imgDesconecido.Name = "pn_imgDesconecido";
            this.pn_imgDesconecido.Size = new System.Drawing.Size(123, 130);
            this.pn_imgDesconecido.TabIndex = 22;
            // 
            // pb_Amigo
            // 
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
            // lb_InfoUsuario
            // 
            this.lb_InfoUsuario.AutoSize = true;
            this.lb_InfoUsuario.ForeColor = System.Drawing.Color.Red;
            this.lb_InfoUsuario.Location = new System.Drawing.Point(3, 229);
            this.lb_InfoUsuario.Name = "lb_InfoUsuario";
            this.lb_InfoUsuario.Size = new System.Drawing.Size(146, 13);
            this.lb_InfoUsuario.TabIndex = 10;
            this.lb_InfoUsuario.Text = "O campo nome é obrigatório !";
            this.lb_InfoUsuario.Visible = false;
            // 
            // bt_Limpar
            // 
            this.bt_Limpar.Location = new System.Drawing.Point(259, 257);
            this.bt_Limpar.Name = "bt_Limpar";
            this.bt_Limpar.Size = new System.Drawing.Size(75, 23);
            this.bt_Limpar.TabIndex = 6;
            this.bt_Limpar.Text = "&Limpar";
            this.bt_Limpar.UseVisualStyleBackColor = true;
            this.bt_Limpar.Click += new System.EventHandler(this.bt_Limpar_Click);
            // 
            // bt_Adicionar
            // 
            this.bt_Adicionar.Location = new System.Drawing.Point(340, 256);
            this.bt_Adicionar.Name = "bt_Adicionar";
            this.bt_Adicionar.Size = new System.Drawing.Size(75, 23);
            this.bt_Adicionar.TabIndex = 5;
            this.bt_Adicionar.Text = "&Adiconar";
            this.bt_Adicionar.UseVisualStyleBackColor = true;
            this.bt_Adicionar.Click += new System.EventHandler(this.bt_Adicionar_Click);
            // 
            // tb_Telefone
            // 
            this.tb_Telefone.Location = new System.Drawing.Point(6, 110);
            this.tb_Telefone.Mask = "(00) - 0000-0000";
            this.tb_Telefone.Name = "tb_Telefone";
            this.tb_Telefone.Size = new System.Drawing.Size(100, 20);
            this.tb_Telefone.TabIndex = 3;
            // 
            // Erro
            // 
            this.Erro.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fm_NovoAmigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(440, 327);
            this.Controls.Add(this.gb_menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fm_NovoAmigo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Amigo";
            this.gb_menu.ResumeLayout(false);
            this.gb_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Amigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Erro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_Nome;
        private System.Windows.Forms.TextBox tb_Nome;
        private System.Windows.Forms.Label lb_Telefone;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.Label lb_observacao;
        private System.Windows.Forms.RichTextBox rtb_Observacao;
        private System.Windows.Forms.GroupBox gb_menu;
        private System.Windows.Forms.Button bt_Adicionar;
        private System.Windows.Forms.ErrorProvider Erro;
        private System.Windows.Forms.Label lb_InfoUsuario;
        private System.Windows.Forms.MaskedTextBox tb_Telefone;
        private System.Windows.Forms.Button bt_Limpar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_InserirImagem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pb_Amigo;
        private System.Windows.Forms.Panel pn_imgDesconecido;
    }
}