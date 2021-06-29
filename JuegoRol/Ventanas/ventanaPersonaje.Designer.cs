namespace JuegoRol
{
    partial class ventanaPersonaje
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
            this.comboBox1_Lista_de_personajes = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.salud = new System.Windows.Forms.Label();
            this.edad = new System.Windows.Forms.Label();
            this.fechadenacimiento = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.Label();
            this.apodo = new System.Windows.Forms.Label();
            this.tipo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.armadura = new System.Windows.Forms.Label();
            this.nivel = new System.Windows.Forms.Label();
            this.destreza = new System.Windows.Forms.Label();
            this.fuerza = new System.Windows.Forms.Label();
            this.velocidad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Btn_guardar_lista_de_personajes = new System.Windows.Forms.Button();
            this.Btn_jugar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1_Lista_de_personajes
            // 
            this.comboBox1_Lista_de_personajes.FormattingEnabled = true;
            this.comboBox1_Lista_de_personajes.Location = new System.Drawing.Point(88, 33);
            this.comboBox1_Lista_de_personajes.Name = "comboBox1_Lista_de_personajes";
            this.comboBox1_Lista_de_personajes.Size = new System.Drawing.Size(80, 21);
            this.comboBox1_Lista_de_personajes.TabIndex = 0;
            this.comboBox1_Lista_de_personajes.SelectedIndexChanged += new System.EventHandler(this.comboBox1_Lista_de_personajes_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.salud);
            this.groupBox1.Controls.Add(this.edad);
            this.groupBox1.Controls.Add(this.fechadenacimiento);
            this.groupBox1.Controls.Add(this.nombre);
            this.groupBox1.Controls.Add(this.apodo);
            this.groupBox1.Controls.Add(this.tipo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 224);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos:";
            // 
            // salud
            // 
            this.salud.AutoSize = true;
            this.salud.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salud.Location = new System.Drawing.Point(26, 188);
            this.salud.Name = "salud";
            this.salud.Size = new System.Drawing.Size(46, 16);
            this.salud.TabIndex = 5;
            this.salud.Text = "Salud:";
            // 
            // edad
            // 
            this.edad.AutoSize = true;
            this.edad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edad.Location = new System.Drawing.Point(26, 158);
            this.edad.Name = "edad";
            this.edad.Size = new System.Drawing.Size(44, 16);
            this.edad.TabIndex = 4;
            this.edad.Text = "Edad:";
            // 
            // fechadenacimiento
            // 
            this.fechadenacimiento.AutoSize = true;
            this.fechadenacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechadenacimiento.Location = new System.Drawing.Point(26, 127);
            this.fechadenacimiento.Name = "fechadenacimiento";
            this.fechadenacimiento.Size = new System.Drawing.Size(99, 16);
            this.fechadenacimiento.TabIndex = 3;
            this.fechadenacimiento.Text = "Fecha de nac. :";
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(26, 65);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(60, 16);
            this.nombre.TabIndex = 2;
            this.nombre.Text = "Nombre:";
            // 
            // apodo
            // 
            this.apodo.AutoSize = true;
            this.apodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apodo.Location = new System.Drawing.Point(26, 95);
            this.apodo.Name = "apodo";
            this.apodo.Size = new System.Drawing.Size(52, 16);
            this.apodo.TabIndex = 1;
            this.apodo.Text = "Apodo:";
            // 
            // tipo
            // 
            this.tipo.AutoSize = true;
            this.tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipo.Location = new System.Drawing.Point(26, 33);
            this.tipo.Name = "tipo";
            this.tipo.Size = new System.Drawing.Size(39, 16);
            this.tipo.TabIndex = 0;
            this.tipo.Text = "Tipo:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.armadura);
            this.groupBox2.Controls.Add(this.nivel);
            this.groupBox2.Controls.Add(this.destreza);
            this.groupBox2.Controls.Add(this.fuerza);
            this.groupBox2.Controls.Add(this.velocidad);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(214, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(197, 224);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Caracteristicas:";
            // 
            // armadura
            // 
            this.armadura.AutoSize = true;
            this.armadura.Location = new System.Drawing.Point(26, 158);
            this.armadura.Name = "armadura";
            this.armadura.Size = new System.Drawing.Size(70, 16);
            this.armadura.TabIndex = 9;
            this.armadura.Text = "Armadura:";
            // 
            // nivel
            // 
            this.nivel.AutoSize = true;
            this.nivel.Location = new System.Drawing.Point(26, 127);
            this.nivel.Name = "nivel";
            this.nivel.Size = new System.Drawing.Size(42, 16);
            this.nivel.TabIndex = 8;
            this.nivel.Text = "Nivel:";
            // 
            // destreza
            // 
            this.destreza.AutoSize = true;
            this.destreza.Location = new System.Drawing.Point(26, 65);
            this.destreza.Name = "destreza";
            this.destreza.Size = new System.Drawing.Size(65, 16);
            this.destreza.TabIndex = 7;
            this.destreza.Text = "Destreza:";
            // 
            // fuerza
            // 
            this.fuerza.AutoSize = true;
            this.fuerza.Location = new System.Drawing.Point(26, 95);
            this.fuerza.Name = "fuerza";
            this.fuerza.Size = new System.Drawing.Size(52, 16);
            this.fuerza.TabIndex = 6;
            this.fuerza.Text = "Fuerza:";
            // 
            // velocidad
            // 
            this.velocidad.AutoSize = true;
            this.velocidad.Location = new System.Drawing.Point(26, 33);
            this.velocidad.Name = "velocidad";
            this.velocidad.Size = new System.Drawing.Size(73, 16);
            this.velocidad.TabIndex = 5;
            this.velocidad.Text = "Velocidad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Personaje:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(9, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(192, 16);
            this.label13.TabIndex = 4;
            this.label13.Text = "Detalle de los Personajes:";
            // 
            // Btn_guardar_lista_de_personajes
            // 
            this.Btn_guardar_lista_de_personajes.Location = new System.Drawing.Point(112, 322);
            this.Btn_guardar_lista_de_personajes.Name = "Btn_guardar_lista_de_personajes";
            this.Btn_guardar_lista_de_personajes.Size = new System.Drawing.Size(96, 41);
            this.Btn_guardar_lista_de_personajes.TabIndex = 5;
            this.Btn_guardar_lista_de_personajes.Text = "Guardar Lista de Personajes";
            this.Btn_guardar_lista_de_personajes.UseVisualStyleBackColor = true;
            this.Btn_guardar_lista_de_personajes.Click += new System.EventHandler(this.Btn_guardar_lista_de_personajes_Click);
            // 
            // Btn_jugar
            // 
            this.Btn_jugar.Location = new System.Drawing.Point(214, 322);
            this.Btn_jugar.Name = "Btn_jugar";
            this.Btn_jugar.Size = new System.Drawing.Size(99, 41);
            this.Btn_jugar.TabIndex = 6;
            this.Btn_jugar.Text = "Jugar!";
            this.Btn_jugar.UseVisualStyleBackColor = true;
            this.Btn_jugar.Click += new System.EventHandler(this.Btn_jugar_Click);
            // 
            // ventanaPersonaje
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(423, 375);
            this.Controls.Add(this.Btn_jugar);
            this.Controls.Add(this.Btn_guardar_lista_de_personajes);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1_Lista_de_personajes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ventanaPersonaje";
            this.Text = "Detalles del Personaje";
            this.Load += new System.EventHandler(this.ventanaPersonaje_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1_Lista_de_personajes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label edad;
        private System.Windows.Forms.Label fechadenacimiento;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label apodo;
        private System.Windows.Forms.Label tipo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label armadura;
        private System.Windows.Forms.Label nivel;
        private System.Windows.Forms.Label destreza;
        private System.Windows.Forms.Label fuerza;
        private System.Windows.Forms.Label velocidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label salud;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button Btn_guardar_lista_de_personajes;
        private System.Windows.Forms.Button Btn_jugar;
    }
}