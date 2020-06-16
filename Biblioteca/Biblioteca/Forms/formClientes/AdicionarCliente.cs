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
    public partial class AdicionarCliente : Form
    {
        public AdicionarCliente()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
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

            TelefoneCliente telCli = new TelefoneCliente();
            telCli.Cpf_Cliente = cli.Cpf;
            telCli.Telefone = txtTelefone.Text;

            cli.saveOnBase();
            telCli.saveOnBase();

            this.Dispose();
        }
    }
}
