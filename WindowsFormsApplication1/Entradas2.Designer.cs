namespace WindowsFormsApplication1
{
    partial class Entradas2
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
            this.txtIdEntrada = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdSector = new System.Windows.Forms.TextBox();
            this.idSector = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.idPartido = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtIdPartido = new System.Windows.Forms.TextBox();
            this.dvgEntradas = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnElimiinar = new System.Windows.Forms.Button();
            this.cboPartidos = new System.Windows.Forms.ComboBox();
            this.cboSector = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTorneo = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblSector = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgEntradas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdEntrada
            // 
            this.txtIdEntrada.Location = new System.Drawing.Point(397, 11);
            this.txtIdEntrada.Name = "txtIdEntrada";
            this.txtIdEntrada.Size = new System.Drawing.Size(152, 20);
            this.txtIdEntrada.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "idEntrada";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(397, 45);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(152, 20);
            this.txtPrecio.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Precio";
            // 
            // txtIdSector
            // 
            this.txtIdSector.Location = new System.Drawing.Point(688, 11);
            this.txtIdSector.Name = "txtIdSector";
            this.txtIdSector.Size = new System.Drawing.Size(116, 20);
            this.txtIdSector.TabIndex = 4;
            // 
            // idSector
            // 
            this.idSector.AutoSize = true;
            this.idSector.Location = new System.Drawing.Point(610, 17);
            this.idSector.Name = "idSector";
            this.idSector.Size = new System.Drawing.Size(52, 12);
            this.idSector.TabIndex = 5;
            this.idSector.Text = "idSector";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "stock";
            // 
            // idPartido
            // 
            this.idPartido.AutoSize = true;
            this.idPartido.Location = new System.Drawing.Point(610, 52);
            this.idPartido.Name = "idPartido";
            this.idPartido.Size = new System.Drawing.Size(55, 12);
            this.idPartido.TabIndex = 7;
            this.idPartido.Text = "idPartido";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(397, 90);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(152, 20);
            this.txtStock.TabIndex = 8;
            // 
            // txtIdPartido
            // 
            this.txtIdPartido.Location = new System.Drawing.Point(688, 48);
            this.txtIdPartido.Name = "txtIdPartido";
            this.txtIdPartido.Size = new System.Drawing.Size(116, 20);
            this.txtIdPartido.TabIndex = 9;
            // 
            // dvgEntradas
            // 
            this.dvgEntradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgEntradas.Location = new System.Drawing.Point(357, 129);
            this.dvgEntradas.Name = "dvgEntradas";
            this.dvgEntradas.Size = new System.Drawing.Size(626, 193);
            this.dvgEntradas.TabIndex = 10;
            this.dvgEntradas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgEntradas_CellClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(222)))), ((int)(((byte)(210)))));
            this.btnAgregar.Location = new System.Drawing.Point(23, 17);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(97, 47);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(222)))), ((int)(((byte)(210)))));
            this.btnEditar.Location = new System.Drawing.Point(23, 70);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(97, 46);
            this.btnEditar.TabIndex = 12;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnElimiinar
            // 
            this.btnElimiinar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(222)))), ((int)(((byte)(210)))));
            this.btnElimiinar.Location = new System.Drawing.Point(23, 129);
            this.btnElimiinar.Name = "btnElimiinar";
            this.btnElimiinar.Size = new System.Drawing.Size(97, 50);
            this.btnElimiinar.TabIndex = 13;
            this.btnElimiinar.Text = "Eliminar";
            this.btnElimiinar.UseVisualStyleBackColor = false;
            this.btnElimiinar.Click += new System.EventHandler(this.btnElimiinar_Click);
            // 
            // cboPartidos
            // 
            this.cboPartidos.FormattingEnabled = true;
            this.cboPartidos.Location = new System.Drawing.Point(14, 233);
            this.cboPartidos.Name = "cboPartidos";
            this.cboPartidos.Size = new System.Drawing.Size(140, 20);
            this.cboPartidos.TabIndex = 14;
            this.cboPartidos.SelectedIndexChanged += new System.EventHandler(this.cboPartidos_SelectedIndexChanged);
            // 
            // cboSector
            // 
            this.cboSector.FormattingEnabled = true;
            this.cboSector.Location = new System.Drawing.Point(205, 233);
            this.cboSector.Name = "cboSector";
            this.cboSector.Size = new System.Drawing.Size(140, 20);
            this.cboSector.TabIndex = 15;
            this.cboSector.SelectedIndexChanged += new System.EventHandler(this.cboSector_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 12);
            this.label4.TabIndex = 16;
            this.label4.Text = "Torneo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 12);
            this.label5.TabIndex = 17;
            this.label5.Text = "Fecha:";
            // 
            // lblTorneo
            // 
            this.lblTorneo.AutoSize = true;
            this.lblTorneo.Location = new System.Drawing.Point(79, 310);
            this.lblTorneo.Name = "lblTorneo";
            this.lblTorneo.Size = new System.Drawing.Size(0, 12);
            this.lblTorneo.TabIndex = 18;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(79, 271);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(0, 12);
            this.lblFecha.TabIndex = 19;
            // 
            // lblSector
            // 
            this.lblSector.AutoSize = true;
            this.lblSector.Location = new System.Drawing.Point(264, 271);
            this.lblSector.Name = "lblSector";
            this.lblSector.Size = new System.Drawing.Size(0, 12);
            this.lblSector.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(202, 271);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 12);
            this.label9.TabIndex = 21;
            this.label9.Text = "Nombre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 12);
            this.label6.TabIndex = 22;
            this.label6.Text = "Buscar Partido por ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(213, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 12);
            this.label7.TabIndex = 23;
            this.label7.Text = "Buscar Sector por Id";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(222)))), ((int)(((byte)(210)))));
            this.btnVolver.Location = new System.Drawing.Point(908, 11);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 24;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // Entradas2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(221)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(997, 346);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblSector);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblTorneo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboSector);
            this.Controls.Add(this.cboPartidos);
            this.Controls.Add(this.btnElimiinar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dvgEntradas);
            this.Controls.Add(this.txtIdPartido);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.idPartido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.idSector);
            this.Controls.Add(this.txtIdSector);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdEntrada);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Entradas2";
            this.Text = "Entradas";
            this.Load += new System.EventHandler(this.Entradas2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgEntradas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdEntrada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdSector;
        private System.Windows.Forms.Label idSector;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label idPartido;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtIdPartido;
        private System.Windows.Forms.DataGridView dvgEntradas;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnElimiinar;
        private System.Windows.Forms.ComboBox cboPartidos;
        private System.Windows.Forms.ComboBox cboSector;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTorneo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblSector;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnVolver;
    }
}