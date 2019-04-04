using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BroodjesBestellen
{
    class Persistence
    {
        private string _connectionstring;
        private MySqlConnection conn;

        //constructor
        public Persistence()
        {
            _connectionstring = "server=localhost;user id=root;database=dbbroodjes;Password='Test123';";
            conn = new MySqlConnection(_connectionstring);
        }

        public List<Brood> GetBroodFromDB()
        {
            List<Brood> lijst = new List<Brood>();

             
            MySqlCommand cmd = new MySqlCommand("select * from bestelling", conn);

            conn.Open();
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                Brood eval = new Brood(Convert.ToInt32(dataReader["idbestelling"]),dataReader["naam"].ToString(), dataReader["broodje"].ToString(),Convert.ToInt32(dataReader["hoeveelheid"]),Convert.ToDouble(dataReader["prijs"]),dataReader["opmerkingen"].ToString());
                lijst.Add(eval);
            }
            conn.Close();
            return lijst;
        }
        public void addBroodinDB(Brood item)
        {
            string strJaar, strMaand, StrDag, StrDatum;
            strJaar = item.datum.Year.ToString();
            strMaand = item.datum.Month.ToString();
            StrDag = item.datum.Day.ToString();
            StrDatum = strJaar + "-" + strMaand + "-" + StrDag;
            MySqlCommand cmd = new MySqlCommand("insert into bestelling (naam,broodje,hoeveelheid,prijs,opmerkingen) values ('" + item.naam + "','" + item.broodje + "'," + item.Aantal + "," + item.Prijs +",'"+item.Opmerking+ "')", conn);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void DeleteBroodinDB(int pId)
        {
            MySqlCommand cmd = new MySqlCommand("delete from bestelling where (idbestelling = "+pId+")",conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public List<Brood> GetBroodjesFromDB()
        {
            List<Brood> lijst = new List<Brood>();


            MySqlCommand cmd = new MySqlCommand("SELECT distinct broodje FROM bestelling;", conn);

            conn.Open();
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                Brood eval = new Brood(dataReader["broodje"].ToString());
                lijst.Add(eval);
            }
            conn.Close();
            return lijst;
        }
        public List<Brood> GetNaamFromDB()
        {
            List<Brood> lijst = new List<Brood>();


            MySqlCommand cmd = new MySqlCommand("SELECT distinct naam FROM bestelling;", conn);

            conn.Open();
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                Brood eval = new Brood(dataReader["naam"].ToString());
                lijst.Add(eval);
            }
            conn.Close();
            return lijst;
        }
    }
}
