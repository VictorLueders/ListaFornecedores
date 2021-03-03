using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaFornecedores.Model
{
    public class Fornecedor
    {
        public string Empresa { get; set; }
        public string Nome { get; set; }
        public string CpfCnpj { get; set; }
        public string Data { get; set; }
        public string Telefone{ get; set; }

        public Fornecedor()
        {

        }

        public Fornecedor(string empresa, string nome, string cpfCnpj, string telefone)
        {
            this.Nome = nome;
            this.Empresa = empresa;
            this.CpfCnpj= cpfCnpj;
            this.Telefone = telefone;
            this.Data = DateTime.Now.ToString();
        }
    }
}
