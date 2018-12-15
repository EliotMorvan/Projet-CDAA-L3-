using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet2
{
    public class Planet
    {
        //Attributes
        private int id;
        private string name;
        private string localization;
        private int population;
        private string language;
        private string climate;
        internal Characters charactersFrom;

        //Constructor
        public Planet(int id, string name, string localization, int population, string language, string climate, Characters charactersFrom)
        {
            this.Id = id;
            this.Name = name;
            this.Localization = localization;
            this.Population = population;
            this.Language = language;
            this.Climate = climate;
            this.CharactersFrom = charactersFrom;
        }

        public Planet()
        {
            this.charactersFrom = new Characters();
        }

        //Getter&Setter
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Localization
        {
            get { return this.localization; }
            set { this.localization = value; }
        }
        public int Population
        {
            get { return this.population; }
            set { this.population = value; }
        }
        public string Language
        {
            get { return this.language; }
            set { this.language = value; }
        }
        public string Climate
        {
            get { return this.climate; }
            set { this.climate = value; }
        }
        public Characters CharactersFrom
        {
            get { return this.charactersFrom; }
            set { this.charactersFrom = value; }
        }

        //Overrides
        //ToString
        public override string ToString()
        {
            string tmp = "";
            tmp += "ID : " + this.Id + " / Name : " + this.Name + " / Localization : " + this.Localization + " / Population : " + this.Population + " / Language : " + this.Language + " / Climate : " + this.Climate + "\n";
            return tmp;
        }

        //Methods
        public void addCharacter(Character cToAdd)
        {
            this.CharactersFrom.addCharacter(cToAdd);
        }

    }
}
