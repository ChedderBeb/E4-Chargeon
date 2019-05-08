using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chargeon
{
	class Habilitation
	{
		private int id;
		private string nature, domaine;
		private DateTime date;

		public Habilitation(int unId, string uneNature, string unDomaine)
		{
			this.id = unId;
			this.nature = uneNature;
			this.domaine = unDomaine;

		}
		public Habilitation(int unId, string uneNature, string unDomaine, DateTime uneDate)
		{
			this.id = unId;
			this.nature = uneNature;
			this.domaine = unDomaine;
			this.date = uneDate;
		}

		public int Id { get => id; set => id = value; }
		public string Nature { get => nature; set => nature = value; }
		public string Domaine { get => domaine; set => domaine = value; }
		public DateTime Date { get => date; set => date = value; }
	}


}
