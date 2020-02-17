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
    public partial class FormCadastroEmpresas : Form
    {
        Empresa model = new Empresa();
        public FormCadastroEmpresas()
        {
            InitializeComponent();
            limpar();
        }

        void limpar()
        {
            PopularEmpresas();

            txtCnpjEmpresa.Text = txtNomeFantasiaEmpresa.Text = cboUf.Text = "";
            btnCadastrarEmpresa.Text = "Cadastrar";
            btnDeletarEmpresa.Enabled = false;
            model.ID = 0;

        }

        private void PopularEmpresas()
        {

            dgvCadastroEmpresa.AutoGenerateColumns = false;
            using (CadastrosDbEntity Db = new CadastrosDbEntity())
            {
                dgvCadastroEmpresa.DataSource = Db.Empresas.ToList<Empresa>();

            }

        }

        private void btnCadastrarEmpresa_Click(object sender, EventArgs e)
        {

            
            txtCnpjEmpresa.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (txtNomeFantasiaEmpresa.Text != "" && cboUf.Text != "" & txtCnpjEmpresa.Text.Length == 14)
            {
                model.NomeFantasia = txtNomeFantasiaEmpresa.Text.Trim();
                model.UF = cboUf.Text.Trim();
                model.CNPJ = txtCnpjEmpresa.Text.Trim();

                using (CadastrosDbEntity db = new CadastrosDbEntity())
                {
                    if (model.ID == 0)
                        db.Empresas.Add(model);
                    else
                    {
                        if (MessageBox.Show("Realmente deseja atualizar os dados?", "Confirmar Atualização", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                        else
                            return;
                    }
                    db.SaveChanges();
                }

                limpar();
            }
            else 
                MessageBox.Show("Não é permitido campos em branco");
        }

        private void txtCnpjEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            
        }

        private void btnFecharCadastroEmpresa_Click(object sender, EventArgs e)
        {


            Close();


           

           
           

            
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            limpar();
        }

        private void dgvCadastroEmpresa_DoubleClick(object sender, EventArgs e)
        {
            if (dgvCadastroEmpresa.CurrentRow.Index != -1)
            {
                model.ID = Convert.ToInt32(dgvCadastroEmpresa.CurrentRow.Cells["ID"].Value);

                using (CadastrosDbEntity db = new CadastrosDbEntity())
                {
                    model = db.Empresas.Where(x => x.ID == model.ID).FirstOrDefault();
                    txtCnpjEmpresa.Text = model.CNPJ;
                    //long longCNPJ = long.Parse(model.CNPJ);
                    //string CNPJFormatado = String.Format(@"{0:00\.000\.000\/0000\-00}", longCNPJ); //Formatar de Long para CNPJ
                    //txtCnpjEmpresa.Text = CNPJFormatado;
                    txtNomeFantasiaEmpresa.Text = model.NomeFantasia;
                    cboUf.Text = model.UF;   
                }
            btnDeletarEmpresa.Enabled = true;
            btnCadastrarEmpresa.Text = "Atualizar";
            }
        }

        private void btnDeletarEmpresa_Click(object sender, EventArgs e)
        {
            using (CadastrosDbEntity db = new CadastrosDbEntity())
            {

                if (MessageBox.Show("Deseja realmente excluir este registro?", "Confirme a exclusão", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var entry = db.Entry(model);
                if (entry.State == System.Data.Entity.EntityState.Detached)
                    db.Empresas.Attach(model);
                db.Empresas.Remove(model);
                db.SaveChanges();
                limpar();
                }
            }
        }

        private void txtCnpjEmpresa_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Estudar o que o Handled faz.

            }

            //// only allow one decimal point
            //if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            //{
            //    e.Handled = true;
            //}
        }

        //private void txtCnpjEmpresa_KeyPress_1(object sender, KeyPressEventArgs e)
        //{

        //        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
        //        {
        //            e.Handled = true; // Estudar o que o Handled faz.

        //        }

        //        //// only allow one decimal point
        //        //if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
        //        //{
        //        //    e.Handled = true;
        //        //}

        //}


    }
}
