using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Exo6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("entrer un caractere : ");
            char c = Convert.ToChar(Console.Read());
            if (Calcul.estVoyelle(c))
            {
                Console.WriteLine(" C'est une voyelle : ");
            }else
            {
                Console.WriteLine(" Ce n'est pas une voyelle : ");
            }
        }
    }
}
 