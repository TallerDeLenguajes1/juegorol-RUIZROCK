using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoRol
{
    public partial class ventanaPersonaje : Form
    {

        List<Personajes> ListaParticipantes;
        public ventanaPersonaje(List<Personajes> Player)
        {
            InitializeComponent();
            this.ListaParticipantes = Player;
            inicializarComboBox();
        }

        private void inicializarComboBox()
        {
            foreach (Personajes personaje in ListaParticipantes)
            {
                comboBox1.Items.Add(personaje.Nombre);
            }

            comboBox1.SelectedIndex = 0;
        }

        //cargar detalles de los personajes para visualizar

        private void inicializarPersonaje(Personajes participante)
        {
            lbl_nombre.Text = participante.Nombre;
            lbl_salud.Text = Convert.ToString(participante.Salud);
            DateTime fechaSola = participante.FechaDeNacimiento.Date;
            lbl_fecnac.Text = fechaSola.ToString("d");
            lbl_edad.Text = Convert.ToString(participante.Edad);



            lbl_nivel.Text = Convert.ToString(participante.Nivel);
            lbl_tipo.Text = Convert.ToString(participante.Personaje);
            lbl_apodo.Text = participante.Apodo;
            lbl_velocidad.Text = Convert.ToString(participante.Velocidad);
            lbl_destreza.Text = Convert.ToString(participante.Destreza);
            lbl_fuerza.Text = Convert.ToString(participante.Fuerza);
            lbl_armadura.Text = Convert.ToString(participante.Armadura);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = comboBox1.SelectedIndex;
            inicializarPersonaje(ListaParticipantes.ElementAt(i));
        }

        private void btn_guardar_lista_de_jugadores_Click(object sender, EventArgs e)
        {
            guardarArchivoCSV();
            guardarArchivoJson();

            MessageBox.Show("Jugadores Cargados", "Guardando Lista de Personajes");
        }

        //guargar archivos CSV y Json

        private void guardarArchivoCSV()
        {
            FileStream jugadores = new FileStream("ListaJugadores.csv", FileMode.Create);
            StreamWriter escribirJugadore = new StreamWriter(jugadores);

            foreach (Personajes personaje in ListaParticipantes)
            {
                escribirJugadore.WriteLine("{0};{1};{2}", personaje.Nombre, personaje.Personaje, personaje.Salud);
            }
            escribirJugadore.Close();
        }

        private void guardarArchivoJson()
        {

            FileStream jugadores = new FileStream("ListaJugadores.Json", FileMode.Create);
            StreamWriter escribirJugadore = new StreamWriter(jugadores);

            foreach (Personajes personaje in ListaParticipantes)
            {
                string strJson = JsonSerializer.Serialize(personaje);
                escribirJugadore.WriteLine("{0}", strJson);
            }
            escribirJugadore.Close();
        }

        private void btn_jugar_Click(object sender, EventArgs e)
        {
            IniciarPartida ventanaPartida = new IniciarPartida(ListaParticipantes);
            ventanaPartida.Show();
            Close();
        }
    }
}
