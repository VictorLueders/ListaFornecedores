
namespace ListaFornecedores.View
{
    partial class Form2
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
            this.dataGridFornecedores = new System.Windows.Forms.DataGridView();
            this.Empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CpfCnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataDeCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFornecedores = new System.Windows.Forms.Label();
            this.lblBarra = new System.Windows.Forms.Label();
            this.btnCFornecedor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCC = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFornecedores)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridFornecedores
            // 
            this.dataGridFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFornecedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Empresa,
            this.Nome,
            this.CpfCnpj,
            this.DataDeCadastro,
            this.Telefones});
            this.dataGridFornecedores.Location = new System.Drawing.Point(280, 12);
            this.dataGridFornecedores.Name = "dataGridFornecedores";
            this.dataGridFornecedores.Size = new System.Drawing.Size(544, 457);
            this.dataGridFornecedores.TabIndex = 0;
            // 
            // Empresa
            // 
            this.Empresa.HeaderText = "Empresa";
            this.Empresa.Name = "Empresa";
            this.Empresa.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // CpfCnpj
            // 
            this.CpfCnpj.HeaderText = "CPF/CNPJ";
            this.CpfCnpj.Name = "CpfCnpj";
            this.CpfCnpj.ReadOnly = true;
            // 
            // DataDeCadastro
            // 
            this.DataDeCadastro.HeaderText = "Data do cadastro";
            this.DataDeCadastro.Name = "DataDeCadastro";
            this.DataDeCadastro.ReadOnly = true;
            // 
            // Telefones
            // 
            this.Telefones.HeaderText = "Telefones";
            this.Telefones.Name = "Telefones";
            this.Telefones.ReadOnly = true;
            // 
            // lblFornecedores
            // 
            this.lblFornecedores.AutoSize = true;
            this.lblFornecedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFornecedores.Location = new System.Drawing.Point(12, 12);
            this.lblFornecedores.Name = "lblFornecedores";
            this.lblFornecedores.Size = new System.Drawing.Size(260, 42);
            this.lblFornecedores.TabIndex = 1;
            this.lblFornecedores.Text = "Fornecedores:";
            // 
            // lblBarra
            // 
            this.lblBarra.AutoSize = true;
            this.lblBarra.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarra.Location = new System.Drawing.Point(12, 54);
            this.lblBarra.Name = "lblBarra";
            this.lblBarra.Size = new System.Drawing.Size(260, 29);
            this.lblBarra.TabIndex = 3;
            this.lblBarra.Text = "___________________";
            // 
            // btnCFornecedor
            // 
            this.btnCFornecedor.BackColor = System.Drawing.Color.White;
            this.btnCFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCFornecedor.ForeColor = System.Drawing.Color.Black;
            this.btnCFornecedor.Location = new System.Drawing.Point(43, 321);
            this.btnCFornecedor.Name = "btnCFornecedor";
            this.btnCFornecedor.Size = new System.Drawing.Size(197, 61);
            this.btnCFornecedor.TabIndex = 4;
            this.btnCFornecedor.Text = "Cadastro";
            this.btnCFornecedor.UseVisualStyleBackColor = false;
            this.btnCFornecedor.Click += new System.EventHandler(this.btnCFornecedor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cadastro de fornecedor";
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(60, 141);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(145, 20);
            this.txtEmpresa.TabIndex = 1;
            this.txtEmpresa.Text = "Empresa";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(60, 184);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(145, 20);
            this.txtNome.TabIndex = 2;
            this.txtNome.Text = "Nome";
            // 
            // txtCC
            // 
            this.txtCC.Location = new System.Drawing.Point(60, 227);
            this.txtCC.Name = "txtCC";
            this.txtCC.Size = new System.Drawing.Size(145, 20);
            this.txtCC.TabIndex = 3;
            this.txtCC.Text = "CPF/CNPJ";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(60, 271);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(145, 20);
            this.txtTelefone.TabIndex = 4;
            this.txtTelefone.Text = "Telefone";
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(836, 481);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtCC);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtEmpresa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCFornecedor);
            this.Controls.Add(this.lblBarra);
            this.Controls.Add(this.lblFornecedores);
            this.Controls.Add(this.dataGridFornecedores);
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFornecedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridFornecedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CpfCnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataDeCadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefones;
        private System.Windows.Forms.Label lblFornecedores;
        private System.Windows.Forms.Label lblBarra;
        private System.Windows.Forms.Button btnCFornecedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCC;
        private System.Windows.Forms.TextBox txtTelefone;
    }
}