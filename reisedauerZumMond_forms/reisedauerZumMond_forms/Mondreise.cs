using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reisedauerZumMond_forms
{
    internal class Mondreise
    {
        int distance;
        string time;
        int speed;

        public Mondreise(string time, int speed, int distance)
        {
            this.time = time;
            this.speed = speed;
            this.distance = distance;
        }

        public int getTime()
        {
            int traveltime = 0;

            if (time == "Stunden")
            {
                traveltime = distance / speed;
            }
            else
            {
                traveltime = (distance / speed) / 24;
            }

            return traveltime;
        }
    }
}
