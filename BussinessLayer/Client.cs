using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Freelancing_Projects_Portal_Core_Webapp.BussinessLayer
{

    //Models client details
    public class Client
    {
        //Client id
        public int Id { get; set; }

        //Client name
        public string Name { get; set; }

        //Client email
        public string Email { get; set; }

        //is a senior or not
        public Boolean Vetran { get; set; }
    }
}
