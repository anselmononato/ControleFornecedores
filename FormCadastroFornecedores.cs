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
    public partial class FormCadastroFornecedores : Form
    {
        Fornecedor model = new Fornecedor();
        public FormCadastroFornecedores()
        {
            InitializeComponent();
            limpar();
        }

        void limpar()
        {
            PopularFornecedores();

            txtCnpjFornecedor.Text = txtNomeFantasiaFornecedor.Text = cboTipo.Text = "";
            btnCadastrarFornecedor.Text = "Cadastrar";
            btnDeletarFornecedor.Enabled = false;
            model.ID = 0;

        }

        private void PopularFornecedores()
        {

            dgvCadastroFornecedor.AutoGenerateColumns = false;
            using (CadastrosDbEntity Db = new CadastrosDbEntity())
            {
                dgvCadastroFornecedor.DataSource = Db.Fornecedors.ToList<Fornecedor>();

            }

        }

        private void btnCadastrarFornecedor_Click(object sender, EventArgs e)
        {

            
            txtCnpjFornecedor.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (txtNomeFantasiaFornecedor.Text != "" && cboTipo.Text != "" & txtCnpjFornecedor.Text.Length == 14)
            {
                model.Nome = txtNomeFantasiaFornecedor.Text.Trim();
                model.Tipo = cboTipo.Text.Trim();
                model.CPF_CNPJ = txtCnpjFornecedor.Text.Trim();

                using (CadastrosDbEntity db = new CadastrosDbEntity())
                {
                    if (model.ID == 0)
                        db.Fornecedors.Add(model);
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

        private void txtCnpjFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            
        }

        private void btnFecharCadastroFornecedor_Click(object sender, EventArgs e)
        {


            Close();


           

           
           

            
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            limpar();
        }

        private void dgvCadastroFornecedor_DoubleClick(object sender, EventArgs e)
        {
            if (dgvCadastroFornecedor.CurrentRow.Index != -1)
            {
                model.ID = Convert.ToInt32(dgvCadastroFornecedor.CurrentRow.Cells["ID"].Value);

                using (CadastrosDbEntity db = new CadastrosDbEntity())
                {
                    model = db.Fornecedors.Where(x => x.ID == model.ID).FirstOrDefault();
                    txtCnpjFornecedor.Text = model.CPF_CNPJ;
                    //long longCNPJ = long.Parse(model.CNPJ);
                    //string CNPJFormatado = String.Format(@"{0:00\.000\.000\/0000\-00}", longCNPJ); //Formatar de Long para CNPJ
                    //txtCnpjFornecedor.Text = CNPJFormatado;
                    txtNomeFantasiaFornecedor.Text = model.Nome;
                    cboTipo.Text = model.Tipo;   
                }
            btnDeletarFornecedor.Enabled = true;
            btnCadastrarFornecedor.Text = "Atualizar";
            }
        }

        private void btnDeletarFornecedor_Click(object sender, EventArgs e)
        {


            using (CadastrosDbEntity db = new CadastrosDbEntity())
            {

                if (MessageBox.Show("Deseja realmente excluir este registro?", "Confirme a exclusão", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var entry = db.Entry(model);
                if (entry.State == System.Data.Entity.EntityState.Detached)
                    db.Fornecedors.Attach(model);
                db.Fornecedors.Remove(model);
                db.SaveChanges();
                limpar();
                }
            }
        }

        private void txtCnpjFornecedor_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Estudar o que o Handled faz.

            }

            else
            {
                this.txtCnpjFornecedor.Mask = "";
            }

            //// only allow one decimal point
            //if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            //{
            //    e.Handled = true;
            //}
        }

        private void txtCnpjFornecedor_Leave(object sender, EventArgs e)
        {

            validaCPF_CNPJ(txtCnpjFornecedor.Text);

        }


        private object validaCPF_CNPJ(string entrada)
        {
            long CNPJ;
            if (txtCnpjFornecedor.Text.Length == 14)
            {
                CNPJ =  long.Parse(txtCnpjFornecedor.Text);
                this.txtCnpjFornecedor.Mask = "99,999,999/9999-99";
                this.txtCnpjFornecedor.BackColor = default;
                btnCadastrarFornecedor.Enabled = true;
                String tipo = cboTipo.Text = "PJ";
            }
            else if (txtCnpjFornecedor.Text.Length == 11)
            {
                this.txtCnpjFornecedor.Mask = "999,999,999-99";
                this.txtCnpjFornecedor.BackColor = default;
                btnCadastrarFornecedor.Enabled = true;
                cboTipo.Text = "PF";
            }
            else
            {
                this.txtCnpjFornecedor.Mask = "";
                //this.txtCnpjFornecedor.Text = "";
                this.txtCnpjFornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
                btnCadastrarFornecedor.Enabled = false;
                cboTipo.Text = "";
            }

            return null;
        }

        

        private void txtCnpjFornecedor_Enter(object sender, EventArgs e)
        {
            this.txtCnpjFornecedor.Mask = "";
            //int textLength = this.txtCnpjFornecedor.TextLength;
            this.txtCnpjFornecedor.SelectionStart = this.txtCnpjFornecedor.TextLength;
            this.txtCnpjFornecedor.SelectionLength = 0;
        }









        //private void txtCnpjFornecedor_KeyPress_1(object sender, KeyPressEventArgs e)
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
