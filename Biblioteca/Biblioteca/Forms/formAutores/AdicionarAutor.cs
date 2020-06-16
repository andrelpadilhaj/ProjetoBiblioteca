using Biblioteca.Classes;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Biblioteca.Forms.formAutores
{
    public partial class AdicionarAutor : Form
    {
        public AdicionarAutor()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Autor tmpA = new Autor();
            tmpA.nome = txtNome.Text;
            tmpA.dtNascimento = pickDtNascimento.Text;
            MessageBox.Show(tmpA.dtNascimento);
            tmpA.saveOnBase();
            this.Dispose();
        }
    }
}
