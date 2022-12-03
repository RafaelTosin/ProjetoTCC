using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;//libraby sql
using System.Windows.Forms;//library formulario
using System.Data; //library biblioteca

namespace susamogusimpostur
{
    class conexao
    {
        static private string servidor = "localhost";
        static private string bancodados = "tds";
        static private string usuario = "root";
        static private string senha = "";
        static public string StrCon = "server="+servidor+ ";database="+bancodados+ ";user id="+usuario+ ";password="+senha;

        public MySqlConnection Getconexao()
        {
            MySqlConnection con = new MySqlConnection(StrCon);
            return con;
        }
        public bool conectar()
        {
            var result = false;
            try
            {
                Getconexao().Open();
                result = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("falha: " + ex.Message);
            }
            return result;
        }
        public DataTable GetPerfil()
        {
            MySqlConnection conexao = Getconexao();
            string sql = "SELECT * FROM perfil";
            DataTable dbperfil = new DataTable();
            try
            {
                conexao.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                MySqlDataAdapter dados = new MySqlDataAdapter(comando);
                dados.Fill(dbperfil);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
            return dbperfil;
        }
    }
}
