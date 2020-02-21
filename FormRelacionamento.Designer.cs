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
            this.SuspendLayout();
            // 
            // cboEmpresaLista
            // 
            this.cboEmpresaLista.DisplayMember = "Names";
            this.cboEmpresaLista.FormattingEnabled = true;
            this.cboEmpresaLista.Location = new System.Drawing.Point(153, 50);
            this.cboEmpresaLista.Name = "cboEmpresaLista";
            this.cboEmpresaLista.Size = new System.Drawing.Size(225, 21);
            this.cboEmpresaLista.TabIndex = 0;
            this.cboEmpresaLista.Text = "Selecione Empresa";
            this.cboEmpresaLista.ValueMember = "Value";
            this.cboEmpresaLista.SelectedIndexChanged += new System.EventHandler(this.cboEmpresaLista_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecione a Empresa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fornecedores Disponíveis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(507, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fornecedores Selecionados";
            // 
            // clbFornecedoresDisponiveis
            // 
            this.clbFornecedoresDisponiveis.DisplayMember = "NomeFornecedor";
            this.clbFornecedoresDisponiveis.FormattingEnabled = true;
            this.clbFornecedoresDisponiveis.Location = new System.Drawing.Point(42, 122);
            this.clbFornecedoresDisponiveis.Name = "clbFornecedoresDisponiveis";
            this.clbFornecedoresDisponiveis.Size = new System.Drawing.Size(306, 289);
            this.clbFornecedoresDisponiveis.TabIndex = 4;
            this.clbFornecedoresDisponiveis.ValueMember = "IdFornecedor";
            // 
            // clbFornecedoresSelecionados
            // 
            this.clbFornecedoresSelecionados.DisplayMember = "NomeFornecedor";
            this.clbFornecedoresSelecionados.FormattingEnabled = true;
            this.clbFornecedoresSelecionados.Location = new System.Drawing.Point(435, 122);
            this.clbFornecedoresSelecionados.Name = "clbFornecedoresSelecionados";
            this.clbFornecedoresSelecionados.Size = new System.Drawing.Size(306, 289);
            this.clbFornecedoresSelecionados.TabIndex = 5;
            this.clbFornecedoresSelecionados.ValueMember = "IdFornecedor";
            // 
            // btnAdicionaFornecedores
            // 
            this.btnAdicionaFornecedores.Location = new System.Drawing.Point(354, 197);
            this.btnAdicionaFornecedores.Name = "btnAdicionaFornecedores";
            this.btnAdicionaFornecedores.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionaFornecedores.TabIndex = 6;
            this.btnAdicionaFornecedores.Text = "Adicionar";
            this.btnAdicionaFornecedores.UseVisualStyleBackColor = true;
            this.btnAdicionaFornecedores.Click += new System.EventHandler(this.btnAdicionaFornecedores_Click);
            // 
            // btnRemoveFornecedores
            // 
            this.btnRemoveFornecedores.Location = new System.Drawing.Point(354, 240);
            this.btnRemoveFornecedores.Name = "btnRemoveFornecedores";
            this.btnRemoveFornecedores.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveFornecedores.TabIndex = 7;
            this.btnRemoveFornecedores.Text = "Remover";
            this.btnRemoveFornecedores.UseVisualStyleBackColor = true;
            this.btnRemoveFornecedores.Click += new System.EventHandler(this.btnRemoveFornecedores_Click);
            // 
            // btnGravaAssociacao
            // 
            this.btnGravaAssociacao.Location = new System.Drawing.Point(666, 433);
            this.btnGravaAssociacao.Name = "btnGravaAssociacao";
            this.btnGravaAssociacao.Size = new System.Drawing.Size(75, 23);
            this.btnGravaAssociacao.TabIndex = 8;
            this.btnGravaAssociacao.Text = "Gravar";
            this.btnGravaAssociacao.UseVisualStyleBackColor = true;
            this.btnGravaAssociacao.Click += new System.EventHandler(this.btnGravaAssociacao_Click);
            // 
            // FormRelacionamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 468);
            this.Controls.Add(this.btnGravaAssociacao);
            this.Controls.Add(this.btnRemoveFornecedores);
            this.Controls.Add(this.btnAdicionaFornecedores);
            this.Controls.Add(this.clbFornecedoresSelecionados);
            this.Controls.Add(this.clbFornecedoresDisponiveis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboEmpresaLista);
            this.Name = "FormRelacionamento";
            this.Text = "Form1";
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
    }
}