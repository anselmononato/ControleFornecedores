using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroFornecedoresGrupoSym
{

    public class ClassesDeListagem
    {


        private int _IdFornecedor;
        private string _NomeFornecedor;

        public int IdFornecedor
        {
            get { return _IdFornecedor; }
            set { _IdFornecedor = value; }
        }

        public String NomeFornecedor
        {
            get { return _NomeFornecedor; }
            set { _NomeFornecedor = value; }
        }
    }
    public class ClasseEmpresa
    {


        private int _IdEmpresa;
        private string _NomeEmpresa;

        public int Value
        {
            get { return _IdEmpresa; }
            set { _IdEmpresa = value; }
        }

        public String Names
        {
            get { return _NomeEmpresa; }
            set { _NomeEmpresa = value; }
        }
    }

}
