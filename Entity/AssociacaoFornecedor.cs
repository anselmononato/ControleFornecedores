//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CadastroFornecedoresGrupoSym.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class AssociacaoFornecedor
    {
        public int ID { get; set; }
        public int Empresa_ID { get; set; }
        public int Fornecedor_ID { get; set; }
    
        public virtual Empresa Empresa { get; set; }
        public virtual Fornecedor Fornecedor { get; set; }
    }
}
