using System;

namespace JuegoRol.Modelos
{
    public enum tipo
        {
            ogro, duende, burro, nieri,ehamigo
        };

    public class Personajes
    {
                     //datos y caracteristicas
        private tipo personaje;
        private string nombre;
        private string apodo;
        private DateTime fechaDeNacimiento;
        private int edad;
        private int salud = 100;

        private int velocidad;
        private int destreza;
        private int fuerza;
        private int nivel = 1;
        private int armadura;
        /*****************************************************************************************/
        /*****************************************************************************************/
        /*****************************************************************************************/

                    //Metodos get/set de cada variable
        internal tipo Personaje
        {
            get
            {
                return personaje;
            }

            set
            {
                personaje = value;
            }
        }
        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }
        public string Apodo
        {
            get
            {
                return apodo;
            }

            set
            {
                apodo = value;
            }
        }
        public DateTime FechaDeNacimiento
        {
            get
            {
                return fechaDeNacimiento;
            }

            set
            {
                fechaDeNacimiento = value;
            }
        }
        public int Edad
        {
            get
            {
                return edad;
            }

            set
            {
                edad = value;
            }
        }
        public int Salud
        {
            get
            {
                return salud;
            }

            set
            {
                salud = value;
            }
        }
        public int Velocidad
        {
            get
            {
                return velocidad;
            }

            set
            {
                velocidad = value;
            }
        }
        public int Destreza
        {
            get
            {
                return destreza;
            }

            set
            {
                destreza = value;
            }
        }
        public int Fuerza
        {
            get
            {
                return fuerza;
            }

            set
            {
                fuerza = value;
            }
        }
        public int Nivel
        {
            get
            {
                return nivel;
            }

            set
            {
                nivel = value;
            }
        }
        public int Armadura
        {
            get
            {
                return armadura;
            }

            set
            {
                armadura = value;
            }
        }
        
        /*****************************************************************************************/
        /*****************************************************************************************/
        /*****************************************************************************************/

        //acciones de los personajes
        public int Poder()
        {
            return Destreza * Fuerza * Nivel;
        }

        public float Ataque()
        {
            Random efectividadgolpe = new Random();
            return Poder() * efectividadgolpe.Next(35);
        }

        public int Defensa()
        {
            return Armadura * Velocidad;
        }

        public float Vida(float ataqueEnemigo)
        {
            Salud = Salud - (int)ataqueEnemigo;
            return Salud;
        }

    }
}
