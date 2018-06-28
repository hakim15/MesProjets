using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cahier3
{
    class Program
    {
        static void Main(string[] args)
        {
            PanierAchat pn2 = new PanierAchat();

            Console.WriteLine("Entrer le code de l'item : ");
            String no = Console.ReadLine();
            pn2.noItem = no;
            Console.WriteLine("Entrer le nom de l'item : ");
            String nom = Console.ReadLine();
            pn2.nomItem = nom;
            Console.WriteLine("Entrer la taille de l'item : ");
            String taille = Console.ReadLine();
            pn2.sizeItem = taille;
            Console.WriteLine("Entrer le prix de l'item : ");
            Decimal prix = Convert.ToDecimal(Console.ReadLine());
            pn2.priceItem = prix;
            Console.WriteLine("*******************************************");
            //PanierAchat pn = new PanierAchat(no, nom, taille, prix);
            //Console.WriteLine("**********Panier avec constructeur avec parametres*******");
            //Console.WriteLine(pn);
            Console.WriteLine("**********Panier avec constructeur sans parametres*******");
            //Console.WriteLine(pn2.sizeItem);
            Console.WriteLine(pn2);

        }
    }
}
