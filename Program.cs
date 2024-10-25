using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        public class Cargador { 
        public Dictionary<int, string> Diccionario = new Dictionary<int, string>();
            public Cargador()
            {
                
            }
            public void RellenarDiccionario(int Id,string valor)
            {
                Diccionario[Id] = valor;
                Console.WriteLine("Dato guardado");
            }
        }

        public  void AlumnM()
        {

        }

        static void Main(string[] args)
        {
            Cargador cargador = new Cargador();
            Console.WriteLine("Ingresa una url");
            Console.ReadLine();
            string url = Console.ReadLine();
            cargador.RellenarDiccionario(0,url);


            Console.ReadKey();
        }
    }
}
