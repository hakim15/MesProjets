using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using factures;



namespace ClassLibrary1
{
    public class Calcul
    {
        //ff
        public static double Carre(double n)
        {
            return n * n;
        }

        public static bool estPair(int n)
        {
           
            return (n % 2 == 0);
        }

        public static bool estVoyelle(char c)
        {
           
            return ("aoieuyAOIEUY".IndexOf(c) >= 0);
        }

        public static double coutTotal(facturette [] ft)
        {
            double totalLigne = 0;
            double total = 0;

            for (int i = 0; i < ft.Length; i++)
            {
                totalLigne = ft[i].qte * ft[i].prix;
                Console.WriteLine("Vous avez acheter " + ft[i].qte+" "+ft[i].nom+" @ "+ft[i].prix+ " = " + totalLigne);
                total += totalLigne;
                Console.WriteLine("****************************************************");
            }
            
            
            return total;
        }
        enum jourSemaine { Dimanche, Lundi, Mardi, Mercredi, Jeudi, Vendredi, Samedi };
        public static string definirJour(stDate dt)
        {
            
        int c = (14 - dt.mois) / 12;
            int a = dt.annee - c;
            int m = dt.mois + 12 * c - 2;
            int j = (dt.jour + a + a / 4 - a / 100 + a / 400 + (31 * m) / 12) % 7;
            String jour = Enum.GetName(typeof(jourSemaine), j);
            return jour;
        }

      
    }
}
