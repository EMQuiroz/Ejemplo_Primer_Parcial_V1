# Ejemplo primer parcial V1. 


## Proyecto: Marvel.
![C#](./img_proyecto/ejemplo_parcial.png)


## Descripción
Este parcial fue tomado en el año 2021, los temas vistos son:
- Abstraccion, encapsulamiento, herencia.
- windows form.
- proyecto de consola.
- Clases estaticas.
- Sobrecarga de operadores.

## Desarrollo de temas


- ### Uso de herencia:
    Mostramos los datos del personaje usando la clase base.

~~~ C# (lenguaje en el que esta escrito)
        /// <summary>
        /// Muestra la informacion del enemigo
        /// </summary>
        /// <returns>un string</returns>
        public string MostrarEnemigo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Nombre}");
            sb.Append(base.Mostrar());
            sb.AppendLine($"Su objetivo es {this.objetivo}");

            return sb.ToString();
        }
~~~



---