using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dapper;

namespace Biblioteca.Classes
{
    class TelefoneFuncionario
    {
        public int Cod_Funcionario { get; set; }
        public string Telefone { get; set; }
        public string getData
        {
            get
            {
                return $"{ Cod_Funcionario };{ Telefone }";
            }
        }

        public void saveOnBase()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BibliotecaDB")))
            {
                connection.Execute($"insert into Telefone_Funcionario (Cod_Funcionario, Telefone) " +
                                   $"values ('{ Cod_Funcionario }', '{ Telefone }');");
            }
        }

        public void removerTelefone()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BibliotecaDB")))
            {
                connection.Execute($"delete from Telefone_Funcionario " +
                                   $"where Cod_Funcionario like '%{ Cod_Funcionario }%' " +
                                   $"and Telefone like '%{ Telefone }%';");
            }
        }

        public List<TelefoneFuncionario> getTelefones()
        {
            List<TelefoneFuncionario> temp;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BibliotecaDB")))
            {
                temp = connection.Query<TelefoneFuncionario>($"select tf.Telefone " +
                                                         $"from Telefone_Funcionario tf " +
                                                         $"where tf.Cod_Funcionario like '%{ Cod_Funcionario }%'").ToList();
            }

            return temp;
        }
    }
}
