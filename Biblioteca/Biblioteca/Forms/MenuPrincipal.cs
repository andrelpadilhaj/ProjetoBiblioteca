using Biblioteca.Classes;
using Biblioteca.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            Funcionarios f = new Funcionarios();
            f.ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Clientes c = new Clientes();
            c.ShowDialog();
        }

        private void btnAutores_Click(object sender, EventArgs e)
        {
            Autores a = new Autores();
            a.ShowDialog();
        }

        private void btnEditoras_Click(object sender, EventArgs e)
        {
            Editoras ed = new Editoras();
            ed.ShowDialog();
        }

        private void btnLivros_Click(object sender, EventArgs e)
        {
            Livros l = new Livros();
            l.ShowDialog();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            Vendas v = new Vendas();
            v.ShowDialog();
        }
    }
}
