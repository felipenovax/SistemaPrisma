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

namespace SistemaPrisma
{
    public partial class frmUsuario : Form
    {
        private MySqlConnection conn;
        

        public frmUsuario()
        {
            string connStr = "server=localhost;user=root;database=prisma;port=3306;password='040288fe'";
            conn = new MySqlConnection(connStr);

            //string pesquisar = txtPesquisar.Text;
            

            InitializeComponent();
            
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            GravarCampo();
            LimpaCampos();
        }


        public void GravarCampo()
        {

            string nome = txtNome.Text;
            string login = txtLogin.Text;
            string senha = txtSenha.Text;
            string setor = comboBox1.Text;
            string cargo = comboBox2.Text;
            string administrador = "";


            switch (checkBox1.CheckState)
            {
                case CheckState.Checked:
                    administrador = "S";
                    
                    break;
                case CheckState.Unchecked:
                    administrador = "N";
                    break;
            }

            string select = $"select * from usuarios where nome = '{nome}' || login = '{login}';";
            //string query = $"INSERT INTO usuarios (nome,login,senha,setor,cargo,administrador) VALUE ('{nome}','{login}','{senha}','{setor}','{cargo}','{administrador}');";
            

            
            MySqlCommand cmd = new MySqlCommand(select, conn); //criar estancia MySqlCommand
            MySqlDataReader reader = cmd.ExecuteReader(); //Executar a Query
            


            if (reader.Read())
            {
                conn.Close();
                reader.Close();
                MessageBox.Show("Usuário já cadastrado na base de dados","Atenção");
                
            }
            else
            {
                
                reader.Close();
                string query = $"INSERT INTO usuarios (nome,login,senha,setor,cargo,administrador) VALUE ('{nome}','{login}','{senha}','{setor}','{cargo}','{administrador}');";
                //conn.Open();
                MySqlCommand comando = new MySqlCommand(query, conn); //criar estancia MySqlCommand
                MySqlDataReader ler = comando.ExecuteReader(); //Executar a Query

                conn.Close();
                ler.Close();
                MessageBox.Show("Cadastro Efetuado!!","Atenção");
                
            }

        }

        private void LimpaCampos()
        {
            txtNome.Text = "";
            txtLogin.Text = "";
            txtSenha.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            checkBox1.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //colocar um array de setores
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PesquisaUsuario();
        }



        public void PesquisaUsuario()
        {
            string nome = txtPesquisar.Text;
            string login = txtPesquisar.Text;
            conn.Open();
            string PesqConexao = $"SELECT * FROM usuarios WHERE nome = '{nome}' OR login = '{login}';";
            MySqlCommand comando = new MySqlCommand(PesqConexao, conn);
            MySqlDataReader ler = comando.ExecuteReader();

            if(ler.Read())
            {
                panel1.Enabled = false;
                txtNome.Text = ler.GetString("nome");
                txtLogin.Text = ler.GetString("login");
                comboBox1.Text = ler.GetString("setor");
                MessageBox.Show("Pesquisou!!", "Sucesso!");
                conn.Close();
                ler.Close();
            }
            else
            {
                MessageBox.Show("Não Pesquisou!", "Falha!");
                conn.Close();
                ler.Close();
            }
        }

    }
}
