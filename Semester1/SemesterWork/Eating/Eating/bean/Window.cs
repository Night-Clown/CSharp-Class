using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eating.bean
{
    class Window
    {
        public int wId;
        public int wNumber;
        public string wName;
        public int wXStart;
        public int wXEnd;
        public int wYStart;
        public int wYEnd;
        public string wUsername;
        public string wPassword;
        public int cId;

        public Window(int wId, int wNumber, string wName, int wXStart, int wXEnd, int wYStart, int wYEnd, string wUsername, string wPassword, int cId)
        {
            this.wId = wId;
            this.wNumber = wNumber;
            this.wName = wName;
            this.wXStart = wXStart;
            this.wXEnd = wXEnd;
            this.wYStart = wYStart;
            this.wYEnd = wYEnd;
            this.wUsername = wUsername;
            this.wPassword = wPassword;
            this.cId = cId;
        }
    }
}
