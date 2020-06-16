using Biblioteca.Classes;
using Biblioteca.Forms.formClientes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Biblioteca.Forms
{
    public partial class Clientes : Form
    {
        List<Classes.Cliente> listCliente;
        public Clientes()
        {
            InitializeComponent();
        }

        private void updateList()
        {
            listClientes.DataSource = listCliente;
            listClientes.DisplayMember = "getCoreData";
        }

        private void btnAdicionarCliente_Click(object sender, EventArgs e)
        {
            AdicionarCliente aCli = new AdicionarCliente();
            aCli.ShowDialog();
        }

        private void btnConsultarClientes_Click(object sender, EventArgs e)
        {
            if (comboConsulta.SelectedItem == null)
            {
                comboConsulta.SelectedIndex = 0;
            }

            
            Cliente cli = new Cliente();
            switch (comboConsulta.SelectedIndex)
            {
                case 0:
                    listCliente = cli.getClientes("Cpf", txtConsulta.Text);
                    break;
                case 1:
                    listCliente = cli.getClientes("Nome", txtConsulta.Text);
                    break;
                case 2:
                    listCliente = cli.getClientes("Email", txtConsulta.Text);
                    break;
            }

            updateList();
        }

        private void listClientes_SelectedCoubleClick(object sender, EventArgs e)
        {
            int i = listClientes.SelectedIndex;
            InformacaoCliente infoFm = new InformacaoCliente(listCliente[i].Cpf,
                                                             listCliente[i].Nome,
                                                             listCliente[i].Email,
                                                             listCliente[i].Uf,
                                                             listCliente[i].Cep,
                                                             listCliente[i].Cidade,
                                                             listCliente[i].Bairro,
                                                             listCliente[i].Logradouro,
                                                             listCliente[i].Numero,
                                                             listCliente[i].Complemento);
            infoFm.ShowDialog();
        }
    }
}
