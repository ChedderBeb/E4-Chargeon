using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Chargeon
{
	class Assemblage
	{
		//Connexion à la base de données
		private MySqlConnection bdd = new MySqlConnection("SERVER= 127.0.0.1; DATABASE= chargeon; UID=root; PASSWORD= ;");

		//Permet d'accéder à la ligne ci-dessus
		public MySqlConnection Bdd { get => bdd; }
		string msgErr = "";
		public string MsgErr { get => msgErr; set => msgErr = value; }

		//Permet d'accéder à la liste technicien de le classe Technicien
		internal List<Technicien> Technicien { get => technicien; set => technicien = value; }

		//Permet d'accéder à la liste habilitation de la classe Habilitation
		internal List<Habilitation> Habilitation { get => habilitation; set => habilitation = value; }

		List<Technicien> technicien = new List<Technicien>();
		List<Habilitation> habilitation = new List<Habilitation>();
		//Techniciens CRUD

		//Remplit la liste technicien ci-dessus avec tous les techniciens récupérés dans la base de données
		public void GetTechniciens()
		{
			technicien = new List<Technicien>();
			Bdd.Open();
			try
			{
				string query = "SELECT * FROM technicien";
				MySqlCommand cmd = new MySqlCommand(query, Bdd);
				MySqlDataReader dataReader = cmd.ExecuteReader();
				while (dataReader.Read())
				{
					this.technicien.Add(new Technicien(Int32.Parse(dataReader["techId"].ToString()), dataReader["techNom"].ToString(), dataReader["techPrenom"].ToString(), float.Parse(dataReader["techLong"].ToString()), float.Parse(dataReader["techLat"].ToString())));
				}
				dataReader.Close();
				Bdd.Close();
			}
			catch (Exception expt)
			{
				this.technicien = null;
				MsgErr = expt.Message;
			}
			Bdd.Close();
		}

		//Insertion d'un technicien dans la base de données
		public void InsertTechniciens(Technicien unTech)
		{
			Bdd.Open();
			try
			{

				string query = "INSERT INTO technicien (techNom, techPrenom, techLong, techLat) VAlUES ('" + unTech.Nom + "', '" + unTech.Prenom + "', '" + unTech.Longi + "', '" + unTech.Lat + "')";
				MySqlCommand cmd = new MySqlCommand(query, Bdd);
				cmd.ExecuteNonQuery();
				Bdd.Close();

			}
			catch (Exception expt)
			{
				this.technicien = null;
				MsgErr = expt.Message;
			}
			Bdd.Close();
		}

		//Modification d'un technicien dans la base de données
		public void UpdateTechniciens(Technicien unTech)
		{
			Bdd.Open();
			try
			{
				string query = "UPDATE technicien SET techNom = '" + unTech.Nom + "', techPrenom = '" + unTech.Prenom + "', techLong = '" + unTech.Longi + "', techLat = '" + unTech.Lat + "' WHERE techId = " + unTech.Id;
				MySqlCommand cmd = new MySqlCommand(query, Bdd);
				cmd.ExecuteNonQuery();
				Bdd.Close();


			}
			catch (Exception expt)
			{
				MsgErr = expt.Message;

			}
			Bdd.Close();
		}

		//Suppression d'un technicien dans la base de données
		public void DeleteTechniciens(int idTech)
		{
			Bdd.Open();
			try
			{
				string query = "DELETE FROM technicien WHERE techId = " + idTech;
				MySqlCommand cmd = new MySqlCommand(query, Bdd);
				cmd.ExecuteNonQuery();
				Bdd.Close();
			}
			catch (Exception expt)
			{
				MsgErr = expt.Message;

			}
			Bdd.Close();

		}

		//Habilitation CRUD

		//Remplit la liste habilitation avec toutes les habilitations récupérées dans la base de données
		public void SetHabilitations()
		{
			habilitation = new List<Habilitation>();
			Bdd.Open();
			try
			{
				string query = "SELECT * FROM habilitation";
				MySqlCommand cmd = new MySqlCommand(query, Bdd);
				MySqlDataReader dataReader = cmd.ExecuteReader();
				while (dataReader.Read())
				{
					this.habilitation.Add(new Habilitation(Int32.Parse(dataReader["habId"].ToString()), dataReader["habNat"].ToString(), dataReader["habDomaine"].ToString()));
				}
				dataReader.Close();
				Bdd.Close();

			}
			catch (Exception expt)
			{
				this.habilitation = null;
				MsgErr = expt.Message;
			}
			Bdd.Close();
		}

		//Insertion d'une habilitation dans la base de données
		public void InsertHabilitation(Habilitation uneHab)
		{
			Bdd.Open();
			try
			{
				string query = "INSERT INTO habilitation (habNat, habDomaine) VALUES ('" + uneHab.Nature + "', '" + uneHab.Domaine + "')";
				MySqlCommand cmd = new MySqlCommand(query, Bdd);
				cmd.ExecuteNonQuery();
				Bdd.Close();
			}
			catch (Exception expt)
			{
				this.habilitation = null;
				MsgErr = expt.Message;
			}
			Bdd.Close();
		}

		//Modification d'une habilitation dans la base de données
		public void UpdateHabilitations(Habilitation uneHab)
		{
			Bdd.Open();
			try
			{
				string query = "UPDATE habilitation SET habNat = '" + uneHab.Nature + "', habDomaine = '" + uneHab.Domaine + "' WHERE habId =" + uneHab.Id;
				MySqlCommand cmd = new MySqlCommand(query, Bdd);
				cmd.ExecuteNonQuery();
				Bdd.Close();

			}
			catch (Exception expt)
			{
				MsgErr = expt.Message;
			}
			Bdd.Close();

		}

		//Suppression d'une habilitation dans la base de données
		public void DeleteHabilitation(int idHab)
		{
			Bdd.Open();
			try
			{
				string query = "DELETE FROM habilitation WHERE habId = " + idHab;
				MySqlCommand cmd = new MySqlCommand(query, Bdd);
				cmd.ExecuteNonQuery();
				Bdd.Close();
			}
			catch (Exception expt)
			{
				MsgErr = expt.Message;
			}
			Bdd.Close();
		}

		//Habilitations des Techniciens CRUD

		//Remplit la liste habilitation avec les habilitations récupérées dans la base de données
		public List<Habilitation> SetHabTech(Technicien unTech)
		{
			habilitation = new List<Habilitation>();
			Bdd.Open();
			try
			{
				string query = "SELECT * FROM obtenir INNER JOIN habilitation ON obtenirHabId = habId WHERE obtenirTechId = " + unTech.Id;
				MySqlCommand cmd = new MySqlCommand(query, Bdd);
				MySqlDataReader dataReader = cmd.ExecuteReader();
				while (dataReader.Read())
				{
					this.habilitation.Add(new Habilitation(Int32.Parse(dataReader["habId"].ToString()), dataReader["habNat"].ToString(), dataReader["habDomaine"].ToString(), dataReader.GetDateTime("obtenirHabValid")));
				}
				dataReader.Close();
				Bdd.Close();
			}
			catch (Exception expt)
			{
				this.habilitation = null;
				MsgErr = expt.Message;
			}
			Bdd.Close();
			return habilitation;
		}

		//Insertion d'une habilitation d'un technicien dans la base de données
		public void InsertHabTech(Technicien unTech, Habilitation uneHab)
		{
			Bdd.Open();

			try
			{
				string query = "INSERT INTO obtenir (obtenirHabId, obtenirHabValid, obtenirTechId) VALUES (" + uneHab.Id + ", '" + uneHab.Date.ToString("yyyy-MM-dd") + "', " + unTech.Id + ")";
				MySqlCommand cmd = new MySqlCommand(query, Bdd);
				cmd.ExecuteNonQuery();
				Bdd.Close();
			}
			catch (Exception expt)
			{
				MsgErr = expt.Message;
			}

			Bdd.Close();

		}

		//Modification d'une habilitation d'un technicien dans la base de données
		public void UpdateHabTech(Technicien unTech, Habilitation uneHab)
		{
			Bdd.Open();
			try
			{
				string query = "UPDATE obtenir SET obtenirTechId = " + unTech.Id + ", obtenirHabId = " + uneHab.Id + ", obtenirHabValid = '" + uneHab.Date.ToString("yyyy-MM-dd") + "' WHERE obtenirTechId = " + unTech.Id;
				MySqlCommand cmd = new MySqlCommand(query, Bdd);
				cmd.ExecuteNonQuery();
				Bdd.Close();
			}
			catch (Exception expt)
			{

				MsgErr = expt.Message;
			}
			Bdd.Close();
		}

		//Suppression d'un habilitation d'un technicien dans la base de données
		public void DeleteHabTech(Technicien unTech)
		{
			Bdd.Open();
			try
			{
				string query = "DELETE FROM obtenir WHERE obtenirTechId = " + unTech.Id;
				MySqlCommand cmd = new MySqlCommand(query, Bdd);
				cmd.ExecuteNonQuery();
				Bdd.Close();
			}
			catch (Exception expt)
			{
				MsgErr = expt.Message;
			}
			Bdd.Close();
		}

	}
}
