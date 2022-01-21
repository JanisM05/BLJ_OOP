using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tannenbaum_forms
{
    internal class Tanne
    {
        int stammbreite;
        int stammhoehe;
        int kronenhoehe;

        public Tanne(int stammbreite, int stammhoehe, int kronenhoehe)
        {
            this.stammbreite = stammbreite;
            this.stammhoehe = stammhoehe;
            this.kronenhoehe = kronenhoehe;
        }

        private string getKrone()
        {
            string krone = "";
            int leerschlaege = kronenhoehe;
            int sterne = 1;

            for (int i = 0; i < kronenhoehe; i++)
            {
                for (int z = 0; z < leerschlaege; z++)
                {
                    krone += " ";
                }

                for (int k = 0; k < sterne; k++)
                {
                    krone += "*";
                }
                krone += "\n";
                sterne += 2;
                leerschlaege -= 1;
            }

            return krone;
        }


        private string getStamm()
        {
            string stamm = "";
            int leerschlaege = kronenhoehe -1;
            int sterne = stammbreite;

            for (int i = 0;i < stammhoehe; i++)
            {
                for (int z = 0; z < leerschlaege; z++)
                {
                    stamm += " ";
                }

                for ( int k = 0;k < sterne; k++)
                {
                    stamm += "*";
                }

                stamm += "\n";
            }

            return stamm;
        }

        public string getZeichnung()
        {
            string tannenbaum =  getKrone() + getStamm();
            return tannenbaum;
        }
    }
}
