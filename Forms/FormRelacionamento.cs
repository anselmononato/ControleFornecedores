using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CadastroFornecedoresGrupoSym.Entity;

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
            btnGravaAssociacao.Enabled = false;
        }
        public void PopularCheckedListBoxFornecedoresDisponiveis(int IDEmpresaComboBox)
        {
            clbFornecedoresDisponiveis.Items.Clear();
            List<ClassesDeListagem> NaoFornecedoresAssociadosSQL = funcoesDoSistema.NaoFornecedoresAssociadosSQL(IDEmpresaComboBox);




            foreach (ClassesDeListagem item in NaoFornecedoresAssociadosSQL)
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
            btnDesfazer.Enabled = btnGravaAssociacao.Enabled = false;
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
                btnDesfazer.Enabled = btnGravaAssociacao.Enabled = true;
                
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
                foreach (ClassesDeListagem item in itensSelecionados)
                {
                    clbFornecedoresSelecionados.Items.Add(item);
                    clbFornecedoresDisponiveis.Items.Remove(item);

                }
                btnDesfazer.Enabled = btnGravaAssociacao.Enabled = true;
               
            }
        }
        private void BtnGravaAssociacao_Click(object sender, EventArgs e)
        {
            if(cboEmpresaLista.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione uma empresa para associar");
                return;
            }


            if (MessageBox.Show("Realmente deseja atualizar os dados?", "Confirmar Atualização", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                
                //DateTime.TryParse(txtNascimento.Text.Trim(), out DateTime dataNascimento);

                var AssociarFornecedores = clbFornecedoresSelecionados.Items;
                List<int> CriarAssociacaoFornecedoresID = new List<int>();
                Int32.TryParse(cboEmpresaLista.SelectedValue.ToString(), out int EmpresaSelecionada);
                foreach (ClassesDeListagem item in AssociarFornecedores)
                {
                    CriarAssociacaoFornecedoresID.Add(item.IdFornecedor);
                }


                funcoesDoSistema.CriaRelacionamento(EmpresaSelecionada, CriarAssociacaoFornecedoresID);
            }
            else
                return;
            btnDesfazer.Enabled = btnGravaAssociacao.Enabled = false;
        }
        private void BtnDesfazer_Click(object sender, EventArgs e)
        {
            cboEmpresaLista_SelectionChangeCommitted(null,null);
            btnDesfazer.Enabled = btnGravaAssociacao.Enabled = false;
        }
        private void btnFecharCadastroFornecedor_Click(object sender, EventArgs e)
        {
            Close();
        }
     
    }


}
