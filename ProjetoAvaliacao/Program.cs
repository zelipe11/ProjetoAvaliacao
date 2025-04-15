using FuncoesWinthor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAvaliacao
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                UsuarioVO logado = new UsuarioVO();

                frmLogin login = new frmLogin(1);

                if (login.ShowDialog() == DialogResult.Yes)
                {
                    logado = login.usuario;
                    Application.Run(new frmInicial());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.ToString());
            }            
        }
    }
}
