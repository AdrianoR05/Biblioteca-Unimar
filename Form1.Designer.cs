namespace Biblioteca_Unimar
{
    partial class InterfazMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfazMenu));
            this.Titulo = new System.Windows.Forms.PictureBox();
            this.registro = new System.Windows.Forms.Button();
            this.verPrestamo = new System.Windows.Forms.Button();
            this.sancionados = new System.Windows.Forms.Button();
            this.renovacion = new System.Windows.Forms.Button();
            this.librosDisp = new System.Windows.Forms.Button();
            this.devolucion = new System.Windows.Forms.Button();
            this.ingresarlibro = new System.Windows.Forms.Button();
            this.solicitud = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Titulo)).BeginInit();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Titulo.Image = ((System.Drawing.Image)(resources.GetObject("Titulo.Image")));
            this.Titulo.Location = new System.Drawing.Point(12, 12);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(679, 84);
            this.Titulo.TabIndex = 1;
            this.Titulo.TabStop = false;
            // 
            // registro
            // 
            this.registro.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.registro.Location = new System.Drawing.Point(262, 150);
            this.registro.Name = "registro";
            this.registro.Size = new System.Drawing.Size(153, 29);
            this.registro.TabIndex = 2;
            this.registro.Text = "Registrar Alumno";
            this.registro.UseVisualStyleBackColor = true;
            this.registro.Click += new System.EventHandler(this.registro_Click);
            // 
            // verPrestamo
            // 
            this.verPrestamo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.verPrestamo.Location = new System.Drawing.Point(262, 220);
            this.verPrestamo.Name = "verPrestamo";
            this.verPrestamo.Size = new System.Drawing.Size(153, 29);
            this.verPrestamo.TabIndex = 2;
            this.verPrestamo.Text = "Ver préstamos activos";
            this.verPrestamo.UseVisualStyleBackColor = true;
            // 
            // sancionados
            // 
            this.sancionados.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.sancionados.Location = new System.Drawing.Point(262, 290);
            this.sancionados.Name = "sancionados";
            this.sancionados.Size = new System.Drawing.Size(153, 29);
            this.sancionados.TabIndex = 2;
            this.sancionados.Text = "Alumnos sancionados";
            this.sancionados.UseVisualStyleBackColor = true;
            // 
            // renovacion
            // 
            this.renovacion.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.renovacion.Location = new System.Drawing.Point(262, 325);
            this.renovacion.Name = "renovacion";
            this.renovacion.Size = new System.Drawing.Size(153, 29);
            this.renovacion.TabIndex = 2;
            this.renovacion.Text = "Renovar libro";
            this.renovacion.UseVisualStyleBackColor = true;
            // 
            // librosDisp
            // 
            this.librosDisp.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.librosDisp.Location = new System.Drawing.Point(262, 255);
            this.librosDisp.Name = "librosDisp";
            this.librosDisp.Size = new System.Drawing.Size(153, 29);
            this.librosDisp.TabIndex = 2;
            this.librosDisp.Text = "Libros disponibles";
            this.librosDisp.UseVisualStyleBackColor = true;
            // 
            // devolucion
            // 
            this.devolucion.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.devolucion.Location = new System.Drawing.Point(262, 360);
            this.devolucion.Name = "devolucion";
            this.devolucion.Size = new System.Drawing.Size(153, 29);
            this.devolucion.TabIndex = 2;
            this.devolucion.Text = "Devolución";
            this.devolucion.UseVisualStyleBackColor = true;
            // 
            // ingresarlibro
            // 
            this.ingresarlibro.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ingresarlibro.Location = new System.Drawing.Point(262, 395);
            this.ingresarlibro.Name = "ingresarlibro";
            this.ingresarlibro.Size = new System.Drawing.Size(153, 29);
            this.ingresarlibro.TabIndex = 2;
            this.ingresarlibro.Text = "Ingresar nuevo libro";
            this.ingresarlibro.UseVisualStyleBackColor = true;
            // 
            // solicitud
            // 
            this.solicitud.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.solicitud.Location = new System.Drawing.Point(262, 185);
            this.solicitud.Name = "solicitud";
            this.solicitud.Size = new System.Drawing.Size(153, 29);
            this.solicitud.TabIndex = 2;
            this.solicitud.Text = "Solicitar préstamo";
            this.solicitud.UseVisualStyleBackColor = true;
            // 
            // InterfazMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(704, 484);
            this.Controls.Add(this.ingresarlibro);
            this.Controls.Add(this.devolucion);
            this.Controls.Add(this.renovacion);
            this.Controls.Add(this.solicitud);
            this.Controls.Add(this.librosDisp);
            this.Controls.Add(this.sancionados);
            this.Controls.Add(this.verPrestamo);
            this.Controls.Add(this.registro);
            this.Controls.Add(this.Titulo);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InterfazMenu";
            this.Text = "Biblioteca Unimar";
            this.Load += new System.EventHandler(this.InterfazMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Titulo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox Titulo;
        private System.Windows.Forms.Button registro;
        private System.Windows.Forms.Button verPrestamo;
        private System.Windows.Forms.Button sancionados;
        private System.Windows.Forms.Button renovacion;
        private System.Windows.Forms.Button librosDisp;
        private System.Windows.Forms.Button devolucion;
        private System.Windows.Forms.Button ingresarlibro;
        private System.Windows.Forms.Button solicitud;
    }
}

