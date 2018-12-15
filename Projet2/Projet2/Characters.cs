using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet2
{
    public class Characters
    {
        //Attribute
        private List<Character> listCharacter;

        //Getter&Setter
        public List<Character> ListCharacter
        {
            get { return this.listCharacter; }
            set { this.listCharacter = value; }
        }

        //Constructors
        public Characters(List<Character> listCharacter)
        {
            this.ListCharacter = listCharacter;
        }

        public Characters()
        {
            this.listCharacter = new List<Character>();
        } //Default constructor

        //Methods
        //Add
        public void addCharacter(Character c)
        {
            this.ListCharacter.Add(c);
        }

        //Delete by ID
        public void deleteCharacter(int id)
        {
            for (int i = 0; i < this.ListCharacter.Count; i++)
            {
                if (id == this.ListCharacter[i].Id)
                {
                    this.ListCharacter.Remove(this.ListCharacter[i]);
                }
            }
        }

        //Get by Name
        public Characters getCharacterByName(string name)
        {
            Characters listCharactersWithName = new Characters();
            for (int i = 0; i < this.ListCharacter.Count; i++)
            {
                if (this.ListCharacter[i].Firstname.Contains(name) || this.ListCharacter[i].Lastname.Contains(name))
                {
                    listCharactersWithName.addCharacter(this.ListCharacter[i]);
                }
            }
            return listCharactersWithName;
        }

        //Get by ID
        public Character getCharacterByID(int id)
        {
            Character charactersWithName = new Character();
            for (int i = 0; i < this.ListCharacter.Count; i++)
            {
                if (this.ListCharacter[i].Id == id)
                {
                    return this.listCharacter[i];
                }
            }
            return charactersWithName;
        }


        //Overrides
        public override string ToString()
        {
            string tmp = "";
            for (int i = 0; i < this.ListCharacter.Count; i++)
            {
                tmp += this.ListCharacter[i].ToString() + "\n";
            }
            return tmp;
        }
    }
}
