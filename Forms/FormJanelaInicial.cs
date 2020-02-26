using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using CadastroFornecedoresGrupoSym.Entity;


namespace CadastroFornecedoresGrupoSym
{
    public partial class FormJanelaInicial : Form
    {
        private readonly FuncoesDoSistema funcoesDoSistema = new FuncoesDoSistema();
        public FormJanelaInicial()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopularComboBoxEmpresa();
        }
        private void PopularFornecedoresInicial(int IDFornecedorSelecionado)
        {
            dgvFEInicial.AutoGenerateColumns = false;
            
            using (var db = new CadastrosDbEntity())
            {
                if (IDFornecedorSelecionado.ToString() != "")
                {
                   
                    var listaFornecedores = db.Fornecedor.SqlQuery("SELECT F.* FROM dbo.Fornecedor F " +
                        "INNER JOIN dbo.AssociacaoFornecedor AF on (AF.Fornecedor_ID = F.ID) " +
                        "INNER JOIN dbo.Empresa E on (E.ID = AF.Empresa_ID)  " +
                        "WHERE E.ID in (" + IDFornecedorSelecionado + ") ")
                        .ToList();
                        dgvFEInicial.DataSource = listaFornecedores;
                }
            }

        }
        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroEmpresas FormCadastroEmpresas = new FormCadastroEmpresas();
            FormCadastroEmpresas.ShowDialog();
            PopularComboBoxEmpresa();
            dgvFEInicial.DataSource = null;
        }
        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroFornecedores FormCadastroFornecedores = new FormCadastroFornecedores();
            FormCadastroFornecedores.ShowDialog();
            PopularComboBoxEmpresa();
            dgvFEInicial.DataSource = null;
        }
        private void cboEmpresaLista_SelectionChangeCommitted(object sender, EventArgs e)
        {
            bool result = int.TryParse(cboEmpresaLista.SelectedValue.ToString(), out int IDFornecedorSelecionado);

            PopularFornecedoresInicial(IDFornecedorSelecionado);
        }
        public void PopularComboBoxEmpresa()
        {

            List<Empresa> Tabelaempresas = funcoesDoSistema.Tabelaempresas(null);
            var ListagemEmpresa = funcoesDoSistema.ListagemEmpresas(Tabelaempresas);

            cboEmpresaLista.DataSource = ListagemEmpresa;
            cboEmpresaLista.DisplayMember = "Names";
            cboEmpresaLista.ValueMember = "Value";

            cboEmpresaLista.Text = "Selecione Empresa";

        }
        private void empresaFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRelacionamento formRelacionamento = new FormRelacionamento();
            formRelacionamento.ShowDialog();
            dgvFEInicial.DataSource = null;
        }

    }
   
}
