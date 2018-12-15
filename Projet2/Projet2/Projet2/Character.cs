using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet2
{
    public class Character
    {
        //Attribute
        private int id;
        private string firstname;
        private string lastname;
        private int age;
        private string race;
        private TypeOfSoldier typeOfSoldier;

        //Getter&Setter
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Firstname
        {
            get { return this.firstname; }
            set { this.firstname = value; }
        }
        public string Lastname
        {
            get { return this.lastname; }
            set { this.lastname = value; }
        }
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
        public string Race
        {
            get { return this.race; }
            set { this.race = value; }
        }
        public TypeOfSoldier TypeOfSoldier
        {
            get { return this.typeOfSoldier; }
            set { this.typeOfSoldier = value; }
        }

        //Constructors
        public Character(int id, string firstname, string lastname, int age, string race, TypeOfSoldier typeOfSoldier)
        {
            this.Id = id;
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Age = age;
            this.Race = race;
            this.TypeOfSoldier = typeOfSoldier;
        }

        public Character()
        {
            this.Id = 0;
            this.Firstname = "";
            this.Lastname = "";
            this.Age = 0;
            this.Race = "";
            this.TypeOfSoldier = TypeOfSoldier.Other;
        }

        //ToString
        public override string ToString()
        {
            string tmp = "";
            tmp += "ID : " + this.Id + " / Firstname : " + this.Firstname + " / Lastname : " + this.Lastname + " / Age : " + this.Age + " / Race : " + this.Race + " / Type of soldier : " + this.TypeOfSoldier;
            return tmp;
        }
    }
}
