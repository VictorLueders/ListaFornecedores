
namespace ListaFornecedores
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblInstrucao = new System.Windows.Forms.Label();
            this.lblInsira = new System.Windows.Forms.Label();
            this.txtUf = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCnpj = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInstrucao
            // 
            this.lblInstrucao.AutoSize = true;
            this.lblInstrucao.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstrucao.Location = new System.Drawing.Point(115, 28);
            this.lblInstrucao.Name = "lblInstrucao";
            this.lblInstrucao.Size = new System.Drawing.Size(618, 39);
            this.lblInstrucao.TabIndex = 0;
            this.lblInstrucao.Text = "Primeiramente, cadastre sua empresa.";
            // 
            // lblInsira
            // 
            this.lblInsira.AutoSize = true;
            this.lblInsira.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsira.Location = new System.Drawing.Point(359, 88);
            this.lblInsira.Name = "lblInsira";
            this.lblInsira.Size = new System.Drawing.Size(95, 33);
            this.lblInsira.TabIndex = 0;
            this.lblInsira.Text = "Insira:";
            // 
            // txtUf
            // 
            this.txtUf.Location = new System.Drawing.Point(329, 148);
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(153, 20);
            this.txtUf.TabIndex = 1;
            this.txtUf.Text = "Unidade Federativa";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(329, 189);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(153, 20);
            this.txtNome.TabIndex = 2;
            this.txtNome.Text = "Nome";
            // 
            // txtCnpj
            // 
            this.txtCnpj.Location = new System.Drawing.Point(329, 228);
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(153, 20);
            this.txtCnpj.TabIndex = 3;
            this.txtCnpj.Text = "CNPJ";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.White;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(307, 299);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(193, 49);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            this.btnCadastrar.MouseLeave += new System.EventHandler(this.btnCadastrar_MouseLeave);
            this.btnCadastrar.MouseHover += new System.EventHandler(this.btnCadastrar_MouseHover);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(838, 483);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtCnpj);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtUf);
            this.Controls.Add(this.lblInsira);
            this.Controls.Add(this.lblInstrucao);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInstrucao;
        private System.Windows.Forms.Label lblInsira;
        private System.Windows.Forms.TextBox txtUf;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCnpj;
        private System.Windows.Forms.Button btnCadastrar;
    }
}

