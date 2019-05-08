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
        internal List<Bornes> ListBornes { get => listBornes; set => listBornes = value; }

        List<Bornes> listBornes = new List<Bornes>();

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


        //-------------------------------------Léo--------------------------------------------------------
        public void GetBornes()
        {
            listBornes = new List<Bornes>();
            Bdd.Open();
            try
            {
                string query = "SELECT * FROM borne";
                MySqlCommand cmd = new MySqlCommand(query, Bdd);
                MySqlDataReader bornes1 = cmd.ExecuteReader();
                while(bornes1.Read())
                {
                    this.listBornes.Add(new Bornes(Int32.Parse(bornes1["boId"].ToString()), Int32.Parse(bornes1["boPuissance"].ToString()), Int32.Parse(bornes1["boStatId"].ToString()), bornes1["boNumSerie"].ToString(), bornes1["boType"].ToString(), bornes1["boRef"].ToString(), false, float.Parse(bornes1["boLong"].ToString()), float.Parse(bornes1["boLat"].ToString())));
                }
                bornes1.Close();
                Bdd.Close();
            }
            catch(Exception ex)
            {
                this.listBornes = null;
                MsgErr = ex.Message;
            }
            Bdd.Close();
        }
        

        public int GetPuissanceBornes(string reference)
        {
            int puissance = 0;

            string query = "SELECT boPuissance FROM borne ";
            query += "WHERE boRef = '" + reference +"' ";
            Bdd.Open();
            MySqlCommand cmd = new MySqlCommand(query, Bdd);
            MySqlDataReader datareader = cmd.ExecuteReader();
            datareader.Read();
            puissance = Int32.Parse(datareader["boPuissance"].ToString());
            datareader.Close();
            Bdd.Close();
            return puissance;
        }




       //--------------------------------------------------Fin Léo-------------------------------------------
    }
}
