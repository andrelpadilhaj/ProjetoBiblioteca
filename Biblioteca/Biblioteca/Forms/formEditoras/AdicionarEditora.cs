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
    public partial class AdicionarEditora : Form
    {
        public AdicionarEditora()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Editora editora = new Editora();
            editora.Nome = txtNome.Text;
            editora.Email = txtEmail.Text;
            editora.Uf = txtUf.Text;
            editora.Cep = txtCep.Text;
            editora.Cidade = txtCidade.Text;
            editora.Bairro = txtBairro.Text;
            editora.Logradouro = txtLogradouro.Text;
            editora.Numero = txtNumero.Text;
            editora.Complemento = txtComplemento.Text;

            editora.saveOnBase();
            this.Dispose();
        }
    }
}
