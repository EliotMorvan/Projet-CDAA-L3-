namespace IHM
{
    partial class Form1
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
            this.m_displayAllCharacters = new System.Windows.Forms.Button();
            this.m_Display = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // m_displayAllCharacters
            // 
            this.m_displayAllCharacters.Location = new System.Drawing.Point(12, 12);
            this.m_displayAllCharacters.Name = "m_displayAllCharacters";
            this.m_displayAllCharacters.Size = new System.Drawing.Size(121, 23);
            this.m_displayAllCharacters.TabIndex = 0;
            this.m_displayAllCharacters.Text = "Display all Characters";
            this.m_displayAllCharacters.UseVisualStyleBackColor = true;
            this.m_displayAllCharacters.Click += new System.EventHandler(this.button1_Click);
            // 
            // m_Display
            // 
            this.m_Display.AutoSize = true;
            this.m_Display.Location = new System.Drawing.Point(12, 54);
            this.m_Display.Name = "m_Display";
            this.m_Display.Size = new System.Drawing.Size(0, 13);
            this.m_Display.TabIndex = 1;
            this.m_Display.UseMnemonic = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.m_Display);
            this.Controls.Add(this.m_displayAllCharacters);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button m_displayAllCharacters;
        private System.Windows.Forms.Label m_Display;
    }
}

