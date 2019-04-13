using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
        
        //Techniciens CRUD
      
        
        
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

        public string GetRefBornes()
        {
            Bdd.Open();
            
            string query = "SELECT boRef FROM borne";
            MySqlCommand cmd = new MySqlCommand(query, Bdd);            
            MySqlDataReader bornes = cmd.ExecuteReader();
            
            
              Bdd.Close();
              return bornes.ToString();
            
           
        }
    }
}
