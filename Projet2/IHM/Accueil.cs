using Projet2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IHM
{
    public partial class Accueil : Form
    {
        private Characters characters;
        private Planets planets;
        private List<Control> mainPageButtons = new List<Control>();
        private List<Control> addCharPageButtons = new List<Control>();

        //Get / Set
        public Characters Characters
        {
            get { return this.characters; }
        }

        //Constructeur / Initialisation de l'interface
        public Accueil()
        {
            InitializeComponent();
            Projet2.Program.initForTest(ref planets, ref characters);
            RegisterButtons();
            displayMainPageButtons();
        }

        /////////////////////////////////
        // Implemented functionalities //
        /////////////////////////////////

        //Stock all buttons of the main page on a List
        public void RegisterButtons()
        {
            this.m_displayAllCharacters = new System.Windows.Forms.Button();
            this.m_displayAllPlanets = new System.Windows.Forms.Button();
            this.m_addACharacter = new System.Windows.Forms.Button();
            this.l_display = new System.Windows.Forms.Label();
            this.l_planet = new System.Windows.Forms.Label();
            this.l_firstName = new System.Windows.Forms.Label();
            this.tb_firstName = new System.Windows.Forms.TextBox();
            this.l_lastName = new System.Windows.Forms.Label();
            this.tb_lastName = new System.Windows.Forms.TextBox();
            this.l_age = new System.Windows.Forms.Label();
            this.tb_age = new System.Windows.Forms.TextBox();
            this.l_race = new System.Windows.Forms.Label();
            this.tb_race = new System.Windows.Forms.TextBox();
            this.cb_planetChoice = new System.Windows.Forms.ComboBox();
            this.b_add = new System.Windows.Forms.Button();
            this.b_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            this.l_planet = new System.Windows.Forms.Label();
            this.l_firstName = new System.Windows.Forms.Label();
            this.tb_firstName = new System.Windows.Forms.TextBox();
            this.l_lastName = new System.Windows.Forms.Label();
            this.tb_lastName = new System.Windows.Forms.TextBox();
            this.l_age = new System.Windows.Forms.Label();
            this.tb_age = new System.Windows.Forms.TextBox();
            this.l_race = new System.Windows.Forms.Label();
            this.tb_race = new System.Windows.Forms.TextBox();
            this.l_typeOfSoldier = new System.Windows.Forms.Label();
            this.cb_typeOfSoldier = new System.Windows.Forms.ComboBox();
            this.cb_planetChoice = new System.Windows.Forms.ComboBox();
            this.b_add = new System.Windows.Forms.Button();
            this.b_cancel = new System.Windows.Forms.Button();

            // 
            // m_displayAllCharacters
            // 
            this.m_displayAllCharacters.Location = new System.Drawing.Point(12, 12);
            this.m_displayAllCharacters.Name = "m_displayAllCharacters";
            this.m_displayAllCharacters.Size = new System.Drawing.Size(121, 23);
            this.m_displayAllCharacters.TabIndex = 0;
            this.m_displayAllCharacters.Text = "Display all characters";
            this.m_displayAllCharacters.UseVisualStyleBackColor = true;
            this.m_displayAllCharacters.Click += new System.EventHandler(this.m_displayAllCharacters_Click);
            // 
            // m_displayAllPlanets
            // 
            this.m_displayAllPlanets.Location = new System.Drawing.Point(139, 12);
            this.m_displayAllPlanets.Name = "m_displayAllPlanets";
            this.m_displayAllPlanets.Size = new System.Drawing.Size(121, 23);
            this.m_displayAllPlanets.TabIndex = 2;
            this.m_displayAllPlanets.Text = "Display all planets";
            this.m_displayAllPlanets.UseVisualStyleBackColor = true;
            this.m_displayAllPlanets.Click += new System.EventHandler(this.m_displayAllPlanets_Click);
            // 
            // m_addACharacter
            // 
            this.m_addACharacter.Location = new System.Drawing.Point(266, 12);
            this.m_addACharacter.Name = "m_addACharacter";
            this.m_addACharacter.Size = new System.Drawing.Size(121, 23);
            this.m_addACharacter.TabIndex = 3;
            this.m_addACharacter.Text = "Add a character";
            this.m_addACharacter.UseVisualStyleBackColor = true;
            this.m_addACharacter.Click += new System.EventHandler(this.m_addACharacter_Click);
            // 
            // l_display
            // 
            l_display.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            l_display.AutoSize = true;
            l_display.Location = new Point(10, 100);
            l_display.Text = planets.ToString();
            // 
            // l_planet
            // 
            this.l_planet.AutoSize = true;
            this.l_planet.Location = new System.Drawing.Point(157, 18);
            this.l_planet.Name = "l_planet";
            this.l_planet.Size = new System.Drawing.Size(37, 13);
            this.l_planet.TabIndex = 1;
            this.l_planet.Text = "Planet";
            // 
            // l_firstName
            // 
            this.l_firstName.AutoSize = true;
            this.l_firstName.Location = new System.Drawing.Point(157, 44);
            this.l_firstName.Name = "l_firstName";
            this.l_firstName.Size = new System.Drawing.Size(55, 13);
            this.l_firstName.TabIndex = 3;
            this.l_firstName.Text = "First name";
            // 
            // tb_firstName
            // 
            this.tb_firstName.Location = new System.Drawing.Point(12, 38);
            this.tb_firstName.Name = "tb_firstName";
            this.tb_firstName.Size = new System.Drawing.Size(121, 20);
            this.tb_firstName.TabIndex = 2;
            // 
            // l_lastName
            // 
            this.l_lastName.AutoSize = true;
            this.l_lastName.Location = new System.Drawing.Point(157, 70);
            this.l_lastName.Name = "l_lastName";
            this.l_lastName.Size = new System.Drawing.Size(56, 13);
            this.l_lastName.TabIndex = 5;
            this.l_lastName.Text = "Last name";
            // 
            // tb_lastName
            // 
            this.tb_lastName.Location = new System.Drawing.Point(12, 64);
            this.tb_lastName.Name = "tb_lastName";
            this.tb_lastName.Size = new System.Drawing.Size(121, 20);
            this.tb_lastName.TabIndex = 4;
            // 
            // l_age
            // 
            this.l_age.AutoSize = true;
            this.l_age.Location = new System.Drawing.Point(157, 96);
            this.l_age.Name = "l_age";
            this.l_age.Size = new System.Drawing.Size(26, 13);
            this.l_age.TabIndex = 7;
            this.l_age.Text = "Age";
            // 
            // tb_age
            // 
            this.tb_age.Location = new System.Drawing.Point(12, 90);
            this.tb_age.Name = "tb_age";
            this.tb_age.Size = new System.Drawing.Size(121, 20);
            this.tb_age.TabIndex = 6;
            // 
            // l_race
            // 
            this.l_race.AutoSize = true;
            this.l_race.Location = new System.Drawing.Point(157, 122);
            this.l_race.Name = "l_race";
            this.l_race.Size = new System.Drawing.Size(33, 13);
            this.l_race.TabIndex = 9;
            this.l_race.Text = "Race";
            // 
            // tb_race
            // 
            this.tb_race.Location = new System.Drawing.Point(12, 116);
            this.tb_race.Name = "tb_race";
            this.tb_race.Size = new System.Drawing.Size(121, 20);
            this.tb_race.TabIndex = 8;
            // 
            // l_typeOfSoldier
            // 
            this.l_typeOfSoldier.AutoSize = true;
            this.l_typeOfSoldier.Location = new System.Drawing.Point(157, 148);
            this.l_typeOfSoldier.Name = "l_race";
            this.l_typeOfSoldier.Size = new System.Drawing.Size(33, 13);
            this.l_typeOfSoldier.TabIndex = 9;
            this.l_typeOfSoldier.Text = "Type of soldier";
            // 
            // cb_typeOfSoldier
            // 
            this.cb_planetChoice.FormattingEnabled = true;
            this.cb_typeOfSoldier.Location = new System.Drawing.Point(12, 142);
            this.cb_typeOfSoldier.Name = "tb_race";
            this.cb_typeOfSoldier.Size = new System.Drawing.Size(121, 20);
            this.cb_typeOfSoldier.TabIndex = 9;
            SetTypeOfSoldiers();
            // 
            // cb_planetChoice
            // 
            this.cb_planetChoice.FormattingEnabled = true;
            this.cb_planetChoice.Location = new System.Drawing.Point(12, 10);
            this.cb_planetChoice.Name = "cb_planetChoice";
            this.cb_planetChoice.Size = new System.Drawing.Size(121, 21);
            this.cb_planetChoice.TabIndex = 10;
            // 
            // b_add
            // 
            this.b_add.Location = new System.Drawing.Point(12, 185);
            this.b_add.Name = "b_add";
            this.b_add.Size = new System.Drawing.Size(75, 23);
            this.b_add.TabIndex = 11;
            this.b_add.Text = "Add";
            this.b_add.UseVisualStyleBackColor = true;
            this.b_add.Click += new System.EventHandler(this.b_add_Click);
            // 
            // b_cancel
            // 
            this.b_cancel.Location = new System.Drawing.Point(93, 185);
            this.b_cancel.Name = "b_cancel";
            this.b_cancel.Size = new System.Drawing.Size(75, 23);
            this.b_cancel.TabIndex = 12;
            this.b_cancel.Text = "Cancel";
            this.b_cancel.UseVisualStyleBackColor = true;
            this.b_cancel.Click += new System.EventHandler(this.b_cancel_Click);

            //Stock all buttons on their respective list
            //Main page
            mainPageButtons.Add(m_displayAllCharacters);
            mainPageButtons.Add(m_displayAllPlanets);
            mainPageButtons.Add(m_addACharacter);

            //Add a character page
            addCharPageButtons.Add(l_planet);
            addCharPageButtons.Add(l_firstName);
            addCharPageButtons.Add(tb_firstName);
            addCharPageButtons.Add(l_lastName);
            addCharPageButtons.Add(tb_lastName);
            addCharPageButtons.Add(l_age);
            addCharPageButtons.Add(tb_age);
            addCharPageButtons.Add(l_race);
            addCharPageButtons.Add(tb_race);
            addCharPageButtons.Add(l_typeOfSoldier);
            addCharPageButtons.Add(cb_typeOfSoldier);
            addCharPageButtons.Add(cb_planetChoice);
            addCharPageButtons.Add(b_add);
            addCharPageButtons.Add(b_cancel); 
        }

        //Display the main page components
        private void displayMainPageButtons()
        {
            mainPageButtons.ForEach(button => this.Controls.Add(button));
        }

        //Display the add character page components
        private void displayAddCharPageButtons()
        {
            addCharPageButtons.ForEach(button => this.Controls.Add(button));
        }

        //Appel régulier de la combobox afin d'avoir également les planètes ajoutées durant l'exécution
        public void SetPlanetChoices()
        {
            Dictionary<Planet, string> values = new Dictionary<Planet, string>();
            for (int i = 0; i < planets.ListPlanet.Count; i++)
            {
                values.Add(planets.ListPlanet[i], planets.ListPlanet[i].Name);
            }

            cb_planetChoice.DataSource = new BindingSource(values, null);
            cb_planetChoice.DisplayMember = "Value";
            cb_planetChoice.ValueMember = "Key";
        }

        public void SetTypeOfSoldiers()
        {
            Dictionary<TypeOfSoldier, string> values = new Dictionary<TypeOfSoldier, string>();
                values.Add(TypeOfSoldier.Droide, TypeOfSoldier.Droide.ToString());
                values.Add(TypeOfSoldier.Gungan, TypeOfSoldier.Gungan.ToString());
                values.Add(TypeOfSoldier.Jedi, TypeOfSoldier.Jedi.ToString());
                values.Add(TypeOfSoldier.Other, TypeOfSoldier.Other.ToString());
                values.Add(TypeOfSoldier.Sith, TypeOfSoldier.Sith.ToString());
                values.Add(TypeOfSoldier.Trooper, TypeOfSoldier.Trooper.ToString());

            cb_typeOfSoldier.DataSource = new BindingSource(values, null);
            cb_typeOfSoldier.DisplayMember = "Value";
            cb_typeOfSoldier.ValueMember = "Key";
        }

        //////////////////////////
        // Every button actions //
        //////////////////////////

        //Action on the "display all characters" button
        private void m_displayAllCharacters_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            displayMainPageButtons();
            l_display.Text = characters.ToString();
            this.Controls.Add(l_display);
        }

        //Action on the "display all planets" button
        private void m_displayAllPlanets_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            displayMainPageButtons();
            l_display.Text = planets.ToString();
            this.Controls.Add(l_display);
        }
        
        //Action on the "add a character" button
        private void m_addACharacter_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            displayAddCharPageButtons();
            SetPlanetChoices();
        }

        //Action on the "cancel" button
        private void b_cancel_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            displayMainPageButtons();
        }

        //Action on the "add" button
        private void b_add_Click(object sender, EventArgs e)
        {
            //Get all values
            string firstName = tb_firstName.Text;
            string lastName = tb_lastName.Text;
            int age = Convert.ToInt32(tb_age.Text);
            string race = tb_race.Text;
            TypeOfSoldier type = ((KeyValuePair<TypeOfSoldier, string>)cb_typeOfSoldier.SelectedItem).Key;

            //Create new character
            Character newChar = new Character(characters.ListCharacter.Count, firstName, lastName, age, race, type);

            //Add it to the characters list
            this.characters.addCharacter(newChar);
            
        }
    }
}
