namespace BeerSys.Forms
{
    partial class FormConfiguracoes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfiguracoes));
            this.txtAddSenha = new System.Windows.Forms.TextBox();
            this.lblAddSenha = new System.Windows.Forms.Label();
            this.lblAddNome = new System.Windows.Forms.Label();
            this.txtAddNome = new System.Windows.Forms.TextBox();
            this.lblAdicionarUsuario = new System.Windows.Forms.Label();
            this.chkEAdmin = new System.Windows.Forms.CheckBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAddSenha
            // 
            this.txtAddSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddSenha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddSenha.Location = new System.Drawing.Point(15, 118);
            this.txtAddSenha.Name = "txtAddSenha";
            this.txtAddSenha.PasswordChar = '*';
            this.txtAddSenha.Size = new System.Drawing.Size(214, 25);
            this.txtAddSenha.TabIndex = 2;
            // 
            // lblAddSenha
            // 
            this.lblAddSenha.AutoSize = true;
            this.lblAddSenha.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddSenha.Location = new System.Drawing.Point(12, 98);
            this.lblAddSenha.Name = "lblAddSenha";
            this.lblAddSenha.Size = new System.Drawing.Size(45, 17);
            this.lblAddSenha.TabIndex = 8;
            this.lblAddSenha.Text = "Senha";
            // 
            // lblAddNome
            // 
            this.lblAddNome.AutoSize = true;
            this.lblAddNome.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNome.Location = new System.Drawing.Point(12, 38);
            this.lblAddNome.Name = "lblAddNome";
            this.lblAddNome.Size = new System.Drawing.Size(45, 17);
            this.lblAddNome.TabIndex = 7;
            this.lblAddNome.Text = "Nome";
            // 
            // txtAddNome
            // 
            this.txtAddNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddNome.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddNome.Location = new System.Drawing.Point(15, 58);
            this.txtAddNome.Name = "txtAddNome";
            this.txtAddNome.Size = new System.Drawing.Size(214, 25);
            this.txtAddNome.TabIndex = 1;
            // 
            // lblAdicionarUsuario
            // 
            this.lblAdicionarUsuario.AutoSize = true;
            this.lblAdicionarUsuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdicionarUsuario.Location = new System.Drawing.Point(12, 9);
            this.lblAdicionarUsuario.Name = "lblAdicionarUsuario";
            this.lblAdicionarUsuario.Size = new System.Drawing.Size(140, 17);
            this.lblAdicionarUsuario.TabIndex = 9;
            this.lblAdicionarUsuario.Text = "ADICIONAR USUARIO";
            // 
            // chkEAdmin
            // 
            this.chkEAdmin.AutoSize = true;
            this.chkEAdmin.Location = new System.Drawing.Point(15, 160);
            this.chkEAdmin.Name = "chkEAdmin";
            this.chkEAdmin.Size = new System.Drawing.Size(104, 17);
            this.chkEAdmin.TabIndex = 3;
            this.chkEAdmin.Text = "É administrador?";
            this.chkEAdmin.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(12, 183);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(82, 33);
            this.btnCadastrar.TabIndex = 10;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // FormConfiguracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.chkEAdmin);
            this.Controls.Add(this.lblAdicionarUsuario);
            this.Controls.Add(this.txtAddSenha);
            this.Controls.Add(this.lblAddSenha);
            this.Controls.Add(this.lblAddNome);
            this.Controls.Add(this.txtAddNome);
            this.DoubleBuffered = true;
            this.Name = "FormConfiguracoes";
            this.Text = "CONFIGURAÇÕES";
            this.Load += new System.EventHandler(this.FormConfiguracoes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAddSenha;
        private System.Windows.Forms.Label lblAddSenha;
        private System.Windows.Forms.Label lblAddNome;
        private System.Windows.Forms.TextBox txtAddNome;
        private System.Windows.Forms.Label lblAdicionarUsuario;
        private System.Windows.Forms.CheckBox chkEAdmin;
        private System.Windows.Forms.Button btnCadastrar;
    }
}