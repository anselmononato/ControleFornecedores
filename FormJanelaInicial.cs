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

namespace CadastroFornecedoresGrupoSym
{
    public partial class FormJanelaInicial : Form
    {
        
        public FormJanelaInicial()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadEmpresaLista();
            
        }

      
        void PopularFornecedoresInicial(int IDFornecedorSelecionado)
        {
            dgvFEInicial.AutoGenerateColumns = false;
            
            using (var db = new CadastrosDbEntity())
            {
                if (IDFornecedorSelecionado.ToString() != "")
                {
                   
                    var listaFornecedores = db.Fornecedors.SqlQuery("SELECT F.* FROM dbo.Fornecedor F " +
                        "INNER JOIN dbo.AssociacaoFornecedor AF on (AF.Fornecedor_ID = F.ID) " +
                        "INNER JOIN dbo.Empresa E on (E.ID = AF.Empresa_ID)  " +
                        "WHERE E.ID in (" + IDFornecedorSelecionado + ") ")
                        .ToList();
                        dgvFEInicial.DataSource = listaFornecedores;
                }
            }

        }

        private void dgvFEInicial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        // Alimenta o ComboBox 
        public void loadEmpresaLista()
        {
            CadastrosDbEntity db = new CadastrosDbEntity();

            var empresaLista = (from z in db.Empresas
                        select new { Value = z.ID, Names = z.NomeFantasia }).ToList();


            cboEmpresaLista.DataSource = empresaLista;
            cboEmpresaLista.DisplayMember = "Names";
            cboEmpresaLista.ValueMember = "Value";
            cboEmpresaLista.Text = "Selecione Empresa";
        }


        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroEmpresas f2 = new FormCadastroEmpresas();
            f2.ShowDialog();
            loadEmpresaLista();
            dgvFEInicial.DataSource = null;
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroFornecedores f3 = new FormCadastroFornecedores();
            f3.ShowDialog();
            loadEmpresaLista();
            dgvFEInicial.DataSource = null;
        }


        private void cboEmpresaLista_SelectionChangeCommitted(object sender, EventArgs e)
        {
            bool result = int.TryParse(cboEmpresaLista.SelectedValue.ToString(), out int IDFornecedorSelecionado);

            PopularFornecedoresInicial(IDFornecedorSelecionado);
        }

       
    }
}
