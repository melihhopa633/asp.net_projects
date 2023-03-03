using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Team
    {
        public int TeamID { get; set; }
        public string PersonName { get; set; }
        public string Title { get; set; }
        public string ImageURL { get; set; }
        public string FacebookURL { get; set; }
        public string InstagramURL { get; set; }
        public string WebSiteURL { get; set; }
        public string TwitterURL { get; set; }
    }
}
