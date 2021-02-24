
namespace FORM
{
    partial class FRMCliente
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
            this.GPBCLIENTE = new System.Windows.Forms.GroupBox();
            this.TXTCEDULA = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnBorrar = new System.Windows.Forms.Button();
            this.BTNSAVE = new System.Windows.Forms.Button();
            this.CMBSEXO = new System.Windows.Forms.ComboBox();
            this.CMBCATEGORIA = new System.Windows.Forms.ComboBox();
            this.TXTCODPERSONA = new System.Windows.Forms.TextBox();
            this.TXTNOMBRE = new System.Windows.Forms.TextBox();
            this.TXTNUMSEGSOCIAL = new System.Windows.Forms.TextBox();
            this.TXTAPMATERNO = new System.Windows.Forms.TextBox();
            this.TXTAPPATERNO = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DGVCLIENTES = new System.Windows.Forms.DataGridView();
            this.APPATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APMATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEDULA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SEXO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMSEGSOCIAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CATEGORIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGOPEDIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GPBCLIENTE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCLIENTES)).BeginInit();
            this.SuspendLayout();
            // 
            // GPBCLIENTE
            // 
            this.GPBCLIENTE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GPBCLIENTE.Controls.Add(this.TXTCEDULA);
            this.GPBCLIENTE.Controls.Add(this.label8);
            this.GPBCLIENTE.Controls.Add(this.BtnBorrar);
            this.GPBCLIENTE.Controls.Add(this.BTNSAVE);
            this.GPBCLIENTE.Controls.Add(this.CMBSEXO);
            this.GPBCLIENTE.Controls.Add(this.CMBCATEGORIA);
            this.GPBCLIENTE.Controls.Add(this.TXTCODPERSONA);
            this.GPBCLIENTE.Controls.Add(this.TXTNOMBRE);
            this.GPBCLIENTE.Controls.Add(this.TXTNUMSEGSOCIAL);
            this.GPBCLIENTE.Controls.Add(this.TXTAPMATERNO);
            this.GPBCLIENTE.Controls.Add(this.TXTAPPATERNO);
            this.GPBCLIENTE.Controls.Add(this.label7);
            this.GPBCLIENTE.Controls.Add(this.label6);
            this.GPBCLIENTE.Controls.Add(this.label5);
            this.GPBCLIENTE.Controls.Add(this.label4);
            this.GPBCLIENTE.Controls.Add(this.label3);
            this.GPBCLIENTE.Controls.Add(this.label2);
            this.GPBCLIENTE.Controls.Add(this.label1);
            this.GPBCLIENTE.Dock = System.Windows.Forms.DockStyle.Top;
            this.GPBCLIENTE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPBCLIENTE.Location = new System.Drawing.Point(0, 0);
            this.GPBCLIENTE.Margin = new System.Windows.Forms.Padding(4);
            this.GPBCLIENTE.Name = "GPBCLIENTE";
            this.GPBCLIENTE.Padding = new System.Windows.Forms.Padding(4);
            this.GPBCLIENTE.Size = new System.Drawing.Size(1370, 168);
            this.GPBCLIENTE.TabIndex = 0;
            this.GPBCLIENTE.TabStop = false;
            this.GPBCLIENTE.Text = "CLIENTE";
            // 
            // TXTCEDULA
            // 
            this.TXTCEDULA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTCEDULA.Location = new System.Drawing.Point(527, 129);
            this.TXTCEDULA.Name = "TXTCEDULA";
            this.TXTCEDULA.Size = new System.Drawing.Size(180, 22);
            this.TXTCEDULA.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(524, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "CEDULA";
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.BackColor = System.Drawing.Color.Gray;
            this.BtnBorrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnBorrar.FlatAppearance.BorderSize = 2;
            this.BtnBorrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnBorrar.Location = new System.Drawing.Point(1147, 125);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(137, 26);
            this.BtnBorrar.TabIndex = 16;
            this.BtnBorrar.Text = "DATOS NUEVOS";
            this.BtnBorrar.UseVisualStyleBackColor = false;
            this.BtnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // BTNSAVE
            // 
            this.BTNSAVE.BackColor = System.Drawing.Color.Gray;
            this.BTNSAVE.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BTNSAVE.FlatAppearance.BorderSize = 2;
            this.BTNSAVE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BTNSAVE.Location = new System.Drawing.Point(982, 125);
            this.BTNSAVE.Name = "BTNSAVE";
            this.BTNSAVE.Size = new System.Drawing.Size(137, 26);
            this.BTNSAVE.TabIndex = 15;
            this.BTNSAVE.Text = "GUARDAR";
            this.BTNSAVE.UseVisualStyleBackColor = false;
            this.BTNSAVE.Click += new System.EventHandler(this.BTNSAVE_Click);
            // 
            // CMBSEXO
            // 
            this.CMBSEXO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMBSEXO.ForeColor = System.Drawing.SystemColors.Desktop;
            this.CMBSEXO.FormattingEnabled = true;
            this.CMBSEXO.Items.AddRange(new object[] {
            "MASCULINO",
            "FEMENINO"});
            this.CMBSEXO.Location = new System.Drawing.Point(829, 54);
            this.CMBSEXO.Name = "CMBSEXO";
            this.CMBSEXO.Size = new System.Drawing.Size(209, 24);
            this.CMBSEXO.TabIndex = 14;
            this.CMBSEXO.Text = "Seleccione";
            this.CMBSEXO.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // CMBCATEGORIA
            // 
            this.CMBCATEGORIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMBCATEGORIA.ForeColor = System.Drawing.SystemColors.Desktop;
            this.CMBCATEGORIA.FormattingEnabled = true;
            this.CMBCATEGORIA.Items.AddRange(new object[] {
            "NUEVO",
            "LONGEVO"});
            this.CMBCATEGORIA.Location = new System.Drawing.Point(316, 129);
            this.CMBCATEGORIA.Name = "CMBCATEGORIA";
            this.CMBCATEGORIA.Size = new System.Drawing.Size(183, 24);
            this.CMBCATEGORIA.TabIndex = 13;
            this.CMBCATEGORIA.Text = "Seleccione";
            // 
            // TXTCODPERSONA
            // 
            this.TXTCODPERSONA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTCODPERSONA.Location = new System.Drawing.Point(743, 129);
            this.TXTCODPERSONA.Name = "TXTCODPERSONA";
            this.TXTCODPERSONA.Size = new System.Drawing.Size(213, 22);
            this.TXTCODPERSONA.TabIndex = 12;
            // 
            // TXTNOMBRE
            // 
            this.TXTNOMBRE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTNOMBRE.Location = new System.Drawing.Point(527, 54);
            this.TXTNOMBRE.Name = "TXTNOMBRE";
            this.TXTNOMBRE.Size = new System.Drawing.Size(272, 22);
            this.TXTNOMBRE.TabIndex = 11;
            // 
            // TXTNUMSEGSOCIAL
            // 
            this.TXTNUMSEGSOCIAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTNUMSEGSOCIAL.Location = new System.Drawing.Point(12, 129);
            this.TXTNUMSEGSOCIAL.Name = "TXTNUMSEGSOCIAL";
            this.TXTNUMSEGSOCIAL.Size = new System.Drawing.Size(278, 22);
            this.TXTNUMSEGSOCIAL.TabIndex = 10;
            // 
            // TXTAPMATERNO
            // 
            this.TXTAPMATERNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTAPMATERNO.Location = new System.Drawing.Point(271, 54);
            this.TXTAPMATERNO.Name = "TXTAPMATERNO";
            this.TXTAPMATERNO.Size = new System.Drawing.Size(228, 22);
            this.TXTAPMATERNO.TabIndex = 8;
            // 
            // TXTAPPATERNO
            // 
            this.TXTAPPATERNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTAPPATERNO.Location = new System.Drawing.Point(12, 54);
            this.TXTAPPATERNO.Name = "TXTAPPATERNO";
            this.TXTAPPATERNO.Size = new System.Drawing.Size(231, 22);
            this.TXTAPPATERNO.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(740, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "CODIGO PERSONA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(313, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "CATEGORIA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(249, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "NUMERO DE SEGURIDAD SOCIAL";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(826, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "SEXO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(524, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "NOMBRES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "APELLIDO MATERNO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "APELLIDO PATERNO";
            // 
            // DGVCLIENTES
            // 
            this.DGVCLIENTES.AllowUserToAddRows = false;
            this.DGVCLIENTES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCLIENTES.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.APPATERNO,
            this.APMATERNO,
            this.NOMBRES,
            this.CEDULA,
            this.SEXO,
            this.NUMSEGSOCIAL,
            this.CATEGORIA,
            this.CODIGOPEDIDO});
            this.DGVCLIENTES.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVCLIENTES.Location = new System.Drawing.Point(0, 168);
            this.DGVCLIENTES.Name = "DGVCLIENTES";
            this.DGVCLIENTES.RowHeadersWidth = 51;
            this.DGVCLIENTES.RowTemplate.Height = 24;
            this.DGVCLIENTES.Size = new System.Drawing.Size(1370, 581);
            this.DGVCLIENTES.TabIndex = 1;
            // 
            // APPATERNO
            // 
            this.APPATERNO.HeaderText = "APELLIDO PATERNO";
            this.APPATERNO.MinimumWidth = 6;
            this.APPATERNO.Name = "APPATERNO";
            this.APPATERNO.Width = 167;
            // 
            // APMATERNO
            // 
            this.APMATERNO.HeaderText = "APELLIDO MATERNO";
            this.APMATERNO.MinimumWidth = 6;
            this.APMATERNO.Name = "APMATERNO";
            this.APMATERNO.Width = 158;
            // 
            // NOMBRES
            // 
            this.NOMBRES.HeaderText = "NOMBRES";
            this.NOMBRES.MinimumWidth = 6;
            this.NOMBRES.Name = "NOMBRES";
            this.NOMBRES.Width = 225;
            // 
            // CEDULA
            // 
            this.CEDULA.HeaderText = "CEDULA";
            this.CEDULA.Name = "CEDULA";
            this.CEDULA.Width = 110;
            // 
            // SEXO
            // 
            this.SEXO.HeaderText = "SEXO";
            this.SEXO.MinimumWidth = 6;
            this.SEXO.Name = "SEXO";
            this.SEXO.Width = 150;
            // 
            // NUMSEGSOCIAL
            // 
            this.NUMSEGSOCIAL.HeaderText = "NUMERO DE SEGURIDAD SOCIAL";
            this.NUMSEGSOCIAL.MinimumWidth = 6;
            this.NUMSEGSOCIAL.Name = "NUMSEGSOCIAL";
            this.NUMSEGSOCIAL.Width = 191;
            // 
            // CATEGORIA
            // 
            this.CATEGORIA.HeaderText = "CATEGORIA";
            this.CATEGORIA.MinimumWidth = 6;
            this.CATEGORIA.Name = "CATEGORIA";
            this.CATEGORIA.Width = 150;
            // 
            // CODIGOPEDIDO
            // 
            this.CODIGOPEDIDO.HeaderText = "CODIGO PEDIDO";
            this.CODIGOPEDIDO.MinimumWidth = 6;
            this.CODIGOPEDIDO.Name = "CODIGOPEDIDO";
            this.CODIGOPEDIDO.Width = 180;
            // 
            // FRMCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.DGVCLIENTES);
            this.Controls.Add(this.GPBCLIENTE);
            this.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRMCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMClientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRMCLIENTS_Load);
            this.GPBCLIENTE.ResumeLayout(false);
            this.GPBCLIENTE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCLIENTES)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GPBCLIENTE;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CMBSEXO;
        private System.Windows.Forms.ComboBox CMBCATEGORIA;
        private System.Windows.Forms.TextBox TXTCODPERSONA;
        private System.Windows.Forms.TextBox TXTNOMBRE;
        private System.Windows.Forms.TextBox TXTNUMSEGSOCIAL;
        private System.Windows.Forms.TextBox TXTAPMATERNO;
        private System.Windows.Forms.TextBox TXTAPPATERNO;
        private System.Windows.Forms.DataGridView DGVCLIENTES;
        private System.Windows.Forms.Button BTNSAVE;
        private System.Windows.Forms.Button BtnBorrar;
        private System.Windows.Forms.TextBox TXTCEDULA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn APPATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn APMATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRES;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEDULA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEXO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMSEGSOCIAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATEGORIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGOPEDIDO;
    }
}