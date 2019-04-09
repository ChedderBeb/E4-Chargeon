namespace E4_Chargeon
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
			this.userControlTechniciens1 = new E4_Chargeon.UserControlTechniciens();
			this.SuspendLayout();
			// 
			// userControlTechniciens1
			// 
			this.userControlTechniciens1.Location = new System.Drawing.Point(12, 12);
			this.userControlTechniciens1.Name = "userControlTechniciens1";
			this.userControlTechniciens1.Size = new System.Drawing.Size(1046, 513);
			this.userControlTechniciens1.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1096, 583);
			this.Controls.Add(this.userControlTechniciens1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

        }

		#endregion

		private UserControlTechniciens userControlTechniciens1;
	}
}

