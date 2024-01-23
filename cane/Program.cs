using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cane
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cane c = new Cane();
            c.razza = "Labrador";
            c.nome = "Ringhio";

            c.proprietario = new Persona ();
            c.proprietario.nome = "Simone";

            Console.ReadLine(); 

        }
    }
}
