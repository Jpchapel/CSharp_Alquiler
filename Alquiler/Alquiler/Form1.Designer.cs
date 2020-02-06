namespace Alquiler
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.VehiculoDia = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Salir = new System.Windows.Forms.Button();
            this.Vehiculos = new System.Windows.Forms.DataGridView();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Combustible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alquilado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oculto_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oculto_Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // VehiculoDia
            // 
            this.VehiculoDia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.VehiculoDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehiculoDia.ForeColor = System.Drawing.Color.White;
            this.VehiculoDia.Location = new System.Drawing.Point(15, 388);
            this.VehiculoDia.Name = "VehiculoDia";
            this.VehiculoDia.Size = new System.Drawing.Size(424, 20);
            this.VehiculoDia.TabIndex = 23;
            this.VehiculoDia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(424, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "vehículo del día";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(456, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(345, 329);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(93, 23);
            this.Salir.TabIndex = 20;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Vehiculos
            // 
            this.Vehiculos.AllowUserToAddRows = false;
            this.Vehiculos.AllowUserToDeleteRows = false;
            this.Vehiculos.AllowUserToResizeColumns = false;
            this.Vehiculos.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Vehiculos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Vehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Vehiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Marca,
            this.Modelo,
            this.Combustible,
            this.Alquilado,
            this.oculto_id,
            this.oculto_Color});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Vehiculos.DefaultCellStyle = dataGridViewCellStyle5;
            this.Vehiculos.Location = new System.Drawing.Point(15, 138);
            this.Vehiculos.Name = "Vehiculos";
            this.Vehiculos.RowHeadersVisible = false;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Vehiculos.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.Vehiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Vehiculos.Size = new System.Drawing.Size(423, 175);
            this.Vehiculos.TabIndex = 19;
            this.Vehiculos.Click += new System.EventHandler(this.Vehiculos_Click);
            // 
            // Marca
            // 
            this.Marca.DataPropertyName = "Marca";
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            this.Marca.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Marca.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Modelo
            // 
            this.Modelo.DataPropertyName = "Modelo";
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            this.Modelo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Modelo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Combustible
            // 
            this.Combustible.DataPropertyName = "Combustible";
            this.Combustible.HeaderText = "Combustible";
            this.Combustible.Name = "Combustible";
            this.Combustible.ReadOnly = true;
            this.Combustible.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Combustible.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Alquilado
            // 
            this.Alquilado.DataPropertyName = "Alugado";
            this.Alquilado.HeaderText = "Alquilado S/N";
            this.Alquilado.Name = "Alquilado";
            this.Alquilado.ReadOnly = true;
            this.Alquilado.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Alquilado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // oculto_id
            // 
            this.oculto_id.DataPropertyName = "IdVehiculo";
            this.oculto_id.HeaderText = "oculto_id";
            this.oculto_id.Name = "oculto_id";
            this.oculto_id.Visible = false;
            // 
            // oculto_Color
            // 
            this.oculto_Color.DataPropertyName = "Color";
            this.oculto_Color.HeaderText = "oculto_Color";
            this.oculto_Color.Name = "oculto_Color";
            this.oculto_Color.Visible = false;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(14, 118);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(424, 20);
            this.Label1.TabIndex = 18;
            this.Label1.Text = "Seleccione vehículo para alquilar o ver datos do alquiler";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 424);
            this.Controls.Add(this.VehiculoDia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Vehiculos);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "Alquiler de vehiculos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vehiculos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label VehiculoDia;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Button Salir;
        internal System.Windows.Forms.DataGridView Vehiculos;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Combustible;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alquilado;
        private System.Windows.Forms.DataGridViewTextBoxColumn oculto_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn oculto_Color;
    }
}

