using System;
using System.Collections;
using System.Text;


namespace Full_GRASP_And_SOLID.Library
{
    //Primero creo la clase "ConsolePrinter".
    //Al hacerlo, las tarjetas no se imprimen en sí mismas, el principio de SRP dice que una clase puede tener más de una responsabilidad, antes el código no cumplia con el principio.
    //Estas responsabilidades deben estar relacionadas con una sola funcionalidad.
    //Al hacer la impresión en una clase separada estoy cumpliendo el principio SRP, tengo una sola funcionalidad --> imprimir recetas.
    //La clase tiene UNA sola razón para cambiar.
    //Todos los métodos y atributos están relacionados con esa responsabilidad.
    public class ConsolePrinter
    {
        public static void RecetasPrint(StringBuilder PrintRecipe)
        {
            Console.Write(PrintRecipe);
        }
    }
}
