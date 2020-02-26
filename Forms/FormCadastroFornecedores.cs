using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using CadastroFornecedoresGrupoSym.Entity;

namespace CadastroFornecedoresGrupoSym
{
    public partial class FormCadastroFornecedores : Form
    {
        private readonly FuncoesDoSistema funcoesDoSistema = new FuncoesDoSistema();
        private Fornecedor model = new Fornecedor();
        private readonly Color colorInvalidated = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
        private readonly Color colorValidated = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
        public FormCadastroFornecedores()
        {
            InitializeComponent();
            limpar();
        }

        void limpar()
        {
            PopularFornecedores();

            txtCnpjFornecedor.Text = txtNomeFantasiaFornecedor.Text = txtNascimento.Text = cboTipo.Text = "";
            btnCadastrarFornecedor.Text = "Cadastrar";
            btnDeletarFornecedor.Enabled = false;
            model.ID = 0;
            txtCnpjFornecedor.Mask = "";
        }
        
        private void PopularFornecedores()
        {

            dgvCadastroFornecedor.AutoGenerateColumns = false;
            using (CadastrosDbEntity Db = new CadastrosDbEntity())
            {
                dgvCadastroFornecedor.DataSource = Db.Fornecedor.ToList<Fornecedor>();

            }

        }

        private void btnCadastrarFornecedor_Click(object sender, EventArgs e)
        {
            txtNomeFantasiaFornecedor.Text = txtNomeFantasiaFornecedor.Text.Trim();

            txtCnpjFornecedor.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            if (txtNomeFantasiaFornecedor.Text != ""
                && cboTipo.Text != ""
                && validaCPF_CNPJ() != null
                && (funcoesDoSistema.ValidaIdade(txtNascimento.Text.Trim())
                    || cboTipo.Text == "PJ"))
            
            {
                if (cboTipo.Text == "PF")
                {
                    DateTime.TryParse(txtNascimento.Text.Trim(), out DateTime dataNascimento);
                    model.Nascimento = dataNascimento;
                }

                model.Nome = txtNomeFantasiaFornecedor.Text.Trim();
                model.Tipo = cboTipo.Text.Trim();
                model.CPF_CNPJ = txtCnpjFornecedor.Text.Trim();
                

                using (CadastrosDbEntity db = new CadastrosDbEntity())
                {
                    if (model.ID == 0)
                        db.Fornecedor.Add(model);
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
                MessageBox.Show("Erro ao gravar. Verifique se todos os campos foram preenchidos e validados");
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
                    model = db.Fornecedor.Where(x => x.ID == model.ID).FirstOrDefault();
                    txtCnpjFornecedor.Text = model.CPF_CNPJ;
                    txtNomeFantasiaFornecedor.Text = model.Nome;
                    cboTipo.Text = model.Tipo;
                    txtNascimento.Text =  model.Nascimento.ToString();
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
                    db.Fornecedor.Attach(model);
                db.Fornecedor.Remove(model);
                db.SaveChanges();
                limpar();
                }
            }
        }

         private void txtCnpjFornecedor_Leave(object sender, EventArgs e)
        {

            //  string tipo = validaCPF_CNPJ();

            Regex pattern = new Regex(@"[^\d]");
            txtCnpjFornecedor.Text = pattern.Replace(txtCnpjFornecedor.Text, "");

            txtCnpjFornecedor.Mask = cboTipo.Text == "PJ" ? "99,999,999/9999-99" : cboTipo.Text == "PF" ? "999,999,999-99" : "";

        }

        private string validaCPF_CNPJ()
        {

            Regex pattern = new Regex(@"[^\d]");
            string teste = pattern.Replace(txtCnpjFornecedor.Text, "");



            if (teste.Length == 11
                    && Sirb.Documents.BR.Validation.CPF.IsValid(teste))
            {

                txtCnpjFornecedor.BackColor = colorValidated;
                btnCadastrarFornecedor.Enabled = true;
                lbNascimento.Visible = true;
                txtNascimento.Visible = true;
                txtNascimento.Mask = "00/00/0000";
                cboTipo.Text = "PF";
                return cboTipo.Text;
            }
            else if (teste.Length == 14 
                && Sirb.Documents.BR.Validation.CNPJ.IsValid(teste))
            {

                txtCnpjFornecedor.BackColor = colorValidated;
                btnCadastrarFornecedor.Enabled = true;
                cboTipo.Text = "PJ";
                txtNascimento.Visible = lbNascimento.Visible = false;
                return cboTipo.Text;
                
            }
           
            else
            {
                txtCnpjFornecedor.Mask = "";
                txtCnpjFornecedor.BackColor = colorInvalidated;
                cboTipo.Text = "";
                
                txtNascimento.Visible = lbNascimento.Visible = false;
                return null;

            }
        }

        private void TxtCnpjFornecedor_Enter(object sender, EventArgs e)
        {
            txtCnpjFornecedor.Mask = "";
            txtCnpjFornecedor.SelectionStart = txtCnpjFornecedor.TextLength;
            txtCnpjFornecedor.SelectionLength = 0;
        }

        private void txtCnpjFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void txtCnpjFornecedor_TextChanged(object sender, EventArgs e)
        {
            validaCPF_CNPJ();
        }

        private void txtNascimento_TextChanged(object sender, EventArgs e)
        {
            if (funcoesDoSistema.ValidaIdade(txtNascimento.Text.Trim()))
            {
                txtNascimento.BackColor = colorValidated;
            }
            else
            {
                txtNascimento.BackColor = colorInvalidated;
            }
        }
    }

    }