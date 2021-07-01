using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoRol
{
    public partial class IniciarPartida : Form
    {
        List<Personajes> personajesPartida;
        int numAtaque;

        private const int MDP = 5000;

        public IniciarPartida(List<Personajes> personaje)
        {
            InitializeComponent();
            this.personajesPartida = personaje;
        }

        private void inicializarVentana(List<Personajes> participantes)
        {
            numAtaque = 0;
            NOMBREP1.Text = personajesPartida.ElementAt(0).Nombre;
            NOMBREP2.Text = personajesPartida.ElementAt(1).Nombre;
            SALUDP1.Text = personajesPartida.ElementAt(0).Salud.ToString();
            SALUDP2.Text = personajesPartida.ElementAt(1).Salud.ToString();
            btn_iniciar_partida.Enabled = true;
            btn_iniciar_partida.Text = "Iniciar Batalla";
            btn_siguiente_partida.Enabled = false;
        }

        private void btn_iniciar_partida_Click(object sender, EventArgs e)
        {
            if (numAtaque < 100 && siguenVivos() == 1)
            {

                Personajes personaje1 = personajesPartida.ElementAt(0);
                Personajes personaje2 = personajesPartida.ElementAt(1);
                inicializarPersonaje(personaje1, personaje2);
                actualizarVentanaBatalla(personaje1, personaje2, numAtaque);


                numAtaque++;
            }
            else
            {

                btn_iniciar_partida.Enabled = false;
                btn_siguiente_partida.Enabled = true;
                if (personajesPartida.ElementAt(0).Salud < personajesPartida.ElementAt(1).Salud)
                {
                    Ganador.Text = "Gana " + NOMBREP2.Text;
                    personajesPartida.RemoveAt(0);
                    premioGanador(personajesPartida.ElementAt(0));

                }
                else
                {
                    Ganador.Text = "Gana " + NOMBREP1.Text;
                    personajesPartida.RemoveAt(1);
                    premioGanador(personajesPartida.ElementAt(0));

                }
            }
        }

        private void inicializarPersonaje(Personajes participante1, Personajes participante2)
        {
            NOMBREP1.Text = participante1.Nombre;
            NOMBREP2.Text = participante2.Nombre;

            NIVELP1.Text = Convert.ToString(participante1.Nivel);
            TIPOP1.Text = Convert.ToString(participante1.Personaje);
            APODOP1.Text = participante1.Apodo;
            VELOCIDADP1.Text = Convert.ToString(participante1.Velocidad);
            DESTREZAP1.Text = Convert.ToString(participante1.Destreza);
            FUERZAP1.Text = Convert.ToString(participante1.Fuerza);
            ARMADURAP1.Text = Convert.ToString(participante1.Armadura);

            NIVELP2.Text = Convert.ToString(participante2.Nivel);
            TIPOP2.Text = Convert.ToString(participante2.Personaje);
            APODOP2.Text = participante2.Apodo;
            VELOCIDADP2.Text = Convert.ToString(participante2.Velocidad);
            DESTREZAP2.Text = Convert.ToString(participante2.Destreza);
            FUERZAP2.Text = Convert.ToString(participante2.Fuerza);
            ARMADURAP2.Text = Convert.ToString(participante2.Armadura);

        }

        private void btn_siguiente_partida_Click(object sender, EventArgs e)
        {
            if (personajesPartida.Count != 1)
            {
                inicializarVentana(personajesPartida);
            }
            else
            {
                MessageBox.Show("El ganador es " + personajesPartida.ElementAt(0).Nombre, "Ganador!!!");
                Close();
                personajesPartida.Clear();
            }
        }

        private void premioGanador(Personajes participante)
        {
            if (personajesPartida.Count == 1)
            {
                guardarGanador("Ganador", ".csv", participante);
            }
            else
            {
                Random num = new Random();
                participante.Salud = 100;
                int catSeleccionada = num.Next(4);

                switch (catSeleccionada)
                {
                    case 0:
                        participante.Velocidad += num.Next(1);
                        break;
                    case 1:
                        participante.Destreza += num.Next(1);
                        break;
                    case 2:
                        participante.Fuerza += num.Next(1);
                        break;
                    case 3:
                        participante.Nivel += 1;
                        break;
                    case 4:
                        participante.Armadura += num.Next(1);
                        break;
                }
            }

        }

        private void guardarGanador(string nombre, string formato, Personajes ganador)
        {
            //CSV 
            FileStream Ganadores = new FileStream(nombre + formato, FileMode.OpenOrCreate);
            using (StreamWriter escribirGanador = new StreamWriter(Ganadores))
            {
                escribirGanador.WriteLine("Ganador:;{0};{1};{2}", ganador.Nombre, ganador.Personaje, ganador.Salud);
                escribirGanador.Close();
            }

        }

        private int siguenVivos()
        {
            if (personajesPartida.ElementAt(0).Salud > 0 && personajesPartida.ElementAt(1).Salud > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        private float danioProvocadoPorEnemigo(Personajes participante, Personajes enemigo)
        {
            return Math.Abs((float)(enemigo.Ataque() - participante.Defensa()) / MDP * 100);
        }

        private void actualizarVentanaBatalla(Personajes p1, Personajes p2, int cantidadAtaque)
        {
            float danioP1 = danioProvocadoPorEnemigo(p1, p2);
            float danioP2 = danioProvocadoPorEnemigo(p2, p1);
            SALUDP1.Text = p1.Vida(danioP1).ToString();
            SALUDP2.Text = p2.Vida(danioP2).ToString();

            btn_iniciar_partida.Text = "Ataque" + (numAtaque + 1).ToString();
        }
    }
}
