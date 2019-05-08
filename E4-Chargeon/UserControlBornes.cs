using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Chargeon;
namespace E4_Chargeon
{
	public partial class UserControlBornes : UserControl
	{
		public UserControlBornes()
		{
			InitializeComponent();
			majLvBornes();
		}
		static Assemblage assemblage = new Assemblage();
		public void majLvBornes()
		{
			try
			{
				lvBornes.Items.Clear();
				assemblage.SetBornes();
				if(assemblage.MsgErr != "")
				{
					MessageBox.Show(assemblage.MsgErr, "Erreur");
				}
				foreach(Bornes lesBornes in assemblage.ListBornes)
				{
					ListViewItem item = new ListViewItem(new string[] { "IdBornes", "NumSerieBornes", "TypeBornes", "RefBornes", "PuissanceBornes", "ConcuBornes", "LatBornes", "LongBornes" });
					item.SubItems[0].Text = lesBornes.Id.ToString();
					item.SubItems[1].Text = lesBornes.NumSerie.ToString();
					item.SubItems[2].Text = lesBornes.Type.ToString();
					item.SubItems[3].Text = lesBornes.Reference.ToString();
					item.SubItems[4].Text = lesBornes.Puissance.ToString();
					item.SubItems[5].Text = lesBornes.Concu.ToString();
					item.SubItems[6].Text = lesBornes.Lat.ToString();
					item.SubItems[7].Text = lesBornes.Longi.ToString();

					lvBornes.Items.Add(item);
					
				}

			}catch(Exception expt)
			{
				MessageBox.Show(expt.Message, "Erreur");
			}
		}

		//CRUD
		//Create A METTRE A JOUR DANS ASSEMBLAGE !
		/*
		private void BtAjout_Click(object sender, EventArgs e)
		{
			try
			{
				//Requete pour insérer les données dans la base
				string MyConnection2 = "server=localhost;database=chargeon_e4;user=root;password=";
				string Query = "insert into chargeon_e4.borne(boNumSerie, boType, boRef, boPuissance, boConcu, boLong, boLat) values" +
					"('" + this.tbNumSerie.Text + "','" + this.tbType.Text + "','" + this.tbRef.Text + "','" + this.tbPuissance.Text + "','"
					+ this.tbConcu.Text + "','" + this.tbLong.Text + "','" + this.tbLat.Text + "') ";
				MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
				MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
				MySqlDataReader MyReader2;
				MyConn2.Open();
				MyReader2 = MyCommand2.ExecuteReader();
				while (MyReader2.Read())
				{
				}
				MyConn2.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		//Update
		private void btModif_Click(object sender, EventArgs e)
		{
			try
			{
				//Requete pour modifier les données
				string MyConnection2 = "server=localhost;database=chargeon_e4;user=root;password=";
				string Query = "update chargeon_e4.borne set boNumSerie='" + this.tbNumSerie.Text + "',boType='" + this.tbType.Text +
					"',boRef='" + this.tbRef.Text + "',boPuissance='" + this.tbPuissance.Text +
					"',boConcu='" + this.tbConcu.Text + "' ,boLong='" + this.tbLong.Text + "',boLat='" + this.tbLat.Text + "'where boId = '" + this.tbId.Text + "';'";
				MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
				MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
				MySqlDataReader MyReader2;
				MyConn2.Open();
				MyReader2 = MyCommand2.ExecuteReader();
				MessageBox.Show("Bornes mises à jour");
				while (MyReader2.Read())
				{
				}
				MyConn2.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		//Delete
		private void BtSuppr_Click(object sender, EventArgs e)
		{
			try
			{
				//Requete pour la suppréssion des sonnées 
				string MyConnection2 = "server=localhost;database=chargeon_e4;user=root;password=";
				string Query = "delete from chargeon_e4.borne where boId='" + this.tbId.Text + "';";
				MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
				MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
				MySqlDataReader MyReader2;
				MyConn2.Open();
				MyReader2 = MyCommand2.ExecuteReader();
				MessageBox.Show("Bornes Supprimées");
				while (MyReader2.Read())
				{
				}
				MyConn2.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}*/
	}
}
