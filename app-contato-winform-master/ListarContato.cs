using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppContatoForm
{
    public partial class ListarContato : Form
    {
        private List<Contato> ListaContato = new List<Contato>();

        private MySqlConnection conexao;

        private MySqlCommand comando;

        public ListarContato()
        {
            InitializeComponent();
            Conexao();
            CarregarLista();
           

        }

        private void Conexao()
        {
            string conexaoString = "server=localhost;database=app_contato_bd;user=root;password=root;port=3360";
            conexao = new MySqlConnection(conexaoString);
            comando = conexao.CreateCommand();

            conexao.Open();
        }

        private void CarregarLista()
        {
            MySqlCommand cmd = new MySqlCommand("Select * from Contato", conexao);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dtTabela.DataSource = dt;

        }
        private void ListarContato_Load(object sender, EventArgs e)
        {

        }
    }
}
