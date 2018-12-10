using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_CDAA_EliotMorvan.Gestion;
using TP_CDAA_EliotMorvan.Produits;

namespace TP_CDAA_EliotMorvan
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Création d'une entreprise distribuant toute sorte de catégories de produits. (default)
            Entreprise EV_All = new Entreprise("BuroValé", 1990, "B. Peyroles", "bp@gmail.com");
            //Display
            Console.WriteLine(EV_All.ToString());

            //Création d'une entreprise ne distribuant pas de maroquinerie
            //On enlève la catégorie de la liste d'activités de l'entreprise
            Entreprise EV_NoMaroquinerie = new Entreprise("Only Papeterie entreprise", 2018, "K. Gillotes", "kg@gmail.com");
            EV_NoMaroquinerie.EnleverCategoriesVente(Categorie.maroquinerie);
            //Display
            Console.WriteLine(EV_NoMaroquinerie.ToString());

            //Création d'une entreprise ne distribuant que de la maroquinerie
            //On peut retirer toutes les catégories de la liste et les ajouter une par une 
            Entreprise EV_OnlyMaroquinerie = new Entreprise("Only Maroquinerie entreprise", 2016, "H.Pottiers", "hp@gmail.com");
            EV_OnlyMaroquinerie.EnleverToutesCategoriesVente();
            EV_OnlyMaroquinerie.AjouterCategoriesVente(Categorie.maroquinerie);
            //Display
            Console.WriteLine(EV_OnlyMaroquinerie.ToString());

            //Création d'une entité de chaque produit manuellement
            Agenda agenda1 = new Agenda(20, "Moleskine", Color.rouge, "2017-2018", "24-32", false, true);
            Console.WriteLine(agenda1.ToString());

            Bagage bagage1 = new Bagage(80, "Nava", 47, true, Color.noire);
            Console.WriteLine(bagage1.ToString());

            Feutre feutre1 = new Feutre(1, "Pilot", 10, "dorée");
            Console.WriteLine(feutre1.ToString());

            //Creation d'un panier lors de la création 
            //Distribue tous les types de produit et ajout d'un produit
            EV_All.AjouterAuPanier(agenda1, 100);
            Console.WriteLine(EV_All.Panier.ToString());

            //ajout d'un autre produit
            EV_All.AjouterAuPanier(bagage1, 20);
            Console.WriteLine(EV_All.Panier.ToString());

            //ajout du même produit agenda1 (expect: 150 unités d'agenda1)
            EV_All.AjouterAuPanier(agenda1, 50);
            Console.WriteLine(EV_All.Panier.ToString());

            //ajout d'un produit en quantité trop grande pour la capacité du panier
            EV_All.AjouterAuPanier(agenda1, 1000);
            Console.WriteLine(EV_All.Panier.ToString());

            //Retrait de 5 bagage1 (expect: 15 unités de bagage1)
            EV_All.RetirerDuPanier(bagage1, 5);
            Console.WriteLine(EV_All.Panier.ToString());

            //Retrait de feutres non présents dans les produits du panier
            EV_All.RetirerDuPanier(feutre1, 1);

            //Ajout de valeurs négatives
            EV_All.AjouterAuPanier(feutre1, -2);
            EV_All.AjouterAuPanier(bagage1, -2);
            Console.WriteLine(EV_All.Panier.ToString());

            //Retrait de plus de bagages que de présents dans le panier
            EV_All.RetirerDuPanier(bagage1, 60);
            Console.WriteLine(EV_All.Panier.ToString());

            //Ajout d'un produit incompatible avec le domaine de distribution de l'entreprise
            EV_NoMaroquinerie.AjouterAuPanier(bagage1, 10);
            Console.WriteLine(EV_NoMaroquinerie.Panier.ToString());

            //Ajout d'un produit et vérification de l'allocation mémoire
            Console.WriteLine("taille avant ajout : " + EV_NoMaroquinerie.Panier.GetPlacesRestantes());
            EV_NoMaroquinerie.AjouterAuPanier(agenda1, 10);
            Console.WriteLine(EV_NoMaroquinerie.Panier.ToString());
            Console.WriteLine("taille après ajout : " + EV_NoMaroquinerie.Panier.GetPlacesRestantes());

            PanierClassique panierC = new PanierClassique(20);
            panierC.AjouterProduit(agenda1);
            panierC.AjouterProduit(agenda1);

            panierC.AjouterProduit(feutre1);
            panierC.AjouterProduit(feutre1);

            panierC.AjouterProduit(agenda1);

            panierC.AjouterProduit(feutre1);
            panierC.AjouterProduit(feutre1);

            panierC.AjouterProduit(bagage1);
            panierC.AjouterProduit(bagage1);

            panierC.RetirerProduit(feutre1);

            panierC.TriParId();
            Console.WriteLine(panierC.ToString());

            //Permet de maintenir l'application ouverte
            Console.ReadLine();
        }
    }

    public enum Categorie
    {
        papeterie,
        maroquinerie,
        fournitures
    }

    public enum Color
    {
        rouge,
        noire,
        blanche,
        jaune,
        verte,
        bleue
    }
}
