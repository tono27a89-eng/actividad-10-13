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
            Dictionary<string,double>notas = new Dictionary<string,double>();
            string nombre;
            double num;
            Console.WriteLine("ingrese cuantas notas va ingresar");
            int.TryParse(Console.ReadLine(), out int lim);
            for (int i = 0; i < lim; i++)
            {


                Console.WriteLine($"Ingrese  nombre NO.{i + 1} de {lim} estudiantes");
                nombre = Console.ReadLine();
                if (notas.ContainsKey(nombre))
                {
                    Console.WriteLine("valor ya ingresado ingrese otro");
                    i--;

                }
                else
                {
                    Console.WriteLine("ingrese notas: ");
                    double.TryParse(Console.ReadLine(), out num);
                    notas.Add(nombre,num);

                }

            }
            foreach (var item in notas)
            {
                Console.WriteLine("prodcuto Id: " + item.Key + "valor: " + item.Value);

            }

        }
    }
}
