﻿namespace IHM
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
            this.ClientSize = new System.Drawing.Size(665, 456);
            this.Name = "Accueil";
            this.Text = "CDAA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button m_displayAllCharacters;
        private System.Windows.Forms.Button m_displayAllPlanets;
        private System.Windows.Forms.Button m_addACharacter;
        private System.Windows.Forms.Label l_planet;
        private System.Windows.Forms.Label l_firstName;
        private System.Windows.Forms.TextBox tb_firstName;
        private System.Windows.Forms.Label l_lastName;
        private System.Windows.Forms.TextBox tb_lastName;
        private System.Windows.Forms.Label l_age;
        private System.Windows.Forms.TextBox tb_age;
        private System.Windows.Forms.Label l_race;
        private System.Windows.Forms.TextBox tb_race;
        private System.Windows.Forms.ComboBox cb_planetChoice;
        private System.Windows.Forms.Button b_add;
        private System.Windows.Forms.Button b_cancel;
    }
}

