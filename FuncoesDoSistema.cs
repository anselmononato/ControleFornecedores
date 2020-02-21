using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroFornecedoresGrupoSym
{
    class FuncoesDoSistema
    {
        CadastrosDbEntity db = new CadastrosDbEntity();
        public List<Empresa> Tabelaempresas(string Condicao)
        {
            string CondicoesEmpresas = null;
            var TabelaEmpresas = db.Empresas.SqlQuery("select * from Empresa"+ CondicoesEmpresas).ToList();

            return TabelaEmpresas;
        }

        public dynamic ListagemEmpresas(List<Empresa> Tabelaempresas) 
        {
            var RetornoEmpresas = (from z in Tabelaempresas
                                   select new { Value = z.ID.ToString(), Names = z.NomeFantasia }).ToList();

            return RetornoEmpresas;
        }


        public dynamic ListagemFornecedoresSelecionados(int EmpresaID)
        {

            
            var SelectFornecedoresSelecionados = db.Fornecedors.SqlQuery("select  * from Fornecedor where Fornecedor.ID in (select distinct AssociacaoFornecedor.fornecedor_id from AssociacaoFornecedor where Empresa_ID = "+EmpresaID+")")
                        .ToList();
            var ListagemFornecedoresSelecionados = (from z in SelectFornecedoresSelecionados
                                    select new { IdFornecedor = z.ID, NomeFornecedor = z.Nome }).ToList();

            return ListagemFornecedoresSelecionados;

        }


        public dynamic ListagemFornecedoresDisponiveis(int EmpresaID)
        {
            CadastrosDbEntity db = new CadastrosDbEntity();

            var SelectFornecedoresDisponiveis = db.Fornecedors.SqlQuery("select  * from Fornecedor where Fornecedor.ID not in (select AssociacaoFornecedor.fornecedor_id from AssociacaoFornecedor where Empresa_ID = "+ EmpresaID+ ")")
                        .ToList();

            var ListagemFornecedoresDisponiveis = (from z in SelectFornecedoresDisponiveis
                                    select new { IdFornecedor = z.ID, NomeFornecedor = z.Nome }).ToList();


            return ListagemFornecedoresDisponiveis;
 

        }




    }

}
