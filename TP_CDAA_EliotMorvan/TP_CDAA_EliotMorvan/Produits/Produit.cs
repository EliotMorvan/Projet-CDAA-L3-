using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_CDAA_EliotMorvan
{
    public abstract class Produit
    {
        //Tout produit quel qu'il soit est composé au minimum d'un prix, d'une marque et d'une couleur
        private string id;
        private int prix;
        private string marque;
        private Categorie categorie;

        //Accesseurs avec possiblités de fixer une valeur précise pour chaque attribut
        public int Prix
        {
            get { return this.prix; }
            set { this.prix = value; }
        }
        public string Marque
        {
            get { return this.marque; }
            set { this.marque = value; }
        }
        public Categorie Categorie
        {
            get { return this.categorie; }
            set { this.categorie = value; }
        }
        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        //Constructeur par défaut
        public Produit()
        {
            this.prix = -1;
            this.marque = "marque";
            this.categorie = Categorie.fournitures;
        }

        //Constructeur par passage de valeur
        public Produit(int p, string m)
        {
            this.prix = p;
            this.marque = m;
        }

        //Affichage
        public override string ToString()
        {
            return "prix: " + prix + "E, marque: " + marque + ", catégorie: " + categorie + ",\n";
        }
    }   
}
