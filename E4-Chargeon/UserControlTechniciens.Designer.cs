namespace E4_Chargeon
{
	partial class UserControlTechniciens
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

		#region Code généré par le Concepteur de composants

		/// <summary> 
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
			this.gbTechnicien = new System.Windows.Forms.GroupBox();
			this.btnSupTech = new System.Windows.Forms.Button();
			this.btnModifTech = new System.Windows.Forms.Button();
			this.btnAjoutTech = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tbLongTech = new System.Windows.Forms.TextBox();
			this.tbLatTech = new System.Windows.Forms.TextBox();
			this.tbPrenomTech = new System.Windows.Forms.TextBox();
			this.tbNomTech = new System.Windows.Forms.TextBox();
			this.lvTech = new System.Windows.Forms.ListView();
			this.idTech = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.nomTech = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.prenomTech = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.techLong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.techLat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.gbHab = new System.Windows.Forms.GroupBox();
			this.btnSupHab = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.lvHab = new System.Windows.Forms.ListView();
			this.idHab = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.habNat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.habDom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label9 = new System.Windows.Forms.Label();
			this.btnModifHab = new System.Windows.Forms.Button();
			this.tbDomHab = new System.Windows.Forms.TextBox();
			this.btnAjoutHab = new System.Windows.Forms.Button();
			this.tbNatHab = new System.Windows.Forms.TextBox();
			this.gbTechHab = new System.Windows.Forms.GroupBox();
			this.dtpValidHab = new System.Windows.Forms.DateTimePicker();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.cbHab = new System.Windows.Forms.ComboBox();
			this.btnSupHabTech = new System.Windows.Forms.Button();
			this.lvTechHab = new System.Windows.Forms.ListView();
			this.idTechHab = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.hab = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.habValid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btnModifHabTech = new System.Windows.Forms.Button();
			this.btnAjoutHabTech = new System.Windows.Forms.Button();
			this.gbTechnicien.SuspendLayout();
			this.gbHab.SuspendLayout();
			this.gbTechHab.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbTechnicien
			// 
			this.gbTechnicien.Controls.Add(this.btnSupTech);
			this.gbTechnicien.Controls.Add(this.btnModifTech);
			this.gbTechnicien.Controls.Add(this.btnAjoutTech);
			this.gbTechnicien.Controls.Add(this.label4);
			this.gbTechnicien.Controls.Add(this.label3);
			this.gbTechnicien.Controls.Add(this.label2);
			this.gbTechnicien.Controls.Add(this.label1);
			this.gbTechnicien.Controls.Add(this.tbLongTech);
			this.gbTechnicien.Controls.Add(this.tbLatTech);
			this.gbTechnicien.Controls.Add(this.tbPrenomTech);
			this.gbTechnicien.Controls.Add(this.tbNomTech);
			this.gbTechnicien.Controls.Add(this.lvTech);
			this.gbTechnicien.Location = new System.Drawing.Point(12, 12);
			this.gbTechnicien.Name = "gbTechnicien";
			this.gbTechnicien.Size = new System.Drawing.Size(336, 476);
			this.gbTechnicien.TabIndex = 21;
			this.gbTechnicien.TabStop = false;
			this.gbTechnicien.Text = "Techniciens";
			// 
			// btnSupTech
			// 
			this.btnSupTech.Location = new System.Drawing.Point(241, 447);
			this.btnSupTech.Name = "btnSupTech";
			this.btnSupTech.Size = new System.Drawing.Size(75, 23);
			this.btnSupTech.TabIndex = 11;
			this.btnSupTech.Text = "Supprimer";
			this.btnSupTech.UseVisualStyleBackColor = true;
			this.btnSupTech.Click += new System.EventHandler(this.btnSupTech_Click);
			// 
			// btnModifTech
			// 
			this.btnModifTech.Location = new System.Drawing.Point(131, 447);
			this.btnModifTech.Name = "btnModifTech";
			this.btnModifTech.Size = new System.Drawing.Size(75, 23);
			this.btnModifTech.TabIndex = 10;
			this.btnModifTech.Text = "Modifier";
			this.btnModifTech.UseVisualStyleBackColor = true;
			this.btnModifTech.Click += new System.EventHandler(this.btnModifTech_Click);
			// 
			// btnAjoutTech
			// 
			this.btnAjoutTech.Location = new System.Drawing.Point(16, 447);
			this.btnAjoutTech.Name = "btnAjoutTech";
			this.btnAjoutTech.Size = new System.Drawing.Size(75, 23);
			this.btnAjoutTech.TabIndex = 9;
			this.btnAjoutTech.Text = "Ajouter";
			this.btnAjoutTech.UseVisualStyleBackColor = true;
			this.btnAjoutTech.Click += new System.EventHandler(this.btnAjoutTech_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(7, 397);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(51, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Latitude :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(7, 364);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(60, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Longitude :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 321);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Prénom :";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 292);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Nom :";
			// 
			// tbLongTech
			// 
			this.tbLongTech.Location = new System.Drawing.Point(73, 364);
			this.tbLongTech.Name = "tbLongTech";
			this.tbLongTech.Size = new System.Drawing.Size(100, 20);
			this.tbLongTech.TabIndex = 4;
			// 
			// tbLatTech
			// 
			this.tbLatTech.Location = new System.Drawing.Point(73, 397);
			this.tbLatTech.Name = "tbLatTech";
			this.tbLatTech.Size = new System.Drawing.Size(100, 20);
			this.tbLatTech.TabIndex = 3;
			// 
			// tbPrenomTech
			// 
			this.tbPrenomTech.Location = new System.Drawing.Point(73, 321);
			this.tbPrenomTech.Name = "tbPrenomTech";
			this.tbPrenomTech.Size = new System.Drawing.Size(100, 20);
			this.tbPrenomTech.TabIndex = 2;
			// 
			// tbNomTech
			// 
			this.tbNomTech.Location = new System.Drawing.Point(73, 289);
			this.tbNomTech.Name = "tbNomTech";
			this.tbNomTech.Size = new System.Drawing.Size(100, 20);
			this.tbNomTech.TabIndex = 1;
			// 
			// lvTech
			// 
			this.lvTech.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idTech,
            this.nomTech,
            this.prenomTech,
            this.techLong,
            this.techLat});
			this.lvTech.FullRowSelect = true;
			this.lvTech.Location = new System.Drawing.Point(7, 20);
			this.lvTech.Name = "lvTech";
			this.lvTech.Size = new System.Drawing.Size(323, 263);
			this.lvTech.TabIndex = 0;
			this.lvTech.UseCompatibleStateImageBehavior = false;
			this.lvTech.View = System.Windows.Forms.View.Details;
			this.lvTech.SelectedIndexChanged += new System.EventHandler(this.lvTech_SelectedIndexChanged);
			// 
			// idTech
			// 
			this.idTech.Text = "Id";
			this.idTech.Width = 27;
			// 
			// nomTech
			// 
			this.nomTech.Text = "Nom";
			this.nomTech.Width = 55;
			// 
			// prenomTech
			// 
			this.prenomTech.Text = "Prénom";
			this.prenomTech.Width = 72;
			// 
			// techLong
			// 
			this.techLong.Text = "Longitude";
			// 
			// techLat
			// 
			this.techLat.Text = "Latitude";
			// 
			// gbHab
			// 
			this.gbHab.Controls.Add(this.btnSupHab);
			this.gbHab.Controls.Add(this.label8);
			this.gbHab.Controls.Add(this.lvHab);
			this.gbHab.Controls.Add(this.label9);
			this.gbHab.Controls.Add(this.btnModifHab);
			this.gbHab.Controls.Add(this.tbDomHab);
			this.gbHab.Controls.Add(this.btnAjoutHab);
			this.gbHab.Controls.Add(this.tbNatHab);
			this.gbHab.Location = new System.Drawing.Point(721, 12);
			this.gbHab.Name = "gbHab";
			this.gbHab.Size = new System.Drawing.Size(310, 476);
			this.gbHab.TabIndex = 22;
			this.gbHab.TabStop = false;
			this.gbHab.Text = "Habilitations";
			// 
			// btnSupHab
			// 
			this.btnSupHab.Location = new System.Drawing.Point(231, 447);
			this.btnSupHab.Name = "btnSupHab";
			this.btnSupHab.Size = new System.Drawing.Size(75, 23);
			this.btnSupHab.TabIndex = 17;
			this.btnSupHab.Text = "Supprimer";
			this.btnSupHab.UseVisualStyleBackColor = true;
			this.btnSupHab.Click += new System.EventHandler(this.btnSupHab_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(9, 335);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(55, 13);
			this.label8.TabIndex = 16;
			this.label8.Text = "Domaine :";
			// 
			// lvHab
			// 
			this.lvHab.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idHab,
            this.habNat,
            this.habDom});
			this.lvHab.FullRowSelect = true;
			this.lvHab.Location = new System.Drawing.Point(6, 20);
			this.lvHab.Name = "lvHab";
			this.lvHab.Size = new System.Drawing.Size(298, 263);
			this.lvHab.TabIndex = 2;
			this.lvHab.UseCompatibleStateImageBehavior = false;
			this.lvHab.View = System.Windows.Forms.View.Details;
			this.lvHab.SelectedIndexChanged += new System.EventHandler(this.lvHab_SelectedIndexChanged);
			// 
			// idHab
			// 
			this.idHab.Text = "Id";
			// 
			// habNat
			// 
			this.habNat.Text = "Nature";
			// 
			// habDom
			// 
			this.habDom.Text = "Domaine";
			this.habDom.Width = 79;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(9, 299);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(45, 13);
			this.label9.TabIndex = 15;
			this.label9.Text = "Nature :";
			// 
			// btnModifHab
			// 
			this.btnModifHab.Location = new System.Drawing.Point(121, 447);
			this.btnModifHab.Name = "btnModifHab";
			this.btnModifHab.Size = new System.Drawing.Size(75, 23);
			this.btnModifHab.TabIndex = 16;
			this.btnModifHab.Text = "Modifier";
			this.btnModifHab.UseVisualStyleBackColor = true;
			this.btnModifHab.Click += new System.EventHandler(this.btnModifHab_Click);
			// 
			// tbDomHab
			// 
			this.tbDomHab.Location = new System.Drawing.Point(96, 332);
			this.tbDomHab.Name = "tbDomHab";
			this.tbDomHab.Size = new System.Drawing.Size(100, 20);
			this.tbDomHab.TabIndex = 14;
			// 
			// btnAjoutHab
			// 
			this.btnAjoutHab.Location = new System.Drawing.Point(6, 447);
			this.btnAjoutHab.Name = "btnAjoutHab";
			this.btnAjoutHab.Size = new System.Drawing.Size(75, 23);
			this.btnAjoutHab.TabIndex = 15;
			this.btnAjoutHab.Text = "Ajouter";
			this.btnAjoutHab.UseVisualStyleBackColor = true;
			this.btnAjoutHab.Click += new System.EventHandler(this.btnAjoutHab_Click);
			// 
			// tbNatHab
			// 
			this.tbNatHab.Location = new System.Drawing.Point(96, 296);
			this.tbNatHab.Name = "tbNatHab";
			this.tbNatHab.Size = new System.Drawing.Size(100, 20);
			this.tbNatHab.TabIndex = 12;
			// 
			// gbTechHab
			// 
			this.gbTechHab.Controls.Add(this.dtpValidHab);
			this.gbTechHab.Controls.Add(this.label7);
			this.gbTechHab.Controls.Add(this.label6);
			this.gbTechHab.Controls.Add(this.cbHab);
			this.gbTechHab.Controls.Add(this.btnSupHabTech);
			this.gbTechHab.Controls.Add(this.lvTechHab);
			this.gbTechHab.Controls.Add(this.btnModifHabTech);
			this.gbTechHab.Controls.Add(this.btnAjoutHabTech);
			this.gbTechHab.Enabled = false;
			this.gbTechHab.Location = new System.Drawing.Point(379, 12);
			this.gbTechHab.Name = "gbTechHab";
			this.gbTechHab.Size = new System.Drawing.Size(310, 476);
			this.gbTechHab.TabIndex = 23;
			this.gbTechHab.TabStop = false;
			this.gbTechHab.Text = "Habilitations du Technicien";
			this.gbTechHab.Visible = false;
			// 
			// dtpValidHab
			// 
			this.dtpValidHab.Location = new System.Drawing.Point(117, 364);
			this.dtpValidHab.Name = "dtpValidHab";
			this.dtpValidHab.Size = new System.Drawing.Size(121, 20);
			this.dtpValidHab.TabIndex = 18;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(30, 367);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(83, 13);
			this.label7.TabIndex = 17;
			this.label7.Text = "Date obtention :";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(30, 303);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(65, 13);
			this.label6.TabIndex = 18;
			this.label6.Text = "Habilitation :";
			// 
			// cbHab
			// 
			this.cbHab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbHab.FormattingEnabled = true;
			this.cbHab.Location = new System.Drawing.Point(117, 303);
			this.cbHab.Name = "cbHab";
			this.cbHab.Size = new System.Drawing.Size(121, 21);
			this.cbHab.TabIndex = 16;
			this.cbHab.SelectedIndexChanged += new System.EventHandler(this.cbHab_SelectedIndexChanged);
			// 
			// btnSupHabTech
			// 
			this.btnSupHabTech.Location = new System.Drawing.Point(227, 447);
			this.btnSupHabTech.Name = "btnSupHabTech";
			this.btnSupHabTech.Size = new System.Drawing.Size(75, 23);
			this.btnSupHabTech.TabIndex = 14;
			this.btnSupHabTech.Text = "Supprimer";
			this.btnSupHabTech.UseVisualStyleBackColor = true;
			this.btnSupHabTech.Click += new System.EventHandler(this.btnSupHabTech_Click);
			// 
			// lvTechHab
			// 
			this.lvTechHab.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idTechHab,
            this.hab,
            this.habValid});
			this.lvTechHab.FullRowSelect = true;
			this.lvTechHab.Location = new System.Drawing.Point(4, 19);
			this.lvTechHab.Name = "lvTechHab";
			this.lvTechHab.Size = new System.Drawing.Size(298, 263);
			this.lvTechHab.TabIndex = 1;
			this.lvTechHab.UseCompatibleStateImageBehavior = false;
			this.lvTechHab.View = System.Windows.Forms.View.Details;
			this.lvTechHab.SelectedIndexChanged += new System.EventHandler(this.lvTechHab_SelectedIndexChanged);
			// 
			// idTechHab
			// 
			this.idTechHab.Text = "Id";
			this.idTechHab.Width = 44;
			// 
			// hab
			// 
			this.hab.Text = "Habilitations";
			this.hab.Width = 73;
			// 
			// habValid
			// 
			this.habValid.Text = "Date d\'obtention";
			this.habValid.Width = 111;
			// 
			// btnModifHabTech
			// 
			this.btnModifHabTech.Location = new System.Drawing.Point(117, 447);
			this.btnModifHabTech.Name = "btnModifHabTech";
			this.btnModifHabTech.Size = new System.Drawing.Size(75, 23);
			this.btnModifHabTech.TabIndex = 13;
			this.btnModifHabTech.Text = "Modifier";
			this.btnModifHabTech.UseVisualStyleBackColor = true;
			this.btnModifHabTech.Click += new System.EventHandler(this.btnModifHabTech_Click);
			// 
			// btnAjoutHabTech
			// 
			this.btnAjoutHabTech.Location = new System.Drawing.Point(2, 447);
			this.btnAjoutHabTech.Name = "btnAjoutHabTech";
			this.btnAjoutHabTech.Size = new System.Drawing.Size(75, 23);
			this.btnAjoutHabTech.TabIndex = 12;
			this.btnAjoutHabTech.Text = "Ajouter";
			this.btnAjoutHabTech.UseVisualStyleBackColor = true;
			this.btnAjoutHabTech.Click += new System.EventHandler(this.btnAjoutHabTech_Click);
			// 
			// UserControlTechniciens
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.gbTechHab);
			this.Controls.Add(this.gbHab);
			this.Controls.Add(this.gbTechnicien);
			this.Name = "UserControlTechniciens";
			this.Size = new System.Drawing.Size(1046, 513);
			this.gbTechnicien.ResumeLayout(false);
			this.gbTechnicien.PerformLayout();
			this.gbHab.ResumeLayout(false);
			this.gbHab.PerformLayout();
			this.gbTechHab.ResumeLayout(false);
			this.gbTechHab.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox gbTechnicien;
		private System.Windows.Forms.ListView lvTech;
		private System.Windows.Forms.GroupBox gbHab;
		private System.Windows.Forms.ListView lvHab;
		private System.Windows.Forms.GroupBox gbTechHab;
		private System.Windows.Forms.ListView lvTechHab;
		private System.Windows.Forms.ColumnHeader idTech;
		private System.Windows.Forms.ColumnHeader nomTech;
		private System.Windows.Forms.ColumnHeader prenomTech;
		private System.Windows.Forms.ColumnHeader techLong;
		private System.Windows.Forms.ColumnHeader techLat;
		private System.Windows.Forms.ColumnHeader idHab;
		private System.Windows.Forms.ColumnHeader habNat;
		private System.Windows.Forms.ColumnHeader habDom;
		private System.Windows.Forms.ColumnHeader idTechHab;
		private System.Windows.Forms.ColumnHeader hab;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbLongTech;
		private System.Windows.Forms.TextBox tbLatTech;
		private System.Windows.Forms.TextBox tbPrenomTech;
		private System.Windows.Forms.TextBox tbNomTech;
		private System.Windows.Forms.Button btnSupTech;
		private System.Windows.Forms.Button btnModifTech;
		private System.Windows.Forms.Button btnAjoutTech;
		private System.Windows.Forms.Button btnSupHab;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button btnModifHab;
		private System.Windows.Forms.TextBox tbDomHab;
		private System.Windows.Forms.Button btnAjoutHab;
		private System.Windows.Forms.TextBox tbNatHab;
		private System.Windows.Forms.DateTimePicker dtpValidHab;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cbHab;
		private System.Windows.Forms.Button btnSupHabTech;
		private System.Windows.Forms.ColumnHeader habValid;
		private System.Windows.Forms.Button btnModifHabTech;
		private System.Windows.Forms.Button btnAjoutHabTech;
	}
}
