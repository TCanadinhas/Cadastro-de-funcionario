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
        public string quantFilhos;
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
            return nome + "#" + idade + "#" + sexo + "#" + eCivil + "#" + filhos + "#" + quantFilhos + "#" + tSanguineo + "#" + telefone + "#" + email + "#" + profissao + "#" + 
                salario + "#" + rua + "#" + cep + "#" + bairro + "#" + cidade + "#" + estado;
        }

        public void funcionarioFromString(string data)
        {
            Console.WriteLine("funcionarioFromString: " + data);
            string[] info = data.Split('#');
            nome = info[0];
            idade = info[1]; 
            sexo = info[2];
            eCivil = info[3];
            filhos = info[4];
            quantFilhos = info[5];
            tSanguineo = info[6];
            telefone = info[7];
            email = info[8];
            profissao = info[9];
            salario = info[10];
            rua = info[11];
            cep = info[12];
            bairro = info[13];
            cidade = info[14];
            estado = info[15];


            //System.IO.File.WriteAllLines(@"C:\Users\talita.santos\Desktop\Trabs lolô\Cadastro de funcionario\WindowsFormsApplication1\contas.txt", info);

        }

        /*
         * Funcionario f = new Functionario();
         * f.nome = "Antoanne";
         * f.idade = 32;
         * 
         * Console.WL(f.funcionarioAsString());
         * Antoanne#M#32#99999-9999
         * 
         * f.funcionarioFromString("Milena#F#16#12345-6789");
         * Console.WL(f.nome);
         * Milena
         * 
         * --------
         * 
             * Criei novo Funcionario
             * Escrever novo funcionario no TXT
             *      file.WL(f.funcionarioAsString());
             *      
             * Criei novo Funcionario
             * Escrever novo funcionario no TXT
             *      file.WL(f.funcionarioAsString());
             *      
             * Milena#F#16#12345-6789
             * Antoanne#M#32#99999-9999
         * 
         * FECHAR PROGRAMA!!
         * DIA SEGUINTE...
         * ABRI PROGRAMA!
         * 
         * Ver se tem algum funcionário no TXT
         *  Se tiver, carrega eles TODOS!
         *      fazer FOR para carregar cada funcionario na lista geral de funcionarios,
         *      depois atualizar o listBox
         * 
         * Dentro do StreamReader
         *      Funcionario f = new Functionario();
         *      f.funcionarioFromString(linha_do_txt);
         * 
         * Ao final, teremos os funcionarios na lista geral
         * 
         * Agora sim atualizar o listbox
         * 
         * Somente depois de tudo isso, abrir o programa
         * 
         * 
         * 
         */


    }
}
