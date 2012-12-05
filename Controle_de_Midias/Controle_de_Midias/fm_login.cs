using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Controle_de_Midias
{
    public partial class fm_login : Form
    {
        public bool logado = true;
        public fm_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            logado = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            logado = false;
            this.Close();
        }

    }
}
