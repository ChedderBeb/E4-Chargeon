using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Chargeon
{
    
    public partial class UserControlStat : UserControl
    {
        public UserControlStat()
        {
            InitializeComponent();
            
        }
        
        
        private void UserControlStat_Load(object sender, EventArgs e)
        {
          Assemblage assemblage = new Assemblage();
            string LesBornes = assemblage.GetRefBornes();
            comboBox1.Items.Add(LesBornes);


        }
    }
}
