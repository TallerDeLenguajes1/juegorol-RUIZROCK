using JuegoRol.Modelos;
using System;
using System.Collections.Generic;

namespace JuegoRol
{
    class CrearPlayerGenerico
    {
        static Random aleatorio = new Random();

//metodo para crear personaje
        public static Personajes CrearPersonaje(List<string> nombreAleatorio)
        {

            Personajes nuevoJugador = new Personajes();

            nuevoJugador.Personaje = generarTipo();
            nuevoJugador.Nombre = generarNombre(nombreAleatorio);
            nuevoJugador.Apodo = generarApodo();
            nuevoJugador.FechaDeNacimiento = generadorFechaNacimiento();
            nuevoJugador.Edad = generadorEdad(nuevoJugador.FechaDeNacimiento);
            nuevoJugador.Salud = 100;

            nuevoJugador.Velocidad = genererVelocidad();
            nuevoJugador.Destreza = genererDestreza();
            nuevoJugador.Fuerza = genererFuerza();
            nuevoJugador.Nivel = 1;
            nuevoJugador.Armadura = genererArmadura();

            return nuevoJugador;
        }
        /*****************************************************************************************/
        /*****************************************************************************************/
        /*****************************************************************************************/

        //metodos para la Obtención de los Datos

        //tipo
        static tipo generarTipo()
        {

            int num = aleatorio.Next(5);
            tipo tipo;

            switch (num)
            {
                case 0:
                    tipo = tipo.ogro;
                    break;
                case 1:
                    tipo = tipo.duende;
                    break;
                case 2:
                    tipo = tipo.burro;
                    break;
                case 3:
                    tipo = tipo.nieri;
                    break;
                default:
                    tipo = tipo.ehamigo;
                    break;
            }
            return tipo;
        }

                        //nombre
        private static string generarNombre(List<string> nombrepersonaje)
        {
            string[] nombres = { "Carlos", "Maria", "Pedro", "Juan", "Lucia" };
            int numNombre = aleatorio.Next(5);
            return nombres[numNombre];
        }

                        //apodo
        private static string generarApodo()
        {
            string[] apodos = { "Pepillo", "Cepillin","riñon fijo", "sasha", "claudia", "vrayan", "pachano" };
            int numApodo = aleatorio.Next(7);
            return apodos[numApodo];
        }

                        //fecha de nacimiento
        private static DateTime generadorFechaNacimiento()
        {
            DateTime inicio = new DateTime(1721, 1, 1);
            int range = (DateTime.Today - inicio).Days;
            return inicio.AddDays(aleatorio.Next(range)).Date;
        }


                            //edad
        public static int generadorEdad(DateTime fechaNacimiento)
        {
            return DateTime.Today.Year - fechaNacimiento.Year;
        }

        /*****************************************************************************************/
        /*****************************************************************************************/
        /*****************************************************************************************/
        
        //metodos para la Obtencion de las Caracteristicas

        //velocidad
        public static int genererVelocidad()
        {
            return aleatorio.Next(1, 11);
        }

                        //destreza
        public static int genererDestreza()
        {
            return aleatorio.Next(1, 6);
        }

                        //fuerza
        public static int genererFuerza()
        {
            return aleatorio.Next(1, 11);
        }

                        //armadura
        public static int genererArmadura()
        {
            return aleatorio.Next(1, 11);
        }
    }
}
