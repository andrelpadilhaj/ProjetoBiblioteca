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

namespace Biblioteca.Forms.formLivros
{
    public partial class AdicionarLivro : Form
    {
        List<Classes.Autor> autores;
        List<Classes.Editora> editoras;
        public AdicionarLivro()
        {
            InitializeComponent();
            autores = new Autor().getAutores("Codigo", "");
            editoras = new Editora().getEditoras("Codigo", "");
            comboAutor.DataSource = autores;
            comboAutor.DisplayMember = "Nome";
            comboEditora.DataSource = editoras;
            comboEditora.DisplayMember = "Nome";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            new NotImplementedException();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            
            Classes.Livro livro = new Classes.Livro();
            livro.Nome = txtNome.Text;
            livro.Genero = txtGenero.Text;
            livro.Cod_Autor = autores[comboAutor.SelectedIndex].codigo;
            livro.Paginas = Convert.ToInt32(txtPaginas.Text);
            livro.dtPublicacao = dtPublicacao.Text;
            livro.Valor = float.Parse(txtValor.Text);

            livro.saveOnBase(editoras[comboEditora.SelectedIndex].Codigo);
        }

        private void txtPaginas_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPaginas_Click(object sender, EventArgs e)
        {

        }

        private void dtPublicacao_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblPublicacao_Click(object sender, EventArgs e)
        {

        }

        private void comboEditora_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboAutor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGenero_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }
    }
}
