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
            this.nom = unNom;
            this.prenom = unPrenom;
            this.longi = uneLong;
            this.lat = uneLat;
        }

        public int Id { get => id; set => id = value; }
    }
}
