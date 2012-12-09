namespace Controle_de_Midias
{
    partial class fm_login
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.pn_EnviaEmail = new System.Windows.Forms.Panel();
            this.lb_EmailIncorreto = new System.Windows.Forms.Label();
            this.lb_ConectarInternet = new System.Windows.Forms.Label();
            this.lb_Enviado = new System.Windows.Forms.Label();
            this.bt_Cancelar = new System.Windows.Forms.Button();
            this.bt_EnviarEmail = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pn_SolicitaSenha = new System.Windows.Forms.Panel();
            this.tb_Senha = new System.Windows.Forms.TextBox();
            this.bt_esqueciSenha = new System.Windows.Forms.Button();
            this.erroP = new System.Windows.Forms.ErrorProvider(this.components);
            this.pn_EnviaEmail.SuspendLayout();
            this.pn_SolicitaSenha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erroP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Senha";
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(31, 45);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(178, 20);
            this.tb_email.TabIndex = 4;
            this.tb_email.Text = "diego_germano28@yahoo.com.br";
            // 
            // pn_EnviaEmail
            // 
            this.pn_EnviaEmail.Controls.Add(this.lb_EmailIncorreto);
            this.pn_EnviaEmail.Controls.Add(this.lb_ConectarInternet);
            this.pn_EnviaEmail.Controls.Add(this.lb_Enviado);
            this.pn_EnviaEmail.Controls.Add(this.bt_Cancelar);
            this.pn_EnviaEmail.Controls.Add(this.bt_EnviarEmail);
            this.pn_EnviaEmail.Controls.Add(this.label3);
            this.pn_EnviaEmail.Controls.Add(this.tb_email);
            this.pn_EnviaEmail.Location = new System.Drawing.Point(12, 12);
            this.pn_EnviaEmail.Name = "pn_EnviaEmail";
            this.pn_EnviaEmail.Size = new System.Drawing.Size(278, 153);
            this.pn_EnviaEmail.TabIndex = 5;
            // 
            // lb_EmailIncorreto
            // 
            this.lb_EmailIncorreto.AutoSize = true;
            this.lb_EmailIncorreto.BackColor = System.Drawing.SystemColors.Control;
            this.lb_EmailIncorreto.ForeColor = System.Drawing.Color.Red;
            this.lb_EmailIncorreto.Location = new System.Drawing.Point(80, 135);
            this.lb_EmailIncorreto.Name = "lb_EmailIncorreto";
            this.lb_EmailIncorreto.Size = new System.Drawing.Size(91, 13);
            this.lb_EmailIncorreto.TabIndex = 10;
            this.lb_EmailIncorreto.Text = "✘Email incorreto ";
            this.lb_EmailIncorreto.Visible = false;
            // 
            // lb_ConectarInternet
            // 
            this.lb_ConectarInternet.AutoSize = true;
            this.lb_ConectarInternet.BackColor = System.Drawing.SystemColors.Control;
            this.lb_ConectarInternet.ForeColor = System.Drawing.Color.Red;
            this.lb_ConectarInternet.Location = new System.Drawing.Point(80, 135);
            this.lb_ConectarInternet.Name = "lb_ConectarInternet";
            this.lb_ConectarInternet.Size = new System.Drawing.Size(187, 13);
            this.lb_ConectarInternet.TabIndex = 9;
            this.lb_ConectarInternet.Text = "✘Não foi possivél conectar a Internet";
            this.lb_ConectarInternet.Visible = false;
            // 
            // lb_Enviado
            // 
            this.lb_Enviado.AutoSize = true;
            this.lb_Enviado.BackColor = System.Drawing.SystemColors.Control;
            this.lb_Enviado.ForeColor = System.Drawing.Color.Green;
            this.lb_Enviado.Location = new System.Drawing.Point(80, 135);
            this.lb_Enviado.Name = "lb_Enviado";
            this.lb_Enviado.Size = new System.Drawing.Size(153, 13);
            this.lb_Enviado.TabIndex = 8;
            this.lb_Enviado.Text = "✔ Email enviado com sucesso";
            this.lb_Enviado.Visible = false;
            // 
            // bt_Cancelar
            // 
            this.bt_Cancelar.Location = new System.Drawing.Point(111, 98);
            this.bt_Cancelar.Name = "bt_Cancelar";
            this.bt_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.bt_Cancelar.TabIndex = 7;
            this.bt_Cancelar.Text = "Cancelar";
            this.bt_Cancelar.UseVisualStyleBackColor = true;
            this.bt_Cancelar.Click += new System.EventHandler(this.bt_Cancelar_Click);
            // 
            // bt_EnviarEmail
            // 
            this.bt_EnviarEmail.Location = new System.Drawing.Point(192, 98);
            this.bt_EnviarEmail.Name = "bt_EnviarEmail";
            this.bt_EnviarEmail.Size = new System.Drawing.Size(75, 23);
            this.bt_EnviarEmail.TabIndex = 6;
            this.bt_EnviarEmail.Text = "&Enviar";
            this.bt_EnviarEmail.UseVisualStyleBackColor = true;
            this.bt_EnviarEmail.Click += new System.EventHandler(this.bt_EnviarEmail_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enviar para";
            // 
            // pn_SolicitaSenha
            // 
            this.pn_SolicitaSenha.Controls.Add(this.tb_Senha);
            this.pn_SolicitaSenha.Controls.Add(this.bt_esqueciSenha);
            this.pn_SolicitaSenha.Controls.Add(this.label1);
            this.pn_SolicitaSenha.Location = new System.Drawing.Point(1, 1);
            this.pn_SolicitaSenha.Name = "pn_SolicitaSenha";
            this.pn_SolicitaSenha.Size = new System.Drawing.Size(300, 164);
            this.pn_SolicitaSenha.TabIndex = 6;
            // 
            // tb_Senha
            // 
            this.tb_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Senha.Location = new System.Drawing.Point(134, 47);
            this.tb_Senha.Name = "tb_Senha";
            this.tb_Senha.PasswordChar = '●';
            this.tb_Senha.Size = new System.Drawing.Size(141, 47);
            this.tb_Senha.TabIndex = 9;
            this.tb_Senha.TextChanged += new System.EventHandler(this.tb_Senha_TextChanged);
            // 
            // bt_esqueciSenha
            // 
            this.bt_esqueciSenha.Location = new System.Drawing.Point(0, 135);
            this.bt_esqueciSenha.Name = "bt_esqueciSenha";
            this.bt_esqueciSenha.Size = new System.Drawing.Size(297, 25);
            this.bt_esqueciSenha.TabIndex = 7;
            this.bt_esqueciSenha.Text = "Esqueci Minnha senha";
            this.bt_esqueciSenha.UseVisualStyleBackColor = true;
            this.bt_esqueciSenha.Click += new System.EventHandler(this.esqueciSenha_Click);
            // 
            // erroP
            // 
            this.erroP.ContainerControl = this;
            // 
            // fm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 163);
            this.Controls.Add(this.pn_SolicitaSenha);
            this.Controls.Add(this.pn_EnviaEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "fm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bloqueado";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fm_login_FormClosed);
            this.Load += new System.EventHandler(this.fm_login_Load);
            this.pn_EnviaEmail.ResumeLayout(false);
            this.pn_EnviaEmail.PerformLayout();
            this.pn_SolicitaSenha.ResumeLayout(false);
            this.pn_SolicitaSenha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erroP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Panel pn_EnviaEmail;
        private System.Windows.Forms.Button bt_EnviarEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pn_SolicitaSenha;
        private System.Windows.Forms.Button bt_esqueciSenha;
        private System.Windows.Forms.Button bt_Cancelar;
        private System.Windows.Forms.ErrorProvider erroP;
        private System.Windows.Forms.TextBox tb_Senha;
        private System.Windows.Forms.Label lb_EmailIncorreto;
        private System.Windows.Forms.Label lb_ConectarInternet;
        private System.Windows.Forms.Label lb_Enviado;

    }
}