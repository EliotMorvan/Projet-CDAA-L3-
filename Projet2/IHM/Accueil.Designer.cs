namespace IHM
{
    partial class Accueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 456);
            this.Name = "Accueil";
            this.Text = "CDAA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button m_displayAllCharacters;
        private System.Windows.Forms.Button m_displayAllPlanets;
        private System.Windows.Forms.Button m_addACharacter;
        private System.Windows.Forms.Button m_addAPlanet;
        private System.Windows.Forms.Label l_display;
        private System.Windows.Forms.Label l_planet;
        private System.Windows.Forms.Label l_firstName;
        private System.Windows.Forms.TextBox tb_firstName;
        private System.Windows.Forms.Label l_lastName;
        private System.Windows.Forms.TextBox tb_lastName;
        private System.Windows.Forms.Label l_age;
        private System.Windows.Forms.TextBox tb_age;
        private System.Windows.Forms.Label l_race;
        private System.Windows.Forms.TextBox tb_race;
        private System.Windows.Forms.Label l_typeOfSoldier;
        private System.Windows.Forms.ComboBox cb_typeOfSoldier;
        private System.Windows.Forms.ComboBox cb_planetChoice;
        private System.Windows.Forms.Button b_add;
        private System.Windows.Forms.Button b_cancel;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label l_name;
        private System.Windows.Forms.Label l_localization;
        private System.Windows.Forms.TextBox tb_localization;
        private System.Windows.Forms.Label l_population;
        private System.Windows.Forms.TextBox tb_population;
        private System.Windows.Forms.Label l_language;
        private System.Windows.Forms.TextBox tb_language;
        private System.Windows.Forms.Label l_climate;
        private System.Windows.Forms.TextBox tb_climate;
        private System.Windows.Forms.Button b_add2;
        private System.Windows.Forms.Button b_cancel2;
        private System.Windows.Forms.Button b_reset;
        private System.Windows.Forms.Button b_initiate;
        private System.Windows.Forms.Button b_delete_plan;
        private System.Windows.Forms.Button b_delete_char;
        private System.Windows.Forms.ComboBox cb_characters;
        private System.Windows.Forms.Label l_characters;
        private System.Windows.Forms.Button b_delete;
        private System.Windows.Forms.Button b_cancel3;
        private System.Windows.Forms.Label l_planets;
        private System.Windows.Forms.ComboBox cb_planets;
        private System.Windows.Forms.Button b_delete2;
        private System.Windows.Forms.Button b_cancel4;
    }
}

