using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CadastroFornecedoresGrupoSym.Entity;

namespace CadastroFornecedoresGrupoSym
{
    static class Program
    {

        [STAThread]
        static void Main()
        {
       


        Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormJanelaInicial());
            
        }
    }
}
