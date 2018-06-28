using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Exo5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Entrer un entier Quelquonque: ");
            int entier;
            
            if(Int32.TryParse(Console.ReadLine(), out entier))
            {
                if (Calcul.estPair(entier))
                {
                    Console.WriteLine(" Ce nombre est Pair : ");
                }
                else
                {
                    Console.WriteLine(" Ce nombre est Impair: ");
                }
            }else
            {
                Console.WriteLine("Ce n'est pas un entier : ");
            }
        }
    }
}
