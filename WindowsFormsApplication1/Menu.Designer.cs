namespace WindowsFormsApplication1
{
    partial class Menu
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
            this.btnEntradas = new System.Windows.Forms.Button();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.btnPartidos = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnSector = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreditos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEntradas
            // 
            this.btnEntradas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(222)))), ((int)(((byte)(210)))));
            this.btnEntradas.Location = new System.Drawing.Point(162, 91);
            this.btnEntradas.Name = "btnEntradas";
            this.btnEntradas.Size = new System.Drawing.Size(155, 39);
            this.btnEntradas.TabIndex = 0;
            this.btnEntradas.Text = "Entradas";
            this.btnEntradas.UseVisualStyleBackColor = false;
            this.btnEntradas.Click += new System.EventHandler(this.btnEntradas_Click);
            // 
            // btnPedidos
            // 
            this.btnPedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(222)))), ((int)(((byte)(210)))));
            this.btnPedidos.Location = new System.Drawing.Point(500, 91);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(155, 39);
            this.btnPedidos.TabIndex = 1;
            this.btnPedidos.Text = "Pedidos";
            this.btnPedidos.UseVisualStyleBackColor = false;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // btnPartidos
            // 
            this.btnPartidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(222)))), ((int)(((byte)(210)))));
            this.btnPartidos.Location = new System.Drawing.Point(162, 167);
            this.btnPartidos.Name = "btnPartidos";
            this.btnPartidos.Size = new System.Drawing.Size(129, 35);
            this.btnPartidos.TabIndex = 2;
            this.btnPartidos.Text = "Partidos";
            this.btnPartidos.UseVisualStyleBackColor = false;
            this.btnPartidos.Click += new System.EventHandler(this.btnPartidos_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(222)))), ((int)(((byte)(210)))));
            this.btnClientes.Location = new System.Drawing.Point(344, 167);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(129, 35);
            this.btnClientes.TabIndex = 3;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnSector
            // 
            this.btnSector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(222)))), ((int)(((byte)(210)))));
            this.btnSector.Location = new System.Drawing.Point(526, 167);
            this.btnSector.Name = "btnSector";
            this.btnSector.Size = new System.Drawing.Size(129, 35);
            this.btnSector.TabIndex = 4;
            this.btnSector.Text = "Sectores";
            this.btnSector.UseVisualStyleBackColor = false;
            this.btnSector.Click += new System.EventHandler(this.btnSector_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Venta de Entradas";
            // 
            // btnCreditos
            // 
            this.btnCreditos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(184)))), ((int)(((byte)(178)))));
            this.btnCreditos.Location = new System.Drawing.Point(377, 249);
            this.btnCreditos.Margin = new System.Windows.Forms.Padding(0);
            this.btnCreditos.Name = "btnCreditos";
            this.btnCreditos.Size = new System.Drawing.Size(75, 23);
            this.btnCreditos.TabIndex = 6;
            this.btnCreditos.Text = "Créditos";
            this.btnCreditos.UseVisualStyleBackColor = false;
            this.btnCreditos.Click += new System.EventHandler(this.btnCreditos_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(221)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(778, 295);
            this.Controls.Add(this.btnCreditos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSector);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnPartidos);
            this.Controls.Add(this.btnPedidos);
            this.Controls.Add(this.btnEntradas);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEntradas;
        private System.Windows.Forms.Button btnPedidos;
        private System.Windows.Forms.Button btnPartidos;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnSector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreditos;
    }
}