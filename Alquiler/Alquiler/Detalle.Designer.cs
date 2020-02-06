namespace Alquiler
{
    partial class Detalle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Detalle));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ApellidosNombre = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Salir = new System.Windows.Forms.Button();
            this.Devolver = new System.Windows.Forms.Button();
            this.Alquilar = new System.Windows.Forms.Button();
            this.NumeroDias = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.FechaAlquiler = new System.Windows.Forms.DateTimePicker();
            this.Combustible = new System.Windows.Forms.Label();
            this.Color = new System.Windows.Forms.Label();
            this.Modelo = new System.Windows.Forms.Label();
            this.Marca = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(338, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // ApellidosNombre
            // 
            this.ApellidosNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApellidosNombre.Location = new System.Drawing.Point(13, 171);
            this.ApellidosNombre.Name = "ApellidosNombre";
            this.ApellidosNombre.Size = new System.Drawing.Size(306, 21);
            this.ApellidosNombre.TabIndex = 52;
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Label3.Location = new System.Drawing.Point(13, 154);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(306, 17);
            this.Label3.TabIndex = 51;
            this.Label3.Text = "Apellidos y Nombre";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(226, 264);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(93, 23);
            this.Salir.TabIndex = 50;
            this.Salir.Text = "Salír";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Devolver
            // 
            this.Devolver.Location = new System.Drawing.Point(127, 264);
            this.Devolver.Name = "Devolver";
            this.Devolver.Size = new System.Drawing.Size(93, 23);
            this.Devolver.TabIndex = 49;
            this.Devolver.Text = "Devolver";
            this.Devolver.UseVisualStyleBackColor = true;
            this.Devolver.Click += new System.EventHandler(this.Devolver_Click);
            // 
            // Alquilar
            // 
            this.Alquilar.Location = new System.Drawing.Point(28, 264);
            this.Alquilar.Name = "Alquilar";
            this.Alquilar.Size = new System.Drawing.Size(93, 23);
            this.Alquilar.TabIndex = 48;
            this.Alquilar.Text = "Alquilar";
            this.Alquilar.UseVisualStyleBackColor = true;
            this.Alquilar.Click += new System.EventHandler(this.Alquilar_Click);
            // 
            // NumeroDias
            // 
            this.NumeroDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeroDias.Location = new System.Drawing.Point(211, 220);
            this.NumeroDias.Name = "NumeroDias";
            this.NumeroDias.Size = new System.Drawing.Size(108, 21);
            this.NumeroDias.TabIndex = 47;
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Label2.Location = new System.Drawing.Point(211, 203);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(108, 17);
            this.Label2.TabIndex = 46;
            this.Label2.Text = "número de días";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Label1.Location = new System.Drawing.Point(13, 203);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(176, 17);
            this.Label1.TabIndex = 45;
            this.Label1.Text = "Fecha Alquiler";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FechaAlquiler
            // 
            this.FechaAlquiler.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaAlquiler.Location = new System.Drawing.Point(13, 221);
            this.FechaAlquiler.Name = "FechaAlquiler";
            this.FechaAlquiler.Size = new System.Drawing.Size(176, 20);
            this.FechaAlquiler.TabIndex = 44;
            // 
            // Combustible
            // 
            this.Combustible.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Combustible.ForeColor = System.Drawing.Color.White;
            this.Combustible.Location = new System.Drawing.Point(183, 125);
            this.Combustible.Name = "Combustible";
            this.Combustible.Size = new System.Drawing.Size(136, 20);
            this.Combustible.TabIndex = 43;
            this.Combustible.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Color
            // 
            this.Color.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Color.ForeColor = System.Drawing.Color.White;
            this.Color.Location = new System.Drawing.Point(13, 125);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(164, 20);
            this.Color.TabIndex = 42;
            this.Color.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Modelo
            // 
            this.Modelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Modelo.ForeColor = System.Drawing.Color.White;
            this.Modelo.Location = new System.Drawing.Point(183, 101);
            this.Modelo.Name = "Modelo";
            this.Modelo.Size = new System.Drawing.Size(136, 20);
            this.Modelo.TabIndex = 41;
            this.Modelo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Marca
            // 
            this.Marca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Marca.ForeColor = System.Drawing.Color.White;
            this.Marca.Location = new System.Drawing.Point(13, 101);
            this.Marca.Name = "Marca";
            this.Marca.Size = new System.Drawing.Size(164, 20);
            this.Marca.TabIndex = 40;
            this.Marca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Detalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 319);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ApellidosNombre);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Devolver);
            this.Controls.Add(this.Alquilar);
            this.Controls.Add(this.NumeroDias);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.FechaAlquiler);
            this.Controls.Add(this.Combustible);
            this.Controls.Add(this.Color);
            this.Controls.Add(this.Modelo);
            this.Controls.Add(this.Marca);
            this.Name = "Detalle";
            this.Text = "Detalle";
            this.Load += new System.EventHandler(this.Detalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.TextBox ApellidosNombre;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Button Salir;
        internal System.Windows.Forms.Button Devolver;
        internal System.Windows.Forms.Button Alquilar;
        internal System.Windows.Forms.TextBox NumeroDias;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.DateTimePicker FechaAlquiler;
        internal System.Windows.Forms.Label Combustible;
        internal System.Windows.Forms.Label Color;
        internal System.Windows.Forms.Label Modelo;
        internal System.Windows.Forms.Label Marca;
    }
}