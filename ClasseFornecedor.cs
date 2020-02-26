using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroFornecedoresGrupoSym
{

    public class ClasseFornecedor
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



}
