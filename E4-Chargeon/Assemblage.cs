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
		private MySqlConnection bdd = new MySqlConnection("SERVER= 127.0.0.1; DATABASE= chargeon; UID=root; PASSWORD= ;");
		string MsgErr = "";
		public MySqlConnection Bdd { get => bdd; }

		List<Technicien> technicien = new List<Technicien>();
		Habilitation habilitation;
		//Techniciens CRUD
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
		public void InsertTechniciens(Technicien unNom, Technicien unPrenom, Technicien uneLong, Technicien uneLat)
		{
			Bdd.Open();
			try
			{

				string query = "INSERT INTO technicien (techNom, techPrenom, techLong, techLat) VAlUES (" + unNom + ", " + unPrenom + ", " + uneLong + ", " + uneLat + ")";
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
		public void UpdateTechniciens(Technicien unId, Technicien unNom, Technicien unPrenom, Technicien uneLong, Technicien uneLat)
		{
			Bdd.Open();
			try
			{
				string query = "UPDATE technicien SET techNom = " + unNom + ", techPrenom = " + unPrenom + ", techLong = " + uneLong + ", techLat = " + uneLat + " WHERE techId = " + unId.Id;
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
		public void DeleteTechniciens(Technicien id)
		{
			Bdd.Open();
			try
			{
				string query = "DELETE FROM technicien WHERE techId = " + id.Id;
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
		public void SetHabilitations()
		{
			Bdd.Open();
			try
			{
				string query = "SELECT * FROM habilitation";
				MySqlCommand cmd = new MySqlCommand(query, Bdd);
				MySqlDataReader dataReader = cmd.ExecuteReader();
				while (dataReader.Read())
				{
					this.habilitation = new Habilitation(Int32.Parse(dataReader["habId"].ToString()), dataReader["habNat"].ToString(), dataReader["habDomaine"].ToString());
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
		public void InsertHabilitation(Habilitation uneNat, Habilitation unDom)
		{
			Bdd.Open();
			try
			{
				string query = "INSERT INTO habilitation (habNat, habDomaine, habValid) VALUES (" + uneNat + ", " + unDom + ")";
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
		public void UpdateHabilitations(Habilitation uneNat, Habilitation unDom)
		{
			try
			{
				string query = "UPDATE habilitation SET habNat = " + uneNat + ", habDomaine = " + unDom + " WHERE habId =" + habilitation.Id;
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
		public void DeleteHabilitation(Habilitation id)
		{
			Bdd.Close();
			try
			{
				string query = "DELETE FROM habilitation WHERE habId = " + id.Id;
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
		public void SetHabTech(Technicien idTech)
		{
			Bdd.Open();
			try
			{
				string query = "SELECT techNom, habId, obtenirHabValid FROM technicien INNER JOIN obtenir ON techId = obtenirTechId INNER JOIN habilitation ON obtenirHabId = habId WHERE techId = " + idTech.Id;
				MySqlCommand cmd = new MySqlCommand(query, Bdd);
				MySqlDataReader dataReader = cmd.ExecuteReader();
				while (dataReader.Read())
				{
					this.technicien.Add(new Technicien(0, dataReader["techNom"].ToString(), "", 0, 0));
					this.habilitation = new Habilitation(Int32.Parse(dataReader["habId"].ToString()), "", "", DateTime.Parse("habValid"));
				}
				dataReader.Close();
				Bdd.Close();
			}
			catch (Exception expt)
			{
				this.technicien = null;
				this.habilitation = null;
				MsgErr = expt.Message;
			}
			Bdd.Close();
		}
		public void InsertHabTech(Technicien techId, Habilitation habId, Habilitation uneDateValid)
		{
			Bdd.Open();

			try
			{
				string query = "INSERT INTO obtenir (obtenirHabId, obtenirHabValid) VALUES (" + habId.Id + ", " + uneDateValid + ") WHERE obtenirTechId = " + techId.Id;
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
		public void UpdateHabTech(Technicien techId, Habilitation habId, Habilitation uneDateValid)
		{
			Bdd.Open();
			try
			{
				string query = "UPDATE obtenir SET obtenirTechId = " + techId.Id + ", obtenirHabId = " + habId.Id + ", obtenirHabValid = '" + uneDateValid + "' WHERE obtenirTechId = " + techId.Id;
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
		public void DeleteHabTech(Technicien techId)
		{
			Bdd.Open();
			try
			{
				string query = "DELETE FROM obtenir WHERE obtenirTechId = " + techId.Id;
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
