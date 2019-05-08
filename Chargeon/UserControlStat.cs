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


namespace Chargeon
{
    
    public partial class UserControlStat : UserControl
    {
        public UserControlStat()
        {
            InitializeComponent();
            
            MajTypeBornesCb(comboBoxType);
        }
        static Assemblage assemblage = new Assemblage();
        
        List<Bornes> maListe = assemblage.ListBornes;


        public class ComboBoxItem
        {
            int id;
            string libelle;
            public ComboBoxItem(int unId , string unLibelle)
            {
                this.id = unId;
                this.libelle = unLibelle;

            }
            
            public override string ToString()
            {
                return libelle;
            }
            public int ToInt()
            {
                return id;
            }
        }
        public class ComboBoxType
        {
            int id;
            string libelle;
            public ComboBoxType(string unLibelle)
            {              
                this.libelle = unLibelle;

            }

            public override string ToString()
            {
                return libelle;
            }
            
        }

        void ClearCombo()
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            comboBox4.Items.Clear();
            comboBox5.Items.Clear();
            comboBox6.Items.Clear();
            comboBox7.Items.Clear();
            comboBox8.Items.Clear();

        }
        public void MajBornesCb()
        {

            ClearCombo();
            string query = "SELECT boId, boRef FROM borne";
            assemblage.Bdd.Open();
            MySqlCommand cmd = new MySqlCommand(query, assemblage.Bdd);
            MySqlDataReader datareader = cmd.ExecuteReader();

            while (datareader.Read())
            {
                comboBox1.Items.Add(new ComboBoxItem(Int32.Parse(datareader["boId"].ToString()), datareader["boRef"].ToString()));
                comboBox2.Items.Add(new ComboBoxItem(Int32.Parse(datareader["boId"].ToString()), datareader["boRef"].ToString()));
                comboBox3.Items.Add(new ComboBoxItem(Int32.Parse(datareader["boId"].ToString()), datareader["boRef"].ToString()));
                comboBox4.Items.Add(new ComboBoxItem(Int32.Parse(datareader["boId"].ToString()), datareader["boRef"].ToString()));
                comboBox5.Items.Add(new ComboBoxItem(Int32.Parse(datareader["boId"].ToString()), datareader["boRef"].ToString()));
                comboBox6.Items.Add(new ComboBoxItem(Int32.Parse(datareader["boId"].ToString()), datareader["boRef"].ToString()));
                comboBox7.Items.Add(new ComboBoxItem(Int32.Parse(datareader["boId"].ToString()), datareader["boRef"].ToString()));
                comboBox8.Items.Add(new ComboBoxItem(Int32.Parse(datareader["boId"].ToString()), datareader["boRef"].ToString()));

            }
            datareader.Close();
            assemblage.Bdd.Close();
            assemblage.GetBornes();
         
        }
        public void MajTypeBornesCb(ComboBox comboboxType)
        {
            comboBoxType.Items.Clear();
           
            string query = "SELECT DISTINCT boType FROM borne";
            assemblage.Bdd.Open();
            MySqlCommand cmd = new MySqlCommand(query, assemblage.Bdd);
            MySqlDataReader datareader = cmd.ExecuteReader();

            while (datareader.Read())
            {
                comboBoxType.Items.Add(new ComboBoxType(datareader["boType"].ToString()));
            }
            datareader.Close();
            assemblage.Bdd.Close();
            assemblage.GetBornes();

        }

        public int GetpuissanceAssemblage(string reference)
        {
            int obj = assemblage.GetPuissanceBornes(reference);
            return obj;
        }
        
        void ClearChart()
        {
            chartStat.Series["puissance"].Points.Clear();
        }

        void GetInfo(string reference ,int i)
        {
            int puissanceBorne = GetpuissanceAssemblage(reference);

            chartStat.Series["puissance"].Points.AddXY(reference,puissanceBorne);
            
        }

       public bool IsValidRef(string reference)
        {
            
                if (reference.StartsWith("Borne"))
            {
                return false;
            }
            else
            {
                return true;
            }

        }
       

        void GetCombo()
        {
            int i = 0;
            if (IsValidRef(comboBox1.Text) == true)
            {
                GetInfo(comboBox1.Text, i++);
            }
            if (IsValidRef(comboBox2.Text) == true)
            {
                GetInfo(comboBox2.Text, i++);
            }
            if (IsValidRef(comboBox3.Text) == true)
            {
                GetInfo(comboBox3.Text, i++);
            }
            if (IsValidRef(comboBox4.Text) == true)
            {
                GetInfo(comboBox4.Text, i++);
            }
            if (IsValidRef(comboBox5.Text) == true)
            {
                GetInfo(comboBox5.Text, i++);
            }
            if (IsValidRef(comboBox5.Text) == true)
            {
                GetInfo(comboBox5.Text, i++);
            }
            if (IsValidRef(comboBox6.Text) == true)
            {
                GetInfo(comboBox6.Text, i++);
            }
            if (IsValidRef(comboBox7.Text) == true)
            {
                GetInfo(comboBox7.Text, i++);
            }
            if (IsValidRef(comboBox8.Text) == true)
            {
                GetInfo(comboBox8.Text, i++);
            }
         
        }

        public void FillComboBox()
        {
            ClearCombo();
            string query = "SELECT DISTINCT boRef FROM borne WHERE ";
            query += "(boType like '%" + comboBoxType.Text + "%') ";

            assemblage.Bdd.Open();
            MySqlCommand cmd = new MySqlCommand(query, assemblage.Bdd);
            MySqlDataReader datareader = cmd.ExecuteReader();

            while (datareader.Read())
            {
                
                    comboBox1.Items.Add(new ComboBoxType(datareader["boRef"].ToString()));
                
                comboBox2.Items.Add(new ComboBoxType(datareader["boRef"].ToString()));
                comboBox3.Items.Add(new ComboBoxType(datareader["boRef"].ToString()));
                comboBox4.Items.Add(new ComboBoxType(datareader["boRef"].ToString()));
                comboBox5.Items.Add(new ComboBoxType(datareader["boRef"].ToString()));
                comboBox6.Items.Add(new ComboBoxType(datareader["boRef"].ToString()));
                comboBox7.Items.Add(new ComboBoxType(datareader["boRef"].ToString()));
                comboBox8.Items.Add(new ComboBoxType(datareader["boRef"].ToString()));


            }
            datareader.Close();
            assemblage.Bdd.Close();
            assemblage.GetBornes();

        }
    
        


        private void button2_Click(object sender, EventArgs e)
        {
            ClearChart();
            GetCombo();
            
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillComboBox();
        }

        private void UserControlStat_Load(object sender, EventArgs e)
        {
            MajBornesCb();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearChart();
        }

        private void chartStat_Click(object sender, EventArgs e)
        {

        }
    }
}
