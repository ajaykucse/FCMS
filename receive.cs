using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using DALL;

namespace BO
{
   public class receive
    {
        //Set & Get for Registration --------------------

        public string name { get; set; }
        public string pass { get; set; }
        public string type { get; set; }
        public string imageBt { get; set; }
        public string createat { get; set; }
        public string addrs { get; set; }
        public int phn { get; set; }
        public bool status { get; set; }

       //-----------------------------------------------

      //Set & Get for Item Types -----------------------

        public string itno { get; set; }
        public string itypes { get; set; }

       //----------------------------------------------

      //Set & Get for Items ----------- ---------------

        public string ino { get; set; }
        public string iname { get; set; }
        public int qty { get; set; }
        public double price { get; set; }
        public string ityno { get; set; }
         
    }
}
