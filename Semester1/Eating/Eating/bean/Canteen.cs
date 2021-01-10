using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eating.bean
{
    class Canteen
    {
        public int cId;
        public string cName;
        public int cLength;
        public int cWidth;
        public string cUsername;
        public string cPassword;

        public Canteen(int cId, string cName, int cLength, int cWidth, string cUsername, string cPassword)
        {
            this.cId = cId;
            this.cName = cName;
            this.cLength = cLength;
            this.cWidth = cWidth;
            this.cUsername = cUsername;
            this.cPassword = cPassword;
        }
    }
}
