namespace ProjectD20_2._0
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
            this.pestañasProyecto = new System.Windows.Forms.TabControl();
            this.personajes = new System.Windows.Forms.TabPage();
            this.borrarTodo = new System.Windows.Forms.Button();
            this.panelPJ = new System.Windows.Forms.Panel();
            this.generarTirada = new System.Windows.Forms.Button();
            this.añadirPJ = new System.Windows.Forms.Button();
            this.tesoro = new System.Windows.Forms.TabPage();
            this.tablas = new System.Windows.Forms.TabPage();
            this.pestañasProyecto.SuspendLayout();
            this.personajes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pestañasProyecto
            // 
            this.pestañasProyecto.Controls.Add(this.personajes);
            this.pestañasProyecto.Controls.Add(this.tesoro);
            this.pestañasProyecto.Controls.Add(this.tablas);
            this.pestañasProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pestañasProyecto.Location = new System.Drawing.Point(0, 0);
            this.pestañasProyecto.Name = "pestañasProyecto";
            this.pestañasProyecto.SelectedIndex = 0;
            this.pestañasProyecto.Size = new System.Drawing.Size(1135, 662);
            this.pestañasProyecto.TabIndex = 0;
            // 
            // personajes
            // 
            this.personajes.Controls.Add(this.borrarTodo);
            this.personajes.Controls.Add(this.panelPJ);
            this.personajes.Controls.Add(this.generarTirada);
            this.personajes.Controls.Add(this.añadirPJ);
            this.personajes.Location = new System.Drawing.Point(4, 25);
            this.personajes.Name = "personajes";
            this.personajes.Padding = new System.Windows.Forms.Padding(3);
            this.personajes.Size = new System.Drawing.Size(1127, 633);
            this.personajes.TabIndex = 0;
            this.personajes.Text = "Personajes";
            this.personajes.UseVisualStyleBackColor = true;
            // 
            // borrarTodo
            // 
            this.borrarTodo.Location = new System.Drawing.Point(184, 24);
            this.borrarTodo.Name = "borrarTodo";
            this.borrarTodo.Size = new System.Drawing.Size(120, 35);
            this.borrarTodo.TabIndex = 3;
            this.borrarTodo.Text = "Borrar todo";
            this.borrarTodo.UseVisualStyleBackColor = true;
            // 
            // panelPJ
            // 
            this.panelPJ.AutoScroll = true;
            this.panelPJ.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPJ.Location = new System.Drawing.Point(15, 75);
            this.panelPJ.Name = "panelPJ";
            this.panelPJ.Size = new System.Drawing.Size(1071, 506);
            this.panelPJ.TabIndex = 2;
            this.panelPJ.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.panelPJ_ControlAdded);
            // 
            // generarTirada
            // 
            this.generarTirada.Location = new System.Drawing.Point(348, 24);
            this.generarTirada.Name = "generarTirada";
            this.generarTirada.Size = new System.Drawing.Size(120, 35);
            this.generarTirada.TabIndex = 1;
            this.generarTirada.Text = "Tirada";
            this.generarTirada.UseVisualStyleBackColor = true;
            // 
            // añadirPJ
            // 
            this.añadirPJ.Location = new System.Drawing.Point(25, 24);
            this.añadirPJ.Name = "añadirPJ";
            this.añadirPJ.Size = new System.Drawing.Size(120, 35);
            this.añadirPJ.TabIndex = 0;
            this.añadirPJ.Text = "Añadir PJ";
            this.añadirPJ.UseVisualStyleBackColor = true;
            this.añadirPJ.Click += new System.EventHandler(this.añadirPJ_Click);
            // 
            // tesoro
            // 
            this.tesoro.Location = new System.Drawing.Point(4, 25);
            this.tesoro.Name = "tesoro";
            this.tesoro.Padding = new System.Windows.Forms.Padding(3);
            this.tesoro.Size = new System.Drawing.Size(1107, 633);
            this.tesoro.TabIndex = 1;
            this.tesoro.Text = "Tesoro";
            this.tesoro.UseVisualStyleBackColor = true;
            // 
            // tablas
            // 
            this.tablas.Location = new System.Drawing.Point(4, 25);
            this.tablas.Name = "tablas";
            this.tablas.Size = new System.Drawing.Size(1107, 633);
            this.tablas.TabIndex = 2;
            this.tablas.Text = "Tablas";
            this.tablas.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 662);
            this.Controls.Add(this.pestañasProyecto);
            this.Name = "Form1";
            this.Text = "ProjectD20 2.0";
            this.pestañasProyecto.ResumeLayout(false);
            this.personajes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl pestañasProyecto;
        private System.Windows.Forms.TabPage personajes;
        private System.Windows.Forms.TabPage tesoro;
        private System.Windows.Forms.TabPage tablas;
        private System.Windows.Forms.Panel panelPJ;
        private System.Windows.Forms.Button generarTirada;
        private System.Windows.Forms.Button añadirPJ;
        private System.Windows.Forms.Button borrarTodo;
    }
}

