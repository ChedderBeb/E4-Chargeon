namespace Chargeon
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
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageIntervention = new System.Windows.Forms.TabPage();
            this.tabPageClient = new System.Windows.Forms.TabPage();
            this.tabPageBornes = new System.Windows.Forms.TabPage();
            this.tabPageTechniciens = new System.Windows.Forms.TabPage();
            this.tabPageStat = new System.Windows.Forms.TabPage();
            this.userControlStat1 = new Chargeon.UserControlStat();
            this.tabControlMain.SuspendLayout();
            this.tabPageStat.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Controls.Add(this.tabPageIntervention);
            this.tabControlMain.Controls.Add(this.tabPageClient);
            this.tabControlMain.Controls.Add(this.tabPageBornes);
            this.tabControlMain.Controls.Add(this.tabPageTechniciens);
            this.tabControlMain.Controls.Add(this.tabPageStat);
            this.tabControlMain.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlMain.Location = new System.Drawing.Point(12, 12);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1276, 628);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageIntervention
            // 
            this.tabPageIntervention.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageIntervention.Location = new System.Drawing.Point(4, 32);
            this.tabPageIntervention.Name = "tabPageIntervention";
            this.tabPageIntervention.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageIntervention.Size = new System.Drawing.Size(1268, 592);
            this.tabPageIntervention.TabIndex = 0;
            this.tabPageIntervention.Text = "Intervention";
            this.tabPageIntervention.UseVisualStyleBackColor = true;
            // 
            // tabPageClient
            // 
            this.tabPageClient.Location = new System.Drawing.Point(4, 32);
            this.tabPageClient.Name = "tabPageClient";
            this.tabPageClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClient.Size = new System.Drawing.Size(1268, 592);
            this.tabPageClient.TabIndex = 1;
            this.tabPageClient.Text = "Client";
            this.tabPageClient.UseVisualStyleBackColor = true;
            // 
            // tabPageBornes
            // 
            this.tabPageBornes.Location = new System.Drawing.Point(4, 32);
            this.tabPageBornes.Name = "tabPageBornes";
            this.tabPageBornes.Size = new System.Drawing.Size(1268, 592);
            this.tabPageBornes.TabIndex = 2;
            this.tabPageBornes.Text = "Bornes";
            this.tabPageBornes.UseVisualStyleBackColor = true;
            // 
            // tabPageTechniciens
            // 
            this.tabPageTechniciens.Location = new System.Drawing.Point(4, 32);
            this.tabPageTechniciens.Name = "tabPageTechniciens";
            this.tabPageTechniciens.Size = new System.Drawing.Size(1268, 592);
            this.tabPageTechniciens.TabIndex = 3;
            this.tabPageTechniciens.Text = "Techniciens";
            this.tabPageTechniciens.UseVisualStyleBackColor = true;
            // 
            // tabPageStat
            // 
            this.tabPageStat.Controls.Add(this.userControlStat1);
            this.tabPageStat.Location = new System.Drawing.Point(4, 32);
            this.tabPageStat.Name = "tabPageStat";
            this.tabPageStat.Size = new System.Drawing.Size(1268, 592);
            this.tabPageStat.TabIndex = 4;
            this.tabPageStat.Text = "Statistiques";
            this.tabPageStat.UseVisualStyleBackColor = true;
            // 
            // userControlStat1
            // 
            this.userControlStat1.Location = new System.Drawing.Point(-4, 4);
            this.userControlStat1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userControlStat1.Name = "userControlStat1";
            this.userControlStat1.Size = new System.Drawing.Size(1269, 584);
            this.userControlStat1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 652);
            this.Controls.Add(this.tabControlMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControlMain.ResumeLayout(false);
            this.tabPageStat.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageIntervention;
        private System.Windows.Forms.TabPage tabPageClient;
        private System.Windows.Forms.TabPage tabPageBornes;
        private System.Windows.Forms.TabPage tabPageTechniciens;
        private System.Windows.Forms.TabPage tabPageStat;
        private UserControlStat userControlStat1;
    }
}

