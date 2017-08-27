using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace SampleAppMicroService
{
    public class Website
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

    [EnableCors(origins: "*", headers: "*", methods: "*")]
   public class MicroServiceController : ApiController
    {
        Website[] websites = new Website[]
        {
            new Website { Id = 1, Name = "Charlotte Tag type", Description = "First in Freendom"},
            new Website { Id = 2, Name = "Charlotte Tag type 2", Description = "First in flight"},
            new Website { Id = 3, Name = "Charlotte football team", Description = "Carolina Pathers"},
            new Website { Id = 4, Name = "Charlotte football team quarterback", Description = "Cam Newton"}
        };

        // GET api/Websites 
        public IEnumerable Get()
        {
            return websites;
        }

        // GET api/Websites/5 
        public Website Get(int id)
        {
            try
            {
                return websites[id];
            }
            catch (Exception e)
            {
                return new Website();
            }
        }
    }
}
