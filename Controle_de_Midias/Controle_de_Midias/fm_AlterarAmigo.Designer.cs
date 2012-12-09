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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_InfoUsuario = new System.Windows.Forms.Label();
            this.bt_Excluir = new System.Windows.Forms.Button();
            this.bt_Alterar = new System.Windows.Forms.Button();
            this.tb_TelefoneAlt = new System.Windows.Forms.MaskedTextBox();
            this.rtb_ObservacaoAlt = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_NomeAlt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_EmailAlt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.erroP = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erroP)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_InfoUsuario);
            this.groupBox1.Controls.Add(this.bt_Excluir);
            this.groupBox1.Controls.Add(this.bt_Alterar);
            this.groupBox1.Controls.Add(this.tb_TelefoneAlt);
            this.groupBox1.Controls.Add(this.rtb_ObservacaoAlt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_NomeAlt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_EmailAlt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(11, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 315);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Amigo";
            // 
            // lb_InfoUsuario
            // 
            this.lb_InfoUsuario.AutoSize = true;
            this.lb_InfoUsuario.ForeColor = System.Drawing.Color.Red;
            this.lb_InfoUsuario.Location = new System.Drawing.Point(6, 288);
            this.lb_InfoUsuario.Name = "lb_InfoUsuario";
            this.lb_InfoUsuario.Size = new System.Drawing.Size(146, 13);
            this.lb_InfoUsuario.TabIndex = 10;
            this.lb_InfoUsuario.Text = "O campo nome é obrigatório !";
            this.lb_InfoUsuario.Visible = false;
            // 
            // bt_Excluir
            // 
            this.bt_Excluir.Location = new System.Drawing.Point(174, 261);
            this.bt_Excluir.Name = "bt_Excluir";
            this.bt_Excluir.Size = new System.Drawing.Size(75, 23);
            this.bt_Excluir.TabIndex = 6;
            this.bt_Excluir.Text = "&Apagar";
            this.bt_Excluir.UseVisualStyleBackColor = true;
            this.bt_Excluir.Click += new System.EventHandler(this.bt_Excluir_Click);
            // 
            // bt_Alterar
            // 
            this.bt_Alterar.Location = new System.Drawing.Point(255, 261);
            this.bt_Alterar.Name = "bt_Alterar";
            this.bt_Alterar.Size = new System.Drawing.Size(75, 23);
            this.bt_Alterar.TabIndex = 5;
            this.bt_Alterar.Text = "&Alterar";
            this.bt_Alterar.UseVisualStyleBackColor = true;
            this.bt_Alterar.Click += new System.EventHandler(this.bt_Alterar_Click);
            // 
            // tb_TelefoneAlt
            // 
            this.tb_TelefoneAlt.Location = new System.Drawing.Point(6, 115);
            this.tb_TelefoneAlt.Mask = "(00) - 0000-0000";
            this.tb_TelefoneAlt.Name = "tb_TelefoneAlt";
            this.tb_TelefoneAlt.Size = new System.Drawing.Size(100, 20);
            this.tb_TelefoneAlt.TabIndex = 3;
            // 
            // rtb_ObservacaoAlt
            // 
            this.rtb_ObservacaoAlt.Location = new System.Drawing.Point(6, 160);
            this.rtb_ObservacaoAlt.Name = "rtb_ObservacaoAlt";
            this.rtb_ObservacaoAlt.Size = new System.Drawing.Size(207, 71);
            this.rtb_ObservacaoAlt.TabIndex = 4;
            this.rtb_ObservacaoAlt.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // tb_NomeAlt
            // 
            this.tb_NomeAlt.Location = new System.Drawing.Point(6, 37);
            this.tb_NomeAlt.Name = "tb_NomeAlt";
            this.tb_NomeAlt.Size = new System.Drawing.Size(330, 20);
            this.tb_NomeAlt.TabIndex = 1;
            this.tb_NomeAlt.Enter += new System.EventHandler(this.tb_NomeAlt_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Observação";
            // 
            // tb_EmailAlt
            // 
            this.tb_EmailAlt.Location = new System.Drawing.Point(6, 76);
            this.tb_EmailAlt.Name = "tb_EmailAlt";
            this.tb_EmailAlt.Size = new System.Drawing.Size(330, 20);
            this.tb_EmailAlt.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "E-mail";
            // 
            // erroP
            // 
            this.erroP.ContainerControl = this;
            // 
            // fm_AlterarAmigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 337);
            this.Controls.Add(this.groupBox1);
            this.Name = "fm_AlterarAmigo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar dados do amigo";
            
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erroP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_InfoUsuario;
        private System.Windows.Forms.Button bt_Excluir;
        private System.Windows.Forms.Button bt_Alterar;
        private System.Windows.Forms.MaskedTextBox tb_TelefoneAlt;
        private System.Windows.Forms.RichTextBox rtb_ObservacaoAlt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_NomeAlt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_EmailAlt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider erroP;
    }
}