using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chargeon
{
	class Technicien
	{
		private int id;
		private string nom, prenom;
		private float longi, lat;

		public Technicien(int unId, string unNom, string unPrenom, float uneLong, float uneLat)
		{
			this.id = unId;
			this.Nom = unNom;
			this.Prenom = unPrenom;
			this.longi = uneLong;
			this.lat = uneLat;
		}
		public int Id { get => id; set => id = value; }
		public string Nom { get => nom; set => nom = value; }
		public string Prenom { get => prenom; set => prenom = value; }
		public float Longi { get => longi; set => longi = value; }
		public float Lat { get => lat; set => lat = value; }
	}
}
