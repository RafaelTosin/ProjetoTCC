using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Loja_de_Discos
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                Conexao con = new Conexao();
                MySqlConnection Conexao = con.GetConexao();
                string SQL = "INSERT INTO usuario(Nome,Email,datanasc,Login,Senha,perfil)" +
                    "values(@nome,@email,@login,@senha)";

                MySqlCommand comando = new MySqlCommand(SQL, Conexao);
                comando.Parameters.AddWithValue("@nome", txtNome.Text);
                comando.Parameters.AddWithValue("@senha", txtSenha.Text);
                comando.Parameters.AddWithValue("@login", txtLoginn.Text);
                comando.Parameters.AddWithValue("@email", txtEmail.Text);
                Conexao.Open();
                if (comando.ExecuteNonQuery()>=4)
            {
                    MessageBox.Show("Cadastro com sucesso!");

                }

                else
                {
                    MessageBox.Show("Erro no Cadastro!");
                }

                Conexao.Close();

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        private void Pesquisar_Click(object sender, EventArgs e)
        {
            Conexao con = new Conexao();
            MySqlConnection conexao = con.GetConexao();
            string consulta;
            if (txtPesquisar.Text == "")
            {
                consulta = "SELECT*FROM usuario";
            }
            else
            {
                consulta = "SELECT*FROM usuario WHERE nome like '%" + txtPesquisar.Text + "%'";
            }
            MySqlCommand comando = new MySqlCommand(consulta, conexao);
            conexao.Open();
            MySqlDataAdapter dados = new MySqlDataAdapter(comando);
            DataTable dtusuario = new DataTable();
            dados.Fill(dtusuario);
            dtviewusuario.DataSource = dtusuario;
            conexao.Close();






        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
