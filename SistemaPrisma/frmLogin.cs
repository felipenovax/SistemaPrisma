using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace SistemaPrisma
{
    public partial class frmLogin : Form
    {

        private MySqlConnection conn;
        string permissao = "";

        public frmLogin()
        {
            string connStr = "server=localhost;user=root;database=prisma;port=3306;password='040288fe'";
            conn = new MySqlConnection(connStr);
            
            InitializeComponent();
        }
        
       private void btnCancelar_Click(object sender, EventArgs e)
       {
           Application.Exit();
       }

       private void btnEntrar_Click(object sender, EventArgs e)
       {
            Entrar(txtLogin.Text, txtSenha.Text);
       }

        public bool Entrar(string login, string senha)
        {
            string query = $"SELECT * FROM usuarios WHERE login ='{login}' AND senha = '{senha}';";

            try
            {
                if (AbrirConexao())
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if(reader.Read())
                    {
                        reader.Close();
                        conn.Close();
                        frmPrincipal frmp = new frmPrincipal();
                        frmp.Show();
                        this.Visible = false;
                        return true;
                    }
                    else
                    {
                        reader.Close();
                        conn.Close();
                        MessageBox.Show("Usuário ou senha inválidos", "Erro ao Conectar!");
                        return false;
                    }
                    
                }
                else
                {
                    conn.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                return false;
            }
        }



        


        private bool AbrirConexao()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Servidor não encontrado!","Falha ao conectar com o Servidor!");
                        break;
                    case 1045:
                        MessageBox.Show("Usuário ou senha inválidos!");
                        break;
                }
            }
                return false;
        }
    }
}
