using Biblioteca.Classes;
using Biblioteca.Forms.formAutores;
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
    public partial class Autores : Form
    {
        List<Autor> listAutor;
        public Autores()
        {
            InitializeComponent();

            listAutores.Enabled = false;
        }

        private void updateList()
        {
            listAutores.DataSource = listAutor;
            listAutores.DisplayMember = "getData";
        }

        private void btnAdicionarAutor_Click(object sender, EventArgs e)
        {
            AdicionarAutor aa = new AdicionarAutor();
            aa.ShowDialog();
        }

        private void btnConsultarAutores_Click(object sender, EventArgs e)
        {
            Autor tmpA = new Autor();
            if (comboConsulta.SelectedItem == null)
            {
                comboConsulta.SelectedIndex = 0;
            }

            switch (comboConsulta.SelectedIndex)
            {
                case 0:
                    listAutor = tmpA.getAutores("Codigo", txtConsulta.Text);
                    break;
                case 1:
                    listAutor = tmpA.getAutores("Nome", txtConsulta.Text);
                    break;
                case 2:
                    listAutor = tmpA.getAutores("Dt_Nascimento", txtConsulta.Text);
                    break;
            }
            

            updateList();
            if (listAutores.Enabled == false)
            {
                listAutores.Enabled = true;
            }
        }

        private void listAutores_DoubleClick(object sender, EventArgs e)
        {
            int i = listAutores.SelectedIndex;
            InformacaoAutor iAutor = new InformacaoAutor(listAutor[i].codigo,
                                                         listAutor[i].nome,
                                                         listAutor[i].dtNascimento);
            iAutor.ShowDialog();
        }
    }
}
