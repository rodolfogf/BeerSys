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


namespace BeerSys.Forms
{
    public partial class FormConfiguracoes : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;

        public FormConfiguracoes()
        {
            InitializeComponent();
        }
        private void FormConfiguracoes_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            //MUDAR AS CORES DOS LABELS EM CADA FORM
            lblAdicionarUsuario.ForeColor = ThemeColor.PrimaryColor;
            lblAddNome.ForeColor = ThemeColor.PrimaryColor;
            lblAddSenha.ForeColor = ThemeColor.PrimaryColor;
            chkEAdmin.ForeColor = ThemeColor.SecondaryColor;
            btnCadastrar.BackColor = ThemeColor.PrimaryColor;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            conexao = new MySqlConnection("Server=localhost;Database=beersys;Uid=root;Pwd=;");
            conexao.Open();
            //Está pegando a conexão MySql que foi aberta no FORM LOGIN, essa conexão é fechada quando o programa fecha
            if (chkEAdmin.Checked && txtAddNome.Text != "" && txtAddSenha.Text != "")
            {
                comando = new MySqlCommand("insert into user(name_user,password_user,is_admin) values ('" + txtAddNome.Text + "','" + txtAddSenha.Text + "',true)", conexao);
                comando.ExecuteNonQuery();
            }
            else if(chkEAdmin.Checked == false && txtAddNome.Text != "" && txtAddSenha.Text != "")
            {
                comando = new MySqlCommand("insert into user(name_user,password_user,is_admin) values ('" + txtAddNome.Text + "','" + txtAddSenha.Text + "',false)", conexao);
                comando.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Existem campos vazios","Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            conexao.Close();

        }
    }
}