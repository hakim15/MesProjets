using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using factures;

namespace Exo8
{
    class Program
    {
        static void Main(string[] args)
        {
            stDate uneDate;
            Console.WriteLine("entrer le jour ");
            uneDate.jour = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("entrer le mois ");
            uneDate.mois = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("entrer lannee ");
            uneDate.annee = Convert.ToInt16(Console.ReadLine());

            uneDate.afficher();
            uneDate.ajouterJour();
            uneDate.afficher();
            Console.WriteLine(uneDate.definirJour());
        }
    }
}
