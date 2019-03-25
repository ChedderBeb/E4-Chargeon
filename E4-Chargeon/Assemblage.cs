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
        public Technicien Technicien { get => technicien; set => technicien = value; }

        Technicien technicien;
        Habilitation habilitation;
        //Techniciens CRUD
        public void SetTechniciens()
        {
            Bdd.Open();
            try
            {
                string query = "SELECT * FROM technicien";
                MySqlCommand cmd = new MySqlCommand(query, Bdd);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    this.technicien = new Technicien(Int32.Parse(dataReader["techId"].ToString()), dataReader["techNom"].ToString(), dataReader["techPrenom"].ToString(), float.Parse(dataReader["techLong"].ToString()), float.Parse(dataReader["techLat"].ToString()));
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
        public void UpdateTechniciens(string unNom, string unPrenom, float uneLong, float uneLat)
        {
            Bdd.Open();
            try
            {
                string query = "UPDATE technicien SET techNom = " + unNom + ", techPrenom = " + unPrenom + ", techLong = " + uneLong + ", techLat = " + uneLat + " WHERE techId = " + Technicien.Id;
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
        public void DeleteTechniciens(int id)
        {
            Bdd.Open();
            try
            {
                string query = "DELETE FROM technicien WHERE techId = " + id;
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
                    this.habilitation = new Habilitation(Int32.Parse(dataReader["habId"].ToString()), dataReader["habNat"].ToString(), dataReader["habDomaine"].ToString(), DateTime.Parse("habValid"));
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
        public void UpdateHabilitations(string uneNat, string unDom, DateTime uneDate)
        {
            try
            {
                string query = "UPDATE habilitation SET habNat = " + uneNat + ", habDomaine = " + unDom + ", habValid = " + uneDate + " WHERE habId =" + habilitation.Id;
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
        public void DeleteHabilitation(int id)
        {
            Bdd.Close();
            try
            {
                string query = "DELETE FROM habiliation WHERE habId = " + id;
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
        public void SetHabTech()
        {
            Bdd.Open();
            try
            {
                string query = "SELECT techId, techNom, natHab, habDomaine, habValid FROM technicien INNER JOIN obtenir ON techId = obtenirTechId INNER JOIN habilitation ON obtenirHabId = habId";
                MySqlCommand cmd = new MySqlCommand(query, Bdd);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    this.technicien = new Technicien(Int32.Parse(dataReader["techId"].ToString()), dataReader["techNom"].ToString(), "", 0, 0);
                    this.habilitation = new Habilitation(0, dataReader["natHab"].ToString(), dataReader["natDomaine"].ToString(), DateTime.Parse("habValid"));
                }
            }
            catch (Exception expt)
            {
                this.technicien = null;
                this.habilitation = null;
                MsgErr = expt.Message;
            }
        }
        public void UpdateHabTech(List<Technicien> listTech, List<Habilitation> listHab)
        {

            Bdd.Open();
            try
            {
                string query = "UPDATE technicien, habilitation, obtenir SET techId = " + listTech + ", techNom";

            }
            catch (Exception expt)
            {

            }

        }
    }
}
