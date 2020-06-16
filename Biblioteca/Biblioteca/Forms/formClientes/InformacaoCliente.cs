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

namespace Biblioteca.Forms.formClientes
{
    public partial class InformacaoCliente : Form
    {
        List<TelefoneCliente> telCli;
        public InformacaoCliente(string Cpf,
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

            telCli = new TelefoneCliente().getTelefonesCliente(Cpf);
            updateTelefones();
        }

        private void updateTelefones()
        {
            telCli = new TelefoneCliente().getTelefonesCliente(txtCpf.Text);
            listaTelefones.DataSource = telCli;
            listaTelefones.DisplayMember = "Telefone";
        }

        private void btnAdicionarTelefone_Click(object sender, EventArgs e)
        {
            TelefoneCliente temp = new TelefoneCliente();
            temp.Cpf_Cliente = txtCpf.Text;
            temp.Telefone = txtAdicionarTelefone.Text;
            temp.saveOnBase();
            updateTelefones();
        }

        private void btnRemoverTelefone_Click(object sender, EventArgs e)
        {
            int i = listaTelefones.SelectedIndex;
            new TelefoneCliente().removerTelefone(txtCpf.Text, telCli[i].Telefone);
            updateTelefones();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Cliente cli = new Cliente();

            cli.Cpf = txtCpf.Text;
            cli.Nome = txtNome.Text;
            cli.Email = txtEmail.Text;
            cli.Uf = txtUf.Text;
            cli.Cep = txtCep.Text;
            cli.Cidade = txtCidade.Text;
            cli.Bairro = txtBairro.Text;
            cli.Logradouro = txtLogradouro.Text;
            cli.Numero = txtNumero.Text;
            cli.Complemento = txtComplemento.Text;

            cli.update();
            this.Dispose();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            Cliente cli = new Cliente();

            cli.Cpf = txtCpf.Text;
            cli.Nome = txtNome.Text;
            cli.Email = txtEmail.Text;
            cli.Uf = txtUf.Text;
            cli.Cep = txtCep.Text;
            cli.Cidade = txtCidade.Text;
            cli.Bairro = txtBairro.Text;
            cli.Logradouro = txtLogradouro.Text;
            cli.Numero = txtNumero.Text;
            cli.Complemento = txtComplemento.Text;

            cli.delete();
            this.Dispose();
        }
    }
}
