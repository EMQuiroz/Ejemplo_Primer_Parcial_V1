using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Marvel
    {

        private static List<Personaje> listaPersonaje;

        static Marvel()
        {
            listaPersonaje = new List<Personaje>();
        }

        //Agrego personajes a la lista si no se encuentran en la misma
        public static Personaje Personaje
        {
            set 
            {    
               listaPersonaje += value;
            }
        } 

        /// <summary>
        /// Muestra toda la informacion de los personajes
        /// </summary>
        /// <returns> retorna un texto</returns>
        public static string MostrarInformacion() 
        {
            StringBuilder sb = new StringBuilder();

            foreach (Personaje auxPersonaje in listaPersonaje) 
            {
                if(auxPersonaje is Avenger) 
                {
                    //modifico el AppendLine por un AppendFormat
                    sb.AppendFormat($"****** AVENGER ****** \n {((Avenger)auxPersonaje).MostrarAvenger()}");

                    
                }
                else if (auxPersonaje is Enemigo)
                {
                    sb.AppendFormat($"****** ENEMIGO ****** \n {((Enemigo)auxPersonaje).MostrarEnemigo()}");

                }

            }

            return sb.ToString();
        }


    }
}
