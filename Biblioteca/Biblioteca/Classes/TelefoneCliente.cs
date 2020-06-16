using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dapper;
using System.CodeDom.Compiler;

namespace Biblioteca.Classes
{
    class TelefoneCliente
    {
        public string Cpf_Cliente { get; set; }
        public string Telefone { get; set; }
        public string getData
        {
            get
            {
                return $"{ Cpf_Cliente };{ Telefone }";
            }
        }
        public void saveOnBase()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BibliotecaDB")))
            {
                connection.Execute($"insert into Telefone_Cliente (Cpf_Cliente, Telefone) " +
                                   $"values ('{ Cpf_Cliente }', '{ Telefone }');");
            }
        }

        public void removerTelefone(string Cpf_Cliente, string Telefone)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BibliotecaDB")))
            {
                connection.Execute($"delete from Telefone_Cliente " +
                                   $"where Cpf_Cliente like '%{ Cpf_Cliente }%' " +
                                   $"and Telefone like '%{ Telefone }%';");
            }
        }

        public List<TelefoneCliente> getTelefonesCliente(string Cpf_Cliente)
        {
            List<TelefoneCliente> temp;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BibliotecaDB")))
            {
                temp = connection.Query<TelefoneCliente>($"select tc.Telefone " +
                                                         $"from Telefone_Cliente tc " +
                                                         $"where tc.Cpf_Cliente like '%{ Cpf_Cliente }%'").ToList();
            }

            return temp;
        }
    }
}
