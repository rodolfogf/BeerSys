using Microsoft.SqlServer.Server;
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
    public partial class FormNovoRotulo : Form
    {
        MySqlConnection conexao;
        MySqlConnection conexao2;
        MySqlCommand comando;
        MySqlCommand comando2;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSQL;
        string strSQL2;
        public FormNovoRotulo()
        {
            InitializeComponent();
        }
        
        //METODOS
        private void FormNovoRotulo_Load(object sender, EventArgs e)
        {
            LoadTheme();

            MySqlConnection cn3 = new MySqlConnection("Server=localhost;Database=beersys;Uid=root;Pwd=;");
            cn3.Open();
            //strSQL = "SELECT * FROM label";
            strSQL = "select label.name_label as 'Rótulo', brand.name_brand as 'Marca', style.name_style as 'Estilo' " +
                "from label inner join brand on (brand.id_brand = label.id_brand) " +
                "inner join style on (style.id_style = label.id_style)";
            da = new MySqlDataAdapter(strSQL, cn3);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvRotulo.DataSource = dt;

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
            foreach (Control lbls in this.Controls)
            {
                if (lbls.GetType() == typeof(Label))
                {
                    Label lbl = (Label)lbls;
                    lbl.ForeColor = ThemeColor.SecondaryColor;
                }
            }
            //MUDAR AS CORES DOS LABELS EM CADA FORM
            //O IF ALI EM CIMA FAZ A MESMA COISA QUE AS LINHAS ABAIXO, CORRIGINDO BUG
            btnEnviarImagem.BackColor = ThemeColor.PrimaryColor;
            btnCadastrarRotulo.BackColor = ThemeColor.PrimaryColor;

        }


        //BUTTONS -------------------------------------------------------------------
        private void btnCadastrarMarca_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=beersys;Uid=root;Pwd=;");
                strSQL = "INSERT INTO brand (name_brand) VALUES (@NOME_BRAND)";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@NOME_BRAND", txtMarca.Text);
                conexao.Open();
                comando.ExecuteNonQuery();
                txtMarca.Text = "";
                MessageBox.Show("Marca cadastrada com sucesso", "Marca", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        private void btnCadastrarFamilia_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=beersys;Uid=root;Pwd=;");
                strSQL = "INSERT INTO family (name_family) VALUES (@NOME_FAMILIA)";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@NOME_FAMILIA", txtNomeFamilia.Text);
                conexao.Open();
                comando.ExecuteNonQuery();
                txtNomeFamilia.Text = "";
                MessageBox.Show("Família cadastrada com sucesso", "Marca", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }
        private void btnCadastrarEstilo_Click(object sender, EventArgs e)
        {

            try
            {
                MySqlConnection cn = new MySqlConnection("Server=localhost;Database=beersys;Uid=root;Pwd=;");
                cn.Open();
                MySqlCommand com = new MySqlCommand();
                com.Connection = cn;
                com.CommandText = "select id_family from family where name_family = @NAME_FAMILY";
                com.Parameters.AddWithValue("@NAME_FAMILY", cmbEstiloFamilia.Text);
                MySqlDataReader drc = com.ExecuteReader();
                drc.Read();
                int id_family = drc.GetInt32(0);
                cn.Close();
                drc.Close();

                conexao = new MySqlConnection("Server=localhost;Database=beersys;Uid=root;Pwd=;");
                strSQL = "INSERT INTO style (name_style, id_family) VALUES (@NOME_FAMILIA, @ID_FAMILIA)";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@NOME_FAMILIA", txtNomeEstilo.Text);
                comando.Parameters.AddWithValue("@ID_FAMILIA", id_family.ToString());
                conexao.Open();
                comando.ExecuteNonQuery();
                txtNomeFamilia.Text = "";
                MessageBox.Show("Estilo cadastrado com sucesso", "Estilo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }

        }

        private void btnCadastrarRotulo_Click(object sender, EventArgs e)
        {
            //PEGA VALOR DO COMBOBOX
            MySqlConnection cn = new MySqlConnection("Server=localhost;Database=beersys;Uid=root;Pwd=;");
            cn.Open();
            MySqlCommand com = new MySqlCommand();
            com.Connection = cn;
            com.CommandText = "select id_brand from brand where name_brand = @NAME_BRAND";
            com.Parameters.AddWithValue("@NAME_BRAND", cmbBrand.Text);
            MySqlDataReader drc = com.ExecuteReader();
            drc.Read();
            int id_brand = drc.GetInt32(0);
            cn.Close();
            drc.Close();
            //PEGA VALOR DO COMBOBOX
            MySqlConnection cn2 = new MySqlConnection("Server=localhost;Database=beersys;Uid=root;Pwd=;");
            cn2.Open();
            MySqlCommand com2 = new MySqlCommand();
            com2.Connection = cn2;
            com2.CommandText = "select id_style from style where name_style = @NAME_STYLE";
            com2.Parameters.AddWithValue("@NAME_STYLE", cmbEstilo.Text);
            MySqlDataReader drc2 = com2.ExecuteReader();
            drc2.Read();
            int id_estilo = drc2.GetInt32(0);
            cn2.Close();
            drc2.Close();

            conexao = new MySqlConnection("Server=localhost;Database=beersys;Uid=root;Pwd=;");
            strSQL = "INSERT INTO label (name_label, id_brand, id_style) VALUES (@NOME_LABEL, @ID_BRAND, @ID_STYLE)";
            comando = new MySqlCommand(strSQL, conexao);
            comando.Parameters.AddWithValue("@NOME_LABEL", txtNomeLabel.Text);
            comando.Parameters.AddWithValue("@ID_BRAND", id_brand);
            comando.Parameters.AddWithValue("@ID_STYLE", id_estilo);
            conexao.Open();
            comando.ExecuteNonQuery();
            txtNomeFamilia.Text = "";
            MessageBox.Show("Rótulo cadastrado com sucesso", "Rótulo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            MySqlConnection cn3 = new MySqlConnection("Server=localhost;Database=beersys;Uid=root;Pwd=;");
            cn3.Open();
            //strSQL = "SELECT * FROM label";
            strSQL = "select label.name_label as 'Rótulo', brand.name_brand as 'Marca', style.name_style as 'Estilo' from label inner join brand on (brand.id_brand = label.id_brand) inner join style on (style.id_style = label.id_style)";
            da = new MySqlDataAdapter(strSQL, cn3);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvRotulo.DataSource = dt;

        }

        //COMBOBOXES - SELECT PARA PREENCHER -------------------------------------------------------------------
        private void cmbEstiloFamilia_Click(object sender, EventArgs e)
        {
            MySqlConnection cn = new MySqlConnection("Server=localhost;Database=beersys;Uid=root;Pwd=;");
            cn.Open();
            MySqlCommand com = new MySqlCommand();
            com.Connection = cn;
            com.CommandText = "select name_family from family";
            MySqlDataReader drc = com.ExecuteReader();
            DataTable dtc = new DataTable();
            dtc.Load(drc);
            cmbEstiloFamilia.DisplayMember = "name_family";
            cmbEstiloFamilia.DataSource = dtc;
            cn.Close();
            drc.Close();
        }

        private void cmbBrand_Click(object sender, EventArgs e)
        {
            MySqlConnection cn = new MySqlConnection("Server=localhost;Database=beersys;Uid=root;Pwd=;");
            cn.Open();
            MySqlCommand com = new MySqlCommand();
            com.Connection = cn;
            com.CommandText = "select name_brand from brand";
            MySqlDataReader drc = com.ExecuteReader();
            DataTable dtc = new DataTable();
            dtc.Load(drc);
            cmbBrand.DisplayMember = "name_brand";
            cmbBrand.DataSource = dtc;
            cn.Close();
            drc.Close();
        }

        private void cmbEstilo_Click(object sender, EventArgs e)
        {
            MySqlConnection cn = new MySqlConnection("Server=localhost;Database=beersys;Uid=root;Pwd=;");
            cn.Open();
            MySqlCommand com = new MySqlCommand();
            com.Connection = cn;
            com.CommandText = "select name_style from style";
            MySqlDataReader drc = com.ExecuteReader();
            DataTable dtc = new DataTable();
            dtc.Load(drc);
            cmbEstilo.DisplayMember = "name_style";
            cmbEstilo.DataSource = dtc;
            cn.Close();
            drc.Close();
        }
    }

}