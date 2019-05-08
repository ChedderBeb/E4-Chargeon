using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chargeon
{
	class Bornes
	{
		private int id, numSerie, puissance;
		private string type, reference;
		private bool concu;
		private float longi, lat;

		public Bornes(int unId, int unNum, int unePuissance, string unType, string uneRef,  float uneLat, float uneLong, bool uneConcu)
		{
			this.id = unId;
			this.numSerie = unNum;
			this.puissance = unePuissance;
			this.type = unType;
			this.reference = uneRef;
			this.longi = uneLong;
			this.lat = uneLat;
			this.concu = uneConcu;

		}

		public int Id { get => id; set => id = value; }
		public int NumSerie { get => numSerie; set => numSerie = value; }
		public int Puissance { get => puissance; set => puissance = value; }
		public string Type { get => type; set => type = value; }
		public string Reference { get => reference; set => reference = value; }
		public bool Concu { get => concu; set => concu = value; }
		public float Longi { get => longi; set => longi = value; }
		public float Lat { get => lat; set => lat = value; }
	}
}
