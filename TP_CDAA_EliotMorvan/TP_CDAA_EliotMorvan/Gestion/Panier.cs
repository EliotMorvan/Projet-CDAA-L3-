using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_CDAA_EliotMorvan.Gestion
{
    public class Panier
    {
        //Articles contient tous les produits stockés et leur quantité
        private Dictionary<Produit, int> articles;;

        //Taille maximum allouée au panier
        private int tailleMax;

        //Accesseurs
        public Dictionary<Produit, int> Articles
        {
            get { return this.articles; }
            set { this.articles = value; }
        }
        public double PrixTotal
        {
            get { return this.prixTotal; }
            set { this.prixTotal = value; }
        }

        //Constructeurs dispensables. Chaque entreprise possède un panier qui lui est propre et les exceptions seront gérées dans la classe Entrerise. 
        //Seule la taille max est définie lors de la construction.
        public Panier(int tailleMax)
        {
            this.tailleMax = tailleMax;
            this.articles = new Dictionary<Produit, int>();
        }

        ////////////////////
        // Fonctionalités //
        ////////////////////

        //AjouterProduit ajoute une quantité définie de produits au panier 
        //On suppose que les valeurs données sont consistentes (pas de gestion d'exception de la valeur en paramètre)
        public void AjouterProduits(Produit produit, int quantite)
        {

            //on teste si la place est suffisante dans le panier
            int placesRestantes = this.GetPlacesRestantes();
            if (quantite > placesRestantes)
            {
                Console.WriteLine("Place insuffisante dans la panier. Il y a " + (quantite - placesRestantes) + " produits en trop.");
            }

            else
            {
                Console.WriteLine("Place suffisante.");

                //Booléen permettant de sauvegarder la présence ou non du produit dans le panier
                bool trouve = false;

                foreach (KeyValuePair<Produit, int> entry in articles)
                {
                    //Si le produit existe déja dans le panier, on incrémente juste sa valeur
                    if (entry.Key == produit)
                    {
                        trouve = true;
                    }
                }

                //Si le produit n'a pas été trouvé, on le créé directement
                if (!trouve)
                {
                    this.articles.Add(produit, quantite);
                    Console.WriteLine("L'article a bien été créée puis ajouté au panier.");
                }
                else
                {
                    articles[produit] += quantite;
                    Console.WriteLine("Il y a maintenant dans le panier " + articles[produit] + " articles de type: " + produit.ToString());
                }
            }
        } 

        //RetirerProduits retire pour un type de produit la quantité souhaitée de ce type depuis le panier
        //On suppose que les valeurs données sont consistentes (pas de gestion d'exception)
        public void RetirerProduits(Produit produit, int quantite)
        {
            //Booléen permettant de sauvegarder la présence ou non du produit dans le panier
            bool trouve = false;

            //Parcours de la liste de produit our vérifier l'existance du produit dans le panier
            foreach (KeyValuePair<Produit, int> entry in articles)
            {
                if (entry.Key == produit)
                {
                    //Si le produit est trouvé ET que la quantité retirée ne donne pas de nombres inférieurs ou égal à , on soustraie simplement les 2 valeurs
                    if (articles[produit] - quantite > 0) 
                    {
                        articles[produit] -= quantite;
                        Console.WriteLine("Il y a maintenant dans le panier " + articles[produit] + " articles de type: " + produit.ToString());
                    }
                    //Si la quantité retirée est plus grande ou égale à la quantité présente dans le panier, on retire le produit du panier
                    else
                    {
                        articles.Remove(produit);
                        Console.WriteLine("Il n'y a maintenant dans le panier plus de produit de type " + produit.ToString());
                    }
                    trouve = true;
                }
            }

            //Logs
            if (!trouve)
                Console.WriteLine("Ce produit n'existe pas dans ce panier. Action impossible.");
            else
                Console.WriteLine("L'action a bien été effectuée.");
        }

        //Récupération de toutes les places restantes dans le panier. On compte les nombres d'instances total plutot que le nombre de type différent.
        public int GetPlacesRestantes()
        {
            int res = 0;
            foreach (KeyValuePair<Produit, int> entry in articles)
            {
                res += entry.Value;
            }
            return 900-res;
        }

        //Fonction permettant de récupérer le montant total du panier
        public int GetPrixTotal()
        {
            int res = 0;
            foreach (KeyValuePair<Produit, int> entry in articles)
            {
                res += entry.Key.Prix * entry.Value;
            }
            return res;
        }

        //Affichage
        public override string ToString()
        {
            string res = "Début du Panier\n-\n";
            foreach (KeyValuePair<Produit, int> entry in articles)
            {
                res += entry.Key.ToString() + "quantité : " + entry.Value + "\n-\n";
            }

            return res + "Fin du Panier\n";
        }
    }
}
