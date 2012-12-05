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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
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
            this.cb_DesabilitaLogin = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bt_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quantidades de dias para informar atrazo de midia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Usuário\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email Padrão";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nome do Usuario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "email_usuario@gmail.com";
            // 
            // tb_qtdDias
            // 
            this.tb_qtdDias.Location = new System.Drawing.Point(15, 33);
            this.tb_qtdDias.Name = "tb_qtdDias";
            this.tb_qtdDias.Size = new System.Drawing.Size(29, 20);
            this.tb_qtdDias.TabIndex = 6;
            // 
            // tb_nomeUsuario
            // 
            this.tb_nomeUsuario.Location = new System.Drawing.Point(76, 125);
            this.tb_nomeUsuario.Name = "tb_nomeUsuario";
            this.tb_nomeUsuario.Size = new System.Drawing.Size(83, 20);
            this.tb_nomeUsuario.TabIndex = 7;
            // 
            // tb_NovaSenha
            // 
            this.tb_NovaSenha.Location = new System.Drawing.Point(76, 177);
            this.tb_NovaSenha.Name = "tb_NovaSenha";
            this.tb_NovaSenha.Size = new System.Drawing.Size(83, 20);
            this.tb_NovaSenha.TabIndex = 8;
            this.tb_NovaSenha.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // tb_ConfirmaSenha
            // 
            this.tb_ConfirmaSenha.Location = new System.Drawing.Point(76, 203);
            this.tb_ConfirmaSenha.Name = "tb_ConfirmaSenha";
            this.tb_ConfirmaSenha.Size = new System.Drawing.Size(83, 20);
            this.tb_ConfirmaSenha.TabIndex = 9;
            this.tb_ConfirmaSenha.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // lb_SenhaAtual
            // 
            this.lb_SenhaAtual.AutoSize = true;
            this.lb_SenhaAtual.Location = new System.Drawing.Point(5, 154);
            this.lb_SenhaAtual.Name = "lb_SenhaAtual";
            this.lb_SenhaAtual.Size = new System.Drawing.Size(65, 13);
            this.lb_SenhaAtual.TabIndex = 10;
            this.lb_SenhaAtual.Text = "Senha Atual";
            // 
            // lb_NovaSenha
            // 
            this.lb_NovaSenha.AutoSize = true;
            this.lb_NovaSenha.Location = new System.Drawing.Point(37, 184);
            this.lb_NovaSenha.Name = "lb_NovaSenha";
            this.lb_NovaSenha.Size = new System.Drawing.Size(33, 13);
            this.lb_NovaSenha.TabIndex = 11;
            this.lb_NovaSenha.Text = "Nova";
            this.lb_NovaSenha.Click += new System.EventHandler(this.label8_Click);
            // 
            // lb_ConfirmaSenha
            // 
            this.lb_ConfirmaSenha.AutoSize = true;
            this.lb_ConfirmaSenha.Location = new System.Drawing.Point(22, 210);
            this.lb_ConfirmaSenha.Name = "lb_ConfirmaSenha";
            this.lb_ConfirmaSenha.Size = new System.Drawing.Size(48, 13);
            this.lb_ConfirmaSenha.TabIndex = 12;
            this.lb_ConfirmaSenha.Text = "Confirma";
            this.lb_ConfirmaSenha.Click += new System.EventHandler(this.label9_Click);
            // 
            // tb_EmailPadrao
            // 
            this.tb_EmailPadrao.Location = new System.Drawing.Point(15, 75);
            this.tb_EmailPadrao.Name = "tb_EmailPadrao";
            this.tb_EmailPadrao.Size = new System.Drawing.Size(271, 20);
            this.tb_EmailPadrao.TabIndex = 13;
            // 
            // lb_NovoNome
            // 
            this.lb_NovoNome.AutoSize = true;
            this.lb_NovoNome.Location = new System.Drawing.Point(8, 128);
            this.lb_NovoNome.Name = "lb_NovoNome";
            this.lb_NovoNome.Size = new System.Drawing.Size(62, 13);
            this.lb_NovoNome.TabIndex = 15;
            this.lb_NovoNome.Text = "Novo nome";
            // 
            // tb_SenhaAtual
            // 
            this.tb_SenhaAtual.Location = new System.Drawing.Point(76, 151);
            this.tb_SenhaAtual.Name = "tb_SenhaAtual";
            this.tb_SenhaAtual.Size = new System.Drawing.Size(83, 20);
            this.tb_SenhaAtual.TabIndex = 14;
            // 
            // cb_DesabilitaLogin
            // 
            this.cb_DesabilitaLogin.AutoSize = true;
            this.cb_DesabilitaLogin.Location = new System.Drawing.Point(25, 245);
            this.cb_DesabilitaLogin.Name = "cb_DesabilitaLogin";
            this.cb_DesabilitaLogin.Size = new System.Drawing.Size(104, 17);
            this.cb_DesabilitaLogin.TabIndex = 16;
            this.cb_DesabilitaLogin.Text = "Desabilitar Login";
            this.cb_DesabilitaLogin.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(291, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "&Configurar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_Cancelar
            // 
            this.bt_Cancelar.Location = new System.Drawing.Point(215, 239);
            this.bt_Cancelar.Name = "bt_Cancelar";
            this.bt_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.bt_Cancelar.TabIndex = 18;
            this.bt_Cancelar.Text = "&Cancelar";
            this.bt_Cancelar.UseVisualStyleBackColor = true;
            this.bt_Cancelar.Click += new System.EventHandler(this.bt_Cancelar_Click);
            // 
            // fm_Configurar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 149);
            this.Controls.Add(this.bt_Cancelar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_DesabilitaLogin);
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
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
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
        private System.Windows.Forms.CheckBox cb_DesabilitaLogin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bt_Cancelar;
    }
}