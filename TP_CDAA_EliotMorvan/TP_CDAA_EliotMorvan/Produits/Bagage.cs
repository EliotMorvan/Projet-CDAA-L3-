using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_CDAA_EliotMorvan.Produits
{
    public class Bagage : Produit
    {
        //Un bagage est un produit possédant une capacité en Litres et un système 4 roues ou non
        private int capacite_en_l;
        private bool quatre_roues;
        private Color couleur;

        //Accesseurs
        public int Capacite_en_l
        {
            get { return this.capacite_en_l; }
            set { this.capacite_en_l = value; }
        }
        public bool Quatre_roues
        {
            get { return this.quatre_roues; }
            set { this.quatre_roues = value; }
        }
        public Color Couleur
        {
            get { return this.couleur; }
            set { this.couleur = value; }
        }

        //Constructeur par défaut
        public Bagage() : base()
        {
            this.capacite_en_l = -1;
            this.quatre_roues = false;
            this.couleur = Color.blanche;
            this.Id = setId();
        }

        //Constructeur par passage de valeur
        public Bagage(int prix, string marque, int capacite, bool quatre_roues, Color couleur) : base(prix, marque)
        {
            this.capacite_en_l = capacite;
            this.quatre_roues = quatre_roues;
            this.couleur = couleur;
            this.Categorie = Categorie.maroquinerie;
            this.Id = setId();
        }

        //Calcul de l'ID
        private string setId()
        {
            string q = "";
            if (quatre_roues)
                q = "qu.";

            return "Pr.Ba." +
                this.Prix + "." +
                this.Marque.Substring(0, 1) + "." +
                this.Categorie.ToString().Substring(0, 1) + "." +
                this.capacite_en_l + "." + 
                q + 
                this.couleur.ToString().Substring(0, 1) + ".";

        }

        //Affichage 
        public override string ToString()
        {
            string q = "est 4 roues";
            if (!quatre_roues)
                q = "n'est pas 4 roues";

            return this.GetType().Name + ": " + base.ToString() + "capacité (en litres): " + capacite_en_l + ", couleur: " + couleur + ", " + q + "\nId: " + this.Id + "\n";
        }
    }
}
