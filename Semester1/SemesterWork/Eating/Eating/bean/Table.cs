using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eating.bean
{
    class Table
    {
        public int tId;
        public int tNumber;
        public int tXStart;
        public int tXEnd;
        public int tYStart;
        public int tYEnd;
        public int cId;
        public int sId;

        public Table(int tId, int tNumber, int tXStart, int tXEnd, int tYStart, int tYEnd, int cId, int sId)
        {
            this.tId = tId;
            this.tNumber = tNumber;
            this.tXStart = tXStart;
            this.tXEnd = tXEnd;
            this.tYStart = tYStart;
            this.tYEnd = tYEnd;
            this.cId = cId;
            this.sId = sId;
        }
    }
}
