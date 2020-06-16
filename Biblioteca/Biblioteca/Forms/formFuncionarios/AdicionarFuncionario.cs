using Biblioteca.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.Forms.formFuncionarios
{
    public partial class AdicionarFuncionario : Form
    {
        public AdicionarFuncionario()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Classes.Funcionario funcionario = new Classes.Funcionario();
            funcionario.Rg = txtRg.Text;
            funcionario.Cpf = txtCpf.Text;
            funcionario.Nome = txtNome.Text;
            funcionario.Email = txtEmail.Text;
            funcionario.Uf = txtUf.Text;
            funcionario.Cep = txtCep.Text;
            funcionario.Cidade = txtCidade.Text;
            funcionario.Bairro = txtBairro.Text;
            funcionario.Logradouro = txtLogradouro.Text;
            funcionario.Numero = txtNumero.Text;
            funcionario.Complemento = txtComplemento.Text;

            funcionario.saveOnBase();

            List<Classes.Funcionario> tmpList;
            tmpList = funcionario.getFuncionarios("Cpf", funcionario.Cpf);

            Classes.TelefoneFuncionario telFuncionario = new Classes.TelefoneFuncionario();
            telFuncionario.Cod_Funcionario = tmpList[0].Codigo;
            telFuncionario.Telefone = txtTelefone.Text;

            telFuncionario.saveOnBase();

            this.Dispose();
        }
    }
}
