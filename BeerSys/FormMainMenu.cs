using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace BeerSys
{
    public partial class FormMainMenu : Form
    {
        //public static System.Media.SystemSound Beep { get; }
        //Mysql
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        //MySqlDataReader dr;
        string strSQL;
        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        //Constructor
        public FormMainMenu()
        {
            InitializeComponent();
            random = new Random();
            this.Text = string.Empty;
            DisableAllButtons();

            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=beersys;Uid=root;Pwd=;");
                conexao.Open();
                //MessageBox.Show("Conectado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //CASO FOR USAR SEM A BORDA DO WINDOWS
            //this.ControlBox = false;
            //this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        /*SERVE PARA ARRASTAR O PROBRAMA USANDO A BARRA
         [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
         private extern static void ReleaseCapture();
         [DllImport("user32.DLL", EntryPoint = "SendMessage")]
         private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        */
        //Methods

        //MÉTODO DESATIVAR BOTÕES
        private void DisableAllButtons()
        {
            btnDashBoard.Enabled = false;
            btnNovoRotulo.Enabled = false;
            btnEstoque.Enabled = false;
            btnVenda.Enabled = false;
            btnNotificacoes.Enabled = false;
            btnConfiguracoes.Enabled = false;
        }

        //MÉTODO ATIVAR BOTÕES
        private void EnableAllButtons()
        {
            btnDashBoard.Enabled = true;
            btnNovoRotulo.Enabled = true;
            btnEstoque.Enabled = true;
            btnVenda.Enabled = true;
            btnNotificacoes.Enabled = true;
            btnConfiguracoes.Enabled = true;
        }
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while(tempIndex == index)
            {
               index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if(btnSender != null)
            {
                if(currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                }
            }
        }
        private void DisableButton()
        {
            foreach(Control previousBtn in panelMenu.Controls)
            {
                if(previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender) //Serve para caminhar entre telas
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormDashboard(), sender);
        }

        private void btnNovoRotulo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormNovoRotulo(), sender);

        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormEstoque(), sender);
        }

        private void btnVenda_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormVenda(), sender);
        }

        private void btnNotificações_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormNotificacoes(), sender);
        }

        private void btnConfiguracoes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormConfiguracoes(), sender);
        }

        private void lblTitle_MouseDown(object sender, MouseEventArgs e)
        {
            //ReleaseCapture();
            //SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public void btnEntrar_Click(object sender, EventArgs e)
        {
            strSQL = "select count(*) from user where name_user = '"+txtNome.Text+"' and password_user ='"+txtSenha.Text+"'";
            comando = new MySqlCommand(strSQL, conexao);
            DataTable dataTable = new DataTable();
            da = new MySqlDataAdapter(comando);
            da.Fill(dataTable);
            
            //VERIFICAÇÃO SE EXISTE O USUARIO NO BANCO DE DADOS
            foreach(DataRow list in dataTable.Rows)
            {
                if (Convert.ToInt32(list.ItemArray[0]) > 0)
                {
                    OpenChildForm(new Forms.FormDashboard(), sender);
                    EnableAllButtons();
                    //MessageBox.Show("Usuário validado");
                    SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\sidne\source\repos\BeerSys\BeerSys\sounds\Beer1.wav");
                    simpleSound.Play();
                    //Corrigir erro de caixa de texto fantasma
                    txtNome.Dispose();
                    txtSenha.Dispose();
                    conexao.Close();
                    this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                    this.MaximizeBox = false;
                }
                else
                {
                    MessageBox.Show("Usuário inválido", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void FormMainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            conexao.Close();
        }


        //ENTER NA CAIXA DE TEXTO
        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

                btnEntrar.PerformClick();
                //NoFocusCueButton();
            }
            else
            {
                base.OnKeyDown(e);
            }
        }
    }
}
