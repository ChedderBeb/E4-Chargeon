using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Chargeon;
using System.Globalization;

namespace E4_Chargeon
{
	public partial class UserControlTechniciens : UserControl
	{
		public UserControlTechniciens()
		{
			InitializeComponent();
			//Permet de gérer le float
			Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-GB");

			//Technicien
			majLvTech();
			majBtnTech();
			gestionEventTech();
			//Habilitation
			majLvHab();
			majBtnHab();
			gestionEventHab();

			//Habilitations du technicien
			majComboBoxHab();
			majLvTechHab();
			majBtnHabTech();			
		}

		static Assemblage assemblage = new Assemblage();

		//TECHNICIEN
		//Mise à jour des informations dans la listView des Techniciens
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
				MessageBox.Show(expt.Message, "Erreur");
			}
		}

		//Evènement lorsque la ligne est sélectionnée 
		//TextBox remplis avec les informations de la ligne
		private void lvTech_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(lvTech.SelectedItems.Count > 0)
			{
				tbNomTech.Text = lvTech.SelectedItems[0].SubItems[1].Text;
				tbPrenomTech.Text = lvTech.SelectedItems[0].SubItems[2].Text;
				tbLongTech.Text = lvTech.SelectedItems[0].SubItems[3].Text;
				tbLatTech.Text = lvTech.SelectedItems[0].SubItems[4].Text;
				//GroupBox des Habilitations du Technicien, visible lorsque que l'on sélectionne un technicien
				gbTechHab.Visible = true;
				gbTechHab.Enabled = true;
				majLvTechHab();
				majComboBoxHab();
			}
			else
			{
				//Sinon groupBox invisible
				gbTechHab.Visible = false;
				gbTechHab.Enabled = false;
			}
			majBtnTech();
			majBtnHabTech();
		}

		//Insertion d'un technicien 
		private void btnAjoutTech_Click(object sender, EventArgs e)
		{
			//Vérification que les champs ne sont pas vides dans les TextBox
			if (tbNomTech.Text != "" && tbPrenomTech.Text != "" && tbLongTech.Text != "" && tbLatTech.Text != "")
			{
				float uneLong = float.Parse(tbLongTech.Text.ToString());
				float uneLat = float.Parse(tbLatTech.Text.ToString());
				string unNom = tbNomTech.Text;
				string unPrenom = tbPrenomTech.Text;
				Technicien unTech = new Technicien(0, unNom, unPrenom, uneLong, uneLat);
				assemblage.InsertTechniciens(unTech);
				if(assemblage.MsgErr == "")
				{
					MessageBox.Show(" L'insertion s'est bien déroulée !");
					majLvTech();

				} else
				{
					MessageBox.Show(assemblage.MsgErr, "Erreur");
					assemblage.MsgErr = "";
				}
			}
			majBtnTech();
		}

		//Modification d'un technicien 
		private void btnModifTech_Click(object sender, EventArgs e)
		{
			//Vérification d'un sélection dans la liste
			if(lvTech.SelectedItems.Count > 0)
			{
				//Vérification que les champs ne sont pas vides dans les TextBox
				if(tbNomTech.Text  != "" && tbPrenomTech.Text != "" && tbLongTech.Text != "" && tbLatTech.Text != "")
				{
					int id = Int32.Parse(lvTech.SelectedItems[0].SubItems[0].Text);
					string nom = tbNomTech.Text;
					string prenom = tbPrenomTech.Text;
					float longi = float.Parse(tbLongTech.Text);
					float lati = float.Parse(tbLatTech.Text);
					Technicien unTech = new Technicien(id, nom, prenom, longi, lati);
					assemblage.UpdateTechniciens(unTech);
					if(assemblage.MsgErr == "")
					{
						MessageBox.Show("La modification s'est bien déroulée");
						majLvTech();
					} else
					{
						MessageBox.Show(assemblage.MsgErr, "Erreur");
						assemblage.MsgErr = "";
					}
				}
				majBtnTech();
			}
		}

		//Suppression d'un technicien
		private void btnSupTech_Click(object sender, EventArgs e)
		{
			//Message de confirmation de suppression
			DialogResult dialogResult = MessageBox.Show("Êtes-vous sûr(e) de bien vouloir supprimer ce technicien ?", "Confirmation", MessageBoxButtons.YesNo);
			if (lvTech.SelectedItems.Count > 0)
			{
				int id = Int32.Parse(lvTech.SelectedItems[0].SubItems[0].Text);
				assemblage.DeleteTechniciens(id);
				if (assemblage.MsgErr == "")
				{
					MessageBox.Show("La suppression s'est bien déroulée");
					majLvTech();
				} else
				{
					MessageBox.Show(assemblage.MsgErr, "Erreur");
				}
			} else
			{
				MessageBox.Show("Veuillez sélectionner un technicien dans la liste !");
			}
			majBtnTech();
		}


		//HABILITATION
		//Mise à jour des informations de la listeView Habilitation
		public void majLvHab()
		{
			try
			{
				lvHab.Items.Clear();
				assemblage.SetHabilitations();
				if(assemblage.MsgErr != "")
				{
					MessageBox.Show(assemblage.MsgErr, "Erreur");
				} else
				{
					foreach(Habilitation uneHab in assemblage.Habilitation)
					{
						ListViewItem item = new ListViewItem(new string[] { "idHab", "habNat", "habDom"});
						item.SubItems[0].Text = uneHab.Id.ToString();
						item.SubItems[1].Text = uneHab.Nature.ToString();
						item.SubItems[2].Text = uneHab.Domaine.ToString();

						lvHab.Items.Add(item);
					}
				}
			}
			catch (Exception expt)
			{
				MessageBox.Show(expt.Message, "Erreur");
			}
		}

		//Evènement lorsque la ligne est sélectionnée 
		private void lvHab_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(lvHab.SelectedItems.Count > 0)
			{
				tbNatHab.Text = lvHab.SelectedItems[0].SubItems[1].Text;
				tbDomHab.Text = lvHab.SelectedItems[0].SubItems[2].Text;
			}
			majBtnHab();
		}

		//Ajout d'une habilitation
		private void btnAjoutHab_Click(object sender, EventArgs e)
		{
			if(tbNatHab.Text != "" && tbDomHab.Text != "")
			{

				string uneNat = tbNatHab.Text;
				string unDom = tbDomHab.Text;
				Habilitation uneHab = new Habilitation(0, uneNat, unDom);
				assemblage.InsertHabilitation(uneHab);
				if (assemblage.MsgErr == "")
				{
					MessageBox.Show(" L'insertion s'est bien déroulée !");
					majLvHab();

				}
				else
				{
					MessageBox.Show(assemblage.MsgErr, "Erreur");
					assemblage.MsgErr = "";
				}
			}
			majBtnHab();
		}

		//Modification d'une habilitation
		private void btnModifHab_Click(object sender, EventArgs e)
		{
			if(lvHab.SelectedItems.Count > 0)
			{
				if (tbNatHab.Text != "" && tbDomHab.Text != "")
				{
					int unId = Int32.Parse(lvHab.SelectedItems[0].SubItems[0].Text);
					string uneNat = tbNatHab.Text;
					string unDom = tbDomHab.Text;
					Habilitation uneHab = new Habilitation(unId, uneNat, unDom);
					assemblage.UpdateHabilitations(uneHab);
					if (assemblage.MsgErr == "")
					{
						MessageBox.Show("La modification s'est bien déroulée");
						majLvHab();
					}
					else
					{
						MessageBox.Show(assemblage.MsgErr, "Erreur");
						assemblage.MsgErr = "";
					}
				}
				majBtnHab();
			}
		}

		//Suppression d'une habilitation
		private void btnSupHab_Click(object sender, EventArgs e)
		{
			//Message de confirmation de suppression
			DialogResult dialogResult = MessageBox.Show("Êtes-vous sûr(e) de bien vouloir supprimer cette habilitation ?", "Confirmation", MessageBoxButtons.YesNo);
			if(lvHab.SelectedItems.Count > 0)
			{
				int id = Int32.Parse(lvHab.SelectedItems[0].SubItems[0].Text);
				assemblage.DeleteHabilitation(id);
				if (assemblage.MsgErr == "")
				{
					MessageBox.Show("La suppression s'est bien déroulée");
					majLvHab();
				}
				else
				{
					MessageBox.Show(assemblage.MsgErr, "Erreur");
				}
			}
			else
			{
				MessageBox.Show("Veuillez sélectionner une habilitation dans la liste !");
			}
			majBtnHab();
		}

		

		//HABILITATION DU TECHNICIEN
		//Mise à jour des informations des habilitations du technicien sélectionné
		public void majLvTechHab()
		{
			try
			{
				lvTechHab.Items.Clear();
				if(lvTech.SelectedItems.Count > 0)
				{
					
					int idTech = Int32.Parse(lvTech.SelectedItems[0].SubItems[0].Text);
					Technicien unTech = new Technicien(idTech, "", "", 0, 0);

					List<Habilitation> lesHab = assemblage.SetHabTech(unTech);
					if(assemblage.MsgErr != "")
					{
						MessageBox.Show(assemblage.MsgErr, "Erreur");
					}
					else
					{
						foreach(Habilitation uneHab in lesHab)
						{
							ListViewItem item = new ListViewItem(new string[] { "idTechHab", "hab", "habValid" });
							item.SubItems[0].Text = idTech.ToString();
							item.SubItems[1].Text = uneHab.Nature.ToString() + uneHab.Domaine.ToString();
							item.SubItems[2].Text = uneHab.Date.ToString();

							lvTechHab.Items.Add(item);
							
						}
					}
				}

			}catch(Exception expt)
			{
				MessageBox.Show(expt.Message, "Erreur");
			}
		}

		//Evènement lors d'une sélection de ligne
		private void lvTechHab_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(lvTechHab.SelectedItems.Count > 0)
			{
				cbHab.Text = lvTechHab.SelectedItems[0].SubItems[1].Text;
				dtpValidHab.Text = lvTechHab.SelectedItems[0].SubItems[2].Text;
			} else
			{
				cbHab.Text = "";
				dtpValidHab.Text = "";
			}
			majBtnHabTech();
		}

		//Mise à jour de la comboBox Habilitation
		public void majComboBoxHab()
		{
			try
			{
				cbHab.Items.Clear();
				cbHab.Text = "";
				assemblage.SetHabilitations();
				foreach(Habilitation hab in assemblage.Habilitation)
				{
					cbHab.Items.Add(new ComboBoxItem(hab.Id, hab.Nature + hab.Domaine));
				}

			} catch(Exception expt)
			{
				MessageBox.Show(expt.Message, "Erreur");
			}
		}

		//Ajout d'une habilitation au technicien sélectionné
		private void btnAjoutHabTech_Click(object sender, EventArgs e)
		{
			if(cbHab.SelectedIndex > -1)
			{
				int idTech = Int32.Parse(lvTech.SelectedItems[0].SubItems[0].Text);
				int idHab = (cbHab.SelectedItem as ComboBoxItem).ToInt();
				DateTime date = dtpValidHab.Value;
				Technicien unTech = new Technicien(idTech, "", "", 0, 0);
				Habilitation uneHab = new Habilitation(idHab, "", "", date);
				assemblage.InsertHabTech(unTech, uneHab);
				if(assemblage.MsgErr == "")
				{
					MessageBox.Show("L'insertion s'est bien déroulée");
					majLvTechHab();
				}
				else
				{
					MessageBox.Show(assemblage.MsgErr, "Erreur");
					assemblage.MsgErr = "";
				}
				majBtnHabTech();
			}
		}

		//Modification d'une habilitation du technicien sélectionné
		private void btnModifHabTech_Click(object sender, EventArgs e)
		{
			if(cbHab.SelectedIndex > -1)
			{
				if(lvTechHab.SelectedItems.Count > 0)
				{
					int idTech = Int32.Parse(lvTechHab.SelectedItems[0].SubItems[0].Text);
					int idHab = (cbHab.SelectedItem as ComboBoxItem).ToInt();
					DateTime date = dtpValidHab.Value;
					Technicien unTech = new Technicien(idTech, "", "", 0, 0);
					Habilitation uneHab = new Habilitation(idHab, "", "", date);
					assemblage.UpdateHabTech(unTech, uneHab);
					if(assemblage.MsgErr == "")
					{
						MessageBox.Show("La modification s'est bien déroulée");
						majLvTechHab();
					}
					else
					{
						MessageBox.Show(assemblage.MsgErr, "Erreur");
						assemblage.MsgErr = "";
					}
				}
				majBtnHabTech();
			}
		}

		//Suppression d'une habilitation du technicien sélectionné
		private void btnSupHabTech_Click(object sender, EventArgs e)
		{
			//Message de confirmation de suppression
			DialogResult dialogResult = MessageBox.Show("Êtes-vous sûr(e) de bien vouloir supprimer cette habilitation du technicien ?", "Confirmation", MessageBoxButtons.YesNo);

			if (lvTechHab.SelectedItems.Count > 0)
			{
				int idTech = Int32.Parse(lvTechHab.SelectedItems[0].SubItems[0].Text);
				Technicien unTech = new Technicien(idTech, "", "", 0, 0);
				assemblage.DeleteHabTech(unTech);
				if(assemblage.MsgErr == "")
				{
					MessageBox.Show("La suppression s'est bien déroulée");
					majLvTechHab();
				}
				else
				{
					MessageBox.Show(assemblage.MsgErr, "Erreur");
					assemblage.MsgErr = "";
				}
			}
			majBtnHabTech();
		}

		//BOUTONS TECHNICIEN
		// Mise à jour des boutons du groupBox Technicien
		private void majBtnTech()
		{
			bool flag = true;
			//Vérifie que tous les champs dans le groupBox sont remplis et retourne faux si ce n'est pas le cas
			foreach(Control tb in gbTechnicien.Controls)
			{
				if (tb is TextBox && tb.Text == "")
				{
					flag = false;
				}
			}
			//Active et désactive le bouton ajouter
			if (flag)
			{
				btnAjoutTech.Enabled = true;
			} else
			{
				btnAjoutTech.Enabled = false;
			}
			//Active et désactive les boutons modifier et supprimer
			if(lvTech.SelectedItems.Count > 0)
			{
				if(btnAjoutTech.Enabled == true)
				{
					btnModifTech.Enabled = true;
				} else
				{
					btnModifTech.Enabled = false;
				}
				btnSupTech.Enabled = true;
			}
			else
			{
				btnSupTech.Enabled = false;
				btnModifTech.Enabled = false;
			}
		}

		//BOUTONS HABILITATION
		//Mise à jour des boutons du groupBox Habilitation
		private void majBtnHab()
		{
			bool flag = true;
			//Vérifie que tous les champs dans le groupBox sont remplis et retourne faux si ce n'est pas le cas
			foreach (Control tb in gbHab.Controls)
			{
				if (tb is TextBox && tb.Text == "")
				{
					flag = false;
				}
			}
			//Active et désactive le bouton ajouter
			if (flag)
			{
				btnAjoutHab.Enabled = true;
			}
			else
			{
				btnAjoutHab.Enabled = false;
			}
			//Active et désactive les boutons modifier et supprimer
			if (lvHab.SelectedItems.Count > 0)
			{
				if (btnAjoutHab.Enabled == true)
				{
					btnModifHab.Enabled = true;
				}
				else
				{
					btnModifHab.Enabled = false;
				}
				btnSupHab.Enabled = true;
			}
			else
			{
				btnSupHab.Enabled = false;
				btnModifHab.Enabled = false;
			}
		}

		//BOUTONS HABILITATIONS DU TECHNICIEN
		//Mise à jour des boutons du groupBox Habilitation du technicien
		private void majBtnHabTech()
		{
			if(cbHab.SelectedIndex > -1)
			{
				btnAjoutHabTech.Enabled = true;
			}
			else
			{
				btnAjoutHabTech.Enabled = false;
			}
			if(lvTechHab.SelectedItems.Count > 0)
			{
				btnSupHabTech.Enabled = true;
			}
			else
			{
				btnSupHabTech.Enabled = false;
			}
			if(btnAjoutHabTech.Enabled == true && btnSupHabTech.Enabled == true)
			{
				btnModifHabTech.Enabled = true;
			}
			else
			{
				btnModifHabTech.Enabled = false;
			}
		}

		//GESTION DES EVENEMENT 

		//Gestion des évènements de l'onglet Technicien
		public void gestionEventTech()
		{
			foreach(Control tb in gbTechnicien.Controls)
			{
				if(tb is TextBox)
				{
					tb.KeyUp += tbTech_KeyUp;
					tb.KeyPress += tb_KeyPress;
				}
			}
		}

		//Evènement KeyUp des textbox de Technicien
		private void tbTech_KeyUp(object sender, KeyEventArgs e)
		{
			majBtnTech();
		}

		//Gestion des évènements des habilitations
		public void gestionEventHab()
		{
			foreach(Control tb in gbHab.Controls)
			{
				if(tb is TextBox)
				{
					tb.KeyPress += tb_KeyPress;
					tb.KeyUp += tbHab_KeyUp;
				}
			}
		}

		//Evènement KeyUp des textbox des Habilitations
		private void tbHab_KeyUp(object sender, KeyEventArgs e)
		{
			majBtnHab();
		}

		//Evènement KeyPress des textbox : vérifie que les évènements se sont déroulés
		private void tb_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '"')
			{
				e.Handled = true;
			}
		}

		//Evènement lors d'un changement de selection dans une comboBox
		private void cbHab_SelectedIndexChanged(object sender, EventArgs e)
		{
			majBtnHabTech();
		}
	}
	
}
