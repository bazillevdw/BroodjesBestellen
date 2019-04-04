using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BroodjesBestellen
{
    class Business
    {
        private Persistence pers;
        private Business bus;
        private List<Brood> _brood;
        private List<Brood> _broodjes;
        private List<Brood> _naam;
        public List<Brood> naam
        {
            get { return _naam; }
            set { _naam = value; }
        }
        public List<Brood> brooden
        {
        get { return _brood; }
        set { _brood = value; }
        }
        public List<Brood> broodjes
        {
            get { return _broodjes; }
            set { _broodjes = value; }
        }

        //constructor
        public Business()
        {
        pers = new Persistence();
        brooden = pers.GetBroodFromDB();
        broodjes = pers.GetBroodjesFromDB();
        }

        //methods
        public List<string> getBrood()
        {
            List<string> result = new List<string>();

            foreach (Brood item in brooden)
            {
                result.Add(item.ToString());
            }
            return result;
        }
        public void vulForm()
        {
            bus = new Business();

            foreach (string lijn in bus.getBrood())
            {
                
            }
        }
        public void AddBrood( string pstrnaam, string pstrbroodje, int pAantal, double pPrijs, string pOpmerking)
        {
            Brood brood = new Brood( pstrnaam, pstrbroodje, pAantal,pPrijs,pOpmerking);
            pers.addBroodinDB(brood);
            brooden = pers.GetBroodFromDB();
        }
        public void DeleteBrood(int Pid)
        {
            pers.DeleteBroodinDB(Pid);
            brooden = pers.GetBroodFromDB();
        }
        public List<string> getBroodjes()
        {
            List<string> result = new List<string>();

            foreach (Brood item in brooden)
            {
                result.Add(item.ToString("item"));
            }
            brooden = pers.GetBroodjesFromDB();
            return result;
        }
        public List<string> getNamen()
        {
            List<string> result = new List<string>();

            foreach (Brood item in naam)
            {
                result.Add(item.Tostring("item","plopkoek"));
            }
            return result;
        }
    }
}
