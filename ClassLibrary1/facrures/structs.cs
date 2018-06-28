using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factures
{
    class structs
    {
        
    }
    public struct facturette
    {
        public int no;        
        public string nom;
        public double prix;
        public int qte;
    }

    public struct facturette2
    {
        private  int m_no;
        private  int m_nbItem;
        public string[] nom { get; set; }
        public double [] prix { get; set; }
        public int [] qte { get; set; }

        public int no
        {
            get { return m_no; }
            set { m_no = value; }
        }
       
        public int nbItem
        {
            get { return m_nbItem; }
            set { m_nbItem = value; }
        }
    }

    public struct stDate
    {
        public int jour;
        public int mois;
        public int annee;
        enum jourSemaine { Dimanche, Lundi, Mardi, Mercredi, Jeudi, Vendredi, Samedi };
        public string definirJour()
        {

            int c = (14 - mois) / 12;
            int a = annee - c;
            int m = mois + 12 * c - 2;
            int j = (jour + a + a / 4 - a / 100 + a / 400 + (31 * m) / 12) % 7;
            String lejour = Enum.GetName(typeof(jourSemaine), j);
            return lejour;
        }

        public void afficher()
        {
            Console.WriteLine(jour+"/"+mois+"/"+annee);
            
        }

        public void ajouterJour()
        {
            

            if((mois == 4 || mois == 6|| mois == 9|| mois == 11)&& (jour == 30))
            {
                if (mois < 12)
                {
                    mois++;
                }else
                {
                    mois = 1;
                    annee++;
                }
               
                jour = 1;
            }else if (mois == 2 && jour==28)//il faut verifier si lanne est bisextile
            {
                if (mois < 12)
                {
                    mois++;
                }
                else
                {
                    mois = 1;
                    annee++;
                }
                jour = 1;
            }else if((mois == 1 || mois == 3|| mois == 3 || mois == 7 || mois == 8 || mois == 10 || mois == 12) && (jour == 31))
            {
                if (mois < 12)
                {
                    mois++;
                }
                else
                {
                    mois = 1;
                    annee++;
                }
                jour = 1;
            }else
            {
                jour++;
            }

        }
    }


}
