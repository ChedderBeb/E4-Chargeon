using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chargeon;

namespace E4_Chargeon
{
	public partial class UserControlTechniciens : UserControl
	{
		public UserControlTechniciens()
		{
			InitializeComponent();
			majLvTech();
		}

		static Assemblage assemblage = new Assemblage();

		//TECHNICIEN
		public void majLvTech()
		{
			try
			{
				lvTech.Items.Clear();
				assemblage.GetTechniciens();
				if(assemblage.MsgErr != "")
				{
					MessageBox.Show(assemblage.MsgErr, "Erreur");
				}
				else
				{
					foreach(Technicien unTech in assemblage.Technicien)
					{
						ListViewItem item = new ListViewItem(new string[] { "idTech", "nomTech", "prenomTech", "techLong", "techLat" });
						item.SubItems[0].Text = unTech.Id.ToString();
						item.SubItems[1].Text = unTech.Nom.ToString();
						item.SubItems[2].Text = unTech.Prenom.ToString();
						item.SubItems[3].Text = unTech.Longi.ToString();
						item.SubItems[4].Text = unTech.Lat.ToString();

						lvTech.Items.Add(item);
					}
				}
			}catch (Exception expt)
			{

			}
		}

		private void lvTech_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(lvTech.SelectedItems.Count > 0)
			{
				tbNomTech.Text = lvTech.SelectedItems[0].SubItems[1].Text;
				tbPrenomTech.Text = lvTech.SelectedItems[0].SubItems[2].Text;
				tbLongTech.Text = lvTech.SelectedItems[0].SubItems[3].Text;
				tbLatTech.Text = lvTech.SelectedItems[0].SubItems[4].Text;
			}
		}

		private void btnAjoutTech_Click(object sender, EventArgs e)
		{
			if(tbNomTech.Text != "" && tbPrenomTech.Text != "" && tbLongTech.Text != "" && tbLatTech.Text != "")
			{
				float uneLong = float.Parse(tbLongTech.Text.ToString());
				float uneLat = float.Parse(tbLatTech.Text.ToString());
				string unNom = tbNomTech.ToString();
				string unPrenom = tbPrenomTech.ToString();
				Technicien unTech = new Technicien(0, unNom, unPrenom, uneLong, uneLat);
				assemblage.InsertTechniciens(unTech);
				if(assemblage.MsgErr == "")
				{
					MessageBox.Show(" L'insertion s'est bien déroulée !");

				} else
				{
					MessageBox.Show(assemblage.MsgErr);
					assemblage.MsgErr = "";
				}
			}
		}
	}
}
