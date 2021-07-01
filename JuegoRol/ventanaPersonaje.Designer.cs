
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_guardar_lista_de_jugadores = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_apodo = new System.Windows.Forms.Label();
            this.lbl_fecnac = new System.Windows.Forms.Label();
            this.lbl_edad = new System.Windows.Forms.Label();
            this.lbl_salud = new System.Windows.Forms.Label();
            this.lbl_armadura = new System.Windows.Forms.Label();
            this.lbl_nivel = new System.Windows.Forms.Label();
            this.lbl_fuerza = new System.Windows.Forms.Label();
            this.lbl_destreza = new System.Windows.Forms.Label();
            this.lbl_velocidad = new System.Windows.Forms.Label();
            this.btn_jugar = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personaje";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(71, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_guardar_lista_de_jugadores
            // 
            this.btn_guardar_lista_de_jugadores.Location = new System.Drawing.Point(71, 268);
            this.btn_guardar_lista_de_jugadores.Name = "btn_guardar_lista_de_jugadores";
            this.btn_guardar_lista_de_jugadores.Size = new System.Drawing.Size(85, 37);
            this.btn_guardar_lista_de_jugadores.TabIndex = 2;
            this.btn_guardar_lista_de_jugadores.Text = "Guardar lista de personajes";
            this.btn_guardar_lista_de_jugadores.UseVisualStyleBackColor = true;
            this.btn_guardar_lista_de_jugadores.Click += new System.EventHandler(this.btn_guardar_lista_de_jugadores_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_salud);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lbl_edad);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lbl_fecnac);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbl_apodo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbl_nombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbl_tipo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(11, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(145, 196);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_armadura);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.lbl_nivel);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lbl_fuerza);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lbl_velocidad);
            this.groupBox2.Controls.Add(this.lbl_destreza);
            this.groupBox2.Location = new System.Drawing.Point(162, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(145, 196);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Caracteristicas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Apodo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fec. de nac.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Edad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Salud";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Velocidad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Destreza";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Fuerza";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Nivel";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 129);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Armadura";
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.Location = new System.Drawing.Point(89, 27);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(0, 13);
            this.lbl_tipo.TabIndex = 7;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(89, 53);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(0, 13);
            this.lbl_nombre.TabIndex = 8;
            // 
            // lbl_apodo
            // 
            this.lbl_apodo.AutoSize = true;
            this.lbl_apodo.Location = new System.Drawing.Point(89, 78);
            this.lbl_apodo.Name = "lbl_apodo";
            this.lbl_apodo.Size = new System.Drawing.Size(0, 13);
            this.lbl_apodo.TabIndex = 9;
            // 
            // lbl_fecnac
            // 
            this.lbl_fecnac.AutoSize = true;
            this.lbl_fecnac.Location = new System.Drawing.Point(89, 102);
            this.lbl_fecnac.Name = "lbl_fecnac";
            this.lbl_fecnac.Size = new System.Drawing.Size(0, 13);
            this.lbl_fecnac.TabIndex = 10;
            // 
            // lbl_edad
            // 
            this.lbl_edad.AutoSize = true;
            this.lbl_edad.Location = new System.Drawing.Point(89, 129);
            this.lbl_edad.Name = "lbl_edad";
            this.lbl_edad.Size = new System.Drawing.Size(0, 13);
            this.lbl_edad.TabIndex = 11;
            // 
            // lbl_salud
            // 
            this.lbl_salud.AutoSize = true;
            this.lbl_salud.Location = new System.Drawing.Point(89, 154);
            this.lbl_salud.Name = "lbl_salud";
            this.lbl_salud.Size = new System.Drawing.Size(0, 13);
            this.lbl_salud.TabIndex = 12;
            // 
            // lbl_armadura
            // 
            this.lbl_armadura.AutoSize = true;
            this.lbl_armadura.Location = new System.Drawing.Point(81, 128);
            this.lbl_armadura.Name = "lbl_armadura";
            this.lbl_armadura.Size = new System.Drawing.Size(0, 13);
            this.lbl_armadura.TabIndex = 18;
            // 
            // lbl_nivel
            // 
            this.lbl_nivel.AutoSize = true;
            this.lbl_nivel.Location = new System.Drawing.Point(81, 103);
            this.lbl_nivel.Name = "lbl_nivel";
            this.lbl_nivel.Size = new System.Drawing.Size(0, 13);
            this.lbl_nivel.TabIndex = 17;
            // 
            // lbl_fuerza
            // 
            this.lbl_fuerza.AutoSize = true;
            this.lbl_fuerza.Location = new System.Drawing.Point(81, 76);
            this.lbl_fuerza.Name = "lbl_fuerza";
            this.lbl_fuerza.Size = new System.Drawing.Size(0, 13);
            this.lbl_fuerza.TabIndex = 16;
            // 
            // lbl_destreza
            // 
            this.lbl_destreza.AutoSize = true;
            this.lbl_destreza.Location = new System.Drawing.Point(81, 52);
            this.lbl_destreza.Name = "lbl_destreza";
            this.lbl_destreza.Size = new System.Drawing.Size(0, 13);
            this.lbl_destreza.TabIndex = 15;
            // 
            // lbl_velocidad
            // 
            this.lbl_velocidad.AutoSize = true;
            this.lbl_velocidad.Location = new System.Drawing.Point(81, 27);
            this.lbl_velocidad.Name = "lbl_velocidad";
            this.lbl_velocidad.Size = new System.Drawing.Size(0, 13);
            this.lbl_velocidad.TabIndex = 14;
            // 
            // btn_jugar
            // 
            this.btn_jugar.Location = new System.Drawing.Point(162, 268);
            this.btn_jugar.Name = "btn_jugar";
            this.btn_jugar.Size = new System.Drawing.Size(75, 37);
            this.btn_jugar.TabIndex = 5;
            this.btn_jugar.Text = "Jugar!";
            this.btn_jugar.UseVisualStyleBackColor = true;
            this.btn_jugar.Click += new System.EventHandler(this.btn_jugar_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(59, 9);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(195, 16);
            this.label24.TabIndex = 6;
            this.label24.Text = "Detalles de los personajes";
            // 
            // ventanaPersonaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 314);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.btn_jugar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_guardar_lista_de_jugadores);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "ventanaPersonaje";
            this.Text = "ventanaPersonaje";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_guardar_lista_de_jugadores;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_salud;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_edad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_fecnac;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_apodo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_armadura;
        private System.Windows.Forms.Label lbl_nivel;
        private System.Windows.Forms.Label lbl_fuerza;
        private System.Windows.Forms.Label lbl_destreza;
        private System.Windows.Forms.Label lbl_velocidad;
        private System.Windows.Forms.Button btn_jugar;
        private System.Windows.Forms.Label label24;
    }
}