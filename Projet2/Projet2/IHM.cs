using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet2
{
    public class IHM
    {
        //Passage par référence
        public static void initForTest(ref Planets planets, ref Characters characters)
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
    }
}
