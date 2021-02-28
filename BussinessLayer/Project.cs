using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Freelancing_Projects_Portal_Core_Webapp.BussinessLayer
{
    //Project infmration 
    public class Project
    {
        //Project id 
        public int Id { get; set; }

        //Heading of the project
        public string ProjectTitle { get; set; }


        //Details of the project
        public string Details { get; set; }

        //Budget of the project
        public decimal Budget { get; set; }

        //Client related key
        public int ClientId { get; set; }

        //Client relationship
        public Client Client { get; set; }

    }
}
