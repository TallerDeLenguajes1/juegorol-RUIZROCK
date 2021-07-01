
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
            this.btn_crear_personaje_nuevo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_lista_de_tipos = new System.Windows.Forms.ComboBox();
            this.btn_fec_de_nac = new System.Windows.Forms.DateTimePicker();
            this.btn_crear_personaje = new System.Windows.Forms.Button();
            this.btn_mostrar_personajes = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_nombre = new System.Windows.Forms.TextBox();
            this.btn_apodo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_crear_personaje_nuevo
            // 
            this.btn_crear_personaje_nuevo.Location = new System.Drawing.Point(12, 163);
            this.btn_crear_personaje_nuevo.Name = "btn_crear_personaje_nuevo";
            this.btn_crear_personaje_nuevo.Size = new System.Drawing.Size(97, 37);
            this.btn_crear_personaje_nuevo.TabIndex = 0;
            this.btn_crear_personaje_nuevo.Text = "Crear Personaje nuevo";
            this.btn_crear_personaje_nuevo.UseVisualStyleBackColor = true;
            this.btn_crear_personaje_nuevo.Click += new System.EventHandler(this.btn_crear_personaje_nuevo_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Creá a tu Personaje";
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
            this.btn_lista_de_tipos.Location = new System.Drawing.Point(112, 99);
            this.btn_lista_de_tipos.Name = "btn_lista_de_tipos";
            this.btn_lista_de_tipos.Size = new System.Drawing.Size(216, 21);
            this.btn_lista_de_tipos.TabIndex = 2;
            this.btn_lista_de_tipos.SelectedIndexChanged += new System.EventHandler(this.btn_lista_de_tipos_SelectedIndexChanged);
            // 
            // btn_fec_de_nac
            // 
            this.btn_fec_de_nac.Location = new System.Drawing.Point(112, 126);
            this.btn_fec_de_nac.Name = "btn_fec_de_nac";
            this.btn_fec_de_nac.Size = new System.Drawing.Size(216, 20);
            this.btn_fec_de_nac.TabIndex = 3;
            this.btn_fec_de_nac.ValueChanged += new System.EventHandler(this.btn_fec_de_nac_ValueChanged);
            // 
            // btn_crear_personaje
            // 
            this.btn_crear_personaje.Location = new System.Drawing.Point(115, 163);
            this.btn_crear_personaje.Name = "btn_crear_personaje";
            this.btn_crear_personaje.Size = new System.Drawing.Size(97, 37);
            this.btn_crear_personaje.TabIndex = 4;
            this.btn_crear_personaje.Text = "Crear Personaje aleatoriamente";
            this.btn_crear_personaje.UseVisualStyleBackColor = true;
            this.btn_crear_personaje.Click += new System.EventHandler(this.btn_crear_personaje_Click);
            // 
            // btn_mostrar_personajes
            // 
            this.btn_mostrar_personajes.Location = new System.Drawing.Point(218, 163);
            this.btn_mostrar_personajes.Name = "btn_mostrar_personajes";
            this.btn_mostrar_personajes.Size = new System.Drawing.Size(110, 37);
            this.btn_mostrar_personajes.TabIndex = 5;
            this.btn_mostrar_personajes.Text = "Mostrar Personajes creados";
            this.btn_mostrar_personajes.UseVisualStyleBackColor = true;
            this.btn_mostrar_personajes.Click += new System.EventHandler(this.btn_mostrar_personajes_Click_1);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(12, 50);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(44, 13);
            this.lbl1.TabIndex = 6;
            this.lbl1.Text = "Nombre";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(12, 76);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(38, 13);
            this.lbl2.TabIndex = 7;
            this.lbl2.Text = "Apodo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tipo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fecha de nac.";
            // 
            // btn_nombre
            // 
            this.btn_nombre.Location = new System.Drawing.Point(112, 47);
            this.btn_nombre.Name = "btn_nombre";
            this.btn_nombre.Size = new System.Drawing.Size(163, 20);
            this.btn_nombre.TabIndex = 10;
            this.btn_nombre.TextChanged += new System.EventHandler(this.btn_nombre_TextChanged_1);
            // 
            // btn_apodo
            // 
            this.btn_apodo.Location = new System.Drawing.Point(112, 73);
            this.btn_apodo.Name = "btn_apodo";
            this.btn_apodo.Size = new System.Drawing.Size(163, 20);
            this.btn_apodo.TabIndex = 11;
            this.btn_apodo.TextChanged += new System.EventHandler(this.btn_apodo_TextChanged);
            // 
            // CrearPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 210);
            this.Controls.Add(this.btn_apodo);
            this.Controls.Add(this.btn_nombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btn_mostrar_personajes);
            this.Controls.Add(this.btn_crear_personaje);
            this.Controls.Add(this.btn_fec_de_nac);
            this.Controls.Add(this.btn_lista_de_tipos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_crear_personaje_nuevo);
            this.Name = "CrearPlayer";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_crear_personaje_nuevo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox btn_lista_de_tipos;
        private System.Windows.Forms.DateTimePicker btn_fec_de_nac;
        private System.Windows.Forms.Button btn_crear_personaje;
        private System.Windows.Forms.Button btn_mostrar_personajes;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox btn_nombre;
        private System.Windows.Forms.TextBox btn_apodo;
    }
}

