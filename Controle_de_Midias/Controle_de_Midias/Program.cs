using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Controle_de_Midias
{
    public class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Program obj = new Program();
            obj.Inicializacao();

        }
        public void Inicializacao()
        {


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //GerenciadorDeBanco GBD = new GerenciadorDeBanco();
            //fm_login login = new fm_login();
            //GBD.AbrirConexao();
            //if (GBD.VerificaLogin())
            //    login.ShowDialog();
            //GBD.FecharConexao();
            //if (login.logado)
                Application.Run(new fm_Principal());
        }
    }
}
