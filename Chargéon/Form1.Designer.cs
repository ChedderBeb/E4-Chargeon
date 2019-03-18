namespace Chargéon
{
    partial class Chargéon
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.Intervention = new System.Windows.Forms.TabPage();
            this.Facture = new System.Windows.Forms.TabPage();
            this.Bornes = new System.Windows.Forms.TabPage();
            this.Techniciens = new System.Windows.Forms.TabPage();
            this.Statistiques = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.AllowDrop = true;
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.Intervention);
            this.tabControl.Controls.Add(this.Facture);
            this.tabControl.Controls.Add(this.Bornes);
            this.tabControl.Controls.Add(this.Techniciens);
            this.tabControl.Controls.Add(this.Statistiques);
            this.tabControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.RightToLeftLayout = true;
            this.tabControl.SelectedIndex = 0;
            this.tabControl.ShowToolTips = true;
            this.tabControl.Size = new System.Drawing.Size(1110, 440);
            this.tabControl.TabIndex = 0;
            // 
            // Intervention
            // 
            this.Intervention.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(186)))), ((int)(((byte)(190)))));
            this.Intervention.Location = new System.Drawing.Point(4, 35);
            this.Intervention.Name = "Intervention";
            this.Intervention.Padding = new System.Windows.Forms.Padding(3);
            this.Intervention.Size = new System.Drawing.Size(1102, 401);
            this.Intervention.TabIndex = 0;
            this.Intervention.Text = "Intervention";
            // 
            // Facture
            // 
            this.Facture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(186)))), ((int)(((byte)(190)))));
            this.Facture.Location = new System.Drawing.Point(4, 35);
            this.Facture.Name = "Facture";
            this.Facture.Padding = new System.Windows.Forms.Padding(3);
            this.Facture.Size = new System.Drawing.Size(1102, 401);
            this.Facture.TabIndex = 1;
            this.Facture.Text = "Clients";
            // 
            // Bornes
            // 
            this.Bornes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(186)))), ((int)(((byte)(190)))));
            this.Bornes.Location = new System.Drawing.Point(4, 35);
            this.Bornes.Name = "Bornes";
            this.Bornes.Padding = new System.Windows.Forms.Padding(3);
            this.Bornes.Size = new System.Drawing.Size(1102, 401);
            this.Bornes.TabIndex = 2;
            this.Bornes.Text = "Bornes";
            // 
            // Techniciens
            // 
            this.Techniciens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(186)))), ((int)(((byte)(190)))));
            this.Techniciens.Location = new System.Drawing.Point(4, 35);
            this.Techniciens.Name = "Techniciens";
            this.Techniciens.Padding = new System.Windows.Forms.Padding(3);
            this.Techniciens.Size = new System.Drawing.Size(1102, 401);
            this.Techniciens.TabIndex = 3;
            this.Techniciens.Text = "Techniciens";
            // 
            // Statistiques
            // 
            this.Statistiques.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(186)))), ((int)(((byte)(190)))));
            this.Statistiques.Location = new System.Drawing.Point(4, 35);
            this.Statistiques.Name = "Statistiques";
            this.Statistiques.Size = new System.Drawing.Size(1102, 401);
            this.Statistiques.TabIndex = 4;
            this.Statistiques.Text = "Statistiques";
            // 
            // Chargéon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1134, 464);
            this.Controls.Add(this.tabControl);
            this.Name = "Chargéon";
            this.Text = "Chargéon";
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage Intervention;
        private System.Windows.Forms.TabPage Facture;
        private System.Windows.Forms.TabPage Bornes;
        private System.Windows.Forms.TabPage Techniciens;
        private System.Windows.Forms.TabPage Statistiques;
    }
}

