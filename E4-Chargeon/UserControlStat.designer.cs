namespace Chargeon
{
	partial class UserControlStat
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.chartStat = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.buttonRefresh = new System.Windows.Forms.Button();
			this.comboBox4 = new System.Windows.Forms.ComboBox();
			this.comboBox5 = new System.Windows.Forms.ComboBox();
			this.comboBox6 = new System.Windows.Forms.ComboBox();
			this.comboBox7 = new System.Windows.Forms.ComboBox();
			this.comboBox8 = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBoxType = new System.Windows.Forms.ComboBox();
			this.buttonClear = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.chartStat)).BeginInit();
			this.SuspendLayout();
			// 
			// chartStat
			// 
			this.chartStat.BackColor = System.Drawing.Color.Peru;
			chartArea1.Name = "ChartArea1";
			this.chartStat.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.chartStat.Legends.Add(legend1);
			this.chartStat.Location = new System.Drawing.Point(3, 3);
			this.chartStat.Name = "chartStat";
			this.chartStat.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
			series1.ChartArea = "ChartArea1";
			series1.IsValueShownAsLabel = true;
			series1.Legend = "Legend1";
			series1.Name = "puissance";
			this.chartStat.Series.Add(series1);
			this.chartStat.Size = new System.Drawing.Size(833, 413);
			this.chartStat.TabIndex = 0;
			this.chartStat.Text = "chart1";
			this.chartStat.Click += new System.EventHandler(this.chartStat_Click);
			// 
			// comboBox1
			// 
			this.comboBox1.AccessibleName = "";
			this.comboBox1.BackColor = System.Drawing.Color.White;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(842, 84);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(101, 24);
			this.comboBox1.TabIndex = 1;
			this.comboBox1.Text = "Borne 1";
			// 
			// comboBox2
			// 
			this.comboBox2.BackColor = System.Drawing.Color.White;
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(842, 114);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(101, 24);
			this.comboBox2.TabIndex = 2;
			this.comboBox2.Text = "Borne 2";
			// 
			// comboBox3
			// 
			this.comboBox3.BackColor = System.Drawing.Color.White;
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Location = new System.Drawing.Point(842, 144);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(101, 24);
			this.comboBox3.TabIndex = 3;
			this.comboBox3.Text = "Borne 3";
			// 
			// buttonRefresh
			// 
			this.buttonRefresh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.buttonRefresh.Location = new System.Drawing.Point(842, 324);
			this.buttonRefresh.Name = "buttonRefresh";
			this.buttonRefresh.Size = new System.Drawing.Size(101, 43);
			this.buttonRefresh.TabIndex = 5;
			this.buttonRefresh.Text = "Actualiser !";
			this.buttonRefresh.UseVisualStyleBackColor = true;
			this.buttonRefresh.Click += new System.EventHandler(this.button2_Click);
			// 
			// comboBox4
			// 
			this.comboBox4.BackColor = System.Drawing.Color.White;
			this.comboBox4.FormattingEnabled = true;
			this.comboBox4.Location = new System.Drawing.Point(842, 174);
			this.comboBox4.Name = "comboBox4";
			this.comboBox4.Size = new System.Drawing.Size(101, 24);
			this.comboBox4.TabIndex = 6;
			this.comboBox4.Text = "Borne 4";
			// 
			// comboBox5
			// 
			this.comboBox5.BackColor = System.Drawing.Color.White;
			this.comboBox5.FormattingEnabled = true;
			this.comboBox5.Location = new System.Drawing.Point(842, 204);
			this.comboBox5.Name = "comboBox5";
			this.comboBox5.Size = new System.Drawing.Size(101, 24);
			this.comboBox5.TabIndex = 7;
			this.comboBox5.Text = "Borne 5";
			// 
			// comboBox6
			// 
			this.comboBox6.BackColor = System.Drawing.Color.White;
			this.comboBox6.FormattingEnabled = true;
			this.comboBox6.Location = new System.Drawing.Point(842, 234);
			this.comboBox6.Name = "comboBox6";
			this.comboBox6.Size = new System.Drawing.Size(101, 24);
			this.comboBox6.TabIndex = 8;
			this.comboBox6.Text = "Borne 6";
			// 
			// comboBox7
			// 
			this.comboBox7.BackColor = System.Drawing.Color.White;
			this.comboBox7.FormattingEnabled = true;
			this.comboBox7.Location = new System.Drawing.Point(842, 264);
			this.comboBox7.Name = "comboBox7";
			this.comboBox7.Size = new System.Drawing.Size(101, 24);
			this.comboBox7.TabIndex = 9;
			this.comboBox7.Text = "Borne 7";
			// 
			// comboBox8
			// 
			this.comboBox8.BackColor = System.Drawing.Color.White;
			this.comboBox8.FormattingEnabled = true;
			this.comboBox8.Location = new System.Drawing.Point(842, 294);
			this.comboBox8.Name = "comboBox8";
			this.comboBox8.Size = new System.Drawing.Size(101, 24);
			this.comboBox8.TabIndex = 10;
			this.comboBox8.Text = "Borne 8";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(843, 61);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 17);
			this.label1.TabIndex = 11;
			this.label1.Text = "Bornes : ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(847, 4);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 17);
			this.label2.TabIndex = 12;
			this.label2.Text = "Type : ";
			// 
			// comboBoxType
			// 
			this.comboBoxType.BackColor = System.Drawing.Color.White;
			this.comboBoxType.FormattingEnabled = true;
			this.comboBoxType.Location = new System.Drawing.Point(843, 34);
			this.comboBoxType.Name = "comboBoxType";
			this.comboBoxType.Size = new System.Drawing.Size(101, 24);
			this.comboBoxType.TabIndex = 13;
			this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
			// 
			// buttonClear
			// 
			this.buttonClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.buttonClear.Location = new System.Drawing.Point(842, 374);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(101, 42);
			this.buttonClear.TabIndex = 14;
			this.buttonClear.Text = "Supprimer !";
			this.buttonClear.UseVisualStyleBackColor = true;
			this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
			// 
			// UserControlStat
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Peru;
			this.Controls.Add(this.buttonClear);
			this.Controls.Add(this.comboBoxType);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBox8);
			this.Controls.Add(this.comboBox7);
			this.Controls.Add(this.comboBox6);
			this.Controls.Add(this.comboBox5);
			this.Controls.Add(this.comboBox4);
			this.Controls.Add(this.buttonRefresh);
			this.Controls.Add(this.comboBox3);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.chartStat);
			this.Name = "UserControlStat";
			this.Size = new System.Drawing.Size(998, 502);
			this.Load += new System.EventHandler(this.UserControlStat_Load);
			((System.ComponentModel.ISupportInitialize)(this.chartStat)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataVisualization.Charting.Chart chartStat;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.Button buttonRefresh;
		private System.Windows.Forms.ComboBox comboBox4;
		private System.Windows.Forms.ComboBox comboBox5;
		private System.Windows.Forms.ComboBox comboBox6;
		private System.Windows.Forms.ComboBox comboBox7;
		private System.Windows.Forms.ComboBox comboBox8;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBoxType;
		private System.Windows.Forms.Button buttonClear;
	}

}
