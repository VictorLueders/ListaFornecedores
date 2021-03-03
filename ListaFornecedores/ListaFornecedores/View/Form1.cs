using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ListaFornecedores.View;
using ListaFornecedores.Model;

namespace ListaFornecedores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }    

        private void btnCadastrar_MouseHover(object sender, EventArgs e)
        {
            btnCadastrar.BackColor = Color.Gray;
        }

        private void btnCadastrar_MouseLeave(object sender, EventArgs e)
        {
            btnCadastrar.BackColor = Color.White;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            List<Fornecedor> forn = new List<Fornecedor>();            
            Empresa empresa = new Empresa(txtUf.Text, txtNome.Text, txtCnpj.Text, forn);
            Form2 form2 = new Form2(empresa);
            this.Hide();
            form2.Show();
        }
    }
}
