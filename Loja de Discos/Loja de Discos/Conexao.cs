using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Loja_de_Discos
{
    class Conexao
    {
        static private string servidor = "localhost";
        static private string bancodedados = "tosinus_store";
        static private string usuario = "root";
        static private string senha = "";
        static public string StrCon = "server=" + servidor + ";database=" + bancodedados + ";user id=" + usuario + ";password=" + senha;

        public MySqlConnection GetConexao()
        {
            MySqlConnection con = new MySqlConnection(StrCon);




            return con;
        }
        public bool conectar()
        {
            var result = false;
            try
            {
                GetConexao().Open();
                result = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha:" + ex.Message);
            }

            return result;
        }
    }
}