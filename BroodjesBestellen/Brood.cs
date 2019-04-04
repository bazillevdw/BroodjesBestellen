using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BroodjesBestellen
{
    class Brood
    {
        private int intId;
        private string strnaam;
        private string strbroodje;
        private int intAantal;
        private double dblPrijs;
        private string strOpmerking;
        private DateTime dteDatum;

        public int id
        {
            get { return intId; }
            set { intId = value; }
        }
        public string naam
        {
            get { return strnaam; }
            set { strnaam = value; }
        }
        public DateTime datum
        {
            get { return dteDatum; }
            set { dteDatum = value; }
        }
        public string broodje
        {
            get { return strbroodje; }
            set { strbroodje = value; }
        }
        public int Aantal
        {
            get { return intAantal; }
            set { intAantal = value; }
        }
        public double Prijs
        {
            get { return dblPrijs; }
            set { dblPrijs = value; }
        }
        public string Opmerking
        {
            get { return strOpmerking; }
            set { strOpmerking = value; }
        }
        //constructor
        public Brood( int pID,string pstrnaam, string pstrbroodje, int pintAantal, double pdblPrijs, string pstrOpmerking)
        {
            intId = pID;
            strnaam = pstrnaam;
            strbroodje = pstrbroodje;
            intAantal = pintAantal;
            dblPrijs = pdblPrijs;
            strOpmerking = pstrOpmerking;
           
        }
        public Brood( string pstrnaam, string pstrbroodje, int pintAantal, double pdblPrijs, string pstrOpmerking, DateTime pdteDatum)
        {
            strnaam = pstrnaam;
            strbroodje = pstrbroodje;
            intAantal = pintAantal;
            dblPrijs = pdblPrijs;
            strOpmerking = pstrOpmerking;
            dteDatum = pdteDatum;
        }
        public Brood()
        {

        }
        public Brood(string pBroodje)
        {
            strbroodje = pBroodje;
        }
        public Brood(string pstrnaam, string pstrbroodje, int pintAantal, double pdblPrijs, string pstrOpmerking)
        {
            strnaam = pstrnaam;
            strbroodje = pstrbroodje;
            intAantal = pintAantal;
            dblPrijs = pdblPrijs;
            strOpmerking = pstrOpmerking;
        }

        //method Tostring overschrijven
        public override string ToString()
        {
            return "Bestelling met id: " + id + " heeft " + Aantal +" " +broodje + " bestelt onder de naam: " + naam;
        }
        public string ToString(string pItem)
        {
            return broodje;
        }
        public string Tostring(string pItem,string pTiem)
        {
            return naam;
        }
    }
}