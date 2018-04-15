using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
namespace _002WebApp.Models
{
    public class ChampionsLeagueContext
    {
        private string connString = System.Configuration.ConfigurationManager.ConnectionStrings["demoData"].ConnectionString;

        public List<CLFinal> GetResults()
        {
            var conn = new SqlConnection(connString);
            var SQL = "Select * From dbo.ChampionsLeague";
            var cmd = new SqlCommand(SQL, conn);
            var results = new List<CLFinal>();
            conn.Open();
            try
            {
                var rdr = cmd.ExecuteReader();
                while (rdr.Read()) {
                    results.Add(new CLFinal { SeasonId = (int)rdr["SeasonId"], Season = rdr["Season"].ToString(), Score = rdr["Score"].ToString(), SecondPlace = rdr["SecondPlace"].ToString(), Winner = rdr["Winner"].ToString() });
                }

            }
            finally
            {
                conn.Close();
            }
            return results;
        }
    }
    public class CLFinal
    {
        public int SeasonId { get; set; }
        public string Season { get; set; }
        public string Winner { get; set; }
        public string SecondPlace { get; set; }
        public string Score { get; set; }
    }
}