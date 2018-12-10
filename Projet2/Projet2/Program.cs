using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet2
{
    public class Program
    {
        private static Characters characters;
        private static Planets planets;

        static void Main(string[] args)
        {
            //Test
            initForTest();
            displayMainMenu();
        }

        public static void initForTest()
        {
            //Declare characters
            Character cYoda = new Character(1, "Yoda", "No lastname", 800, "Unknown", TypeOfSoldier.Jedi);
            Character cJJB = new Character(2, "Jar Jar", "Binks", 30, "Gungan", TypeOfSoldier.Gungan);
            Character cBenK = new Character(3, "Ben", "Kenobi", 75, "Human", TypeOfSoldier.Jedi);
            Character cBenK2 = new Character(5, "Ben", "Kenobi2", 75, "Human", TypeOfSoldier.Jedi);
            Character cDV = new Character(4, "Dark Vador", "No lastname", 75, "Human", TypeOfSoldier.Sith);

            //Declare Characters object
            characters = new Characters();

            //Add this characters into the list
            characters.addCharacter(cYoda);
            characters.addCharacter(cJJB);
            characters.addCharacter(cBenK);
            characters.addCharacter(cBenK2);
            characters.addCharacter(cDV);

            //Declare planets
            Planet pTatooine = new Planet(1, "Tatooine", "Mid Rim", 200000, "Basic", "Hot", new Characters());
            Planet pNaboo = new Planet(2, "Naboo", "Mid Rim", 625000000, "Basic/Gungan", "Temperate", new Characters());

            //add characters for any planets
            pTatooine.addCharacter(cBenK);

            pNaboo.addCharacter(cJJB);

            //Declare Planets object
            planets = new Planets();

            //Add this planets into the Planets object
            planets.addPlanet(pTatooine);
            planets.addPlanet(pNaboo);

        }

        public static void displayMainMenu() //Enable to display a menu
        {
            int choice;

            Console.WriteLine("1. Display all characters\n -------------------------");
            Console.WriteLine("2. Display all planets\n -------------------------");
            Console.WriteLine("3. Display a character(with name)\n -------------------------");
            Console.WriteLine("4. Display a planet(with name)\n -------------------------");
            Console.WriteLine("5. Add a character\n -------------------------");
            Console.WriteLine("6. Add a planet\n -------------------------");
            Console.WriteLine("7. Delete a character\n -------------------------");
            Console.WriteLine("8. Delete a planet\n -------------------------");
            Console.WriteLine("Choose (1/2/3/4/5/6/7) :");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine(characters.ToString());
                    displayBackMenu();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine(planets.ToString());
                    displayBackMenu();
                    break;
                case 3:
                    Console.Clear();
                    displayOneCharacter();
                    break;
                case 4:
                    Console.Clear();
                    displayOnePlanet();
                    break;
                case 5:
                    Console.Clear();
                    addACharacter();
                    break;
                case 6:
                    Console.Clear();
                    addAPlanet();
                    break;
                case 7:
                    Console.Clear();
                    deleteACharacter();
                    break;
                case 8:
                    Console.Clear();
                    deleteAPlanet();
                    break;
            }



        }

        public static void addACharacter()
        {
            Console.WriteLine("Planet or quit (Q): ");
            string planet = Console.ReadLine();
            if (planet == "Q" || planet == "q")
            {
                Console.Clear();
                displayMainMenu();
            }
            Planet planetOfTheCharacter = new Planet();
            Planets pFounds = planets.getPlanetByName(planet);
            if (pFounds.ListPlanet.Count == 0) //If any planet match with the name
            {
                Console.Clear();
                Console.WriteLine("The name doesn't match with a character. Retry !");
                addACharacter();
            }
            else if (pFounds.ListPlanet.Count == 1)
            {
                planetOfTheCharacter = pFounds.ListPlanet[0];
            }
            else
            {
                Console.WriteLine(pFounds.ToString());
                Console.WriteLine("Choose with ID : ");
                int choice = int.Parse(Console.ReadLine());
                planetOfTheCharacter = pFounds.getPlanetByID(choice);
            }


            Console.WriteLine("Firstname : ");
            string firstnameOfCharacter = Console.ReadLine();

            Console.WriteLine("Lastname : ");
            string lastnameOfCharacter = Console.ReadLine();

            Console.WriteLine("Age : ");
            int ageOfCharacter = int.Parse(Console.ReadLine());

            Console.WriteLine("Race : ");
            string raceOfCharacter = Console.ReadLine();

            Console.WriteLine("Type of soldier : ");
            string stringTOSOfCharacter = Console.ReadLine();

            TypeOfSoldier TOSOfCharacter = TypeOfSoldier.Other;
            switch (stringTOSOfCharacter)
            {
                case "Jedi":
                    TOSOfCharacter = TypeOfSoldier.Jedi;
                    break;
                case "Sith":
                    TOSOfCharacter = TypeOfSoldier.Sith;
                    break;
                case "Trooper":
                    TOSOfCharacter = TypeOfSoldier.Trooper;
                    break;
                case "Droide":
                    TOSOfCharacter = TypeOfSoldier.Droide;
                    break;
                case "Gungan":
                    TOSOfCharacter = TypeOfSoldier.Gungan;
                    break;
            }

            Character newCharacter = new Character();

            Console.WriteLine("Is he dead ? (y/n)");
            string answer = Console.ReadLine();
            if (answer == "y" || answer == "Y")
            {
                Console.WriteLine("Year of death :");
                int yearOfDeathOfTheCharacter = int.Parse(Console.ReadLine());
                newCharacter = new DeadCharacter(characters.ListCharacter.Count, firstnameOfCharacter, lastnameOfCharacter, ageOfCharacter, raceOfCharacter, TOSOfCharacter, yearOfDeathOfTheCharacter);
            }
            else
            {
                newCharacter = new Character(characters.ListCharacter.Count, firstnameOfCharacter, lastnameOfCharacter, ageOfCharacter, raceOfCharacter, TOSOfCharacter);
            }
            planetOfTheCharacter.addCharacter(newCharacter);
            characters.addCharacter(newCharacter);
            Console.WriteLine("The chararcter has been added !");
            displayBackMenu();

        }

        public static void addAPlanet()
        {
            Console.WriteLine("Name : ");
            string nameOfPlanet = Console.ReadLine();

            Console.WriteLine("Localization : ");
            string localizationOfPlanet = Console.ReadLine();

            Console.WriteLine("Population : ");
            int populationOfPlanet = int.Parse(Console.ReadLine());

            Console.WriteLine("Language : ");
            string languageOfPlanet = Console.ReadLine();

            Console.WriteLine("Climate : ");
            string climateOfPlanet = Console.ReadLine();

            Characters charactersFrom = new Characters();

            int idOfPlanet = planets.ListPlanet.Count;

            Planet pToAdd = new Planet(idOfPlanet, nameOfPlanet, localizationOfPlanet, populationOfPlanet, languageOfPlanet, climateOfPlanet, charactersFrom);
            planets.addPlanet(pToAdd);

            Console.WriteLine("The planet has been added !");
            displayBackMenu();
        }

        public static void displayBackMenu()
        {
            Console.WriteLine("Press Q to return to the main menu !");
            string choice = Console.ReadLine();
            if (choice == "q" || choice == "Q")
            {
                Console.Clear();
                displayMainMenu();
            }
            else displayBackMenu();
        }

        public static void displayOneCharacter()
        {
            Console.WriteLine("Enter a name or quit (Q):");
            string nameOfCharacter = Console.ReadLine();
            if (nameOfCharacter == "Q" || nameOfCharacter == "q")
            {
                Console.Clear();
                displayMainMenu();
            }
            Characters cFounds = characters.getCharacterByName(nameOfCharacter);
            if (cFounds.ListCharacter.Count == 0) //If any characters match with the name
            {
                Console.Clear();
                Console.WriteLine("The name doesn't match with a character. Retry !");
                displayOneCharacter();
            }
            else
            {
                Console.Clear();
                Console.WriteLine(cFounds.ToString());
                displayBackMenu();
            }
        }

        public static void displayOnePlanet()
        {
            Console.WriteLine("Enter a name or quit (Q):");
            string nameOfPlanet = Console.ReadLine();
            if (nameOfPlanet == "Q" || nameOfPlanet == "q")
            {
                Console.Clear();
                displayMainMenu();
            }
            Planets pFounds = planets.getPlanetByName(nameOfPlanet);
            if (pFounds.ListPlanet.Count == 0) //If any characters match with the name
            {
                Console.Clear();
                Console.WriteLine("The name doesn't match with a planet. Retry !");
                displayOnePlanet();
            }
            else
            {
                Console.Clear();
                Console.WriteLine(pFounds.ToString());
                displayBackMenu();
            }
        }

        public static void deleteACharacter()
        {
            Console.WriteLine("ID of the character to delete :");
            int idToDelete = int.Parse(Console.ReadLine());
            int indicator = 0;

            //Delete on the main list
            characters.deleteCharacter(idToDelete);

            //Delete character on a planet
            for (int i = 0; i < planets.ListPlanet.Count; i++)
            {
                for (int j = 0; j < planets.ListPlanet[i].CharactersFrom.ListCharacter.Count; j++)
                {
                    if (planets.ListPlanet[i].CharactersFrom.ListCharacter[j].Id == idToDelete)
                    {
                        planets.ListPlanet[i].CharactersFrom.deleteCharacter(idToDelete);
                        Console.WriteLine("The character has been deleted !");
                        displayBackMenu();
                        indicator = 1;
                        break;
                    }
                }
            }

            if (indicator == 0)
            {
                Console.WriteLine("The character has been deleted !");
                displayBackMenu();
            }

        }

        public static void deleteAPlanet()
        {
            Console.WriteLine("ID of the planet to delete :");
            int idToDelete = int.Parse(Console.ReadLine());

            planets.deletePlanet(idToDelete);
            Console.WriteLine("The planet has been deleted");
            displayBackMenu();
        }
    }
}
