﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Cadastro : Form
    {
        List<Funcionario> funcionarios = new List<Funcionario>();
        string arq = @"contas.txt";
        
        public Cadastro()
        {
            InitializeComponent();
            LerFuncionarios();
        }

        private void Adicionar(object sender, EventArgs e)
        {
            Funcionario f = new Funcionario();
            bool atualizar = true;


            if (textBoxNome.Text == "")
            {
                atualizar = false;
                LabelObr.Text = "*";
            }
            else LabelObr.Text = "";


            if (textBoxIdade.Text == "")
            {
                atualizar = false;
                labelObrI.Text = "*";
            }
            else labelObrI.Text = "";

            if (radioButtonSf.Checked == false && radioButtonSm.Checked == false && radioButtonSo.Checked == false)
            {
                atualizar = false;
                labelObrS.Text = "*";
            }
            else labelObrS.Text = "";

            if (radioButtonECc.Checked == false && radioButtonECs.Checked == false && radioButtonECv.Checked == false && radioButtonECd.Checked == false)
            {
                atualizar = false;
                labelObrEC.Text = "*";
            }
            else labelObrEC.Text = "";

            if (radioButtonFs.Checked == false && radioButtonFn.Checked == false)
            {
                atualizar = false;
                labelObrF.Text = "*";
            }
            else labelObrF.Text = "";

            if (textBoxTelefone.Text == "")
            {
                atualizar = false;
                labelObrT.Text = "*";
            }
            else labelObrT.Text = "";

            if (textBoxEmail.Text == "")
            {
                atualizar = false;
                labelObrE.Text = "*";
            }
            else labelObrE.Text = "";

            if (comboBoxEstado.Text == "")
            {
                atualizar = false;
                labelObrES.Text = "*";
            }
            else labelObrES.Text = "";

            if (textBoxProfissao.Text == "")
            {
                atualizar = false;
                labelObrTr.Text = "*";
            }
            else labelObrTr.Text = "";

            if (comboBoxSalario.Text == "")
            {
                atualizar = false;
                labelObrTs.Text = "*";
            }
            else labelObrTs.Text = "";

            if (textBoxRua.Text == "")
            {
                atualizar = false;
                labelObrEr.Text = "*";
            }
            else labelObrEr.Text = "";

            if (textBoxCep.Text == "")
            {
                atualizar = false;
                labelObrEce.Text = "*";
            }
            else labelObrEce.Text = "";

            if (textBoxCidade.Text == "")
            {
                atualizar = false;
                labelObrEci.Text = "*";
            }
            else labelObrEci.Text = "";

            if (textBoxBairro.Text == "")
            {
                atualizar = false;
                labelObrEb.Text = "*";
            }
            else labelObrEb.Text = "";

            if (comboBoxTSanguineo.Text == "")
            {
                atualizar = false;
                labelObrTSang.Text = "*";
            }
            else labelObrTSang.Text = "";


            f.nome = textBoxNome.Text;
            f.idade = textBoxIdade.Text;
            f.quantFilhos = textBoxQuantFilho.Text;
            f.tSanguineo = comboBoxTSanguineo.Text;
            f.telefone = textBoxTelefone.Text;
            f.email = textBoxEmail.Text;
            f.profissao = textBoxProfissao.Text;
            f.salario = comboBoxSalario.Text;
            f.rua = textBoxRua.Text;
            f.cep = textBoxCep.Text;
            f.bairro = textBoxBairro.Text;
            f.cidade = textBoxCidade.Text;
            f.estado = comboBoxEstado.Text;

            if (radioButtonSf.Checked == true) f.sexo = "feminino";
            if (radioButtonSm.Checked == true) f.sexo = "masculino";
            if (radioButtonSo.Checked == true) f.sexo = "outro";

            if (radioButtonECc.Checked == true) f.eCivil = "casado(a)";
            if (radioButtonECs.Checked == true) f.eCivil = "solteiro(a)";
            if (radioButtonECv.Checked == true) f.eCivil = "viúvo(a)";
            if (radioButtonECd.Checked == true) f.eCivil = "divorciado(a)";

            if (radioButtonFs.Checked == true) f.filhos = "sim";
            if (radioButtonFn.Checked == true) f.filhos = "não";


            if (atualizar)
            {
                funcionarios.Add(f);

                listBox.Items.Clear();
                foreach (Funcionario func in funcionarios)
                {
                    listBox.Items.Add(func.nome);
                    GravaNovo(f);
                }

                Novo(null, null);
            }
        }


        private void Novo(object sender, EventArgs e)
        {
            listBox.SelectedIndex = -1;

            LabelObr.Text = "";
            labelObrI.Text = "";
            labelObrS.Text = "";
            labelObrEC.Text = "";
            labelObrF.Text = "";
            labelObrT.Text = "";
            labelObrE.Text = "";
            labelObrES.Text = "";
            labelObrTr.Text = "";
            labelObrTs.Text = "";
            labelObrEr.Text = "";
            labelObrEce.Text = "";
            labelObrEci.Text = "";
            labelObrEb.Text = "";
            labelObrTSang.Text = "";

            textBoxBairro.Text = "";
            textBoxCep.Text = "";
            textBoxCidade.Text = "";
            textBoxEmail.Text = "";
            textBoxIdade.Text = "";
            textBoxNome.Text = "";
            textBoxProfissao.Text = "";
            textBoxQuantFilho.Text = "";
            textBoxRua.Text = "";
            textBoxTelefone.Text = "";
            comboBoxEstado.Text = "";
            comboBoxSalario.Text = "";
            comboBoxTSanguineo.Text = "";
            radioButtonECc.Checked = false;
            radioButtonECd.Checked = false;
            radioButtonECs.Checked = false;
            radioButtonECv.Checked = false;
            radioButtonFn.Checked = false;
            radioButtonFs.Checked = false;
            radioButtonSf.Checked = false;
            radioButtonSm.Checked = false;
            radioButtonSo.Checked = false;
        }


        private void GravaNovo(Funcionario f)
        {
            using (StreamWriter file = new StreamWriter(arq, true))
            {
                file.WriteLine(f.funcionarioAsString());
            }
        }


        private void LerFuncionarios()
        {
            String line;
            using (StreamReader file = new StreamReader(arq))
            {
                while ((line = file.ReadLine()) != null)
                {
                    Funcionario f = new Funcionario();
                    f.funcionarioFromString(line);
                    funcionarios.Add(f);
                }
            }

            listBox.Items.Clear();
            foreach (Funcionario func in funcionarios)
            {
                listBox.Items.Add(func.nome);
            }
        }


        private void selecionou(object sender, EventArgs e)
        {
            LabelObr.Text = "";
            labelObrI.Text = "";
            labelObrS.Text = "";
            labelObrEC.Text = "";
            labelObrF.Text = "";
            labelObrT.Text = "";
            labelObrE.Text = "";
            labelObrES.Text = "";
            labelObrTr.Text = "";
            labelObrTs.Text = "";
            labelObrEr.Text = "";
            labelObrEce.Text = "";
            labelObrEci.Text = "";
            labelObrEb.Text = "";
            labelObrTSang.Text = "";

            int index = listBox.SelectedIndex;
            if (index >= 0)
            {
                buttonExit.Visible = true;
                buttonAtualizar.Visible = true;
                Funcionario fSelecionado = getFromIndex(index);
                carregarDados(fSelecionado);
            }

            if (index < 0)
            {
                buttonExit.Visible = false;
                buttonAtualizar.Visible = false;                
            }
           
        }


        private Funcionario getFromIndex(int index)
        {
            return funcionarios.ElementAt(index);
        }


        private void carregarDados(Funcionario f)
        {
            textBoxNome.Text = f.nome;
            textBoxIdade.Text = f.idade;
            //textBoxQuantFilho = f.quantFilhos;
            comboBoxTSanguineo.Text = f.tSanguineo;
            textBoxTelefone.Text = f.telefone;
            textBoxEmail.Text = f.email;
            textBoxProfissao.Text = f.profissao ;
            comboBoxSalario.Text = f.salario;
            textBoxRua.Text = f.rua;
            textBoxCep.Text = f.cep;
            textBoxBairro.Text = f.bairro;
            textBoxCidade.Text = f.cidade;
            comboBoxEstado.Text = f.estado;

            if (f.sexo == "feminino") radioButtonSf.Checked = true;
            if (f.sexo == "masculino") radioButtonSm.Checked = true;
            if (f.sexo == "outro") radioButtonSo.Checked = true;

            if (f.eCivil == "casado(a)") radioButtonECc.Checked = true;
            if (f.eCivil == "solteiro(a)") radioButtonECs.Checked = true;
            if (f.eCivil == "viúvo(a)") radioButtonECv.Checked = true;
            if (f.eCivil == "divorciado(a)") radioButtonECd.Checked = true;

            if (f.filhos == "sim") radioButtonFs.Checked = true;
            if (f.filhos == "não") radioButtonFn.Checked = true;
        }


        private void Excluir(object sender, EventArgs e)
        {
            int index = listBox.SelectedIndex;
            
            listBox.Items.RemoveAt(index);
            funcionarios.RemoveAt(index);
            Novo(null, null);

            //String[] lines = File.ReadAllLines(arq);
            //List<string> linesList = lines.ToList();
            //linesList.RemoveAt(index);
            //lines = linesList.ToArray();
            //File.WriteAllLines(arq, lines);

            List<string> listaFuncionariosString = new List<string>();
            foreach(Funcionario f in funcionarios) {
                listaFuncionariosString.Add(f.funcionarioAsString());
            }
            string[] arrayFuncionariosString = listaFuncionariosString.ToArray();
            File.WriteAllLines(arq, arrayFuncionariosString);

        }


        private void Atualizar(object sender, EventArgs e)
        {
            //int index = listBox.SelectedIndex;

            //String[] lines = File.ReadAllLines(arq);
            //List<string> linesList = lines.ToList();
            //linesList.RemoveAt(index);
            //Funcionario fSelecionado = getFromIndex(index);
            //GravaNovo(fSelecionado);
        }


        private void Sair(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }

}
