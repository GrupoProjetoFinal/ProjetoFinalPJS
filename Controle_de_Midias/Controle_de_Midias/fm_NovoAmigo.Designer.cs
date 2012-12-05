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
            this.lb_Nome = new System.Windows.Forms.Label();
            this.tb_Nome = new System.Windows.Forms.TextBox();
            this.tb_Telefone = new System.Windows.Forms.TextBox();
            this.lb_Telefone = new System.Windows.Forms.Label();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.lb_email = new System.Windows.Forms.Label();
            this.lb_observacao = new System.Windows.Forms.Label();
            this.rtb_Observacao = new System.Windows.Forms.RichTextBox();
            this.gb_menu = new System.Windows.Forms.GroupBox();
            this.bt_Adicionar = new System.Windows.Forms.Button();
            this.Erro = new System.Windows.Forms.ErrorProvider(this.components);
            this.lb_InfoUsuario = new System.Windows.Forms.Label();
            this.gb_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Erro)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Nome
            // 
            this.lb_Nome.AutoSize = true;
            this.lb_Nome.Location = new System.Drawing.Point(101, 12);
            this.lb_Nome.Name = "lb_Nome";
            this.lb_Nome.Size = new System.Drawing.Size(35, 13);
            this.lb_Nome.TabIndex = 0;
            this.lb_Nome.Text = "Nome";
            // 
            // tb_Nome
            // 
            this.tb_Nome.Location = new System.Drawing.Point(104, 28);
            this.tb_Nome.Name = "tb_Nome";
            this.tb_Nome.Size = new System.Drawing.Size(300, 20);
            this.tb_Nome.TabIndex = 1;
            this.tb_Nome.Enter += new System.EventHandler(this.tb_Nome_Enter);
            // 
            // tb_Telefone
            // 
            this.tb_Telefone.Location = new System.Drawing.Point(104, 67);
            this.tb_Telefone.Name = "tb_Telefone";
            this.tb_Telefone.Size = new System.Drawing.Size(300, 20);
            this.tb_Telefone.TabIndex = 3;
            // 
            // lb_Telefone
            // 
            this.lb_Telefone.AutoSize = true;
            this.lb_Telefone.Location = new System.Drawing.Point(101, 51);
            this.lb_Telefone.Name = "lb_Telefone";
            this.lb_Telefone.Size = new System.Drawing.Size(49, 13);
            this.lb_Telefone.TabIndex = 2;
            this.lb_Telefone.Text = "Telefone";
            // 
            // tb_Email
            // 
            this.tb_Email.Location = new System.Drawing.Point(104, 106);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(300, 20);
            this.tb_Email.TabIndex = 5;
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Location = new System.Drawing.Point(101, 90);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(35, 13);
            this.lb_email.TabIndex = 4;
            this.lb_email.Text = "E-mail";
            // 
            // lb_observacao
            // 
            this.lb_observacao.AutoSize = true;
            this.lb_observacao.Location = new System.Drawing.Point(101, 129);
            this.lb_observacao.Name = "lb_observacao";
            this.lb_observacao.Size = new System.Drawing.Size(65, 13);
            this.lb_observacao.TabIndex = 6;
            this.lb_observacao.Text = "Observação";
            // 
            // rtb_Observacao
            // 
            this.rtb_Observacao.Location = new System.Drawing.Point(104, 145);
            this.rtb_Observacao.Name = "rtb_Observacao";
            this.rtb_Observacao.Size = new System.Drawing.Size(300, 96);
            this.rtb_Observacao.TabIndex = 8;
            this.rtb_Observacao.Text = "";
            // 
            // gb_menu
            // 
            this.gb_menu.Controls.Add(this.bt_Adicionar);
            this.gb_menu.Location = new System.Drawing.Point(9, 12);
            this.gb_menu.Name = "gb_menu";
            this.gb_menu.Size = new System.Drawing.Size(86, 226);
            this.gb_menu.TabIndex = 9;
            this.gb_menu.TabStop = false;
            this.gb_menu.Text = "menu";
            // 
            // bt_Adicionar
            // 
            this.bt_Adicionar.Location = new System.Drawing.Point(6, 17);
            this.bt_Adicionar.Name = "bt_Adicionar";
            this.bt_Adicionar.Size = new System.Drawing.Size(75, 23);
            this.bt_Adicionar.TabIndex = 0;
            this.bt_Adicionar.Text = "&Adiconar";
            this.bt_Adicionar.UseVisualStyleBackColor = true;
            this.bt_Adicionar.Click += new System.EventHandler(this.bt_Adicionar_Click);
            // 
            // Erro
            // 
            this.Erro.ContainerControl = this;
            // 
            // lb_InfoUsuario
            // 
            this.lb_InfoUsuario.AutoSize = true;
            this.lb_InfoUsuario.Location = new System.Drawing.Point(6, 253);
            this.lb_InfoUsuario.Name = "lb_InfoUsuario";
            this.lb_InfoUsuario.Size = new System.Drawing.Size(146, 13);
            this.lb_InfoUsuario.TabIndex = 10;
            this.lb_InfoUsuario.Text = "O campo nome é obrigatório !";
            // 
            // fm_NovoAmigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 245);
            this.Controls.Add(this.lb_InfoUsuario);
            this.Controls.Add(this.gb_menu);
            this.Controls.Add(this.rtb_Observacao);
            this.Controls.Add(this.lb_observacao);
            this.Controls.Add(this.tb_Email);
            this.Controls.Add(this.lb_email);
            this.Controls.Add(this.tb_Telefone);
            this.Controls.Add(this.lb_Telefone);
            this.Controls.Add(this.tb_Nome);
            this.Controls.Add(this.lb_Nome);
            this.Name = "fm_NovoAmigo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Amigo";
            this.gb_menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Erro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Nome;
        private System.Windows.Forms.TextBox tb_Nome;
        private System.Windows.Forms.TextBox tb_Telefone;
        private System.Windows.Forms.Label lb_Telefone;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.Label lb_observacao;
        private System.Windows.Forms.RichTextBox rtb_Observacao;
        private System.Windows.Forms.GroupBox gb_menu;
        private System.Windows.Forms.Button bt_Adicionar;
        private System.Windows.Forms.ErrorProvider Erro;
        private System.Windows.Forms.Label lb_InfoUsuario;
    }
}