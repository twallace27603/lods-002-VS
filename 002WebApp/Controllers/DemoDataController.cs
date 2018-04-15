using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using _002WebApp.Models;

namespace _002WebApp.Controllers
{
    public class DemoDataController : ApiController
    {
        // GET: api/DemoData
        public IEnumerable<CLFinal> Get()
        {
            return (new ChampionsLeagueContext()).GetResults();
        }

        // GET: api/DemoData/5
        public CLFinal Get(int id)
        {
            return (new ChampionsLeagueContext()).GetResults().First(cl => cl.SeasonId == id);
        }

 
    }
}
