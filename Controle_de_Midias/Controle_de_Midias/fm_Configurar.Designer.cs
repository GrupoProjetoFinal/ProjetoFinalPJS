namespace Controle_de_Midias
{
    partial class fm_Configurar
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
            this.label1 = new System.Windows.Forms.Label();
            this.lb_qtdDias = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_UsuarioAntigo = new System.Windows.Forms.Label();
            this.lb_emailAntigo = new System.Windows.Forms.Label();
            this.tb_qtdDias = new System.Windows.Forms.TextBox();
            this.tb_nomeUsuario = new System.Windows.Forms.TextBox();
            this.tb_NovaSenha = new System.Windows.Forms.TextBox();
            this.tb_ConfirmaSenha = new System.Windows.Forms.TextBox();
            this.lb_SenhaAtual = new System.Windows.Forms.Label();
            this.lb_NovaSenha = new System.Windows.Forms.Label();
            this.lb_ConfirmaSenha = new System.Windows.Forms.Label();
            this.tb_EmailPadrao = new System.Windows.Forms.TextBox();
            this.lb_NovoNome = new System.Windows.Forms.Label();
            this.tb_SenhaAtual = new System.Windows.Forms.TextBox();
            this.ck_DesabilitaLogin = new System.Windows.Forms.CheckBox();
            this.bt_Confirma = new System.Windows.Forms.Button();
            this.bt_Cancelar = new System.Windows.Forms.Button();
            this.lb_SenhasDiferentes = new System.Windows.Forms.Label();
            this.lb_SenhaIncorreta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quantidades de dias para informar atrazo de midia";
            // 
            // lb_qtdDias
            // 
            this.lb_qtdDias.AutoSize = true;
            this.lb_qtdDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_qtdDias.Location = new System.Drawing.Point(268, 126);
            this.lb_qtdDias.Name = "lb_qtdDias";
            this.lb_qtdDias.Size = new System.Drawing.Size(32, 13);
            this.lb_qtdDias.TabIndex = 1;
            this.lb_qtdDias.Text = "Dias";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email Padrão";
            // 
            // lb_UsuarioAntigo
            // 
            this.lb_UsuarioAntigo.AutoSize = true;
            this.lb_UsuarioAntigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_UsuarioAntigo.Location = new System.Drawing.Point(113, 18);
            this.lb_UsuarioAntigo.Name = "lb_UsuarioAntigo";
            this.lb_UsuarioAntigo.Size = new System.Drawing.Size(104, 13);
            this.lb_UsuarioAntigo.TabIndex = 4;
            this.lb_UsuarioAntigo.Text = "Nome do Usuario";
            // 
            // lb_emailAntigo
            // 
            this.lb_emailAntigo.AutoSize = true;
            this.lb_emailAntigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_emailAntigo.Location = new System.Drawing.Point(84, 87);
            this.lb_emailAntigo.Name = "lb_emailAntigo";
            this.lb_emailAntigo.Size = new System.Drawing.Size(152, 13);
            this.lb_emailAntigo.TabIndex = 5;
            this.lb_emailAntigo.Text = "email_usuario@gmail.com";
            // 
            // tb_qtdDias
            // 
            this.tb_qtdDias.Location = new System.Drawing.Point(12, 142);
            this.tb_qtdDias.Name = "tb_qtdDias";
            this.tb_qtdDias.Size = new System.Drawing.Size(29, 20);
            this.tb_qtdDias.TabIndex = 2;
            // 
            // tb_nomeUsuario
            // 
            this.tb_nomeUsuario.Location = new System.Drawing.Point(12, 64);
            this.tb_nomeUsuario.Name = "tb_nomeUsuario";
            this.tb_nomeUsuario.Size = new System.Drawing.Size(113, 20);
            this.tb_nomeUsuario.TabIndex = 0;
            // 
            // tb_NovaSenha
            // 
            this.tb_NovaSenha.Location = new System.Drawing.Point(11, 181);
            this.tb_NovaSenha.Name = "tb_NovaSenha";
            this.tb_NovaSenha.PasswordChar = '●';
            this.tb_NovaSenha.Size = new System.Drawing.Size(83, 20);
            this.tb_NovaSenha.TabIndex = 3;
            // 
            // tb_ConfirmaSenha
            // 
            this.tb_ConfirmaSenha.Location = new System.Drawing.Point(11, 222);
            this.tb_ConfirmaSenha.Name = "tb_ConfirmaSenha";
            this.tb_ConfirmaSenha.PasswordChar = '●';
            this.tb_ConfirmaSenha.Size = new System.Drawing.Size(83, 20);
            this.tb_ConfirmaSenha.TabIndex = 4;
            // 
            // lb_SenhaAtual
            // 
            this.lb_SenhaAtual.AutoSize = true;
            this.lb_SenhaAtual.Location = new System.Drawing.Point(12, 262);
            this.lb_SenhaAtual.Name = "lb_SenhaAtual";
            this.lb_SenhaAtual.Size = new System.Drawing.Size(182, 13);
            this.lb_SenhaAtual.TabIndex = 10;
            this.lb_SenhaAtual.Text = "Digite sua senha atual para confirmar";
            // 
            // lb_NovaSenha
            // 
            this.lb_NovaSenha.AutoSize = true;
            this.lb_NovaSenha.Location = new System.Drawing.Point(8, 165);
            this.lb_NovaSenha.Name = "lb_NovaSenha";
            this.lb_NovaSenha.Size = new System.Drawing.Size(67, 13);
            this.lb_NovaSenha.TabIndex = 11;
            this.lb_NovaSenha.Text = "Nova Senha";
            // 
            // lb_ConfirmaSenha
            // 
            this.lb_ConfirmaSenha.AutoSize = true;
            this.lb_ConfirmaSenha.Location = new System.Drawing.Point(12, 206);
            this.lb_ConfirmaSenha.Name = "lb_ConfirmaSenha";
            this.lb_ConfirmaSenha.Size = new System.Drawing.Size(82, 13);
            this.lb_ConfirmaSenha.TabIndex = 12;
            this.lb_ConfirmaSenha.Text = "Confirma Senha";
            // 
            // tb_EmailPadrao
            // 
            this.tb_EmailPadrao.Location = new System.Drawing.Point(12, 103);
            this.tb_EmailPadrao.Name = "tb_EmailPadrao";
            this.tb_EmailPadrao.Size = new System.Drawing.Size(288, 20);
            this.tb_EmailPadrao.TabIndex = 1;
            // 
            // lb_NovoNome
            // 
            this.lb_NovoNome.AutoSize = true;
            this.lb_NovoNome.Location = new System.Drawing.Point(9, 48);
            this.lb_NovoNome.Name = "lb_NovoNome";
            this.lb_NovoNome.Size = new System.Drawing.Size(62, 13);
            this.lb_NovoNome.TabIndex = 15;
            this.lb_NovoNome.Text = "Novo nome";
            // 
            // tb_SenhaAtual
            // 
            this.tb_SenhaAtual.Location = new System.Drawing.Point(15, 278);
            this.tb_SenhaAtual.Name = "tb_SenhaAtual";
            this.tb_SenhaAtual.PasswordChar = '●';
            this.tb_SenhaAtual.Size = new System.Drawing.Size(83, 20);
            this.tb_SenhaAtual.TabIndex = 6;
            this.tb_SenhaAtual.Enter += new System.EventHandler(this.tb_SenhaAtual_Enter);
            // 
            // ck_DesabilitaLogin
            // 
            this.ck_DesabilitaLogin.AutoSize = true;
            this.ck_DesabilitaLogin.Location = new System.Drawing.Point(196, 184);
            this.ck_DesabilitaLogin.Name = "ck_DesabilitaLogin";
            this.ck_DesabilitaLogin.Size = new System.Drawing.Size(104, 17);
            this.ck_DesabilitaLogin.TabIndex = 5;
            this.ck_DesabilitaLogin.Text = "Desabilitar Login";
            this.ck_DesabilitaLogin.UseVisualStyleBackColor = true;
            // 
            // bt_Confirma
            // 
            this.bt_Confirma.Location = new System.Drawing.Point(235, 325);
            this.bt_Confirma.Name = "bt_Confirma";
            this.bt_Confirma.Size = new System.Drawing.Size(75, 23);
            this.bt_Confirma.TabIndex = 8;
            this.bt_Confirma.Text = "&Confirmar";
            this.bt_Confirma.UseVisualStyleBackColor = true;
            this.bt_Confirma.Click += new System.EventHandler(this.bt_Confirma_Click);
            // 
            // bt_Cancelar
            // 
            this.bt_Cancelar.Location = new System.Drawing.Point(152, 325);
            this.bt_Cancelar.Name = "bt_Cancelar";
            this.bt_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.bt_Cancelar.TabIndex = 7;
            this.bt_Cancelar.Text = "&Cancelar";
            this.bt_Cancelar.UseVisualStyleBackColor = true;
            this.bt_Cancelar.Click += new System.EventHandler(this.bt_Cancelar_Click);
            // 
            // lb_SenhasDiferentes
            // 
            this.lb_SenhasDiferentes.AutoSize = true;
            this.lb_SenhasDiferentes.BackColor = System.Drawing.SystemColors.Control;
            this.lb_SenhasDiferentes.ForeColor = System.Drawing.Color.Red;
            this.lb_SenhasDiferentes.Location = new System.Drawing.Point(8, 245);
            this.lb_SenhasDiferentes.Name = "lb_SenhasDiferentes";
            this.lb_SenhasDiferentes.Size = new System.Drawing.Size(139, 13);
            this.lb_SenhasDiferentes.TabIndex = 16;
            this.lb_SenhasDiferentes.Text = "✘As senhas não são iguais";
            this.lb_SenhasDiferentes.Visible = false;
            // 
            // lb_SenhaIncorreta
            // 
            this.lb_SenhaIncorreta.AutoSize = true;
            this.lb_SenhaIncorreta.BackColor = System.Drawing.SystemColors.Control;
            this.lb_SenhaIncorreta.ForeColor = System.Drawing.Color.Red;
            this.lb_SenhaIncorreta.Location = new System.Drawing.Point(12, 301);
            this.lb_SenhaIncorreta.Name = "lb_SenhaIncorreta";
            this.lb_SenhaIncorreta.Size = new System.Drawing.Size(95, 13);
            this.lb_SenhaIncorreta.TabIndex = 17;
            this.lb_SenhaIncorreta.Text = "✘Senha Incorreta";
            this.lb_SenhaIncorreta.Visible = false;
            // 
            // fm_Configurar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 360);
            this.Controls.Add(this.lb_SenhaIncorreta);
            this.Controls.Add(this.lb_SenhasDiferentes);
            this.Controls.Add(this.bt_Cancelar);
            this.Controls.Add(this.bt_Confirma);
            this.Controls.Add(this.ck_DesabilitaLogin);
            this.Controls.Add(this.lb_NovoNome);
            this.Controls.Add(this.tb_SenhaAtual);
            this.Controls.Add(this.tb_EmailPadrao);
            this.Controls.Add(this.lb_ConfirmaSenha);
            this.Controls.Add(this.lb_NovaSenha);
            this.Controls.Add(this.lb_SenhaAtual);
            this.Controls.Add(this.tb_ConfirmaSenha);
            this.Controls.Add(this.tb_NovaSenha);
            this.Controls.Add(this.tb_nomeUsuario);
            this.Controls.Add(this.tb_qtdDias);
            this.Controls.Add(this.lb_emailAntigo);
            this.Controls.Add(this.lb_UsuarioAntigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_qtdDias);
            this.Controls.Add(this.label1);
            this.Name = "fm_Configurar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações";
            this.Load += new System.EventHandler(this.fm_Configurar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_qtdDias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_UsuarioAntigo;
        private System.Windows.Forms.Label lb_emailAntigo;
        private System.Windows.Forms.TextBox tb_qtdDias;
        private System.Windows.Forms.TextBox tb_nomeUsuario;
        private System.Windows.Forms.TextBox tb_NovaSenha;
        private System.Windows.Forms.TextBox tb_ConfirmaSenha;
        private System.Windows.Forms.Label lb_SenhaAtual;
        private System.Windows.Forms.Label lb_NovaSenha;
        private System.Windows.Forms.Label lb_ConfirmaSenha;
        private System.Windows.Forms.TextBox tb_EmailPadrao;
        private System.Windows.Forms.Label lb_NovoNome;
        private System.Windows.Forms.TextBox tb_SenhaAtual;
        private System.Windows.Forms.CheckBox ck_DesabilitaLogin;
        private System.Windows.Forms.Button bt_Confirma;
        private System.Windows.Forms.Button bt_Cancelar;
        private System.Windows.Forms.Label lb_SenhasDiferentes;
        private System.Windows.Forms.Label lb_SenhaIncorreta;
    }
}