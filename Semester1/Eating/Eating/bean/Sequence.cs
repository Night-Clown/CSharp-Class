using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eating.bean
{
    class Sequence
    {
        public int sId;
        public string sState;
        public DateTime sStartTime;
        public DateTime sEndTime;
        public int wNumber;
        public int uId;
        public int tId;

        public Sequence(int sId, string sState, DateTime sStartTime, DateTime sEndTime, int wNumber, int uId, int tId)
        {
            this.sId = sId;
            this.sState = sState;
            this.sStartTime = sStartTime;
            this.sEndTime = sEndTime;
            this.wNumber = wNumber;
            this.uId = uId;
            this.tId = tId;
        }
    }
}
