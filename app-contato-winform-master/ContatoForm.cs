using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppContatoForm
{
    public partial class ContatoForm : Form
    {
        private MySqlConnection conexao;

        private MySqlCommand comando;

        public ContatoForm()
        {
            InitializeComponent();

            Conexao();
        }

        private void Conexao()
        {
            string conexaoString = "server=localhost;database=app_contato_bd;user=root;password=root;port=3360";
            conexao = new MySqlConnection(conexaoString);
            comando = conexao.CreateCommand();

            conexao.Open();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try  
            {
             

                //MessageBox.Show(dataNascimento.ToString());


                if ( ! rdSexo1.Checked && ! rdSexo2.Checked)
                {
                    MessageBox.Show("Marque uma opção");
                }
                else
                {
                    var nome = txtNome.Text;
                    var email = txtEmail.Text;
                    var telefone = txtTelefone.Text;
                    var dataNascimento = dateDataNascimento.Value;

                    var sexo = "Feminino";

                    if (rdSexo1.Checked)
                    {
                        sexo = "Masculino";
                    }


                    string query = "INSERT INTO Contato (nome_con, sexo_con, email_con, data_nasc_con, telefone_con) VALUES (@_nome, @_sexo, @_email, @_dataNascimento, @_telefone)";
                    var comando = new MySqlCommand(query, conexao); 

                    comando.Parameters.AddWithValue("@_nome", nome);
                    comando.Parameters.AddWithValue("@_email", email);
                    comando.Parameters.AddWithValue("@_sexo", sexo);
                    comando.Parameters.AddWithValue("@_dataNascimento", dataNascimento);
                    comando.Parameters.AddWithValue("@_telefone", telefone);

                    comando.ExecuteNonQuery();

                    txtNome.Clear();
                    dateDataNascimento.Clear();
                    rdSexoGroup.Clear();
                    txtEmail.Clear();
                    txtTelefone.Clear();
                    rdSexo1.Checked = false;
                    rdSexo2.Checked = false;
                    txtNome.Focus();

                   

                    var opcao = MessageBox.Show("Salvo com sucesso!\n + Deseja realizar um novo cadastro?","Informação",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if(opcao == DialogResult.Yes)
                    {
                        LimparInputs();
                    }
                    else
                    {
                        this.Close();
                    }
                    if (opcao == DialogResult.No)
                    {
                       MenuForm form = new MenuForm();
                       form.ShowDialog();  
                    }


                    MessageBox.Show("Salvo com sucesso!");

                }


            }
            catch(Exception ex)
            {
                //MessageBox.Show($"Ocorreram erros ao tentar salvar os dados! " +
                  //$"Contate o suporte do sistema. (CAD 25)");

                MessageBox.Show(ex.Message);
            }
        }

        private void LimparInputs()
        {
            //throw new NotImplementedException();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateDataNascimento_ValueChanged(object sender, DateTime value)
        {

        }
    }
}
