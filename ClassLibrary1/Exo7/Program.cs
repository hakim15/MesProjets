using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using factures;


namespace Exo7
{
    class Program
    {
        static void Main(string[] args)


        {
            facturette2 ft2 = new facturette2();
            double total = 0;
            Console.WriteLine("Entrer le nombre total d'item : ");
            ft2.nbItem = Convert.ToInt16(Console.ReadLine());


            ft2.nom = new String[ft2.nbItem];
            ft2.prix = new double[ft2.nbItem];

            



        }
    }

  
}

