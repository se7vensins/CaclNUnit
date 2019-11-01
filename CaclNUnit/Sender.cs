using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaclNUnit
{
    public class Sender
    {
        public add objAdd = null;
        public sub objSub = null;
        public mult objMult = null;
        public div objDiv = null;


        public add setAdd
        {
            set { objAdd = value; }
        }
        public sub setSub
        {
            set { objSub = value; }
        }
        public mult setMult
        {
            set { objMult = value; }
        }
        public div setDiv
        {
            set { objDiv = value; }
        }

        public void SendNotif()
        {
            objAdd.addition();
            objSub.subtration();
            objMult.multiply();
            objDiv.divide();
        }
    }
}
