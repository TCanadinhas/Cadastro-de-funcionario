using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Funcionario
    {
        public string nome;
        public string idade;
        public string sexo;
        public string eCivil;
        public string filhos;
        public string tSanguineo;
        public string telefone;
        public string email;
        public string profissao;
        public string salario;
        public string rua;
        public string cep;
        public string bairro;
        public string cidade;
        public string estado;

        public string funcionarioAsString()
        {
            return nome + "#" + sexo + "#" + idade + "#" + telefone;
        }

        public void funcionárioFromString(string data)
        {
            string[] info = data.Split('#');
            nome = info[0];
            sexo = info[1];
            idade = info[2];
            telefone = info[3];
        }

    }
}
