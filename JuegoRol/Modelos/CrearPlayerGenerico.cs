using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoRol
{
    class CrearPlayerGenerico
    {
        static Random aleatorio = new Random();

        /*****************************************************************************************/
        /*****************************************************************************************/
        /*****************************************************************************************/

        //metodos para la Obtención de los Datos



        //nombre
        public static string generarNombre()
        {
            string[] nombres = { "Carlos", "Maria", "Pedro", "Juan", "Lucia", "Pancracia", "Eusebia", "Dolores", "Mirta", "Irma", "Camilo", "Mario", "Alfredo" };
            int numNombre = aleatorio.Next(12);
            return nombres[numNombre];
        }

        //apodo
        public static string generarApodo()
        {
            string[] apodos = { "Pepillo", "Cepillin", "riñon fijo", "sasha", "claudia", "vrayan", "pachano" };
            int numApodo = aleatorio.Next(7);
            return apodos[numApodo];
        }

        //fecha de nacimiento
        public static DateTime generadorFechaNacimiento()
        {
            DateTime inicio = new DateTime(1960, 1, 1);
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
