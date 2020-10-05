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
    public partial class FormEstoque : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSQL;
        public FormEstoque()
        {
            InitializeComponent();
        }

        private void FormEstoque_Load(object sender, EventArgs e)
        {
            LoadTheme();

            //PREENCHER COMBOBOX
            MySqlConnection cn = new MySqlConnection("Server=localhost;Database=beersys;Uid=root;Pwd=;");
            cn.Open();
            MySqlCommand com = new MySqlCommand();
            com.Connection = cn;
            com.CommandText = "select name_label from label";
            MySqlDataReader drc = com.ExecuteReader();
            DataTable dtc = new DataTable();
            dtc.Load(drc);
            cmbRotuloProduto.DisplayMember = "name_label";
            cmbRotuloProduto.DataSource = dtc;
            cn.Close();
            drc.Close();

            //PREENCHER DATAGRID
            MySqlConnection cn3 = new MySqlConnection("Server=localhost;Database=beersys;Uid=root;Pwd=;");
            cn3.Open();
            //strSQL = "SELECT * FROM label";
            strSQL = "select label.name_label as 'Rótulo', brand.name_brand as 'Marca', style.name_style as 'Estilo', product.price as 'Preço', product.volume as 'Volume' from label inner join brand on (brand.id_brand = label.id_brand) inner join style on (style.id_style = label.id_style) inner join product on (label.id_label = product.id_label)";
            da = new MySqlDataAdapter(strSQL, cn3);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvEstoque.DataSource = dt;
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

        }

        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            MySqlConnection cn = new MySqlConnection("Server=localhost;Database=beersys;Uid=root;Pwd=;");
            cn.Open();
            MySqlCommand com = new MySqlCommand();
            com.Connection = cn;
            com.CommandText = "select id_label from label where name_label = @NAME_LABEL";
            com.Parameters.AddWithValue("@NAME_LABEL", cmbRotuloProduto.Text);
            MySqlDataReader drc = com.ExecuteReader();
            drc.Read();
            //USAR ESSE ID LABEL NA QUERY DE ADICIONAR PRODUTO
            int id_label = drc.GetInt32(0);
            cn.Close();
            drc.Close();

            conexao = new MySqlConnection("Server=localhost;Database=beersys;Uid=root;Pwd=;");
            strSQL = "INSERT INTO product (id_label,vessel_indice,price,volume,bulk_sale) VALUES (@ID_LABEL," +
                "+@VESSEL_INDICE,@PRICE,@VOLUME,@BULK_SALE)";
            comando = new MySqlCommand(strSQL, conexao);
            comando.Parameters.AddWithValue("@ID_LABEL", id_label);
            comando.Parameters.AddWithValue("@VESSEL_INDICE", txtTipodeEmbalagem.Text);
            comando.Parameters.AddWithValue("@PRICE", txtPreco.Text);
            comando.Parameters.AddWithValue("@VOLUME", txtVolume.Text);
            comando.Parameters.AddWithValue("@BULK_SALE", chkGranel.Checked);

            conexao.Open();
            comando.ExecuteNonQuery();
            txtTipodeEmbalagem.Text = "";
            txtPreco.Text = "";
            txtVolume.Text = "";
            chkGranel.CheckState = 0;

            MessageBox.Show("Produto cadastrado com sucesso", "Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conexao.Close();

            MySqlConnection cn3 = new MySqlConnection("Server=localhost;Database=beersys;Uid=root;Pwd=;");
            cn3.Open();
            //strSQL = "SELECT * FROM label";
            strSQL = "select label.name_label as 'Rótulo', brand.name_brand as 'Marca', style.name_style as 'Estilo', product.price as 'Preço', product.volume as 'Volume' from label inner join brand on (brand.id_brand = label.id_brand) inner join style on (style.id_style = label.id_style) inner join product on (label.id_label = product.id_label)";
            da = new MySqlDataAdapter(strSQL, cn3);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvEstoque.DataSource = dt;
        }
    }
}