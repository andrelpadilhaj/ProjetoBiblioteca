using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dapper;

namespace Biblioteca.Classes
{
    class Editora
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Uf { get; set; }
        public string Cep { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string getData
        {
            get
            {
                return $"{ Codigo };{ Nome };{ Email };{ Uf };{ Cep };{ Cidade };{ Bairro };{ Logradouro };{ Numero };{ Complemento }";
            }
        }

        public string getCoreData
        {
            get
            {
                return $"{ Codigo };{ Nome };{ Email }";
            }
        }

        public void saveOnBase()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BibliotecaDB")))
            {
                connection.Execute($"insert into Editora (Nome, Email, Uf, Cep, Cidade, Bairro, Logradouro, Numero, Complemento) " +
                                   $"values ('{ Nome }', '{ Email }', '{ Uf }', '{ Cep }', '{ Cidade }', '{ Bairro }', '{ Logradouro }', '{ Numero }', '{ Complemento }');");
            }
        }

        public void update()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BibliotecaDB")))
            {
                connection.Execute($"update Editora " +
                                   $"set Nome = '{ Nome }', " +
                                   $"Email = '{ Email }', " +
                                   $"Uf = '{ Uf }', " +
                                   $"Cep = '{ Cep }', " +
                                   $"Cidade = '{ Cidade }', " +
                                   $"Bairro = '{ Bairro }', " +
                                   $"Logradouro = '{ Logradouro }', " +
                                   $"Numero = '{ Numero }', " +
                                   $"Complemento = '{ Complemento }' " +
                                   $"where Codigo like '%{ Codigo }%';");
            }
        }
        public void deleteRel()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BibliotecaDB")))
            {
                connection.Execute($"delete from Rel_Livro_Editora " +
                                   $"where Cod_Editora like '%{ Codigo }%';");
            }
        }
        public void delete()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BibliotecaDB")))
            {
                connection.Execute($"delete from Rel_Livro_Editora " +
                                   $"where Cod_Editora like '%{ Codigo }%';");
                connection.Execute($"delete from Editora " +
                                   $"where Codigo like '%{ Codigo }%';");
            }
        }
        public List<Editora> getRelEditoras(int pesquisa)
        {
            List<Editora> temp;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BibliotecaDB")))
            {
                temp = connection.Query<Editora>($"select e.Codigo, e.Nome, e.Email, e.Uf, e.Cep, e.Cidade, e.Bairro, e.Logradouro, e.Numero, e.Complemento " +
                                        $"from Editora e " +
                                        $"join Rel_Livro_Editora rle " +
                                        $"on e.Codigo = rle.Cod_Editora " +
                                        $"where rle.Cod_Livro = { pesquisa };").ToList();
            }

            return temp;
        }
        public List<Editora> getEditoras(string tipo, string pesquisa)
        {
            List<Editora> temp;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BibliotecaDB")))
            {
                temp = connection.Query<Editora>($"select e.Codigo, e.Nome, e.Email, e.Uf, e.Cep, e.Cidade, e.Bairro, e.Logradouro, e.Numero, e.Complemento " +
                                        $"from Editora e " +
                                        $"where { tipo } like '%{ pesquisa }%';").ToList();
            }

            return temp;
        }
    }
}
