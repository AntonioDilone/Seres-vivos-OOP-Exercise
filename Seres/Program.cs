using System;
using System.Collections.Specialized;

namespace Seres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Ser> seres= new List<Ser>();
            Console.WriteLine("Cuantos seres vivos desea agregar?");
            int cantSeres = int.Parse(Console.ReadLine());  
            Dictionary<string, int> humano= new Dictionary<string, int>();
            Dictionary<string, int> planta= new Dictionary<string, int>();
            Dictionary<string, int> animal= new Dictionary<string, int>();

            for (int i = 0; i < cantSeres; i++)
            {
                Ser serVivo = new Ser();
                Console.WriteLine("Cual es el nombre de este ser vivo");
                serVivo.nombre = Console.ReadLine();
                Console.WriteLine("Cual es la edad del ser vivo?");
                serVivo.edad = int.Parse(Console.ReadLine());
                Console.WriteLine("Cual es el peso del ser vivo?");
                serVivo.peso = double.Parse(Console.ReadLine());
                Console.WriteLine("Cual es el tipo de ser vivo? (Humano, animal, o planta)");
                serVivo.tipo = Console.ReadLine().ToLower();
                seres.Add(serVivo);
                Console.Clear();
            }
            foreach (var item in seres)
            {
                if (humano.ContainsKey(item.tipo))
                {
                    humano[item.tipo]++;
                } else if (animal.ContainsKey(item.tipo))
                {
                    animal[item.tipo]++;
                }
                else if (planta.ContainsKey(item.tipo))
                {
                    planta[item.tipo]++;
                }
                else
                {
                    humano[item.tipo] = 1;
                    animal[item.tipo] = 1;
                    planta[item.tipo] = 1;
                }
            }
            
            foreach (var item in seres.OrderByDescending(x => x.edad))
            {
                Console.WriteLine(item.nombre + " es un "+item.tipo+" de "+item.edad + " edad");
            }
            foreach (var item in seres)
            {
                Console.WriteLine(item.nombre + " es un " + item.tipo + " de " + item.edad + " edad");
            }
            Console.ReadLine();


        }
    }
}
