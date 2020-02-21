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

        AssociacaoFornecedor model = new AssociacaoFornecedor();




        readonly FuncoesDoSistema funcoesDoSistema = new FuncoesDoSistema();

        public FormRelacionamento()
        {
            InitializeComponent();
            PopularComboBoxEmpresa();
            model.Empresa_ID = 1;
            model.Fornecedor_ID = 10;

            using (CadastrosDbEntity db = new CadastrosDbEntity())
            {
                db.AssociacaoFornecedors.Add(model);
                db.SaveChanges();
            }

        }

        public void PopularComboBoxEmpresa()
        {

            var Tabelaempresas = funcoesDoSistema.Tabelaempresas(null);
            var ListagemEmpresa = funcoesDoSistema.ListagemEmpresas(Tabelaempresas);


            cboEmpresaLista.DataSource = ListagemEmpresa;
            cboEmpresaLista.ValueMember = "Value";
            cboEmpresaLista.DisplayMember = "Names";


        }



        public void PopularCheckedListBoxFornecedoresSelecinados(int IDEmpresaComboBox)
        {

            clbFornecedoresSelecionados.Items.Clear();
            var ListagemFornecedoresSelecionados = funcoesDoSistema.ListagemFornecedoresSelecionados(IDEmpresaComboBox);
            foreach (var item in ListagemFornecedoresSelecionados)
            {
                clbFornecedoresSelecionados.Items.Add(item);
            }

        }


        public void PopularCheckedListBoxFornecedoresDisponiveis(int IDEmpresaComboBox)
        {
            clbFornecedoresDisponiveis.Items.Clear();
            var ListagemFornecedoresDisponiveis = funcoesDoSistema.ListagemFornecedoresDisponiveis(IDEmpresaComboBox);
            foreach (var item in ListagemFornecedoresDisponiveis)
            {
                clbFornecedoresDisponiveis.Items.Add(item);
            }
        }






        private void cboEmpresaLista_SelectedIndexChanged(object sender, EventArgs e)
        {


            int IdEmpresaSelecionada = Int32.Parse(cboEmpresaLista.SelectedValue.ToString());


            PopularCheckedListBoxFornecedoresSelecinados(IdEmpresaSelecionada);
            PopularCheckedListBoxFornecedoresDisponiveis(IdEmpresaSelecionada);

        }

        private void btnRemoveFornecedores_Click(object sender, EventArgs e)
        {
            var itensSelecionados = clbFornecedoresSelecionados.CheckedItems;

            foreach (var item in itensSelecionados.OfType<object>().ToList())
            {

               clbFornecedoresDisponiveis.Items.Add(item);
              clbFornecedoresSelecionados.Items.Remove(item);
            }
        }
        private void btnAdicionaFornecedores_Click(object sender, EventArgs e)
        {
            var itensSelecionados = clbFornecedoresDisponiveis.CheckedItems;

            foreach (var item in itensSelecionados.OfType<object>().ToList())
            {
                clbFornecedoresSelecionados.Items.Add(item);
                clbFornecedoresDisponiveis.Items.Remove(item);
                
            }
        }

        private void btnGravaAssociacao_Click(object sender, EventArgs e)
        {

            var teste = clbFornecedoresSelecionados.Items;

            foreach (Profile item in teste) { 
            Profile teste2 = (Profile)item;

                int teste3 = teste2.IdFornecedor;
                //item["IdFornecedor"]
            }

           
           




            // { System.Windows.Forms.ListBox.ItemArray.Entry}
        }

    }



    public class Profile
    {
       

        public int IdFornecedor
        {
            get { return IdFornecedor; }
            set { IdFornecedor = value; }
        }


        public int NomeFornecedor
        {
            get { return NomeFornecedor; }
            set { NomeFornecedor = value; }
        }


    }
}
