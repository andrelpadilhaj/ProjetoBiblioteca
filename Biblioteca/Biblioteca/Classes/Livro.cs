using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dapper;

namespace Biblioteca.Classes
{
    class Livro
    {
        public int Codigo { get; set; }
        public int Cod_Autor { get; set; }
        public string Nome { get; set; }
        public string Genero { get; set; }
        public string dtPublicacao { get; set; }
        public int Paginas { get; set; }
        public float Valor { get; set; }
        public string getData
        {
            get
            {
                return $"{ Codigo };{ Cod_Autor };{ Nome };{ Genero };{ dtPublicacao };{ Paginas };{ Paginas };{ Valor };";
            }
        }
        public string getCoreData
        {
            get
            {
                return $"{ Codigo };{ Cod_Autor };{ Nome };{ Genero };{ dtPublicacao }";
            }
        }
        public void saveOnBase(int cod_editora)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BibliotecaDB")))
            {
                connection.Execute($"insert into Livro (Cod_Autor, Nome, Genero, Dt_Publicacao, Paginas, Valor) " +
                                   $"values ('{ Cod_Autor }', '{ Nome }', '{ Genero }', '{ dtPublicacao }', '{ Paginas }', '{ Valor }');");
                connection.Execute($"insert into Rel_Livro_Editora (Cod_Livro, Cod_Editora) " +
                                   $"values ((select Codigo from Livro where Cod_Autor = '{ Cod_Autor }' and Nome = '{ Nome }' and Genero = '{ Genero }'), { cod_editora });");
            }
        }

        public void update()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BibliotecaDB")))
            {
                connection.Execute($"update Livro " +
                                   $"set Cod_Autor = '{ Cod_Autor }', " +
                                   $"Nome = '{ Nome }', " +
                                   $"Genero = '{ Genero }', " +
                                   $"Cidade = '{ dtPublicacao }', " +
                                   $"Paginas = '{ Paginas }', " +
                                   $"Valor = '{ Valor }';");
            }
        }

        public void delete()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BibliotecaDB")))
            {
                connection.Execute($"delete from Rel_Livro_Editora " +
                                   $"where Cod_Livro like '%{ Codigo }%';");
                connection.Execute($"delete from Livro " +
                                   $"where Codigo like '%{ Codigo }%';");
            }
        }

        public List<Livro> getLivros(string tipo, string pesquisa)
        {
            List<Livro> temp;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BibliotecaDB")))
            {
                temp = connection.Query<Livro>($"select Codigo, Cod_Autor, Nome, Genero, Dt_Publicacao, Paginas, Valor " +
                                        $"from Livro " +
                                        $"where { tipo } like '%{ pesquisa }%';").ToList();
            }

            return temp;
        }
    }
}
