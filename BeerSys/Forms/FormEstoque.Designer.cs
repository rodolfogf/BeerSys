namespace BeerSys.Forms
{
    partial class FormEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEstoque));
            this.lblAdicionarProduto = new System.Windows.Forms.Label();
            this.btnCadastrarProduto = new System.Windows.Forms.Button();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.cmbRotuloProduto = new System.Windows.Forms.ComboBox();
            this.lblRotuloProduto = new System.Windows.Forms.Label();
            this.lblTipodeEmbalagem = new System.Windows.Forms.Label();
            this.txtTipodeEmbalagem = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.lblVolume = new System.Windows.Forms.Label();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.chkGranel = new System.Windows.Forms.CheckBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvEstoque = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdicionarProduto
            // 
            this.lblAdicionarProduto.AutoSize = true;
            this.lblAdicionarProduto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdicionarProduto.Location = new System.Drawing.Point(28, 30);
            this.lblAdicionarProduto.Name = "lblAdicionarProduto";
            this.lblAdicionarProduto.Size = new System.Drawing.Size(147, 17);
            this.lblAdicionarProduto.TabIndex = 36;
            this.lblAdicionarProduto.Text = "ADICIONAR PRODUTO";
            // 
            // btnCadastrarProduto
            // 
            this.btnCadastrarProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCadastrarProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnCadastrarProduto.FlatAppearance.BorderSize = 0;
            this.btnCadastrarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarProduto.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarProduto.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarProduto.Location = new System.Drawing.Point(31, 379);
            this.btnCadastrarProduto.Name = "btnCadastrarProduto";
            this.btnCadastrarProduto.Size = new System.Drawing.Size(132, 33);
            this.btnCadastrarProduto.TabIndex = 7;
            this.btnCadastrarProduto.Text = "Cadastrar Produto";
            this.btnCadastrarProduto.UseVisualStyleBackColor = false;
            this.btnCadastrarProduto.Click += new System.EventHandler(this.btnCadastrarProduto_Click);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantidade.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.Location = new System.Drawing.Point(31, 346);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(214, 25);
            this.txtQuantidade.TabIndex = 6;
            // 
            // cmbRotuloProduto
            // 
            this.cmbRotuloProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRotuloProduto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRotuloProduto.FormattingEnabled = true;
            this.cmbRotuloProduto.Location = new System.Drawing.Point(31, 91);
            this.cmbRotuloProduto.Name = "cmbRotuloProduto";
            this.cmbRotuloProduto.Size = new System.Drawing.Size(214, 25);
            this.cmbRotuloProduto.TabIndex = 1;
            // 
            // lblRotuloProduto
            // 
            this.lblRotuloProduto.AutoSize = true;
            this.lblRotuloProduto.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRotuloProduto.Location = new System.Drawing.Point(32, 71);
            this.lblRotuloProduto.Name = "lblRotuloProduto";
            this.lblRotuloProduto.Size = new System.Drawing.Size(48, 17);
            this.lblRotuloProduto.TabIndex = 41;
            this.lblRotuloProduto.Text = "Rótulo";
            // 
            // lblTipodeEmbalagem
            // 
            this.lblTipodeEmbalagem.AutoSize = true;
            this.lblTipodeEmbalagem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipodeEmbalagem.Location = new System.Drawing.Point(32, 126);
            this.lblTipodeEmbalagem.Name = "lblTipodeEmbalagem";
            this.lblTipodeEmbalagem.Size = new System.Drawing.Size(128, 17);
            this.lblTipodeEmbalagem.TabIndex = 43;
            this.lblTipodeEmbalagem.Text = "Tipo de embalagem";
            // 
            // txtTipodeEmbalagem
            // 
            this.txtTipodeEmbalagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTipodeEmbalagem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipodeEmbalagem.Location = new System.Drawing.Point(31, 146);
            this.txtTipodeEmbalagem.Name = "txtTipodeEmbalagem";
            this.txtTipodeEmbalagem.Size = new System.Drawing.Size(214, 25);
            this.txtTipodeEmbalagem.TabIndex = 2;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.Location = new System.Drawing.Point(32, 181);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(42, 17);
            this.lblPreco.TabIndex = 45;
            this.lblPreco.Text = "Preço";
            // 
            // txtPreco
            // 
            this.txtPreco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPreco.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco.Location = new System.Drawing.Point(31, 201);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(214, 25);
            this.txtPreco.TabIndex = 3;
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolume.Location = new System.Drawing.Point(32, 236);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(53, 17);
            this.lblVolume.TabIndex = 47;
            this.lblVolume.Text = "Volume";
            // 
            // txtVolume
            // 
            this.txtVolume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVolume.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVolume.Location = new System.Drawing.Point(31, 256);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.Size = new System.Drawing.Size(214, 25);
            this.txtVolume.TabIndex = 4;
            // 
            // chkGranel
            // 
            this.chkGranel.AutoSize = true;
            this.chkGranel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGranel.Location = new System.Drawing.Point(32, 297);
            this.chkGranel.Name = "chkGranel";
            this.chkGranel.Size = new System.Drawing.Size(183, 21);
            this.chkGranel.TabIndex = 5;
            this.chkGranel.Text = "Produto vendido a granel";
            this.chkGranel.UseVisualStyleBackColor = true;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.Location = new System.Drawing.Point(32, 326);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(79, 17);
            this.lblQuantidade.TabIndex = 49;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 400);
            this.panel1.TabIndex = 50;
            // 
            // dgvEstoque
            // 
            this.dgvEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEstoque.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEstoque.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEstoque.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEstoque.Location = new System.Drawing.Point(286, 20);
            this.dgvEstoque.Name = "dgvEstoque";
            this.dgvEstoque.Size = new System.Drawing.Size(502, 400);
            this.dgvEstoque.TabIndex = 51;
            // 
            // FormEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvEstoque);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.chkGranel);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.txtVolume);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.lblTipodeEmbalagem);
            this.Controls.Add(this.txtTipodeEmbalagem);
            this.Controls.Add(this.lblRotuloProduto);
            this.Controls.Add(this.cmbRotuloProduto);
            this.Controls.Add(this.btnCadastrarProduto);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.lblAdicionarProduto);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "FormEstoque";
            this.Text = "ESTOQUE";
            this.Load += new System.EventHandler(this.FormEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAdicionarProduto;
        private System.Windows.Forms.Button btnCadastrarProduto;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.ComboBox cmbRotuloProduto;
        private System.Windows.Forms.Label lblRotuloProduto;
        private System.Windows.Forms.Label lblTipodeEmbalagem;
        private System.Windows.Forms.TextBox txtTipodeEmbalagem;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.TextBox txtVolume;
        private System.Windows.Forms.CheckBox chkGranel;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvEstoque;
    }
}