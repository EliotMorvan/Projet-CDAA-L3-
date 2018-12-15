using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet2
{
    public class DeadCharacter : Character
    {
        //Attribute
        private int yearOfTheDeath;

        //Get/set
        public int YearOfTheDeath
        {
            get { return this.yearOfTheDeath; }
            set { this.yearOfTheDeath = value; }
        }

        //Constructors
        public DeadCharacter(int id, string firstname, string lastname, int age, string race, TypeOfSoldier typeOfSoldier, int yearOfTheDeath) : base(id, firstname, lastname, age, race, typeOfSoldier)
        {
            this.YearOfTheDeath = yearOfTheDeath;
        }

        public DeadCharacter() : base()
        {
            this.YearOfTheDeath = 0;
        }

        //Overrides
        //ToString
        public override string ToString()
        {
            string tmp = "";
            tmp = base.ToString();
            tmp += " / Year of death : " + this.YearOfTheDeath;
            return tmp;
        }
    }
}
