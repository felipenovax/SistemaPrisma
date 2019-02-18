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
using MySql.Data;

namespace SistemaPrisma
{
    public partial class frmFuncionario : Form
    {
        private MySqlConnection conn;
        

        public frmFuncionario()
        {
            //ClasseDAL conexaoSQL = new ClasseDAL();

            string connStr = "server=sql176.main-hosting.eu;user=u954250672_prism;database=u954250672_prism;port=3306;password='s3nh4Segur@'";
            conn = new MySqlConnection(connStr);

            classeFuncionario func = new classeFuncionario();
            
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Há dados não gravados, deseja realmente sair?", "Atenção dados não salvos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConfirmarDados();
        }
        

        //Métodos públicos
        
        public void ConfirmarDados()
        {
            string query = $"INSERT INTO funcionarios (nome,localnascimento,ufnascimento,nascimento,sexo,escolaridade,cpf,rg,rguf,orgaoexpeditor,estadocivil,nomepai,nomemae,endereco,numero,bairro,cidade,uf,cep,telefone,celular,email,codigo,datacadastro,login,setor,cargo) VALUES ('{txtNome.Text}','{txtLocalNascimento.Text}','{comboBoxEstadoNascimento.Text}','{dateTimePickerNascimento.Value.ToString("yyyyMMdd")}','{char.Parse(comboBoxSexo.SelectedItem.ToString())}','{comboBoxEscolaridade.Text}','{txtCPF.Text}','{txtRG.Text}','{comboBoxRguf.Text}','{txtOrgaoexpeditor.Text}','{comboBoxEstadocivil.Text}','{txtNomepai.Text}','{txtNomemae.Text}','{txtEndereco.Text}','{2}','{txtBairro.Text}','{txtCidade.Text}','{ComboBoxEstado.Text}','{txtCEP.Text}','{txtTelefone.Text}','{txtCelular.Text}','{txtEmail.Text}','{txtCodigo.Text}','{dateTimePickerCadastro.Value.ToString("yyyyMMdd")}','{txtLogin.Text}','{comboBoxSetor.Text}','{txtCargo.Text}');";
            AbrirConexao();
            MySqlCommand cmd = new MySqlCommand(query, conn); //criar estancia MySqlCommand
            MySqlDataReader reader = cmd.ExecuteReader(); //Executar a Query
            reader.Close();
            conn.Close();
            MessageBox.Show("Dados Gravados com Sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Close();
            frmFuncionario frmFunc = new frmFuncionario();
            frmFunc.Show();
        }



        private void AbrirConexao()
        {
            try
            {
                conn.Open();
            }

            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Servidor não encontrado!", "Falha ao conectar com o Servidor!");
                        break;
                    case 1045:
                        MessageBox.Show("Usuário ou senha inválidos!");
                        break;
                }
            }
            
         }



        
        //CAMPOS CPF E RG SOMENTE ACEITAR NUMEROS
        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
               if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtRG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }





















        /*
        public void capturarDados()
        {
            classeFuncionario funcionario = new classeFuncionario();

            funcionario.setNome(txtNome.Text);
            funcionario.setLocalNascimento(txtLocalNascimento.Text);
            funcionario.setUfNascimento(comboBoxEstadoNascimento.Text);
            //Data Nascimento
            funcionario.setSexo(char.Parse(comboBoxSexo.SelectedItem.ToString()));
            funcionario.setEscolaridade(comboBoxEscolaridade.Text);
            //funcionario.setEscolaridade(comboBoxEscolaridade.SelectedItem.ToString());
            funcionario.setCpf(txtCPF.Text);
            funcionario.setRg(txtRG.Text);
            funcionario.setRguf(comboBoxRguf.Text);
            funcionario.setOrgaoexpeditor(txtOrgaoexpeditor.Text);
            funcionario.setEstadocivil(comboBoxEstadocivil.Text);
            funcionario.setNomemae(txtNomemae.Text);
            funcionario.setNomepai(txtNomepai.Text);
            funcionario.setEndereco(txtEndereco.Text);
            funcionario.setBairro(txtBairro.Text);
            funcionario.setCidade(txtCidade.Text);
            funcionario.setUf(ComboBoxEstado.Text);
            funcionario.setCep(txtCEP.Text);
            funcionario.setTelefone(txtTelefone.Text);
            funcionario.setCelular(txtCelular.Text);
            funcionario.setEmail(txtEmail.Text);
            //funcionario.setEmpresa(txtEmpresa.Text);



            //funcionario.setLocalNascimento(txt)
            //capturar os valores e salvar na base de dados MySQL
            //MessageBox.Show("Dados Gravados com Sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //labelNomeQtdeDiarias.Text = hospede.getQtdDiaria().ToString();
            labelNome.Text = funcionario.getSexo().ToString();
        }
        */
    }
}
