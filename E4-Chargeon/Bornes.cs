using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chargeon
{
	class Bornes
	{
		private int id, puissance, statId;
		private string numSerie, type, refe;
		private bool concu;
		private float longe, lat;

		public Bornes(int unId, int unePuissance, int unStatId, string unNumSerie, string unType, string uneRef, bool uneConcu, float uneLong, float uneLat)
		{
			this.id = unId;
			this.puissance = unePuissance;
			this.statId = unStatId;
			this.numSerie = unNumSerie;
			this.type = unType;
			this.refe = uneRef;
			this.concu = uneConcu;
			this.longe = uneLong;
			this.lat = uneLat;

		}

		public int Id { get => id; set => id = value; }
		public int Puissance { get => puissance; set => puissance = value; }
		public int StatId { get => statId; set => statId = value; }
		public string NumSerie { get => numSerie; set => numSerie = value; }
		public string Type { get => type; set => type = value; }
		public string Refe { get => refe; set => refe = value; }
		public bool Concu { get => concu; set => concu = value; }
		public float Long { get => longe; set => longe = value; }
		public float Lat { get => lat; set => lat = value; }

	}
}
