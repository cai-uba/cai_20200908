using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{

        
    class Program
    {
        static void Main(string[] args)
        {
            List<Auto> listaAutos = new List<Auto>();

            Auto a1 = new Auto("Ford", "Fiesta", "Nafta 1.4 TD");
            
            listaAutos.Add(a1);

            Auto a2 = null;

            a2.Marca = "123123";
            //Console.WriteLine(a2.Marca);

            a2 = new Auto("Chevrolet", "Onix", "Nafta 1.3 TD");

            Console.WriteLine(a2.Marca);

            a2.AgregarUnaUnidad();
                
            listaAutos.Add(a2);
                
            listaAutos.Add(new Auto("Volskwagen", "Golf", "Nafta 1.4 TSI"));
                
            Console.WriteLine("Ingrese el nombre de un auto");

            Auto a = new Auto();
            
            Auto a3 = a2;

            a2.QuitarStock(11);

            a3.AgregarUnaUnidad();

            foreach (Auto auto in listaAutos)
            {
                Console.WriteLine(auto.ToString());

                if (auto.Vendido())
                    Console.WriteLine("Esta vendido");
                else
                    Console.WriteLine("Hay stock");

            //if (auto.Modelo.ToUpper().Contains(ingresoUsuario.ToUpper()))
            //{
            //    Console.WriteLine(auto.ToString());
            //}
            }

                string ingresoUsuario = Console.ReadLine();
        }

        public static void GetDesc(Auto a)
        {
            Console.WriteLine(a.Marca);
        }
    }
    
    
}
