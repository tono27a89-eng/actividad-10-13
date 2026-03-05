using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace actividad_10_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ree un diccionario de notas y calcule el promedio general recorriéndolo con foreach.");
            for (int i = 0; i < 3; i++)
            {


                Console.WriteLine($"Ingrese  ID NO.{i + 1} de 3 productos");
                int.TryParse(Console.ReadLine(), out clave);
                if (producto.ContainsKey(clave))
                {
                    Console.WriteLine("valor ya ingresado ingrese otro");
                    i--;

                }
                else
                {
                    Console.WriteLine("ingrese nombre:");
                    nombre = Console.ReadLine();
                    producto.Add(clave, nombre);

                }

            }
            foreach (var item in producto)
            {
                Console.WriteLine("prodcuto Id: " + item.Key + "valor: " + item.Value);

            }

        }
    }
}
