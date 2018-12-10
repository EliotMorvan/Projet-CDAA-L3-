using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet2
{
    public class Planets
    {
        //Attributes
        private List<Planet> listPlanet;

        //Getter&Setter
        internal List<Planet> ListPlanet
        {
            get { return this.listPlanet; }
            set { this.listPlanet = value; }
        }

        //Constructors
        public Planets(List<Planet> listPlanet)
        {
            this.ListPlanet = listPlanet;
        }

        //Default constructor
        public Planets()
        {
            this.listPlanet = new List<Planet>();
        } 

        //Overrides
        //ToString
        public override string ToString()
        {
            string tmp = "";
            for (int i = 0; i < this.ListPlanet.Count; i++)
            {
                tmp += this.ListPlanet[i].ToString();
            }
            return tmp;
        }

        //Methods
        public void addPlanet(Planet p)
        {
            this.ListPlanet.Add(p);
        }

        public void deletePlanet(int id)
        {
            for (int i = 0; i < this.ListPlanet.Count; i++)
            {
                if (this.ListPlanet[i].Id == id)
                {
                    this.ListPlanet.Remove(this.ListPlanet[i]);
                }
            }
        }

        public Planets getPlanetByName(string name)
        {
            Planets planets = new Planets();
            for (int i = 0; i < this.ListPlanet.Count; i++)
            {
                if (this.ListPlanet[i].Name == name)
                {
                    planets.addPlanet(this.ListPlanet[i]);
                }
            }
            return planets;
        }

        public Planet getPlanetByID(int id)
        {
            Planet pNotFound = new Planet();
            for (int i = 0; i < this.ListPlanet.Count; i++)
            {
                if (this.ListPlanet[i].Id == id)
                {
                    return this.ListPlanet[i];
                }
            }
            return pNotFound;
        }
    }
}
