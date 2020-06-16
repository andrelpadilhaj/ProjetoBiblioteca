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

namespace Biblioteca.Forms.formEditoras
{
    public partial class InformacaoEditora : Form
    {
        public InformacaoEditora(int Codigo,
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
            txtNome.Text = Nome;
            txtEmail.Text = Email;
            txtUf.Text = Uf;
            txtCep.Text = Cep;
            txtCidade.Text = Cidade;
            txtBairro.Text = Bairro;
            txtLogradouro.Text = Logradouro;
            txtNumero.Text = Numero;
            txtComplemento.Text = Complemento;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Editora editora = new Editora();

            editora.Codigo = Convert.ToInt32(txtCodigo.Text);
            editora.Nome = txtNome.Text;
            editora.Email = txtEmail.Text;
            editora.Uf = txtUf.Text;
            editora.Cep = txtCep.Text;
            editora.Cidade = txtCidade.Text;
            editora.Bairro = txtBairro.Text;
            editora.Logradouro = txtLogradouro.Text;
            editora.Numero = txtNumero.Text;
            editora.Complemento = txtComplemento.Text;

            editora.update();
            this.Dispose();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            Editora editora = new Editora();

            editora.Codigo = Convert.ToInt32(txtCodigo.Text);
            editora.Nome = txtNome.Text;
            editora.Email = txtEmail.Text;
            editora.Uf = txtUf.Text;
            editora.Cep = txtCep.Text;
            editora.Cidade = txtCidade.Text;
            editora.Bairro = txtBairro.Text;
            editora.Logradouro = txtLogradouro.Text;
            editora.Numero = txtNumero.Text;
            editora.Complemento = txtComplemento.Text;

            editora.delete();
            this.Dispose();
        }
    }
}
