using Biblioteca.Forms.formLivros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.Forms
{
    public partial class Livros : Form
    {
        List<Classes.Livro> lstLivro;
        public Livros()
        {
            InitializeComponent();
        }
        private void updateLivros()
        {
            listLivros.DataSource = lstLivro;
            listLivros.DisplayMember = "getCoreData";
        }
        private void btnAdicionarFuncionario_Click(object sender, EventArgs e)
        {
            AdicionarLivro adLivro = new AdicionarLivro();
            adLivro.ShowDialog();
        }
        private void btnConsultarFuncionarios_Click(object sender, EventArgs e)
        {
            if (comboConsulta.SelectedItem == null)
            {
                comboConsulta.SelectedIndex = 0;
            }


            Classes.Livro livro = new Classes.Livro();
            switch (comboConsulta.SelectedIndex)
            {
                case 0:
                    lstLivro = livro.getLivros("Codigo", txtConsulta.Text);
                    break;
                case 1:
                    lstLivro = livro.getLivros("Nome", txtConsulta.Text);
                    break;
                case 2:
                    lstLivro = livro.getLivros("Autor", txtConsulta.Text);
                    break;
                case 3:
                    lstLivro = livro.getLivros("Dt_Publicacao", txtConsulta.Text);
                    break;
                case 4:
                    lstLivro = livro.getLivros("Paginas", txtConsulta.Text);
                    break;
            }

            updateLivros();
        }

        private void listLivros_DoubleClick(object sender, EventArgs e)
        {
            int i = listLivros.SelectedIndex;
            InformacaoLivro infoL = new InformacaoLivro(lstLivro[i].Codigo,
                                                        lstLivro[i].Cod_Autor,
                                                        lstLivro[i].Nome,
                                                        lstLivro[i].Genero,
                                                        lstLivro[i].dtPublicacao,
                                                        lstLivro[i].Paginas,
                                                        lstLivro[i].Valor);
            infoL.ShowDialog();
        }
    }
}
