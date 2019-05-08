using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4_Chargeon
{
	class ComboBoxItem
	{
		int id;
		string libelle;
		public ComboBoxItem(int unId, string unLibelle)
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
}
