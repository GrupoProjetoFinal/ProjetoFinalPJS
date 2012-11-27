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
            this.lb_Nome = new System.Windows.Forms.Label();
            this.tb_NomeAlt = new System.Windows.Forms.TextBox();
            this.tb_TelefoneAlt = new System.Windows.Forms.TextBox();
            this.lb_Telefone = new System.Windows.Forms.Label();
            this.tb_EmailAlt = new System.Windows.Forms.TextBox();
            this.lb_email = new System.Windows.Forms.Label();
            this.lb_observacao = new System.Windows.Forms.Label();
            this.rtb_ObservacaoAlt = new System.Windows.Forms.RichTextBox();
            this.gb_menu = new System.Windows.Forms.GroupBox();
            this.bt_Excluir = new System.Windows.Forms.Button();
            this.bt_Alterar = new System.Windows.Forms.Button();
            this.gb_menu.SuspendLayout();
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
            // tb_NomeAlt
            // 
            this.tb_NomeAlt.Location = new System.Drawing.Point(104, 28);
            this.tb_NomeAlt.Name = "tb_NomeAlt";
            this.tb_NomeAlt.Size = new System.Drawing.Size(300, 20);
            this.tb_NomeAlt.TabIndex = 1;
            // 
            // tb_TelefoneAlt
            // 
            this.tb_TelefoneAlt.Location = new System.Drawing.Point(104, 67);
            this.tb_TelefoneAlt.Name = "tb_TelefoneAlt";
            this.tb_TelefoneAlt.Size = new System.Drawing.Size(300, 20);
            this.tb_TelefoneAlt.TabIndex = 3;
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
            // tb_EmailAlt
            // 
            this.tb_EmailAlt.Location = new System.Drawing.Point(104, 106);
            this.tb_EmailAlt.Name = "tb_EmailAlt";
            this.tb_EmailAlt.Size = new System.Drawing.Size(300, 20);
            this.tb_EmailAlt.TabIndex = 5;
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
            // rtb_ObservacaoAlt
            // 
            this.rtb_ObservacaoAlt.Location = new System.Drawing.Point(104, 145);
            this.rtb_ObservacaoAlt.Name = "rtb_ObservacaoAlt";
            this.rtb_ObservacaoAlt.Size = new System.Drawing.Size(300, 96);
            this.rtb_ObservacaoAlt.TabIndex = 8;
            this.rtb_ObservacaoAlt.Text = "";
            // 
            // gb_menu
            // 
            this.gb_menu.Controls.Add(this.bt_Excluir);
            this.gb_menu.Controls.Add(this.bt_Alterar);
            this.gb_menu.Location = new System.Drawing.Point(9, 12);
            this.gb_menu.Name = "gb_menu";
            this.gb_menu.Size = new System.Drawing.Size(86, 226);
            this.gb_menu.TabIndex = 9;
            this.gb_menu.TabStop = false;
            this.gb_menu.Text = "menu";
            // 
            // bt_Excluir
            // 
            this.bt_Excluir.Location = new System.Drawing.Point(5, 52);
            this.bt_Excluir.Name = "bt_Excluir";
            this.bt_Excluir.Size = new System.Drawing.Size(75, 23);
            this.bt_Excluir.TabIndex = 1;
            this.bt_Excluir.Text = "&Excluir";
            this.bt_Excluir.UseVisualStyleBackColor = true;
            this.bt_Excluir.Click += new System.EventHandler(this.bt_Excluir_Click);
            // 
            // bt_Alterar
            // 
            this.bt_Alterar.Location = new System.Drawing.Point(6, 17);
            this.bt_Alterar.Name = "bt_Alterar";
            this.bt_Alterar.Size = new System.Drawing.Size(75, 23);
            this.bt_Alterar.TabIndex = 0;
            this.bt_Alterar.Text = "&Alterar";
            this.bt_Alterar.UseVisualStyleBackColor = true;
            this.bt_Alterar.Click += new System.EventHandler(this.bt_Adicionar_Click);
            // 
            // fm_AlterarAmigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 247);
            this.Controls.Add(this.gb_menu);
            this.Controls.Add(this.rtb_ObservacaoAlt);
            this.Controls.Add(this.lb_observacao);
            this.Controls.Add(this.tb_EmailAlt);
            this.Controls.Add(this.lb_email);
            this.Controls.Add(this.tb_TelefoneAlt);
            this.Controls.Add(this.lb_Telefone);
            this.Controls.Add(this.tb_NomeAlt);
            this.Controls.Add(this.lb_Nome);
            this.Name = "fm_AlterarAmigo";
            this.Text = "Alterar dados do amigo";
            this.Load += new System.EventHandler(this.fm_AlterarAmigo_Load);
            this.gb_menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Nome;
        private System.Windows.Forms.TextBox tb_NomeAlt;
        private System.Windows.Forms.TextBox tb_TelefoneAlt;
        private System.Windows.Forms.Label lb_Telefone;
        private System.Windows.Forms.TextBox tb_EmailAlt;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.Label lb_observacao;
        private System.Windows.Forms.RichTextBox rtb_ObservacaoAlt;
        private System.Windows.Forms.GroupBox gb_menu;
        private System.Windows.Forms.Button bt_Alterar;
        private System.Windows.Forms.Button bt_Excluir;
    }
}