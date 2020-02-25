using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroFornecedoresGrupoSym
{
    class FuncoesDoSistema
    {

        CadastrosDbEntity db = new CadastrosDbEntity();
        public List<Empresa> Tabelaempresas(string Condicao)
        {
            string CondicoesEmpresas = null;
            var TabelaEmpresas = db.Empresa.SqlQuery("select * from Empresa"+ CondicoesEmpresas).ToList();

            return TabelaEmpresas;
        }

        public dynamic ListagemEmpresas(List<Empresa> Tabelaempresas) 
        {
            var RetornoEmpresas = (from z in Tabelaempresas
                                   select new { Value = z.ID.ToString(), Names = z.NomeFantasia }).ToList();

            return RetornoEmpresas;
        }

        public dynamic FornecedoresAssociadosSQL(int EmpresaID)

        {var SelectFornecedoresSelecionados = db.Fornecedor.SqlQuery("select  * from Fornecedor where Fornecedor.ID in (select distinct AssociacaoFornecedor.fornecedor_id from AssociacaoFornecedor where Empresa_ID = "+EmpresaID+")")
                        .ToList();

         var ListagemFornecedoresSelecionados = from z in SelectFornecedoresSelecionados
                                                       select new FornecedorItem { IdFornecedor = z.ID, NomeFornecedor = z.Nome };

            return ListagemFornecedoresSelecionados;

        }

        public dynamic NaoFornecedoresAssociadosSQL(int EmpresaID)
        {
            CadastrosDbEntity db = new CadastrosDbEntity();

            var SelectFornecedoresDisponiveis = db.Fornecedor.SqlQuery("select  * from Fornecedor where Fornecedor.ID not in (select AssociacaoFornecedor.fornecedor_id from AssociacaoFornecedor where Empresa_ID = "+ EmpresaID+ ")")
                        .ToList();

            var ListagemFornecedoresDisponiveis = (from z in SelectFornecedoresDisponiveis
                                    select new FornecedorItem { IdFornecedor = z.ID, NomeFornecedor = z.Nome }).ToList();


            return ListagemFornecedoresDisponiveis;
 

        }

        public void CriaRelacionamento(int _EmpresaIdAssociar, List<int> _FornecedoresIdAssociar)
        {
                   
            List<string> ListaValueToInsert = new List<string>();
            
            foreach(int ID in _FornecedoresIdAssociar)
            {
                ListaValueToInsert.Add("("+ _EmpresaIdAssociar + "," + ID.ToString() + ")");
            }
            string ValueToInsert = String.Join(",", ListaValueToInsert.Select(p => p.ToString()).ToArray());

            CadastrosDbEntity db = new CadastrosDbEntity();
            string ComandoDelete = "delete AssociacaoFornecedor where Empresa_ID = "+ _EmpresaIdAssociar;
            string ComandoInsert = "";
            if (_FornecedoresIdAssociar.Count !=0)
            {
                ComandoInsert = "insert into AssociacaoFornecedor (Empresa_ID, Fornecedor_ID) values " + ValueToInsert;
            }
            string ComandoExecutar = ComandoDelete + "; " + ComandoInsert;

            db.Database.ExecuteSqlCommand(ComandoExecutar);

        }

        public void PermitirSomenteNumeros(object sender, KeyPressEventArgs e)
        {
            //Permitir apenas números no campo de CPF ou CNPJ do cadastro empresa.
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }
    
        public bool ValidaIdade(string nascimento)
        {

          //  int teste = nascimento.Length;
            if (nascimento.Length == 10
                && DateTime.TryParse(nascimento, out DateTime DataConvertida) 
                && DataConvertida.AddYears(18) < DateTime.Now
                && DataConvertida.AddYears(500) > DateTime.Now)
            {
                return true;
            }
           
            return false;
        }
    }

}
