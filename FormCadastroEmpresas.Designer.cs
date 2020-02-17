namespace CadastroFornecedoresGrupoSym
{
    partial class FormCadastroEmpresas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCadastrarEmpresa = new System.Windows.Forms.Button();
            this.txtNomeFantasiaEmpresa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDeletarEmpresa = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvCadastroEmpresa = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeFantasia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.cboUf = new System.Windows.Forms.ComboBox();
            this.btnFecharCadastroEmpresa = new System.Windows.Forms.Button();
            this.txtCnpjEmpresa = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastroEmpresa)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastrarEmpresa
            // 
            this.btnCadastrarEmpresa.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCadastrarEmpresa.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.btnCadastrarEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarEmpresa.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCadastrarEmpresa.Location = new System.Drawing.Point(20, 172);
            this.btnCadastrarEmpresa.Name = "btnCadastrarEmpresa";
            this.btnCadastrarEmpresa.Size = new System.Drawing.Size(75, 30);
            this.btnCadastrarEmpresa.TabIndex = 4;
            this.btnCadastrarEmpresa.Text = "Cadastrar";
            this.btnCadastrarEmpresa.UseVisualStyleBackColor = false;
            this.btnCadastrarEmpresa.Click += new System.EventHandler(this.btnCadastrarEmpresa_Click);
            // 
            // txtNomeFantasiaEmpresa
            // 
            this.txtNomeFantasiaEmpresa.Location = new System.Drawing.Point(101, 68);
            this.txtNomeFantasiaEmpresa.Name = "txtNomeFantasiaEmpresa";
            this.txtNomeFantasiaEmpresa.Size = new System.Drawing.Size(162, 20);
            this.txtNomeFantasiaEmpresa.TabIndex = 1;
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
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "UF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "CNPJ";
            // 
            // btnDeletarEmpresa
            // 
            this.btnDeletarEmpresa.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDeletarEmpresa.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.btnDeletarEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletarEmpresa.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDeletarEmpresa.Location = new System.Drawing.Point(104, 172);
            this.btnDeletarEmpresa.Name = "btnDeletarEmpresa";
            this.btnDeletarEmpresa.Size = new System.Drawing.Size(75, 30);
            this.btnDeletarEmpresa.TabIndex = 5;
            this.btnDeletarEmpresa.Text = "Deletar";
            this.btnDeletarEmpresa.UseVisualStyleBackColor = false;
            this.btnDeletarEmpresa.Click += new System.EventHandler(this.btnDeletarEmpresa_Click);
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
            // dgvCadastroEmpresa
            // 
            this.dgvCadastroEmpresa.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvCadastroEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCadastroEmpresa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NomeFantasia,
            this.UF,
            this.CNPJ});
            this.dgvCadastroEmpresa.Location = new System.Drawing.Point(281, 27);
            this.dgvCadastroEmpresa.Name = "dgvCadastroEmpresa";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCadastroEmpresa.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCadastroEmpresa.Size = new System.Drawing.Size(446, 311);
            this.dgvCadastroEmpresa.TabIndex = 14;
            this.dgvCadastroEmpresa.DoubleClick += new System.EventHandler(this.dgvCadastroEmpresa_DoubleClick);
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
            this.label4.Size = new System.Drawing.Size(172, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Cadastro de Empresas";
            // 
            // cboUf
            // 
            this.cboUf.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboUf.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboUf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUf.FormattingEnabled = true;
            this.cboUf.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboUf.Items.AddRange(new object[] {
            "",
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cboUf.Location = new System.Drawing.Point(101, 93);
            this.cboUf.MaxLength = 2;
            this.cboUf.Name = "cboUf";
            this.cboUf.Size = new System.Drawing.Size(55, 21);
            this.cboUf.TabIndex = 2;
            // 
            // btnFecharCadastroEmpresa
            // 
            this.btnFecharCadastroEmpresa.BackColor = System.Drawing.Color.SteelBlue;
            this.btnFecharCadastroEmpresa.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.btnFecharCadastroEmpresa.FlatAppearance.BorderSize = 0;
            this.btnFecharCadastroEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFecharCadastroEmpresa.ForeColor = System.Drawing.SystemColors.Window;
            this.btnFecharCadastroEmpresa.Location = new System.Drawing.Point(688, 0);
            this.btnFecharCadastroEmpresa.Name = "btnFecharCadastroEmpresa";
            this.btnFecharCadastroEmpresa.Size = new System.Drawing.Size(51, 27);
            this.btnFecharCadastroEmpresa.TabIndex = 17;
            this.btnFecharCadastroEmpresa.Text = "Fechar";
            this.btnFecharCadastroEmpresa.UseVisualStyleBackColor = false;
            this.btnFecharCadastroEmpresa.Click += new System.EventHandler(this.btnFecharCadastroEmpresa_Click);
            // 
            // txtCnpjEmpresa
            // 
            this.txtCnpjEmpresa.Location = new System.Drawing.Point(101, 120);
            this.txtCnpjEmpresa.Mask = "99,999,999/9999-99";
            this.txtCnpjEmpresa.Name = "txtCnpjEmpresa";
            this.txtCnpjEmpresa.Size = new System.Drawing.Size(161, 20);
            this.txtCnpjEmpresa.TabIndex = 19;
            this.txtCnpjEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCnpjEmpresa_KeyPress_1);
            // 
            // FormCadastroEmpresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(739, 350);
            this.Controls.Add(this.txtCnpjEmpresa);
            this.Controls.Add(this.btnFecharCadastroEmpresa);
            this.Controls.Add(this.cboUf);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvCadastroEmpresa);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnDeletarEmpresa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCadastrarEmpresa);
            this.Controls.Add(this.txtNomeFantasiaEmpresa);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCadastroEmpresas";
            this.Text = "Cadastro de Empresas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastroEmpresa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarEmpresa;
        private System.Windows.Forms.TextBox txtNomeFantasiaEmpresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDeletarEmpresa;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvCadastroEmpresa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeFantasia;
        private System.Windows.Forms.DataGridViewTextBoxColumn UF;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNPJ;
        private System.Windows.Forms.ComboBox cboUf;
        private System.Windows.Forms.Button btnFecharCadastroEmpresa;
        private System.Windows.Forms.MaskedTextBox txtCnpjEmpresa;
    }
}