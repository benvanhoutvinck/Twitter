using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter
{
    [Serializable]
    class Tweet
    {
        private string naamValue;

        public string Naam
        {
            get { return naamValue; }
            set { naamValue = value; }
        }

        private string berichtValue;

        public string Bericht
        {
            get { return berichtValue; }
            set
            {
                if (value.Length > 140)
                    throw new Exception("Bericht mag maximaal 140 karakters zijn");
                berichtValue = value;
            }
        }

        private DateTime tijdstipValue;

        public DateTime Tijdstip
        {
            get { return tijdstipValue; }
            set { tijdstipValue = value; }
        }

        public override string ToString()
        {
            string tijdstipString;
            DateTime dateNow = DateTime.Now;
            // Difference in days, hours, and minutes.
            TimeSpan ts = dateNow - tijdstipValue;
            int dagen = ts.Days;
            int uren = ts.Hours;
            if (dagen > 0)
            {
                tijdstipString = tijdstipValue.ToShortDateString();
            }
            else if (uren > 1)
            {
                tijdstipString = uren + " uur geleden";
            }
            else
            {
                tijdstipString = ts.Minutes + " geleden.";
            }
            return "Naam: " + this.Naam + "\nBericht: " + this.Bericht + "\nTijdstip: " + tijdstipString;
        }

    }
}
