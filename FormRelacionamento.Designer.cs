namespace CadastroFornecedoresGrupoSym
{
    partial class FormRelacionamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboEmpresaLista = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.clbFornecedoresDisponiveis = new System.Windows.Forms.CheckedListBox();
            this.clbFornecedoresSelecionados = new System.Windows.Forms.CheckedListBox();
            this.btnAdicionaFornecedores = new System.Windows.Forms.Button();
            this.btnRemoveFornecedores = new System.Windows.Forms.Button();
            this.btnGravaAssociacao = new System.Windows.Forms.Button();
            this.btnDesfazer = new System.Windows.Forms.Button();
            this.btnFecharCadastroFornecedor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboEmpresaLista
            // 
            this.cboEmpresaLista.DisplayMember = "Names";
            this.cboEmpresaLista.FormattingEnabled = true;
            this.cboEmpresaLista.Location = new System.Drawing.Point(88, 58);
            this.cboEmpresaLista.Name = "cboEmpresaLista";
            this.cboEmpresaLista.Size = new System.Drawing.Size(184, 21);
            this.cboEmpresaLista.TabIndex = 15;
            this.cboEmpresaLista.Text = "Selecione Empresa";
            this.cboEmpresaLista.ValueMember = "Value";
            this.cboEmpresaLista.SelectionChangeCommitted += new System.EventHandler(this.cboEmpresaLista_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Empresa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fornecedores Não associados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(507, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fornecedores Associados";
            // 
            // clbFornecedoresDisponiveis
            // 
            this.clbFornecedoresDisponiveis.CheckOnClick = true;
            this.clbFornecedoresDisponiveis.DisplayMember = "NomeFornecedor";
            this.clbFornecedoresDisponiveis.FormattingEnabled = true;
            this.clbFornecedoresDisponiveis.Location = new System.Drawing.Point(42, 131);
            this.clbFornecedoresDisponiveis.Name = "clbFornecedoresDisponiveis";
            this.clbFornecedoresDisponiveis.Size = new System.Drawing.Size(306, 289);
            this.clbFornecedoresDisponiveis.TabIndex = 4;
            this.clbFornecedoresDisponiveis.ValueMember = "IdFornecedor";
            // 
            // clbFornecedoresSelecionados
            // 
            this.clbFornecedoresSelecionados.CheckOnClick = true;
            this.clbFornecedoresSelecionados.DisplayMember = "NomeFornecedor";
            this.clbFornecedoresSelecionados.FormattingEnabled = true;
            this.clbFornecedoresSelecionados.Location = new System.Drawing.Point(435, 131);
            this.clbFornecedoresSelecionados.Name = "clbFornecedoresSelecionados";
            this.clbFornecedoresSelecionados.Size = new System.Drawing.Size(306, 289);
            this.clbFornecedoresSelecionados.TabIndex = 5;
            this.clbFornecedoresSelecionados.ValueMember = "IdFornecedor";
            // 
            // btnAdicionaFornecedores
            // 
            this.btnAdicionaFornecedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionaFornecedores.Location = new System.Drawing.Point(354, 206);
            this.btnAdicionaFornecedores.Name = "btnAdicionaFornecedores";
            this.btnAdicionaFornecedores.Size = new System.Drawing.Size(75, 30);
            this.btnAdicionaFornecedores.TabIndex = 6;
            this.btnAdicionaFornecedores.Text = "Adicionar";
            this.btnAdicionaFornecedores.UseVisualStyleBackColor = true;
            this.btnAdicionaFornecedores.Click += new System.EventHandler(this.BtnAdicionaFornecedores_Click);
            // 
            // btnRemoveFornecedores
            // 
            this.btnRemoveFornecedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveFornecedores.Location = new System.Drawing.Point(354, 242);
            this.btnRemoveFornecedores.Name = "btnRemoveFornecedores";
            this.btnRemoveFornecedores.Size = new System.Drawing.Size(75, 30);
            this.btnRemoveFornecedores.TabIndex = 7;
            this.btnRemoveFornecedores.Text = "Remover";
            this.btnRemoveFornecedores.UseVisualStyleBackColor = true;
            this.btnRemoveFornecedores.Click += new System.EventHandler(this.BtnRemoveFornecedores_Click);
            // 
            // btnGravaAssociacao
            // 
            this.btnGravaAssociacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGravaAssociacao.Location = new System.Drawing.Point(665, 430);
            this.btnGravaAssociacao.Name = "btnGravaAssociacao";
            this.btnGravaAssociacao.Size = new System.Drawing.Size(75, 30);
            this.btnGravaAssociacao.TabIndex = 8;
            this.btnGravaAssociacao.Text = "Gravar";
            this.btnGravaAssociacao.UseVisualStyleBackColor = true;
            this.btnGravaAssociacao.Click += new System.EventHandler(this.BtnGravaAssociacao_Click);
            // 
            // btnDesfazer
            // 
            this.btnDesfazer.Enabled = false;
            this.btnDesfazer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesfazer.Location = new System.Drawing.Point(354, 303);
            this.btnDesfazer.Name = "btnDesfazer";
            this.btnDesfazer.Size = new System.Drawing.Size(75, 30);
            this.btnDesfazer.TabIndex = 9;
            this.btnDesfazer.Text = "Desfazer";
            this.btnDesfazer.UseVisualStyleBackColor = true;
            this.btnDesfazer.Click += new System.EventHandler(this.BtnDesfazer_Click);
            // 
            // btnFecharCadastroFornecedor
            // 
            this.btnFecharCadastroFornecedor.BackColor = System.Drawing.Color.SteelBlue;
            this.btnFecharCadastroFornecedor.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.btnFecharCadastroFornecedor.FlatAppearance.BorderSize = 0;
            this.btnFecharCadastroFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFecharCadastroFornecedor.ForeColor = System.Drawing.SystemColors.Window;
            this.btnFecharCadastroFornecedor.Location = new System.Drawing.Point(737, 12);
            this.btnFecharCadastroFornecedor.Name = "btnFecharCadastroFornecedor";
            this.btnFecharCadastroFornecedor.Size = new System.Drawing.Size(51, 27);
            this.btnFecharCadastroFornecedor.TabIndex = 18;
            this.btnFecharCadastroFornecedor.Text = "Fechar";
            this.btnFecharCadastroFornecedor.UseVisualStyleBackColor = false;
            this.btnFecharCadastroFornecedor.Click += new System.EventHandler(this.btnFecharCadastroFornecedor_Click);
            // 
            // FormRelacionamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 468);
            this.Controls.Add(this.btnFecharCadastroFornecedor);
            this.Controls.Add(this.btnDesfazer);
            this.Controls.Add(this.btnGravaAssociacao);
            this.Controls.Add(this.btnRemoveFornecedores);
            this.Controls.Add(this.btnAdicionaFornecedores);
            this.Controls.Add(this.clbFornecedoresSelecionados);
            this.Controls.Add(this.clbFornecedoresDisponiveis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboEmpresaLista);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRelacionamento";
            this.Text = "Associar Fornecedores";
          //  this.Load += new System.EventHandler(this.FormRelacionamento); 
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboEmpresaLista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox clbFornecedoresDisponiveis;
        private System.Windows.Forms.CheckedListBox clbFornecedoresSelecionados;
        private System.Windows.Forms.Button btnAdicionaFornecedores;
        private System.Windows.Forms.Button btnRemoveFornecedores;
        private System.Windows.Forms.Button btnGravaAssociacao;
        private System.Windows.Forms.Button btnDesfazer;
        private System.Windows.Forms.Button btnFecharCadastroFornecedor;
    }
}