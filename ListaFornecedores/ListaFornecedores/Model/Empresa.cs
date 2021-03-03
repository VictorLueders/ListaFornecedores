using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListaFornecedores.Model;

namespace ListaFornecedores.Model
{
    public class Empresa
    {
        public string UF { get; set; }
        public string NomeFantasia { get; set; }
        public string Cnpj { get; set; }
        public List<Fornecedor> Fornecedores{ get; set; }

        public Empresa()
        {
                
        }

        public Empresa(string uf, string nome, string cnpj, List<Fornecedor> forn)
        {
            this.NomeFantasia = nome;
            this.UF = uf;
            this.Cnpj= cnpj;
            this.Fornecedores = forn;
        }
    }
}
