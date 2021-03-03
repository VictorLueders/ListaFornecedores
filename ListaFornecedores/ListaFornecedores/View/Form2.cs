using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ListaFornecedores.Model;
using ListaFornecedores.View;


namespace ListaFornecedores.View
{
    public partial class Form2 : Form
    {
        public Empresa empresa2 { get; set; }

        public Form2(Empresa empresa)
        {
            InitializeComponent();
            empresa2 = empresa;

            foreach (var item in empresa2.Fornecedores)
            {
                string[] dados = new string[5];
                dados[0] = item.Empresa;
                dados[1] = item.Nome;
                dados[2] = item.CpfCnpj;
                dados[3] = item.Data;
                dados[4] = item.Telefone;

                dataGridFornecedores.Rows.Add(dados);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnCFornecedor_Click(object sender, EventArgs e)
        {
            Fornecedor forn = new Fornecedor(txtEmpresa.Text, txtNome.Text, txtCC.Text, txtTelefone.Text);
            empresa2.Fornecedores.Add(forn);

            string[] dados = new string[5];
            dados[0] = forn.Empresa;
            dados[1] = forn.Nome;
            dados[2] = forn.CpfCnpj;
            dados[3] = forn.Data;
            dados[4] = forn.Telefone;

            dataGridFornecedores.Rows.Add(dados);            
        }
    }
}
