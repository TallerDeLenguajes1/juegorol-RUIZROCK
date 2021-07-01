using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoRol
{
    public partial class CrearPlayer : Form
    {
        //instanciar lista de personajes y lista de nombres de los perrsonajes
        List<Personajes> personajesDelJuego = new List<Personajes>();

        public CrearPlayer()
        {
            InitializeComponent();
        }

        private void setearFechaDeNacimiento()
        {
            btn_fec_de_nac.CustomFormat = "dd/MM/yyyy";
            btn_fec_de_nac.Format = DateTimePickerFormat.Custom;
        }

        //campos para llenar

        private void btn_nombre_TextChanged_1(object sender, EventArgs e)
        {
            habilitarBotonCrearPersonaje();
        }

        private void btn_apodo_TextChanged(object sender, EventArgs e)
        {
            habilitarBotonCrearPersonaje();
        }

        private void btn_lista_de_tipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            habilitarBotonCrearPersonaje();
        }

        private void btn_fec_de_nac_ValueChanged(object sender, EventArgs e)
        {
            habilitarBotonCrearPersonaje();
        }

        //crear Personaje

        private void habilitarBotonCrearPersonaje()
        {
                btn_crear_personaje_nuevo.Enabled = camposLlenos();
        }

        private bool camposLlenos()
        {
            return btn_lista_de_tipos.SelectedIndex != -1 && btn_nombre.TextLength != 0 && btn_apodo.TextLength != 0;
        }

        private void btn_crear_personaje_nuevo_Click_1(object sender, EventArgs e)
        {
            Personajes NuevoPersonaje = new Personajes();
            CrearPersonaje(NuevoPersonaje);
            personajesDelJuego.Add(NuevoPersonaje);
            limpiarDatos();
        }

        public void limpiarDatos()
        {
            btn_nombre.Text = "";
            btn_apodo.Text = "";
            btn_fec_de_nac.Value = DateTime.Now;
        }

        private void CrearPersonaje(Personajes NuevoPLAYER)
        {
            //asignacion de datos
            NuevoPLAYER.Nombre = btn_nombre.Text;
            NuevoPLAYER.Personaje = (tipo)btn_lista_de_tipos.SelectedIndex;
            NuevoPLAYER.Apodo = btn_apodo.Text;
            NuevoPLAYER.FechaDeNacimiento = btn_fec_de_nac.Value;
            NuevoPLAYER.Edad = CrearPlayerGenerico.generadorEdad(NuevoPLAYER.FechaDeNacimiento);

            //asignacion de caracteristicas
            NuevoPLAYER.Velocidad = CrearPlayerGenerico.genererVelocidad();
            NuevoPLAYER.Destreza = CrearPlayerGenerico.genererDestreza();
            NuevoPLAYER.Fuerza = CrearPlayerGenerico.genererFuerza();
            NuevoPLAYER.Armadura = CrearPlayerGenerico.genererArmadura();

        }

        //Mostrar personajes y Abrir ventana personaje
        private void btn_mostrar_personajes_Click_1(object sender, EventArgs e)
        {
            ventanaPersonaje ventanaDatos = new ventanaPersonaje(personajesDelJuego);
            ventanaDatos.Show();
        }

        /**************
        ***************
        ***************
        ***************/

        //Crear jugadores aleatorios

        private void btRellenar(Personajes NuevoSLAYER)
        {
            btn_nombre.Text = CrearPlayerGenerico.generarNombre();
            btn_apodo.Text = CrearPlayerGenerico.generarApodo();
            btn_lista_de_tipos.SelectedItem = generarTipo();
            btn_fec_de_nac.Value = CrearPlayerGenerico.generadorFechaNacimiento();
            NuevoSLAYER.Velocidad = CrearPlayerGenerico.genererVelocidad();
            NuevoSLAYER.Destreza = CrearPlayerGenerico.genererDestreza();
            NuevoSLAYER.Fuerza = CrearPlayerGenerico.genererFuerza();
            NuevoSLAYER.Armadura = CrearPlayerGenerico.genererArmadura();
        }

        private string generarTipo()
        {
            Random random = new Random();
            int num = random.Next(5);
            string tipo;

            switch (num)
            {
                case 0:
                    tipo = "Ogro";
                    break;
                case 1:
                    tipo = "Duende";
                    break;
                case 2:
                    tipo = "burro";
                    break;
                case 3:
                    tipo = "ñeri";
                    break;
                default:
                    tipo = "EH AMIGO";
                    break;
            }

            return tipo;
        }


        private void btn_crear_personaje_Click(object sender, EventArgs e)
        {
            Personajes NuevoSLAYER = new Personajes();
            btRellenar(NuevoSLAYER);
        }

    }
}
