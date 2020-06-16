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
    public partial class InformacaoLivro : Form
    {
        List<Classes.Autor> autores;
        List<Classes.Editora> editoras;
        public InformacaoLivro(int codigo,
                               int cod_Autor,
                               string nome,
                               string genero,
                               string dtPublicacao,
                               int paginas,
                               float valor)
        {
            InitializeComponent();
            txtCodigo.Text = Convert.ToString(codigo);
            txtNome.Text = nome;

            updateEditoras();

            int counter = 0;
            foreach (Autor a in autores) {
                if (a.codigo == cod_Autor)
                {
                    comboAutor.SelectedIndex = counter;
                    break;
                }
                counter++;
            }
            txtGenero.Text = genero;
            this.dtPublicacao.Text = dtPublicacao;
            txtPaginas.Text = Convert.ToString(paginas);
            txtValor.Text = Convert.ToString(valor);
        }

        private void updateEditoras()
        {
            autores = new Autor().getAutores("Codigo", "");
            editoras = new Editora().getRelEditoras(Convert.ToInt32(txtCodigo.Text));
            comboAutor.DataSource = autores;
            comboAutor.DisplayMember = "Nome";
            listEditoras.DataSource = editoras;
            listEditoras.DisplayMember = "Nome";
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnExcluirEditora_Click(object sender, EventArgs e)
        {
            int i = listEditoras.SelectedIndex;
            Editora editora = new Editora();
            editora.Codigo = editoras[i].Codigo;
            editora.deleteRel();
            updateEditoras();
        }
    }
}
