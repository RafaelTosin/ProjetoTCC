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

namespace susamogusimpostur
{
    public partial class Form1 : Form
    {
        int codigo;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conexao con = new conexao();
            cboPerfil.DataSource = con.GetPerfil();
            cboPerfil.DisplayMember = "nome";
            cboPerfil.ValueMember = "cod_perfil";

        }

        private void registrar_Click(object sender, EventArgs e)
        {
            conexao con = new conexao();
            MySqlConnection conexao = con.Getconexao();
            string SQL = "INSERT INTO usuario(nome,email,datanasc,login,senha, perfil, foto)" +
            "values(@nome,@email,@datanasc,@login,@senha, @perfil, @foto)";
            MySqlCommand comando = new MySqlCommand(SQL, conexao);
            comando.Parameters.AddWithValue("@nome", nome.Text);
            comando.Parameters.AddWithValue("@email", email.Text);
            comando.Parameters.AddWithValue("@datanasc", nasc.Value);
            comando.Parameters.AddWithValue("@login", login.Text);
            comando.Parameters.AddWithValue("@senha", senha.Text);
            comando.Parameters.AddWithValue("@perfil", Convert.ToInt32(perfil.Text));
            comando.Parameters.AddWithValue("@foto", txtFoto.Text);
            conexao.Open();
            if (comando.ExecuteNonQuery()>=1)
            {
                MessageBox.Show("cadastro concluido");
            }
            else
            {
                MessageBox.Show("erro no cadastro");
            }
            conexao.Close();
            
        
    
        }

        private void search_Click(object sender, EventArgs e)
        {
            conexao con = new conexao();
            MySqlConnection conexao = con.Getconexao();
            string consulta;
            if (searchtxt.Text == "")
            {
                consulta = "Select * FROM usuario";
            }
            else
            {
                consulta = "Select * FROM usuario WHERE nome like '%" + searchtxt.Text + "%'";
            }
            MySqlCommand comando = new MySqlCommand(consulta, conexao);
            conexao.Open();
            MySqlDataAdapter dados = new MySqlDataAdapter(comando);
            DataTable dtUsuario = new DataTable();
            dados.Fill(dtUsuario);

            DataGridViewImageColumn img = new DataGridViewImageColumn();
            Image image = Image.FromFile("C:\\Users\\Aluno\\Downloads\\R.png");
            img.Image = image;
            dtmedo.Columns.Add(img);
            img.Name = "foto";

            dtmedo.DataSource = dtUsuario;
            conexao.Close();
        }

        private void dtmedo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                codigo = Convert.ToInt32(dtmedo.Rows[e.RowIndex].Cells[0].Value);
                conexao con = new conexao();
                MySqlConnection conexao = con.Getconexao();
                string SQL = "SELECT * FROM usuario WHERE usercode=@codigo";
                MySqlCommand comando = new MySqlCommand(SQL, conexao);
                conexao.Open();
                comando.Parameters.AddWithValue("@codigo", codigo);
                MySqlDataReader registro = comando.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();
                    email.Text = Convert.ToString(registro["email"]);
                    nome.Text = Convert.ToString(registro["nome"]);
                    login.Text = Convert.ToString(registro["login"]);
                    senha.Text = Convert.ToString(registro["senha"]);
                    perfil.Text = Convert.ToString(registro["perfil"]);
                }
                else
                {
                    MessageBox.Show("falha ao obter registro");
                }
                conexao.Close();
            }
        }

        private void atualizar_Click(object sender, EventArgs e)
        {
            conexao con = new conexao();
            MySqlConnection conexao = con.Getconexao();
            if (codigo > 0)
            {
                string SQL = "UPDATE usuario set nome=@nome,email=@email," +
                    "datanasc=@datanasc,login=@login,senha=@senha,perfil=@perfil WHERE usercode=@codigo";
                MySqlCommand comando = new MySqlCommand(SQL, conexao);
                comando.Parameters.AddWithValue("@nome", nome.Text);
                comando.Parameters.AddWithValue("@email", email.Text);
                comando.Parameters.AddWithValue("@datanasc", nasc.Value);
                comando.Parameters.AddWithValue("@login", login.Text);
                comando.Parameters.AddWithValue("@senha", senha.Text);
                comando.Parameters.AddWithValue("@perfil", Convert.ToInt32(perfil.Text));
                comando.Parameters.AddWithValue("@codigo", codigo);
                conexao.Open();
                if (comando.ExecuteNonQuery() >= 1)
                {
                    MessageBox.Show("atualizado com perfeição");
                }
                else
                {
                    MessageBox.Show("erro/falta de dados");
                }
            }
            else
            {
                MessageBox.Show("selecione algum dado na listagem");
            }
            conexao.Close();
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            conexao con = new conexao();
            MySqlConnection conexao = con.Getconexao();
            string SQL = "DELETE FROM usuario WHERE usercode=@codigo";
            MySqlCommand comando = new MySqlCommand(SQL, conexao);
            comando.Parameters.AddWithValue("@codigo", codigo);
            conexao.Open();
            if (comando.ExecuteNonQuery() >= 1)
            {
                MessageBox.Show("excluido com sucesso");
            }
            else
            {
                MessageBox.Show("erro na exclusão");
            }
            conexao.Close();
        }

        private void logar_Click(object sender, EventArgs e)
        {
            conexao con = new conexao();
            MySqlConnection conexao = con.Getconexao();
            string SQL = "SELECT * FROM usuario WHERE login=@login and senha=@senha";
            MySqlCommand comando = new MySqlCommand(SQL, conexao);
            comando.Parameters.AddWithValue("@login", lologin.Text);
            comando.Parameters.AddWithValue("@senha", senhalo.Text);
            conexao.Open();
            MySqlDataReader registro = comando.ExecuteReader();
            if (registro.HasRows)
            {
                form form = new form();
                form.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("algo está errado, verifique seus dados novamente");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "imagem file | *.png; *.jpg; *.bmp";
                txtFoto.Text = open.FileName;
                if (open.ShowDialog() == DialogResult.OK)
                {
                    txtFoto.Text = open.FileName;
                    pBfoto.Image = Image.FromFile(open.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha" + ex.Message);
            }
           
        }


        private void txtFoto_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }
    }
}