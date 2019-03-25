using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chargéon
{
    class Bornes
    {
        private string Id, numSerie, puissance, client, localisation;

        private void setID(string boId)
        {
            Id = boId;
        }

        private void setNumSerie(string boNumSerie)
        {
            numSerie = boNumSerie;
        }

        private void setPuissance(string boPuissance)
        {
            puissance = boPuissance;
        }

        private void setClient(string boClient)
        {
            client = boClient;
        }

        private void setLocalisation(string boLocalisation)
        {
            localisation = boLocalisation;
        }

        public string GetSetId
        {

            get
            {
                return this.Id;
            }

            set
            {
                this.Id = value;
            }
        }

        public string GetSetNumSerie
        {

            get
            {
                return this.numSerie;
            }

            set
            {
                this.numSerie = value;
            }
        }

        public string GetSetPuissance
        {

            get
            {
                return this.puissance;
            }

            set
            {
                this.puissance = value;
            }
        }

        public string GetSetClient        {

            get
            {
                return this.Id;
            }

            set
            {
                this.Id = value;
            }
        }

        public string GetSetLocalisation
        {

            get
            {
                return this.localisation;
            }

            set
            {
                this.localisation = value;
            }
        }
    }
}
