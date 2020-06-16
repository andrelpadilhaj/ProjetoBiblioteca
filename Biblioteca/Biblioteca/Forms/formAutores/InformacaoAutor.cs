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

namespace Biblioteca.Forms.formAutores
{
    public partial class InformacaoAutor : Form
    {
        public InformacaoAutor(int codigo, string nome, string data)
        {
            InitializeComponent();
            txtCodigo.Text = Convert.ToString(codigo);
            txtNome.Text = nome;
            txtDataNascimento.Text = data;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Autor tmpA = new Autor();
            tmpA.codigo = Convert.ToInt32(txtCodigo.Text);
            tmpA.nome = txtNome.Text;
            tmpA.dtNascimento = txtDataNascimento.Text;
            tmpA.alterar();
            this.Dispose();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Autor tmpA = new Autor();
            tmpA.codigo = Convert.ToInt32(txtCodigo.Text);
            tmpA.nome = txtNome.Text;
            tmpA.dtNascimento = txtDataNascimento.Text;
            tmpA.excluir();
            this.Dispose();
        }
    }
}
