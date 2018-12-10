using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_CDAA_EliotMorvan.Produits;

namespace TP_CDAA_EliotMorvan.Gestion
{
    public class PanierClassique
    {
        private Produit[] panier;
        private int index;

        //Accesseurs
        public Produit[] Panier
        {
            get { return this.panier; }
            set { this.panier = value; }
        }
        //L'index est accessible en lecture seule
        public int Index {
            get { return this.index; }
        }

        //constructeurs
        public PanierClassique()
        {
            this.panier = new Produit[500];
            index = 0;
        }

        public PanierClassique(int length)
        {
            this.panier = new Produit[length];
            index = 0;
        }

        //Fonctionalités basiques de gestion du panier
        //Ajout simple
        public void AjouterProduit(Produit p)
        {
            panier[index] = p;
            index += 1;
        }

        //retire le produit une seule fois
        public void RetirerProduit(Produit p)
        {
            for (int i = 0; i <= index - 1; i++)
            {
                if (panier[i].Id == p.Id)
                {
                    panier[i] = null;
                    break;
                }
            }
        }

        //Retirer toutes les instances d'un produit
        public void RetirerTous(Produit p)
        {
            for (int i = 0; i <= index - 1; i++)
            {
                if (panier[i].Id == p.Id)
                {
                    panier[i] = null;
                }
            }
        }

        //Affichage
        public override string ToString()
        {
            string res = "- PanierClassique\n";
            for (int i = 0; i <= panier.Length - 1; i++)
            {
                if (panier[i] == null)
                    res += "[" + i + "]\n";
                else
                    res += "[" + i + "] - " + panier[i].ToString();
            }

            return res + "- Fin du panier classique";
        }

        //Appel de la fonction lors de tout changement dans la liste. 
        //Permet de recentrer tous les éléments à la suite 
        public void UpdateOnChange()
        {
            //Creation d'un nouveau panier de même forme et d'un nouvel index
            int length = this.panier.Length;
            Produit[] newPanier = new Produit[length];
            int newIndex = 0;

            //Attribution de chaque instance du panier originel dans le nouveau
            for (int i = 0; i <= this.panier.Length-1; i++)
            {
                if(panier[i] != null)
                {
                    newPanier[newIndex] = panier[i];
                    newIndex += 1;
                }
            }

            //Le panier ne contient plus de "vides" entre les instances d'objet
            //l'index est fixé sur le tableau et est donc également vérifié
            this.panier = newPanier;
            this.index = newIndex;
        }

        //Le tri par ID est en 2 étapes:
        public void TriParId()
        {
            //PanierConverti a le même contenu que le panier principal. Tous les produits apparaiteront sous forme d'entiers et tous les produits identiques auront un numéro identique.
            int[] panierConverti = new int[panier.Length];
            
            //ListeId est la liste de tous les ID uniques enregistrés dans le panier à chaque instant du parcours du panier.
            string[] listeId = new string[panier.Length];

            //Indique si l'ID du produit à un indice a été trouvé dans le tableau d'ID.
            bool idFound = false;

            //Indice du tableau d'ID.
            int indexListeId = 0;

            //Etape1: Transformer le panier existant en un tableau d'entier aux indices similaires.
            //Chaque produit du panier ayant le même ID aura le même entier attribué dans le tableau converti.

            //Parcours entier du panier.
            for (int i = 0; i <= this.panier.Length - 1; i++)
            {
                //On vérifie si l'instance i du panier n'est pas nulle.
                if (panier[i] != null)
                {
                    //Puis on compare son ID avec le tableau d'ID enregistrés jusqu'alors.
                    for (int j = 0; j <= listeId.Length - 1; j++)
                    {
                        //Vérificationque l'indice j du tableau d'ID n'est pas null.
                        if (listeId[j] != null)
                        {
                            //Comparaison entre les 2 ID i et j.
                            if (panier[i].Id == listeId[j])
                            {
                                //Si les ID sont le même, le panier converti prend la valeur de l'indice dans le tableau d'ID + 1.
                                panierConverti[i] = -(j+1);
                                idFound = true;
                            }
                        }
                    }

                    //Si l'ID du produit i du panier n'a pas trouvé son doppleganger dans la liste d'ID enregistré, on l'enregistre puis on attribue son indice à la liste convertie.
                    if (!idFound)
                    {
                        listeId[indexListeId] = panier[i].Id;
                        panierConverti[i] = -(indexListeId+1);
                        indexListeId += 1;
                    }
                    else
                    {
                        //repassage à false de la valeur pour les prochaines itérations.
                        idFound = false;
                    }
                }
            }

            //Etape 2: On applique un algorithme de tri au tableau converti et on applique chaque étape au tableau initial également
            Quicksort(panierConverti, 0, panierConverti.Length - 1);
        }

        //Source: http://snipd.net/quicksort-in-c
        //Algorithme de tri QuickSort (modifié pour cohérence avec le programme présent)
        public void Quicksort(int[] elements, int left, int right)
        {
            int i = left, j = right;
            int pivot = elements[(left + right) / 2];

            while (i <= j)
            {
                while (elements[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (elements[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    // Swap
                    int tmp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = tmp;

                    //Même application
                    Produit tmp2 = panier[i];
                    panier[i] = panier[j];
                    panier[j] = tmp2;

                    i++;
                    j--;
                }
            }

            // Recursive calls
            if (left < j)
            {
                Quicksort(elements, left, j);
            }

            if (i < right)
            {
                Quicksort(elements, i, right);
            }
        }
        
    }
}
