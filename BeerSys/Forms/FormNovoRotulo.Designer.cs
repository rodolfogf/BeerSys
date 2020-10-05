namespace BeerSys.Forms
{
    partial class FormNovoRotulo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNovoRotulo));
            this.lblAdicionarRotulo = new System.Windows.Forms.Label();
            this.lblNomeLabel = new System.Windows.Forms.Label();
            this.txtNomeLabel = new System.Windows.Forms.TextBox();
            this.cmbBrand = new System.Windows.Forms.ComboBox();
            this.lblMarcaLabel = new System.Windows.Forms.Label();
            this.lblEstiloLabel = new System.Windows.Forms.Label();
            this.cmbEstilo = new System.Windows.Forms.ComboBox();
            this.lblAdicionarEstilo = new System.Windows.Forms.Label();
            this.lblEstiloFamilia = new System.Windows.Forms.Label();
            this.cmbEstiloFamilia = new System.Windows.Forms.ComboBox();
            this.btnCadastrarEstilo = new System.Windows.Forms.Button();
            this.lblNomeEstilo = new System.Windows.Forms.Label();
            this.txtNomeEstilo = new System.Windows.Forms.TextBox();
            this.lblNomeFamilia = new System.Windows.Forms.Label();
            this.txtNomeFamilia = new System.Windows.Forms.TextBox();
            this.lblAdicionarFamilia = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblAdicionarMarca = new System.Windows.Forms.Label();
            this.btnCadastrarFamilia = new System.Windows.Forms.Button();
            this.btnCadastrarMarca = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCadastrarRotulo = new System.Windows.Forms.Button();
            this.btnEnviarImagem = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblImagem = new System.Windows.Forms.Label();
            this.dgvRotulo = new System.Windows.Forms.DataGridView();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRotulo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdicionarRotulo
            // 
            this.lblAdicionarRotulo.AutoSize = true;
            this.lblAdicionarRotulo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdicionarRotulo.Location = new System.Drawing.Point(283, 25);
            this.lblAdicionarRotulo.Name = "lblAdicionarRotulo";
            this.lblAdicionarRotulo.Size = new System.Drawing.Size(135, 17);
            this.lblAdicionarRotulo.TabIndex = 13;
            this.lblAdicionarRotulo.Text = "ADICIONAR RÓTULO";
            // 
            // lblNomeLabel
            // 
            this.lblNomeLabel.AutoSize = true;
            this.lblNomeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeLabel.Location = new System.Drawing.Point(283, 54);
            this.lblNomeLabel.Name = "lblNomeLabel";
            this.lblNomeLabel.Size = new System.Drawing.Size(45, 17);
            this.lblNomeLabel.TabIndex = 12;
            this.lblNomeLabel.Text = "Nome";
            // 
            // txtNomeLabel
            // 
            this.txtNomeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeLabel.Location = new System.Drawing.Point(286, 74);
            this.txtNomeLabel.Name = "txtNomeLabel";
            this.txtNomeLabel.Size = new System.Drawing.Size(214, 25);
            this.txtNomeLabel.TabIndex = 8;
            // 
            // cmbBrand
            // 
            this.cmbBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBrand.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBrand.FormattingEnabled = true;
            this.cmbBrand.Location = new System.Drawing.Point(286, 129);
            this.cmbBrand.Name = "cmbBrand";
            this.cmbBrand.Size = new System.Drawing.Size(214, 25);
            this.cmbBrand.TabIndex = 9;
            this.cmbBrand.Click += new System.EventHandler(this.cmbBrand_Click);
            // 
            // lblMarcaLabel
            // 
            this.lblMarcaLabel.AutoSize = true;
            this.lblMarcaLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcaLabel.Location = new System.Drawing.Point(283, 109);
            this.lblMarcaLabel.Name = "lblMarcaLabel";
            this.lblMarcaLabel.Size = new System.Drawing.Size(45, 17);
            this.lblMarcaLabel.TabIndex = 16;
            this.lblMarcaLabel.Text = "Marca";
            // 
            // lblEstiloLabel
            // 
            this.lblEstiloLabel.AutoSize = true;
            this.lblEstiloLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstiloLabel.Location = new System.Drawing.Point(283, 164);
            this.lblEstiloLabel.Name = "lblEstiloLabel";
            this.lblEstiloLabel.Size = new System.Drawing.Size(40, 17);
            this.lblEstiloLabel.TabIndex = 18;
            this.lblEstiloLabel.Text = "Estilo";
            // 
            // cmbEstilo
            // 
            this.cmbEstilo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstilo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstilo.FormattingEnabled = true;
            this.cmbEstilo.Location = new System.Drawing.Point(286, 184);
            this.cmbEstilo.Name = "cmbEstilo";
            this.cmbEstilo.Size = new System.Drawing.Size(214, 25);
            this.cmbEstilo.TabIndex = 10;
            this.cmbEstilo.Click += new System.EventHandler(this.cmbEstilo_Click);
            // 
            // lblAdicionarEstilo
            // 
            this.lblAdicionarEstilo.AutoSize = true;
            this.lblAdicionarEstilo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdicionarEstilo.Location = new System.Drawing.Point(28, 309);
            this.lblAdicionarEstilo.Name = "lblAdicionarEstilo";
            this.lblAdicionarEstilo.Size = new System.Drawing.Size(127, 17);
            this.lblAdicionarEstilo.TabIndex = 19;
            this.lblAdicionarEstilo.Text = "ADICIONAR ESTILO";
            // 
            // lblEstiloFamilia
            // 
            this.lblEstiloFamilia.AutoSize = true;
            this.lblEstiloFamilia.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstiloFamilia.Location = new System.Drawing.Point(28, 399);
            this.lblEstiloFamilia.Name = "lblEstiloFamilia";
            this.lblEstiloFamilia.Size = new System.Drawing.Size(50, 17);
            this.lblEstiloFamilia.TabIndex = 24;
            this.lblEstiloFamilia.Text = "Família";
            // 
            // cmbEstiloFamilia
            // 
            this.cmbEstiloFamilia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstiloFamilia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstiloFamilia.FormattingEnabled = true;
            this.cmbEstiloFamilia.Location = new System.Drawing.Point(28, 419);
            this.cmbEstiloFamilia.Name = "cmbEstiloFamilia";
            this.cmbEstiloFamilia.Size = new System.Drawing.Size(214, 25);
            this.cmbEstiloFamilia.TabIndex = 6;
            this.cmbEstiloFamilia.Click += new System.EventHandler(this.cmbEstiloFamilia_Click);
            // 
            // btnCadastrarEstilo
            // 
            this.btnCadastrarEstilo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnCadastrarEstilo.FlatAppearance.BorderSize = 0;
            this.btnCadastrarEstilo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarEstilo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarEstilo.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarEstilo.Location = new System.Drawing.Point(28, 449);
            this.btnCadastrarEstilo.Name = "btnCadastrarEstilo";
            this.btnCadastrarEstilo.Size = new System.Drawing.Size(132, 33);
            this.btnCadastrarEstilo.TabIndex = 7;
            this.btnCadastrarEstilo.Text = "Cadastrar Estilo";
            this.btnCadastrarEstilo.UseVisualStyleBackColor = false;
            this.btnCadastrarEstilo.Click += new System.EventHandler(this.btnCadastrarEstilo_Click);
            // 
            // lblNomeEstilo
            // 
            this.lblNomeEstilo.AutoSize = true;
            this.lblNomeEstilo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeEstilo.Location = new System.Drawing.Point(28, 339);
            this.lblNomeEstilo.Name = "lblNomeEstilo";
            this.lblNomeEstilo.Size = new System.Drawing.Size(45, 17);
            this.lblNomeEstilo.TabIndex = 21;
            this.lblNomeEstilo.Text = "Nome";
            // 
            // txtNomeEstilo
            // 
            this.txtNomeEstilo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeEstilo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeEstilo.Location = new System.Drawing.Point(28, 359);
            this.txtNomeEstilo.Name = "txtNomeEstilo";
            this.txtNomeEstilo.Size = new System.Drawing.Size(214, 25);
            this.txtNomeEstilo.TabIndex = 5;
            // 
            // lblNomeFamilia
            // 
            this.lblNomeFamilia.AutoSize = true;
            this.lblNomeFamilia.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFamilia.Location = new System.Drawing.Point(28, 199);
            this.lblNomeFamilia.Name = "lblNomeFamilia";
            this.lblNomeFamilia.Size = new System.Drawing.Size(45, 17);
            this.lblNomeFamilia.TabIndex = 27;
            this.lblNomeFamilia.Text = "Nome";
            // 
            // txtNomeFamilia
            // 
            this.txtNomeFamilia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeFamilia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFamilia.Location = new System.Drawing.Point(28, 219);
            this.txtNomeFamilia.Name = "txtNomeFamilia";
            this.txtNomeFamilia.Size = new System.Drawing.Size(214, 25);
            this.txtNomeFamilia.TabIndex = 3;
            // 
            // lblAdicionarFamilia
            // 
            this.lblAdicionarFamilia.AutoSize = true;
            this.lblAdicionarFamilia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdicionarFamilia.Location = new System.Drawing.Point(25, 169);
            this.lblAdicionarFamilia.Name = "lblAdicionarFamilia";
            this.lblAdicionarFamilia.Size = new System.Drawing.Size(135, 17);
            this.lblAdicionarFamilia.TabIndex = 25;
            this.lblAdicionarFamilia.Text = "ADICIONAR FAMÍLIA";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(28, 56);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(45, 17);
            this.lblMarca.TabIndex = 30;
            this.lblMarca.Text = "Nome";
            // 
            // txtMarca
            // 
            this.txtMarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMarca.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(28, 76);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(214, 25);
            this.txtMarca.TabIndex = 1;
            // 
            // lblAdicionarMarca
            // 
            this.lblAdicionarMarca.AutoSize = true;
            this.lblAdicionarMarca.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdicionarMarca.Location = new System.Drawing.Point(28, 26);
            this.lblAdicionarMarca.Name = "lblAdicionarMarca";
            this.lblAdicionarMarca.Size = new System.Drawing.Size(130, 17);
            this.lblAdicionarMarca.TabIndex = 28;
            this.lblAdicionarMarca.Text = "ADICIONAR MARCA";
            // 
            // btnCadastrarFamilia
            // 
            this.btnCadastrarFamilia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnCadastrarFamilia.FlatAppearance.BorderSize = 0;
            this.btnCadastrarFamilia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarFamilia.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarFamilia.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarFamilia.Location = new System.Drawing.Point(28, 249);
            this.btnCadastrarFamilia.Name = "btnCadastrarFamilia";
            this.btnCadastrarFamilia.Size = new System.Drawing.Size(132, 33);
            this.btnCadastrarFamilia.TabIndex = 4;
            this.btnCadastrarFamilia.Text = "Cadastrar Família";
            this.btnCadastrarFamilia.UseVisualStyleBackColor = false;
            this.btnCadastrarFamilia.Click += new System.EventHandler(this.btnCadastrarFamilia_Click);
            // 
            // btnCadastrarMarca
            // 
            this.btnCadastrarMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnCadastrarMarca.FlatAppearance.BorderSize = 0;
            this.btnCadastrarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarMarca.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarMarca.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarMarca.Location = new System.Drawing.Point(28, 106);
            this.btnCadastrarMarca.Name = "btnCadastrarMarca";
            this.btnCadastrarMarca.Size = new System.Drawing.Size(132, 33);
            this.btnCadastrarMarca.TabIndex = 2;
            this.btnCadastrarMarca.Text = "Cadastrar Marca";
            this.btnCadastrarMarca.UseVisualStyleBackColor = false;
            this.btnCadastrarMarca.Click += new System.EventHandler(this.btnCadastrarMarca_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 129);
            this.panel1.TabIndex = 33;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(20, 163);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(235, 129);
            this.panel2.TabIndex = 34;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(20, 305);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(235, 186);
            this.panel3.TabIndex = 35;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnCadastrarRotulo);
            this.panel4.Controls.Add(this.btnEnviarImagem);
            this.panel4.Location = new System.Drawing.Point(278, 20);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(235, 272);
            this.panel4.TabIndex = 36;
            // 
            // btnCadastrarRotulo
            // 
            this.btnCadastrarRotulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnCadastrarRotulo.FlatAppearance.BorderSize = 0;
            this.btnCadastrarRotulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarRotulo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarRotulo.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarRotulo.Location = new System.Drawing.Point(7, 230);
            this.btnCadastrarRotulo.Name = "btnCadastrarRotulo";
            this.btnCadastrarRotulo.Size = new System.Drawing.Size(132, 33);
            this.btnCadastrarRotulo.TabIndex = 12;
            this.btnCadastrarRotulo.Text = "Cadastrar Rótulo";
            this.btnCadastrarRotulo.UseVisualStyleBackColor = false;
            this.btnCadastrarRotulo.Click += new System.EventHandler(this.btnCadastrarRotulo_Click);
            // 
            // btnEnviarImagem
            // 
            this.btnEnviarImagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnEnviarImagem.FlatAppearance.BorderSize = 0;
            this.btnEnviarImagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviarImagem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarImagem.ForeColor = System.Drawing.Color.White;
            this.btnEnviarImagem.Location = new System.Drawing.Point(7, 193);
            this.btnEnviarImagem.Name = "btnEnviarImagem";
            this.btnEnviarImagem.Size = new System.Drawing.Size(132, 33);
            this.btnEnviarImagem.TabIndex = 11;
            this.btnEnviarImagem.Text = "Enviar Imagem";
            this.btnEnviarImagem.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.lblImagem);
            this.panel5.Location = new System.Drawing.Point(278, 305);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(235, 186);
            this.panel5.TabIndex = 37;
            // 
            // lblImagem
            // 
            this.lblImagem.AutoSize = true;
            this.lblImagem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagem.Location = new System.Drawing.Point(4, 3);
            this.lblImagem.Name = "lblImagem";
            this.lblImagem.Size = new System.Drawing.Size(61, 17);
            this.lblImagem.TabIndex = 38;
            this.lblImagem.Text = "IMAGEM";
            // 
            // dgvRotulo
            // 
            this.dgvRotulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRotulo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRotulo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRotulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRotulo.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRotulo.Location = new System.Drawing.Point(539, 20);
            this.dgvRotulo.Name = "dgvRotulo";
            this.dgvRotulo.Size = new System.Drawing.Size(417, 471);
            this.dgvRotulo.TabIndex = 38;
            // 
            // FormNovoRotulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(968, 688);
            this.Controls.Add(this.dgvRotulo);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.btnCadastrarMarca);
            this.Controls.Add(this.btnCadastrarFamilia);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lblAdicionarMarca);
            this.Controls.Add(this.lblNomeFamilia);
            this.Controls.Add(this.txtNomeFamilia);
            this.Controls.Add(this.lblAdicionarFamilia);
            this.Controls.Add(this.lblEstiloFamilia);
            this.Controls.Add(this.cmbEstiloFamilia);
            this.Controls.Add(this.btnCadastrarEstilo);
            this.Controls.Add(this.lblNomeEstilo);
            this.Controls.Add(this.txtNomeEstilo);
            this.Controls.Add(this.lblAdicionarEstilo);
            this.Controls.Add(this.lblEstiloLabel);
            this.Controls.Add(this.cmbEstilo);
            this.Controls.Add(this.lblMarcaLabel);
            this.Controls.Add(this.cmbBrand);
            this.Controls.Add(this.lblAdicionarRotulo);
            this.Controls.Add(this.lblNomeLabel);
            this.Controls.Add(this.txtNomeLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.DoubleBuffered = true;
            this.Name = "FormNovoRotulo";
            this.Text = "NOVO RÓTULO";
            this.Load += new System.EventHandler(this.FormNovoRotulo_Load);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRotulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAdicionarRotulo;
        private System.Windows.Forms.Label lblNomeLabel;
        private System.Windows.Forms.TextBox txtNomeLabel;
        private System.Windows.Forms.ComboBox cmbBrand;
        private System.Windows.Forms.Label lblMarcaLabel;
        private System.Windows.Forms.Label lblEstiloLabel;
        private System.Windows.Forms.ComboBox cmbEstilo;
        private System.Windows.Forms.Label lblAdicionarEstilo;
        private System.Windows.Forms.Label lblEstiloFamilia;
        private System.Windows.Forms.ComboBox cmbEstiloFamilia;
        private System.Windows.Forms.Button btnCadastrarEstilo;
        private System.Windows.Forms.Label lblNomeEstilo;
        private System.Windows.Forms.TextBox txtNomeEstilo;
        private System.Windows.Forms.Label lblNomeFamilia;
        private System.Windows.Forms.TextBox txtNomeFamilia;
        private System.Windows.Forms.Label lblAdicionarFamilia;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblAdicionarMarca;
        private System.Windows.Forms.Button btnCadastrarFamilia;
        private System.Windows.Forms.Button btnCadastrarMarca;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblImagem;
        private System.Windows.Forms.Button btnCadastrarRotulo;
        private System.Windows.Forms.Button btnEnviarImagem;
        private System.Windows.Forms.DataGridView dgvRotulo;
    }
}