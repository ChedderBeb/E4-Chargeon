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
		}

		static Assemblage assemblage = new Assemblage();
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
	}
}
