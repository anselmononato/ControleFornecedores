namespace CadastroFornecedoresGrupoSym
{
    partial class FormCadastroFornecedores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCadastrarFornecedor = new System.Windows.Forms.Button();
            this.txtNomeFantasiaFornecedor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDeletarFornecedor = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvCadastroFornecedor = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeFantasia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.btnFecharCadastroFornecedor = new System.Windows.Forms.Button();
            this.txtCnpjFornecedor = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastroFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastrarFornecedor
            // 
            this.btnCadastrarFornecedor.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCadastrarFornecedor.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.btnCadastrarFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarFornecedor.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCadastrarFornecedor.Location = new System.Drawing.Point(20, 172);
            this.btnCadastrarFornecedor.Name = "btnCadastrarFornecedor";
            this.btnCadastrarFornecedor.Size = new System.Drawing.Size(75, 30);
            this.btnCadastrarFornecedor.TabIndex = 4;
            this.btnCadastrarFornecedor.Text = "Cadastrar";
            this.btnCadastrarFornecedor.UseVisualStyleBackColor = false;
            this.btnCadastrarFornecedor.Click += new System.EventHandler(this.btnCadastrarFornecedor_Click);
            // 
            // txtNomeFantasiaFornecedor
            // 
            this.txtNomeFantasiaFornecedor.Location = new System.Drawing.Point(101, 68);
            this.txtNomeFantasiaFornecedor.Name = "txtNomeFantasiaFornecedor";
            this.txtNomeFantasiaFornecedor.Size = new System.Drawing.Size(162, 20);
            this.txtNomeFantasiaFornecedor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome Fantasia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "CPF / CNPJ";
            // 
            // btnDeletarFornecedor
            // 
            this.btnDeletarFornecedor.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDeletarFornecedor.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.btnDeletarFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletarFornecedor.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDeletarFornecedor.Location = new System.Drawing.Point(104, 172);
            this.btnDeletarFornecedor.Name = "btnDeletarFornecedor";
            this.btnDeletarFornecedor.Size = new System.Drawing.Size(75, 30);
            this.btnDeletarFornecedor.TabIndex = 5;
            this.btnDeletarFornecedor.Text = "Deletar";
            this.btnDeletarFornecedor.UseVisualStyleBackColor = false;
            this.btnDeletarFornecedor.Click += new System.EventHandler(this.btnDeletarFornecedor_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCancelar.Location = new System.Drawing.Point(187, 172);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 30);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Limpar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // dgvCadastroFornecedor
            // 
            this.dgvCadastroFornecedor.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvCadastroFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCadastroFornecedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NomeFantasia,
            this.UF,
            this.CNPJ});
            this.dgvCadastroFornecedor.Location = new System.Drawing.Point(281, 27);
            this.dgvCadastroFornecedor.Name = "dgvCadastroFornecedor";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCadastroFornecedor.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCadastroFornecedor.Size = new System.Drawing.Size(446, 311);
            this.dgvCadastroFornecedor.TabIndex = 14;
            this.dgvCadastroFornecedor.DoubleClick += new System.EventHandler(this.dgvCadastroFornecedor_DoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // NomeFantasia
            // 
            this.NomeFantasia.DataPropertyName = "NomeFantasia";
            this.NomeFantasia.HeaderText = "Nome Fantasia";
            this.NomeFantasia.Name = "NomeFantasia";
            this.NomeFantasia.ReadOnly = true;
            // 
            // UF
            // 
            this.UF.DataPropertyName = "UF";
            this.UF.HeaderText = "UF";
            this.UF.Name = "UF";
            this.UF.ReadOnly = true;
            // 
            // CNPJ
            // 
            this.CNPJ.DataPropertyName = "CNPJ";
            this.CNPJ.HeaderText = "CNPJ";
            this.CNPJ.Name = "CNPJ";
            this.CNPJ.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Cadastro de Fornecedores";
            // 
            // cboTipo
            // 
            this.cboTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboTipo.Items.AddRange(new object[] {
            "",
            "PJ",
            "PF"});
            this.cboTipo.Location = new System.Drawing.Point(101, 93);
            this.cboTipo.MaxLength = 2;
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(55, 21);
            this.cboTipo.TabIndex = 2;
            // 
            // btnFecharCadastroFornecedor
            // 
            this.btnFecharCadastroFornecedor.BackColor = System.Drawing.Color.SteelBlue;
            this.btnFecharCadastroFornecedor.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.btnFecharCadastroFornecedor.FlatAppearance.BorderSize = 0;
            this.btnFecharCadastroFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFecharCadastroFornecedor.ForeColor = System.Drawing.SystemColors.Window;
            this.btnFecharCadastroFornecedor.Location = new System.Drawing.Point(688, 0);
            this.btnFecharCadastroFornecedor.Name = "btnFecharCadastroFornecedor";
            this.btnFecharCadastroFornecedor.Size = new System.Drawing.Size(51, 27);
            this.btnFecharCadastroFornecedor.TabIndex = 17;
            this.btnFecharCadastroFornecedor.Text = "Fechar";
            this.btnFecharCadastroFornecedor.UseVisualStyleBackColor = false;
            this.btnFecharCadastroFornecedor.Click += new System.EventHandler(this.btnFecharCadastroFornecedor_Click);
            // 
            // txtCnpjFornecedor
            // 
            this.txtCnpjFornecedor.Location = new System.Drawing.Point(101, 120);
            this.txtCnpjFornecedor.Name = "txtCnpjFornecedor";
            this.txtCnpjFornecedor.Size = new System.Drawing.Size(161, 20);
            this.txtCnpjFornecedor.TabIndex = 19;
            this.txtCnpjFornecedor.Enter += new System.EventHandler(this.txtCnpjFornecedor_Enter);
            this.txtCnpjFornecedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCnpjFornecedor_KeyPress_1);
            this.txtCnpjFornecedor.Leave += new System.EventHandler(this.txtCnpjFornecedor_Leave);
            // 
            // FormCadastroFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(739, 350);
            this.Controls.Add(this.txtCnpjFornecedor);
            this.Controls.Add(this.btnFecharCadastroFornecedor);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvCadastroFornecedor);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnDeletarFornecedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCadastrarFornecedor);
            this.Controls.Add(this.txtNomeFantasiaFornecedor);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCadastroFornecedores";
            this.Text = "Cadastro de Fornecedores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastroFornecedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarFornecedor;
        private System.Windows.Forms.TextBox txtNomeFantasiaFornecedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDeletarFornecedor;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvCadastroFornecedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeFantasia;
        private System.Windows.Forms.DataGridViewTextBoxColumn UF;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNPJ;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Button btnFecharCadastroFornecedor;
        private System.Windows.Forms.MaskedTextBox txtCnpjFornecedor;
    }
}