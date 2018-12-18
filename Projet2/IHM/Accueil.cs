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
        private Characters characters = new Characters();
        private Planets planets = new Planets();

        private List<Control> mainPageButtons = new List<Control>();

        private List<Control> addCharPageButtons = new List<Control>();
        private List<Control> addPlanetPageButtons = new List<Control>();

        private List<Control> deletePlanetPageButtons = new List<Control>();
        private List<Control> deleteCharPageButtons = new List<Control>();

        //Constructeur / Initialisation de l'interface
        public Accueil()
        {
            InitializeComponent();
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
            this.m_addAPlanet = new System.Windows.Forms.Button();
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
            this.l_typeOfSoldier = new System.Windows.Forms.Label();
            this.cb_typeOfSoldier = new System.Windows.Forms.ComboBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.l_name = new System.Windows.Forms.Label();
            this.l_localization = new System.Windows.Forms.Label();
            this.tb_localization = new System.Windows.Forms.TextBox();
            this.l_population = new System.Windows.Forms.Label();
            this.tb_population = new System.Windows.Forms.TextBox();
            this.l_language = new System.Windows.Forms.Label();
            this.tb_language = new System.Windows.Forms.TextBox();
            this.l_climate = new System.Windows.Forms.Label();
            this.tb_climate = new System.Windows.Forms.TextBox();
            this.b_add2 = new System.Windows.Forms.Button();
            this.b_cancel2 = new System.Windows.Forms.Button();
            this.b_reset = new System.Windows.Forms.Button();
            this.b_initiate = new System.Windows.Forms.Button();
            this.b_delete_plan = new System.Windows.Forms.Button();
            this.b_delete_char = new System.Windows.Forms.Button();
            this.cb_characters = new System.Windows.Forms.ComboBox();
            this.l_characters = new System.Windows.Forms.Label();
            this.b_delete = new System.Windows.Forms.Button();
            this.b_cancel3 = new System.Windows.Forms.Button();
            this.l_planets = new System.Windows.Forms.Label();
            this.cb_planets = new System.Windows.Forms.ComboBox();
            this.b_delete2 = new System.Windows.Forms.Button();
            this.b_cancel4 = new System.Windows.Forms.Button();

            // 
            // m_displayAllCharacters
            // 
            this.m_displayAllCharacters.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.m_displayAllPlanets.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.m_addACharacter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.m_addACharacter.Location = new System.Drawing.Point(266, 12);
            this.m_addACharacter.Name = "m_addACharacter";
            this.m_addACharacter.Size = new System.Drawing.Size(121, 23);
            this.m_addACharacter.TabIndex = 3;
            this.m_addACharacter.Text = "Add a character";
            this.m_addACharacter.UseVisualStyleBackColor = true;
            this.m_addACharacter.Click += new System.EventHandler(this.m_addACharacter_Click);
            // 
            // m_addAPlanet
            // 
            this.m_addAPlanet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.m_addAPlanet.Location = new System.Drawing.Point(393, 12);
            this.m_addAPlanet.Name = "m_addAPlanet";
            this.m_addAPlanet.Size = new System.Drawing.Size(121, 23);
            this.m_addAPlanet.TabIndex = 3;
            this.m_addAPlanet.Text = "Add a Planet";
            this.m_addAPlanet.UseVisualStyleBackColor = true;
            this.m_addAPlanet.Click += new System.EventHandler(this.m_addAPlanet_Click);
            // 
            // l_display
            // 
            l_display.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            l_display.AutoSize = true;
            l_display.Location = new Point(10, 150);
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
            this.tb_firstName.Cursor = System.Windows.Forms.Cursors.IBeam;
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
            this.tb_lastName.Cursor = System.Windows.Forms.Cursors.IBeam;
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
            this.tb_age.Cursor = System.Windows.Forms.Cursors.IBeam;
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
            this.tb_race.Cursor = System.Windows.Forms.Cursors.IBeam;
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
            this.cb_typeOfSoldier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_planetChoice.FormattingEnabled = true;
            this.cb_typeOfSoldier.Location = new System.Drawing.Point(12, 142);
            this.cb_typeOfSoldier.Name = "tb_race";
            this.cb_typeOfSoldier.Size = new System.Drawing.Size(121, 20);
            this.cb_typeOfSoldier.TabIndex = 9;
            SetTypeOfSoldiers();
            // 
            // cb_planetChoice
            // 
            this.cb_planetChoice.Cursor = System.Windows.Forms.Cursors.Hand;
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
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(12, 12);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(112, 20);
            this.tb_name.TabIndex = 0;
            // 
            // l_name
            // 
            this.l_name.AutoSize = true;
            this.l_name.Location = new System.Drawing.Point(149, 19);
            this.l_name.Name = "l_name";
            this.l_name.Size = new System.Drawing.Size(33, 13);
            this.l_name.TabIndex = 1;
            this.l_name.Text = "name";
            // 
            // l_localization
            // 
            this.l_localization.AutoSize = true;
            this.l_localization.Location = new System.Drawing.Point(149, 45);
            this.l_localization.Name = "l_localization";
            this.l_localization.Size = new System.Drawing.Size(59, 13);
            this.l_localization.TabIndex = 3;
            this.l_localization.Text = "localization";
            // 
            // tb_localization
            // 
            this.tb_localization.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_localization.Location = new System.Drawing.Point(12, 38);
            this.tb_localization.Name = "tb_localization";
            this.tb_localization.Size = new System.Drawing.Size(112, 20);
            this.tb_localization.TabIndex = 2;
            // 
            // l_population
            // 
            this.l_population.AutoSize = true;
            this.l_population.Location = new System.Drawing.Point(149, 71);
            this.l_population.Name = "l_population";
            this.l_population.Size = new System.Drawing.Size(56, 13);
            this.l_population.TabIndex = 5;
            this.l_population.Text = "population";
            // 
            // tb_population
            // 
            this.tb_population.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_population.Location = new System.Drawing.Point(12, 64);
            this.tb_population.Name = "tb_population";
            this.tb_population.Size = new System.Drawing.Size(112, 20);
            this.tb_population.TabIndex = 4;
            // 
            // l_language
            // 
            this.l_language.AutoSize = true;
            this.l_language.Location = new System.Drawing.Point(149, 97);
            this.l_language.Name = "l_language";
            this.l_language.Size = new System.Drawing.Size(51, 13);
            this.l_language.TabIndex = 7;
            this.l_language.Text = "language";
            // 
            // tb_language
            // 
            this.tb_language.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_language.Location = new System.Drawing.Point(12, 90);
            this.tb_language.Name = "tb_language";
            this.tb_language.Size = new System.Drawing.Size(112, 20);
            this.tb_language.TabIndex = 6;
            // 
            // l_climate
            // 
            this.l_climate.AutoSize = true;
            this.l_climate.Location = new System.Drawing.Point(149, 123);
            this.l_climate.Name = "l_climate";
            this.l_climate.Size = new System.Drawing.Size(40, 13);
            this.l_climate.TabIndex = 9;
            this.l_climate.Text = "climate";
            // 
            // tb_climate
            // 
            this.tb_climate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_climate.Location = new System.Drawing.Point(12, 116);
            this.tb_climate.Name = "tb_climate";
            this.tb_climate.Size = new System.Drawing.Size(112, 20);
            this.tb_climate.TabIndex = 8;
            // 
            // b_add2
            // 
            this.b_add2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_add2.Location = new System.Drawing.Point(12, 158);
            this.b_add2.Name = "b_add2";
            this.b_add2.Size = new System.Drawing.Size(75, 23);
            this.b_add2.TabIndex = 10;
            this.b_add2.Text = "add";
            this.b_add2.UseVisualStyleBackColor = true;
            this.b_add2.Click += new System.EventHandler(this.b_add2_Click);
            // 
            // b_cancel2
            // 
            this.b_cancel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_cancel2.Location = new System.Drawing.Point(93, 158);
            this.b_cancel2.Name = "b_cancel2";
            this.b_cancel2.Size = new System.Drawing.Size(75, 23);
            this.b_cancel2.TabIndex = 11;
            this.b_cancel2.Text = "cancel";
            this.b_cancel2.UseVisualStyleBackColor = true;
            this.b_cancel2.Click += new System.EventHandler(this.b_cancel_Click);
            // 
            // b_reset
            // 
            this.b_reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_reset.Location = new System.Drawing.Point(12, 93);
            this.b_reset.Name = "b_reset";
            this.b_reset.Size = new System.Drawing.Size(75, 23);
            this.b_reset.TabIndex = 0;
            this.b_reset.Text = "Reset";
            this.b_reset.UseVisualStyleBackColor = true;
            this.b_reset.Click += new System.EventHandler(this.b_reset_Click);
            // 
            // b_initiate
            // 
            this.b_initiate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_initiate.Location = new System.Drawing.Point(93, 93);
            this.b_initiate.Name = "b_initiate";
            this.b_initiate.Size = new System.Drawing.Size(75, 23);
            this.b_initiate.TabIndex = 1;
            this.b_initiate.Text = "Initiate";
            this.b_initiate.UseVisualStyleBackColor = true;
            this.b_initiate.Click += new System.EventHandler(this.b_initiate_Click);
            // 
            // b_delete_plan
            // 
            this.b_delete_plan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_delete_plan.Location = new System.Drawing.Point(393, 39);
            this.b_delete_plan.Name = "b_delete_plan";
            this.b_delete_plan.Size = new System.Drawing.Size(121, 23);
            this.b_delete_plan.TabIndex = 0;
            this.b_delete_plan.Text = "Delete a planet";
            this.b_delete_plan.UseVisualStyleBackColor = true;
            this.b_delete_plan.Click += new System.EventHandler(this.b_delete_plan_Click);
            // 
            // b_delete_char
            // 
            this.b_delete_char.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_delete_char.Location = new System.Drawing.Point(266, 39);
            this.b_delete_char.Name = "b_delete_char";
            this.b_delete_char.Size = new System.Drawing.Size(121, 23);
            this.b_delete_char.TabIndex = 1;
            this.b_delete_char.Text = "Delete a character";
            this.b_delete_char.UseVisualStyleBackColor = true;
            this.b_delete_char.Click += new System.EventHandler(this.b_delete_char_Click);
            // 
            // cb_characters
            // 
            this.cb_characters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_characters.FormattingEnabled = true;
            this.cb_characters.Location = new System.Drawing.Point(12, 25);
            this.cb_characters.Name = "cb_characters";
            this.cb_characters.Size = new System.Drawing.Size(173, 21);
            this.cb_characters.TabIndex = 0;
            // 
            // l_characters
            // 
            this.l_characters.AutoSize = true;
            this.l_characters.Location = new System.Drawing.Point(12, 9);
            this.l_characters.Name = "l_characters";
            this.l_characters.Size = new System.Drawing.Size(57, 13);
            this.l_characters.TabIndex = 1;
            this.l_characters.Text = "characters";
            // 
            // b_delete
            // 
            this.b_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_delete.Location = new System.Drawing.Point(12, 102);
            this.b_delete.Name = "b_delete";
            this.b_delete.Size = new System.Drawing.Size(75, 23);
            this.b_delete.TabIndex = 2;
            this.b_delete.Text = "delete";
            this.b_delete.UseVisualStyleBackColor = true;
            this.b_delete.Click += new System.EventHandler(this.b_delete_Click);
            // 
            // b_cancel3
            // 
            this.b_cancel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_cancel3.Location = new System.Drawing.Point(110, 102);
            this.b_cancel3.Name = "b_cancel3";
            this.b_cancel3.Size = new System.Drawing.Size(75, 23);
            this.b_cancel3.TabIndex = 3;
            this.b_cancel3.Text = "cancel";
            this.b_cancel3.UseVisualStyleBackColor = true;
            this.b_cancel3.Click += new System.EventHandler(this.b_cancel_Click);
            // 
            // l_planets
            // 
            this.l_planets.AutoSize = true;
            this.l_planets.Location = new System.Drawing.Point(13, 10);
            this.l_planets.Name = "l_planets";
            this.l_planets.Size = new System.Drawing.Size(37, 13);
            this.l_planets.TabIndex = 0;
            this.l_planets.Text = "Planet";
            // 
            // cb_planets
            // 
            this.cb_planets.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_planets.FormattingEnabled = true;
            this.cb_planets.Location = new System.Drawing.Point(16, 25);
            this.cb_planets.Name = "cb_planets";
            this.cb_planets.Size = new System.Drawing.Size(173, 21);
            this.cb_planets.TabIndex = 1;
            // 
            // b_delete2
            // 
            this.b_delete2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_delete2.Location = new System.Drawing.Point(12, 102);
            this.b_delete2.Name = "b_delete2";
            this.b_delete2.Size = new System.Drawing.Size(75, 23);
            this.b_delete2.TabIndex = 2;
            this.b_delete2.Text = "delete";
            this.b_delete2.UseVisualStyleBackColor = true;
            this.b_delete2.Click += new System.EventHandler(this.b_delete2_Click);
            // 
            // b_cancel4
            // 
            this.b_cancel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_cancel4.Location = new System.Drawing.Point(110, 102);
            this.b_cancel4.Name = "b_cancel4";
            this.b_cancel4.Size = new System.Drawing.Size(75, 23);
            this.b_cancel4.TabIndex = 3;
            this.b_cancel4.Text = "cancel";
            this.b_cancel4.UseVisualStyleBackColor = true;
            this.b_cancel4.Click += new System.EventHandler(this.b_cancel_Click);

            //Stock all buttons on their respective list
            //Main page
            mainPageButtons.Add(m_displayAllCharacters);
            mainPageButtons.Add(m_displayAllPlanets);
            mainPageButtons.Add(m_addACharacter);
            mainPageButtons.Add(m_addAPlanet);
            mainPageButtons.Add(b_delete_char);
            mainPageButtons.Add(b_delete_plan);
            mainPageButtons.Add(b_reset);
            mainPageButtons.Add(b_initiate);

            //Character addition page
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

            //Planet addition page
            addPlanetPageButtons.Add(tb_name);
            addPlanetPageButtons.Add(l_name);
            addPlanetPageButtons.Add(tb_localization);
            addPlanetPageButtons.Add(l_localization);
            addPlanetPageButtons.Add(tb_population);
            addPlanetPageButtons.Add(l_population);
            addPlanetPageButtons.Add(tb_language);
            addPlanetPageButtons.Add(l_language);
            addPlanetPageButtons.Add(tb_climate);
            addPlanetPageButtons.Add(l_climate);
            addPlanetPageButtons.Add(b_add2);
            addPlanetPageButtons.Add(b_cancel2);

            //Character removing page
            deleteCharPageButtons.Add(l_characters);
            deleteCharPageButtons.Add(cb_characters);
            deleteCharPageButtons.Add(b_delete);
            deleteCharPageButtons.Add(b_cancel3);

            //Planet removing page
            deletePlanetPageButtons.Add(l_planets);
            deletePlanetPageButtons.Add(cb_planets);
            deletePlanetPageButtons.Add(b_delete2);
            deletePlanetPageButtons.Add(b_cancel4);
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

        //Display the add character page components
        private void displayAddPlanetPageButtons()
        {
            addPlanetPageButtons.ForEach(button => this.Controls.Add(button));
        }

        //Appel ponctuel de la combobox afin d'avoir également les planètes ajoutées durant l'exécution
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

        //Display the removing character page components
        public void displayDeleteCharPageButtons()
        {
            deleteCharPageButtons.ForEach(button => this.Controls.Add(button));
        }

        //Display the removing planet page components
        public void displayDeletePlanetPageButtons()
        {
            deletePlanetPageButtons.ForEach(button => this.Controls.Add(button));
        }

        //Liste de tous les types pour la création d'un personnage
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

        //List all characters into a Dictionnary for the comboBox in the removing character page 
        public void SetCharactersList()
        {
            Dictionary<Character, string> values = new Dictionary<Character, string>();
            this.characters.ListCharacter.ForEach(character => values.Add(character, "["+character.Id+"] " + character.Firstname + " " + character.Lastname));    

            cb_characters.DataSource = new BindingSource(values, null);
            cb_characters.DisplayMember = "Value";
            cb_characters.ValueMember = "Key";
        }

        //List all characters into a Dictionnary for the comboBox in the removing character page 
        public void SetPlanetsList()
        {
            Dictionary<Planet, string> values = new Dictionary<Planet, string>();
            this.planets.ListPlanet.ForEach(planet => values.Add(planet, "["+planet.Id+"] " + planet.Name));

            cb_planets.DataSource = new BindingSource(values, null);
            cb_planets.DisplayMember = "Value";
            cb_planets.ValueMember = "Key";
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
            bool canAddChar = false;
            if (this.planets.ListPlanet.Count != 0)
            {
                canAddChar = true;
            }

            if (canAddChar)
            {
                this.Controls.Clear();
                displayAddCharPageButtons();
                SetPlanetChoices();
            }

            else
            {
                this.l_display.Text = "Invalid option: Character needs a planet to be created";
                this.Controls.Add(l_display);
            }
        }

        //Action on the "add a planet" button
        private void m_addAPlanet_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            displayAddPlanetPageButtons();
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

            this.Controls.Clear();
            displayMainPageButtons();
        }

        //Action on the "add" button n.2
        private void b_add2_Click(object sender, EventArgs e)
        {
            //Get all values
            string name = tb_name.Text;
            string localization = tb_localization.Text;
            int population = Convert.ToInt32(tb_population.Text);
            string language = tb_language.Text;
            string climate = tb_climate.Text;
            Characters charactersFrom = new Characters();

            //Create new character
            Planet newPlanet = new Planet(planets.ListPlanet.Count, name, localization, population, language, climate, charactersFrom);

            //Add it to the characters list
            this.planets.addPlanet(newPlanet);

            this.Controls.Clear();
            displayMainPageButtons();
        }

        //Action on the "reset" button
        private void b_reset_Click(object sender, EventArgs e)
        {
            bool displayPlanets = false;
            if (this.l_display.Text == this.planets.ToString())
            {
                displayPlanets = true;
            }

            this.planets = new Planets();
            this.characters = new Characters();

            if (displayPlanets)
                m_displayAllPlanets_Click(sender, e);
            else
                m_displayAllCharacters_Click(sender, e);
        }

        //Action on the "initiate" button
        private void b_initiate_Click(object sender, EventArgs e)
        {
            bool displayPlanets = false;
            if(this.l_display.Text == this.planets.ToString())
            {
                displayPlanets = true;
            }

            Projet2.Program.initForTest(ref planets, ref characters);

            if (displayPlanets)
                m_displayAllPlanets_Click(sender, e);
            else
                m_displayAllCharacters_Click(sender, e);
        }

        //Action on the "delete a planet" button
        private void b_delete_plan_Click(object sender, EventArgs e)
        {
            if(this.planets.ListPlanet.Count == 0)
            {
                l_display.Text = this.planets.ToString();
                this.Controls.Add(l_display);
            }
            else
            {
                this.Controls.Clear();
                SetPlanetsList();
                displayDeletePlanetPageButtons();
            }
        }

        //Action on the "delete a character" button
        private void b_delete_char_Click(object sender, EventArgs e)
        {
            if (this.characters.ListCharacter.Count == 0)
            {
                l_display.Text = this.characters.ToString();
                this.Controls.Add(l_display);
            }
            else
            {
                this.Controls.Clear();
                SetCharactersList();
                displayDeleteCharPageButtons();
            }
        }

        //Action on the "delete" button (character removing page)
        private void b_delete_Click(object sender, EventArgs e)
        {
            Character chara = ((KeyValuePair<Character, string>)cb_characters.SelectedItem).Key;
            this.characters.deleteCharacter(chara.Id);
            this.Controls.Clear();
            displayMainPageButtons();
            l_display.Text = chara.Firstname + " " + chara.Lastname + " has been succesfully removed.";
            this.Controls.Add(l_display);
        }

        //Action on the "delete" button (planet removing page)
        private void b_delete2_Click(object sender, EventArgs e)
        {
            Planet plan = ((KeyValuePair<Planet, string>)cb_planets.SelectedItem).Key;
            this.planets.deletePlanet(plan.Id);
            this.Controls.Clear();
            displayMainPageButtons();
            l_display.Text = plan.Name + " has been succesfully removed.";
            this.Controls.Add(l_display);
        }
    }
}
