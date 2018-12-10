using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_CDAA_EliotMorvan.Produits
{
    public class Feutre : Produit
    {
        //Un feutre est défini étant est un produit possédant en plus:
        //Une épaisseur en mm
        private int epaisseur_en_mm;

        //Une couleur d'encre
        private string couleur_encre;

        //Accesseurs avec possiblités de fixer une valeur précise pour chaque attribut
        public int Epaisseur_en_mm
        {
            get { return this.epaisseur_en_mm; }
            set { this.epaisseur_en_mm = value; }
        }
        public string Couleur_encre
        {
            get { return this.couleur_encre; }
            set { this.couleur_encre = value; }
        }

        //Constructeur par défaut
        public Feutre() : base()
        {
            this.epaisseur_en_mm = -1;
            this.couleur_encre = null;
            this.Id = setId();
        }

        //Constructeur par passage de valeur
        public Feutre(int prix, string marque, int epaisseur_en_mm, string couleur) : base(prix, marque)
        {
            this.epaisseur_en_mm = epaisseur_en_mm;
            this.couleur_encre = couleur;
            this.Categorie = Categorie.fournitures;
            this.Id = setId();
        }

        //Calcul de l'ID
        public string setId()
        {
            return "Pr.Fe." +
                this.Prix + "." +
                this.Marque.Substring(0, 1) + "." +
                this.Categorie.ToString().Substring(0, 1) + "." +
                this.epaisseur_en_mm.ToString().Substring(0,1) + "." +
                this.couleur_encre.Substring(0, 1);
        }

        //Affichage
        public override string ToString()
        {
            return this.GetType().Name + ": " + base.ToString() + "épaisseur (en mm): " + epaisseur_en_mm + ", couleur de l'encre: " + couleur_encre + "\nId: " + this.Id + "\n";
        }
    }
}
