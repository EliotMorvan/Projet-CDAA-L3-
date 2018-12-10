using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_CDAA_EliotMorvan.Produits
{
    public class Agenda : Produit
    {
        //Agenda est un produit défini en plus par: 
        //les années qu'il peut couvrir (de la forme "YYYY-YYYY"),
        private string annees;

        //Ses dimensions (de la forme "longueurxlargeur" en cm),
        private string dimensions_en_cm;

        //Sa couleur,
        private Color couleur;

        //Si les pages sont lignées, ...
        private bool lignage;

        //... ou quadrillées.
        private bool quadrillage;

        //Accesseurs avec possiblités de fixer une valeur précise pour chaque attribut
        public string Annees
        {
            get { return this.annees; }
            set { this.annees = value; }
        }
        public string Dimensions
        {
            get { return this.dimensions_en_cm; }
            set { this.dimensions_en_cm = value; }
        }
        public bool Lignage
        {
            get { return this.lignage; }
            set { this.lignage = value; }
        }
        public bool Quadrillage
        {
            get { return this.quadrillage; }
            set { this.quadrillage = value; }
        }

        //Constructeur par défaut
        public Agenda() : base()
        {
            this.annees = null;
            this.dimensions_en_cm = null;
            this.lignage = false;
            this.quadrillage = false;
            this.Id = setId();
        }

        //Constructeur par passage de valeur
        public Agenda(int prix, string marque, Color couleur, string annees, string dimensions_en_cm, bool lignage, bool quadrillage) : base(prix, marque)
        {
            this.annees = annees;
            this.dimensions_en_cm = dimensions_en_cm;
            this.lignage = lignage;
            this.quadrillage = quadrillage;
            this.couleur = couleur;
            this.Categorie = Categorie.papeterie;
            this.Id = setId();
        }

        //Calcul de l'ID
        private string setId()
        {
            string l = "";
            string q = "";
            if (lignage)
                l = "li.";
            if (quadrillage)
                q = "qu.";

            return "Pr.Ag." +
                this.Prix + "." +
                this.Marque.Substring(0, 1) + "." +
                this.Categorie.ToString().Substring(0, 1) + "." +
                this.annees.Substring(0, 1) + "." +
                this.dimensions_en_cm.Substring(0, 1) + "." +
                this.couleur.ToString().Substring(0, 1) + "." +
                l + q;
                
        }

        //Affichage
        public override string ToString()
        {
            string lig = "ligné ";
            if (!lignage)
                lig = "non ligné";

            string qua = "quadrillé.";
            if (!quadrillage)
                qua = "non quadrillé.";

            return this.GetType().Name + ": " + base.ToString() + "années traitées: " + annees + ", dimensions: " + dimensions_en_cm + ", couleur: " + couleur + ", " + lig + ", " + qua + "\nId: " + this.Id + "\n";
        }
    }
}
