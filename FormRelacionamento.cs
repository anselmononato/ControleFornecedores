using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroFornecedoresGrupoSym
{
    public partial class FormRelacionamento : Form
    {
        private const string Value = "Value";
        private const string Names = "Names";
        AssociacaoFornecedor model = new AssociacaoFornecedor();
        private readonly FuncoesDoSistema funcoesDoSistema = new FuncoesDoSistema();
        public FormRelacionamento()
        {

            InitializeComponent();
            PopularComboBoxEmpresa();
        }
        public void PopularComboBoxEmpresa()
        {

            var ListagemEmpresa = this.funcoesDoSistema.ListagemEmpresas(funcoesDoSistema.Tabelaempresas(null));

            cboEmpresaLista.DataSource = ListagemEmpresa;
            cboEmpresaLista.ValueMember = Value;
            cboEmpresaLista.DisplayMember = Names;
            cboEmpresaLista.SelectedIndex = -1;
            cboEmpresaLista.Text = "Selecione Empresa";

        }
        public void PopularCheckedListBoxFornecedoresDisponiveis(int IDEmpresaComboBox)
        {
            clbFornecedoresDisponiveis.Items.Clear();
            List<FornecedorItem> NaoFornecedoresAssociadosSQL = funcoesDoSistema.NaoFornecedoresAssociadosSQL(IDEmpresaComboBox);




            foreach (FornecedorItem item in NaoFornecedoresAssociadosSQL)
            {
                clbFornecedoresDisponiveis.Items.Add(item);
            }
        }
        public void PopularCheckedListBoxFornecedoresSelecinados(int IDEmpresaComboBox)
        {

            clbFornecedoresSelecionados.Items.Clear();
            var FornecedoresAssociadosSQL = funcoesDoSistema.FornecedoresAssociadosSQL(IDEmpresaComboBox);


            foreach (var item in FornecedoresAssociadosSQL)
            {
                clbFornecedoresSelecionados.Items.Add(item);
            }

        }
        private void cboEmpresaLista_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int IdEmpresaSelecionada = Int32.Parse(cboEmpresaLista.SelectedValue.ToString());

            PopularCheckedListBoxFornecedoresSelecinados(IdEmpresaSelecionada);
            PopularCheckedListBoxFornecedoresDisponiveis(IdEmpresaSelecionada);
            btnDesfazer.Enabled = false;
        }
        private void BtnRemoveFornecedores_Click(object sender, EventArgs e)
        {

            if (clbFornecedoresSelecionados.CheckedItems.Count == 0)
                MessageBox.Show("Selecione um fornecedor para remover a associação");
            else
            {
                var itensSelecionados = clbFornecedoresSelecionados.CheckedItems;
                foreach (var item in itensSelecionados.OfType<object>().ToList())
                {

                    clbFornecedoresDisponiveis.Items.Add(item);
                    clbFornecedoresSelecionados.Items.Remove(item);
                }
                btnDesfazer.Enabled = true;
            }
            
        }
        private void BtnAdicionaFornecedores_Click(object sender, EventArgs e)
        {
            if (clbFornecedoresDisponiveis.CheckedItems.Count == 0)
                MessageBox.Show("Selecione um fornecedor para adicionar a associação");
            else
            {
                var itensSelecionados = clbFornecedoresDisponiveis.CheckedItems.OfType<object>().ToList();
                //foreach (var item in itensSelecionados.OfType<object>().ToList())
                foreach (FornecedorItem item in itensSelecionados)
                {
                    clbFornecedoresSelecionados.Items.Add(item);
                    clbFornecedoresDisponiveis.Items.Remove(item);

                }
                btnDesfazer.Enabled = true;
            }
        }
        private void BtnGravaAssociacao_Click(object sender, EventArgs e)
        {


            if (MessageBox.Show("Realmente deseja atualizar os dados?", "Confirmar Atualização", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {


                var AssociarFornecedores = clbFornecedoresSelecionados.Items;
                List<int> CriarAssociacaoFornecedoresID = new List<int>();
                int EmpresaSelecionada = Int32.Parse(cboEmpresaLista.SelectedValue.ToString());
                foreach (FornecedorItem item in AssociarFornecedores)
                {
                    CriarAssociacaoFornecedoresID.Add(item.IdFornecedor);
                }


                funcoesDoSistema.CriaRelacionamento(EmpresaSelecionada, CriarAssociacaoFornecedoresID);
            }
            else
                return;
            btnDesfazer.Enabled = false;
        }
        private void BtnDesfazer_Click(object sender, EventArgs e)
        {
            cboEmpresaLista_SelectionChangeCommitted(null,null);
            btnDesfazer.Enabled = false;
        }
        private void btnFecharCadastroFornecedor_Click(object sender, EventArgs e)
        {
            Close();
        }
     
    }


}
