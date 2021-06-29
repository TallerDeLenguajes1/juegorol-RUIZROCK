using JuegoRol.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace JuegoRol.Ventanas
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
            jug1_name.Text = personajesPartida.ElementAt(0).Nombre;
            jug2_name.Text = personajesPartida.ElementAt(1).Nombre;
            jug1_salud.Text = personajesPartida.ElementAt(0).Salud.ToString();
            jug2_salud.Text = personajesPartida.ElementAt(1).Salud.ToString();
            btn_iniciar_partida.Enabled = true;
            btn_iniciar_partida.Text = "Iniciar Batalla";
            btn_siguiente_partida.Enabled = false;
        }


        //inicio de la pelea
        private void btn_iniciar_partida_Click(object sender, EventArgs e)
        {
            //
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
                    resultado.Text = "Gana " + jug2_name.Text;
                    personajesPartida.RemoveAt(0);
                    premioGanador(personajesPartida.ElementAt(0));

                }
                else
                {
                    resultado.Text = "Gana " + jug1_name.Text;
                    personajesPartida.RemoveAt(1);
                    premioGanador(personajesPartida.ElementAt(0));

                }
            }
        }


        private void inicializarPersonaje(Personajes participante1, Personajes participante2)
        {
            jug1_name.Text = participante1.Nombre;
            jug2_name.Text = participante2.Nombre;

            label1.Text = Convert.ToString(participante1.Nivel);
            label2.Text = Convert.ToString(participante1.Personaje);
            label3.Text = participante1.Apodo;
            label4.Text = Convert.ToString(participante1.Velocidad);
            label5.Text = Convert.ToString(participante1.Destreza);
            label6.Text = Convert.ToString(participante1.Fuerza);
            label7.Text = Convert.ToString(participante1.Armadura);

            label8.Text = Convert.ToString(participante2.Nivel);
            label9.Text = Convert.ToString(participante2.Personaje);
            label10.Text = participante2.Apodo;
            label11.Text = Convert.ToString(participante2.Velocidad);
            label12.Text = Convert.ToString(participante2.Destreza);
            label13.Text = Convert.ToString(participante2.Fuerza);
            label14.Text = Convert.ToString(participante2.Armadura);

        }

        private void IniciarPartida_Load(object sender, EventArgs e)
        {
            
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
                int catSeleccionada = num.Next(10);

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
                    default:
                        participante.Armadura += num.Next(1);
                        break;
                }
            }

        }

        private void guardarGanador(string nombre, string formato, Personajes ganador)
        {
            FileStream Ganadores = new FileStream(nombre + formato, FileMode.Create);
            StreamWriter escribirGanador = new StreamWriter(Ganadores);
            escribirGanador.WriteLine("Ganador:;{0};{1};{2}", ganador.Nombre, ganador.Personaje, ganador.Salud);
            escribirGanador.Close();
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
            jug1_salud.Text = p1.Vida(danioP1).ToString();
            jug2_salud.Text = p2.Vida(danioP2).ToString();

            btn_iniciar_partida.Text = "Ataque" + (numAtaque + 1).ToString();
        }

        private void jug1_name_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
