using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public class Personaje
    {
        private List<EHabilidades> listaHabilidades;
        protected string nombre;

        //Instancio la lista de Habilidades
        private Personaje()
        {
            listaHabilidades = new List<EHabilidades>();
        }

        public Personaje(string nombre, List<EHabilidades> habilidades) : this()
        {
            this.nombre = nombre;
            this.listaHabilidades = habilidades;

        }

        //obtiene las habilidades de los personajes
        private string ListaHabilidades
        {
            get {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Las habilidades son: ");
                foreach (EHabilidades habilidades  in this.listaHabilidades)
                { 
                    sb.AppendLine($"{habilidades}");
                }
                
                return sb.ToString();
                ; 
            }

        }

        /// <summary>
        /// Al igualar la lista de personajes con una personaje, devuelve si esta el personaje
        /// </summary>
        /// <param name="listaPersonajes"></param>
        /// <param name="personaje"></param>
        /// <returns>retorna un true si esta el personaje </returns>
        public static bool operator ==(List<Personaje> listaPersonajes, Personaje personaje)
        {
            if (!(personaje is null))
            {
                foreach (Personaje auxPersonaje in listaPersonajes)
                {
                    if (auxPersonaje.nombre == personaje.nombre && auxPersonaje.GetType() == personaje.GetType())
                    {
                        return true;
                    }

                }
            }
            return false;
        }

        /// <summary>
        /// Al igualar la lista de personajes con una personaje, devuelve si no esta el personaje
        /// </summary>
        /// <param name="listaPersonajes"></param>
        /// <param name="personaje"></param>
        /// <returns> retorna true si no esta el personaje</returns>
        public static bool operator !=(List<Personaje> listaPersonajes, Personaje personaje)
        {
            return !(listaPersonajes == personaje);
        }

        /// <summary>
        /// Agrega un personaje a la lista de personajes
        /// </summary>
        /// <param name="listaPersonaje"></param>
        /// <param name="personaje"></param>
        /// <returns>retorna la lista de personajes</returns>
         public static List<Personaje> operator +(List<Personaje> listaPersonaje, Personaje personaje)
         {
            if (listaPersonaje!=personaje){
                listaPersonaje.Add(personaje);
            }

            return listaPersonaje;

         }

        /// <summary>
        /// muestra los datos del personaje
        /// </summary>
        /// <returns>retorna un string</returns>
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"El Personaje es: {this.nombre}");
            sb.AppendLine($"{this.ListaHabilidades}");

            return sb.ToString() ;
        }
    }
}
