using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cahier3
{
    class PanierAchat
    {
        private string _noItem;
        private string _nomItem;
        private string _tailleItem;
        private decimal _prixItem;

       
        public string noItem {
            get
            {
                return _noItem;
            }
            set
            {
                _noItem = value;
            }
        }
        public String nomItem
        {
            get
            {
                return _nomItem;
            }
            set
            {
                _nomItem = value;
            }
        }

        public String sizeItem
        {
            get
            {
                if (_tailleItem.IndexOf('0')>=0)
                {
                    return "taille inconnue";
                }else
                {
                return _tailleItem;
                }
            }
            set
            {
                
                    _tailleItem = value;
               
                
            }
        }
       
        public decimal priceItem
        {
            get
            {
                return _prixItem;
            }

            set
            {
                if (value< 0)
                {
                    _prixItem = 0;
                    
                }else
                {
                    _prixItem = value;
                }
                
            }
        }

        public PanierAchat(String no,String nom, String taille,Decimal prix )
        {
            this._noItem = no;
            this._nomItem = nom;
            this._tailleItem = taille;
            this._prixItem = prix;

        }

        public PanierAchat()
        {

        }

        public override  String ToString()
        {

            return "item # :" + noItem +"\n"
                + "Description :" + nomItem + "\n"
                + "taille :" + sizeItem + "\n"
                + "Prix unitaire :" + priceItem + "\n";

        }


    }
}
