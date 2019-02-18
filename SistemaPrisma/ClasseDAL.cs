using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace SistemaPrisma
{
    public class ClasseDAL
    {
        public string conectaBanco = $"server=sql176.main-hosting.eu;user=u954250672_prism;database=u954250672_prism;port=3306;password='s3nh4Segur@'";
        MySqlConnection conexao = null;
        MySqlCommand comando;



        public DataTable ExibirDadosUsuarios()
        {
            try
            {
                conexao = new MySqlConnection(conectaBanco);
                comando = new MySqlCommand("SELECT * FROM usuarios", conexao);

                MySqlDataAdapter Da = new MySqlDataAdapter();
                Da.SelectCommand = comando;

                DataTable Dt = new DataTable();
                Da.Fill(Dt);

                return Dt;

            }
            catch (Exception erro)
            {
                throw erro;
            }

        }

        public DataTable ExibirDadosFuncionarios()
        {
            try
            {
                conexao = new MySqlConnection(conectaBanco);
                comando = new MySqlCommand("SELECT * FROM funcionarios", conexao);

                MySqlDataAdapter Da = new MySqlDataAdapter();
                Da.SelectCommand = comando;

                DataTable Dt = new DataTable();
                Da.Fill(Dt);
                return Dt;

            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }

}
