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
    public partial class InformacaoFuncionario : Form
    {
        List<Classes.TelefoneFuncionario> lstTelefones;
        public InformacaoFuncionario(int Codigo,
                                     string Rg,
                                     string Cpf,
                                     string Nome,
                                     string Email,
                                     string Uf,
                                     string Cep,
                                     string Cidade,
                                     string Bairro,
                                     string Logradouro,
                                     string Numero,
                                     string Complemento)
        {
            InitializeComponent();

            txtCodigo.Text = Convert.ToString(Codigo);
            txtRg.Text = Rg;
            txtCpf.Text = Cpf;
            txtNome.Text = Nome;
            txtEmail.Text = Email;
            txtUf.Text = Uf;
            txtCep.Text = Cep;
            txtCidade.Text = Cidade;
            txtBairro.Text = Bairro;
            txtLogradouro.Text = Logradouro;
            txtNumero.Text = Numero;
            txtComplemento.Text = Complemento;

            updateTelefones();
        }

        public void updateTelefones()
        {
            TelefoneFuncionario tf = new TelefoneFuncionario();
            tf.Cod_Funcionario = Convert.ToInt32(txtCodigo.Text);
            lstTelefones = tf.getTelefones();
            listaTelefones.DataSource = lstTelefones;
            listaTelefones.DisplayMember = "Telefone";
        }

        private void btnAdicionarTelefone_Click(object sender, EventArgs e)
        {
            TelefoneFuncionario tf = new TelefoneFuncionario();
            tf.Cod_Funcionario = Convert.ToInt32(txtCodigo.Text);
            tf.Telefone = txtAdicionarTelefone.Text;
            tf.saveOnBase();
            updateTelefones();
        }

        private void btnRemoverTelefone_Click(object sender, EventArgs e)
        {
            TelefoneFuncionario tf = new TelefoneFuncionario();
            tf.Cod_Funcionario = Convert.ToInt32(txtCodigo.Text);
            tf.Telefone = lstTelefones[listaTelefones.SelectedIndex].Telefone;
            tf.removerTelefone();
            updateTelefones();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();

            funcionario.Codigo = Convert.ToInt32(txtCodigo.Text);
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

            funcionario.update();
            this.Dispose();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();

            funcionario.Codigo = Convert.ToInt32(txtCodigo.Text);
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

            funcionario.delete();
            this.Dispose();
        }
    }
}
