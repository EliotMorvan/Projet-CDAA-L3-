using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_CDAA_EliotMorvan.Gestion;

namespace TP_CDAA_EliotMorvan
{
    public class Entreprise
    {
        //Chaque entreprise possède au moins ces attributs
        private string nomEntreprise;
        private int dateCreation;
        private string fondateur;
        private string mail;

        //Les catégories de vente regroupent sous forme de booléens tous les secteurs d'activité de l'entreprise
        private Dictionary<Categorie, bool> categoriesVente = new Dictionary<Categorie, bool>();

        //Panier de l'entreprise regroupant tous les produits commandés
        private Panier panier;

        //Accesseurs des attributs
        public string NomEntreprise
        {
            get { return this.nomEntreprise; }
            set { this.nomEntreprise = value; }
        }
        public int DateCreation
        {
            get { return this.dateCreation; }
            set { this.dateCreation = value; }
        }
        public string Fondateur
        {
            get { return this.fondateur; }
            set { this.fondateur = value; }
        }
        public string Mail
        {
            get { return this.mail; }
            set { this.mail = value; }
        }
        public Panier Panier
        {
            get { return this.panier; }
            set { this.panier = value; }
        }

        //Accesseurs avec impossibilité de fixer la valeur du dictionnaire 
        public Dictionary<Categorie, bool> CategoriesVente
        {
            get { return this.categoriesVente; }
        }

        //Constructeur par défaut
        public Entreprise()
        {
            this.nomEntreprise = "Nom entreprise";
            this.dateCreation = -1;
            this.fondateur = "fondateur";
            this.mail = "mail";
            this.categoriesVente.Add(Categorie.fournitures, true);
            this.categoriesVente.Add(Categorie.maroquinerie, true);
            this.categoriesVente.Add(Categorie.papeterie, true);
            this.panier = new Panier(500);
        }

        //Constructeur par passage de valeur
        public Entreprise(string nom, int date, string fondateur, string mail)
        {
            this.nomEntreprise = nom;
            this.dateCreation = date;
            this.fondateur = fondateur;
            this.mail = mail;
            this.categoriesVente.Add(Categorie.fournitures, true);
            this.categoriesVente.Add(Categorie.maroquinerie, true);
            this.categoriesVente.Add(Categorie.papeterie, true);
            this.panier = new Panier(900);
        }

        //Enlever une catégorie de vente de l'entreprise (passage à false de la catégorie passée en paramètre)
        public void EnleverCategoriesVente(Categorie c)
        {
            foreach (KeyValuePair<Categorie, bool> entry in categoriesVente)
            {
                if (entry.Key == c) { 
                    categoriesVente[entry.Key] = false;
                    break;
                }
            }
        }

        //Ajouter une catégorie de vente de l'entreprise (passage à false de la catégorie passée en paramètre)
        public void AjouterCategoriesVente(Categorie c)
        {
            foreach (KeyValuePair<Categorie, bool> entry in categoriesVente)
            {
                if (entry.Key == c)
                {
                    categoriesVente[entry.Key] = true;
                    break;
                }
            } 
        }

        //Enlever toutes les catégories de vente de l'entreprise (passage à false de toutes les catégorie)
        public void EnleverToutesCategoriesVente()
        {
            foreach (KeyValuePair<Categorie, bool> entry in categoriesVente.ToList())
            {
                    categoriesVente[entry.Key] = false;
            }
        }

        //Ajouter toutes les catégories de vente de l'entreprise (passage à false de toutes les catégorie)
        public void AjouterToutesCategoriesVente()
        {
            foreach (KeyValuePair<Categorie, bool> entry in categoriesVente.ToList())
            {
                categoriesVente[entry.Key] = true;
            }
        }

        ///////////////////////
        // Gestion du panier //
        ///////////////////////

        public void AjouterAuPanier(Produit produit, int quantite)
        {
            //Booléen afin de sauvegarder la compatibilité entre le produit et le domaine de l'entreprise
            bool transfertPossible = false;

            //Verification de la compatibilité entre le produit et le domaine de distribution de l'entreprise
            foreach (KeyValuePair<Categorie, bool> entry in categoriesVente)
            {
                if (entry.Value == true)
                    if (entry.Key == produit.Categorie)
                        transfertPossible = true;
            }

            //Ajoute (ou non) des produits dans le panier après respect des contraintes
            if (transfertPossible)
            {
                Console.WriteLine("Le produit est compatible avec le domaine de distribution de l'entreprise.");
                if (quantite >= 1)
                {
                    this.panier.AjouterProduits(produit, quantite);
                    Console.WriteLine("Action effectuée.\n");
                }
                else
                    Console.WriteLine("Action cependant impossible, la quantité saisie n'est pas valide.\n");
            }
            else
                Console.WriteLine("Transfert impossible, l'entreprise ne distrbue pas de produits de ce type.");
        }

        public void RetirerDuPanier(Produit produit, int quantite)
        {
            //Booléen afin de vérifier si l'action a correctement été effectuée
            bool trouve = false;
             
            foreach (KeyValuePair<Produit, int> entry in panier.Articles)
            {
                if(entry.Key == produit)
                {
                    trouve = true;
                    break;
                }
            }

            //Si l'élément a été trouvé, on vérifie la quantité à soustraire
            if (trouve)
            {
                Console.WriteLine("L'élément " + produit.GetType().Name + " a été trouvé.");
                if (Panier.Articles[produit] - quantite < 0)
                {
                    Console.WriteLine("La quantité demandée est trop élevée. Action impossible.\n");
                }
                else
                {
                    Panier.Articles[produit] -= quantite;
                    Console.WriteLine("L'action a été effectuée.\n");
                }
            }
            else
                Console.WriteLine("L'élément demandé n'a pas été trouvé.");
        }

        //Affichage
        public override string ToString()
        {
            string res = "Entreprise: " + nomEntreprise + ", fondé en " + dateCreation + " par " + fondateur + ". Contact: " + mail + "\n" + "Entreprise de vente spécialisée dans ";
            foreach (KeyValuePair<Categorie, bool> entry in categoriesVente)
            {
                if(entry.Value == true)
                    res += entry.Key + " ";
            }
            return res + "\n";
        }
    }
}
