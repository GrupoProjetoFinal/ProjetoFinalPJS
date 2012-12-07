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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.pn_EnviaEmail = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pn_SolicitaSenha = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tb_Senha = new System.Windows.Forms.MaskedTextBox();
            this.pn_EnviaEmail.SuspendLayout();
            this.pn_SolicitaSenha.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite a senha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(104, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Verifica a senha";
            this.label2.Visible = false;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(23, 73);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(178, 20);
            this.tb_email.TabIndex = 4;
            this.tb_email.Text = "diego_germano28@yahoo.com.br";
            // 
            // pn_EnviaEmail
            // 
            this.pn_EnviaEmail.Controls.Add(this.button3);
            this.pn_EnviaEmail.Controls.Add(this.button1);
            this.pn_EnviaEmail.Controls.Add(this.label3);
            this.pn_EnviaEmail.Controls.Add(this.tb_email);
            this.pn_EnviaEmail.Location = new System.Drawing.Point(1, 1);
            this.pn_EnviaEmail.Name = "pn_EnviaEmail";
            this.pn_EnviaEmail.Size = new System.Drawing.Size(286, 172);
            this.pn_EnviaEmail.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(180, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 25);
            this.button1.TabIndex = 6;
            this.button1.Text = "ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "enviar senha para esse email";
            // 
            // pn_SolicitaSenha
            // 
            this.pn_SolicitaSenha.Controls.Add(this.tb_Senha);
            this.pn_SolicitaSenha.Controls.Add(this.button2);
            this.pn_SolicitaSenha.Controls.Add(this.label1);
            this.pn_SolicitaSenha.Controls.Add(this.label2);
            this.pn_SolicitaSenha.Location = new System.Drawing.Point(1, 1);
            this.pn_SolicitaSenha.Name = "pn_SolicitaSenha";
            this.pn_SolicitaSenha.Size = new System.Drawing.Size(289, 172);
            this.pn_SolicitaSenha.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 144);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(289, 25);
            this.button2.TabIndex = 7;
            this.button2.Text = "Esqueci Minnha senha";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(63, 138);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 25);
            this.button3.TabIndex = 7;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tb_Senha
            // 
            this.tb_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Senha.Location = new System.Drawing.Point(136, 35);
            this.tb_Senha.Mask = "000000";
            this.tb_Senha.Name = "tb_Senha";
            this.tb_Senha.Size = new System.Drawing.Size(51, 23);
            this.tb_Senha.TabIndex = 8;
            this.tb_Senha.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // fm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 174);
            this.Controls.Add(this.pn_SolicitaSenha);
            this.Controls.Add(this.pn_EnviaEmail);
            this.Name = "fm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fm_login";
            this.Load += new System.EventHandler(this.fm_login_Load);
            this.pn_EnviaEmail.ResumeLayout(false);
            this.pn_EnviaEmail.PerformLayout();
            this.pn_SolicitaSenha.ResumeLayout(false);
            this.pn_SolicitaSenha.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Panel pn_EnviaEmail;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pn_SolicitaSenha;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MaskedTextBox tb_Senha;

    }
}