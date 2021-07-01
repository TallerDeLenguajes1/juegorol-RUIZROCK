using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Linq;
using JuegoRol.Properties;

namespace JuegoRol
{
    public partial class ventanaPersonaje : Form
    {

        List<Personajes> ListaParticipantes;
        public ventanaPersonaje(List<Personajes> Player)
        {
            InitializeComponent();
            inicializarListaMapa();
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

            mostrarImagenTipo(participante);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = comboBox1.SelectedIndex;
            inicializarPersonaje(ListaParticipantes.ElementAt(i));
        }

        public void mostrarImagenTipo(Personajes personaje)
        {
            switch (personaje.Personaje)
            {
                case tipo.ogro:
                    personaje_img.Image = JuegoRol.Properties.Resources.ogro;
                    break;

                case tipo.duende:
                    personaje_img.Image = JuegoRol.Properties.Resources.duende;
                    break;

                case tipo.burro:
                    personaje_img.Image = JuegoRol.Properties.Resources.burro;
                    break;

                case tipo.nieri:
                    personaje_img.Image = JuegoRol.Properties.Resources.nieri;
                    break;

                case tipo.ehamigo:
                    personaje_img.Image = JuegoRol.Properties.Resources.ehamigo;
                    break;
            }
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


        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void btn_jugar_Click(object sender, EventArgs e)
        {
            if (ListaParticipantes.Count < 2)
            {
                MessageBox.Show("Debe tener al menos 2 personajes creados.");
                Close();
            }
            else
            {
                if (Lista_mapa.SelectedItem == null)
                {
                    MessageBox.Show("Debe elegir un mapa.");
                }
                else
                {
                    IniciarPartida ventanaBatallaNueva = new IniciarPartida(ListaParticipantes);
                    ventanaBatallaNueva.Show();
                    Close();
                }

            }
        }

        private void inicializarListaMapa()
        {
            ProvinciasArgentina listaProvincias;
            listaProvincias = ObtieneProvincias();

            foreach (Provincia Prov in listaProvincias.Provincias)
            {
                Lista_mapa.Items.Add(Prov.Nombre);
            }

            Lista_mapa.Items.Add("Predeterminado");

        }

        private static ProvinciasArgentina ObtieneProvincias()
        {
            var url = $"https://apis.datos.gob.ar/georef/api/provincias?campos=id,nombre";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            ProvinciasArgentina ProvinciasArg;
            ProvinciasArg = null;
            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader != null)
                        {
                            using (StreamReader objReader = new StreamReader(strReader))
                            {
                                string responseBody = objReader.ReadToEnd();
                                ProvinciasArg = JsonSerializer.Deserialize<ProvinciasArgentina>(responseBody);
                            }
                        }
                    }
                }
            }
            catch (WebException)
            {
                // Handle error
            }
            return ProvinciasArg;
        }

        // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
        public class Parametros
        {
            [JsonPropertyName("campos")]
            public List<string> Campos { get; set; }
        }

        public class Provincia
        {
            [JsonPropertyName("id")]
            public string Id { get; set; }

            [JsonPropertyName("nombre")]
            public string Nombre { get; set; }
        }

        public class ProvinciasArgentina
        {
            [JsonPropertyName("cantidad")]
            public int Cantidad { get; set; }

            [JsonPropertyName("inicio")]
            public int Inicio { get; set; }

            [JsonPropertyName("parametros")]
            public Parametros Parametros { get; set; }

            [JsonPropertyName("provincias")]
            public List<Provincia> Provincias { get; set; }

            [JsonPropertyName("total")]
            public int Total { get; set; }
        }

        private void Lista_mapa_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
