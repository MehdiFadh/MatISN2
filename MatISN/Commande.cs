using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatISN
{
    public class Commande
    {
        private DateTime dateCommande;
        private DateTime dateLivraison;

        public Commande()
        {
        }

        private int numCommande;

        public int NumCommande
        {
            get { return numCommande; }
            set { numCommande = value; }
        }

        private int numTransport;

        public int NumTransport
        {
            get { return numTransport; }
            set { numTransport = value; }
        }

        private int numCaserne;

        public int NumCaserne
        {
            get { return numCaserne; }
            set { numCaserne = value; }
        }


        public Commande(DateTime dateCommande, DateTime dateLivraison)
        {
            DateCommande = dateCommande;
            DateLivraison = dateLivraison;
        }

        public DateTime DateCommande
        {
            get
            {
                return dateCommande;
            }

            set
            {
                dateCommande = value;
            }
        }

        public DateTime DateLivraison
        {
            get
            {
                return dateLivraison;
            }

            set
            {
                dateLivraison = value;
            }
        }

        public Commande(int numTransport, int numCaserne, DateTime dateCommande, DateTime dateLivraison)
        {
            NumTransport = numTransport;
            NumCaserne = numCaserne;
            DateCommande = dateCommande;
            DateLivraison = dateLivraison;
        }
    }
}
