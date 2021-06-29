namespace JuegoRol
{
    partial class CrearPlayer
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_nombre = new System.Windows.Forms.TextBox();
            this.btn_apodo = new System.Windows.Forms.TextBox();
            this.btn_fec_de_nac = new System.Windows.Forms.DateTimePicker();
            this.btn_lista_de_tipos = new System.Windows.Forms.ComboBox();
            this.btn_crear_personaje_nuevo = new System.Windows.Forms.Button();
            this.btn_crear_personaje_aleatorio = new System.Windows.Forms.Button();
            this.btn_mostrar_personajes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apodo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha de nac.";
            // 
            // btn_nombre
            // 
            this.btn_nombre.Location = new System.Drawing.Point(117, 51);
            this.btn_nombre.Name = "btn_nombre";
            this.btn_nombre.Size = new System.Drawing.Size(196, 20);
            this.btn_nombre.TabIndex = 5;
            this.btn_nombre.TextChanged += new System.EventHandler(this.btn_nombre_TextChanged);
            // 
            // btn_apodo
            // 
            this.btn_apodo.Location = new System.Drawing.Point(117, 83);
            this.btn_apodo.Name = "btn_apodo";
            this.btn_apodo.Size = new System.Drawing.Size(196, 20);
            this.btn_apodo.TabIndex = 6;
            this.btn_apodo.TextChanged += new System.EventHandler(this.btn_apodo_TextChanged);
            // 
            // btn_fec_de_nac
            // 
            this.btn_fec_de_nac.Location = new System.Drawing.Point(117, 152);
            this.btn_fec_de_nac.Name = "btn_fec_de_nac";
            this.btn_fec_de_nac.Size = new System.Drawing.Size(196, 20);
            this.btn_fec_de_nac.TabIndex = 7;
            this.btn_fec_de_nac.ValueChanged += new System.EventHandler(this.btn_fec_de_nac_ValueChanged);
            // 
            // btn_lista_de_tipos
            // 
            this.btn_lista_de_tipos.FormattingEnabled = true;
            this.btn_lista_de_tipos.Items.AddRange(new object[] {
            "Ogro",
            "Duende",
            "Burro",
            "Ñeri",
            "EH AMIGO"});
            this.btn_lista_de_tipos.Location = new System.Drawing.Point(117, 120);
            this.btn_lista_de_tipos.Name = "btn_lista_de_tipos";
            this.btn_lista_de_tipos.Size = new System.Drawing.Size(196, 21);
            this.btn_lista_de_tipos.TabIndex = 8;
            this.btn_lista_de_tipos.SelectedIndexChanged += new System.EventHandler(this.btn_lista_de_tipos_SelectedIndexChanged);
            // 
            // btn_crear_personaje_nuevo
            // 
            this.btn_crear_personaje_nuevo.Location = new System.Drawing.Point(16, 189);
            this.btn_crear_personaje_nuevo.Name = "btn_crear_personaje_nuevo";
            this.btn_crear_personaje_nuevo.Size = new System.Drawing.Size(95, 54);
            this.btn_crear_personaje_nuevo.TabIndex = 9;
            this.btn_crear_personaje_nuevo.Text = "Crear Personaje nuevo";
            this.btn_crear_personaje_nuevo.UseVisualStyleBackColor = true;
            this.btn_crear_personaje_nuevo.Click += new System.EventHandler(this.btn_crear_personaje_nuevo_Click);
            // 
            // btn_crear_personaje_aleatorio
            // 
            this.btn_crear_personaje_aleatorio.Location = new System.Drawing.Point(117, 189);
            this.btn_crear_personaje_aleatorio.Name = "btn_crear_personaje_aleatorio";
            this.btn_crear_personaje_aleatorio.Size = new System.Drawing.Size(95, 54);
            this.btn_crear_personaje_aleatorio.TabIndex = 10;
            this.btn_crear_personaje_aleatorio.Text = "Crear Personaje aleatorio";
            this.btn_crear_personaje_aleatorio.UseVisualStyleBackColor = true;
            this.btn_crear_personaje_aleatorio.Click += new System.EventHandler(this.btn_crear_personaje_aleatorio_Click);
            // 
            // btn_mostrar_personajes
            // 
            this.btn_mostrar_personajes.Location = new System.Drawing.Point(218, 189);
            this.btn_mostrar_personajes.Name = "btn_mostrar_personajes";
            this.btn_mostrar_personajes.Size = new System.Drawing.Size(95, 54);
            this.btn_mostrar_personajes.TabIndex = 11;
            this.btn_mostrar_personajes.Text = "Mostrar Personajes creados";
            this.btn_mostrar_personajes.UseVisualStyleBackColor = true;
            this.btn_mostrar_personajes.Click += new System.EventHandler(this.btn_mostrar_personajes_Click);
            // 
            // CrearPlayer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(330, 255);
            this.Controls.Add(this.btn_mostrar_personajes);
            this.Controls.Add(this.btn_crear_personaje_aleatorio);
            this.Controls.Add(this.btn_crear_personaje_nuevo);
            this.Controls.Add(this.btn_lista_de_tipos);
            this.Controls.Add(this.btn_fec_de_nac);
            this.Controls.Add(this.btn_apodo);
            this.Controls.Add(this.btn_nombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "CrearPlayer";
            this.Text = "Crear Jugador/a";
            this.Load += new System.EventHandler(this.CrearPlayer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox btn_nombre;
        private System.Windows.Forms.TextBox btn_apodo;
        private System.Windows.Forms.DateTimePicker btn_fec_de_nac;
        private System.Windows.Forms.ComboBox btn_lista_de_tipos;
        private System.Windows.Forms.Button btn_crear_personaje_nuevo;
        private System.Windows.Forms.Button btn_crear_personaje_aleatorio;
        private System.Windows.Forms.Button btn_mostrar_personajes;
    }
}