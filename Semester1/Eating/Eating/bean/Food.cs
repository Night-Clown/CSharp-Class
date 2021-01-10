using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eating.bean
{
    class Food
    {
        public int fId;
        public string fName;
        public int fPortion;
        public int fPrice;
        public int wId;

        public Food(int fId, string fName, int fPortion, int fPrice, int wId)
        {
            this.fId = fId;
            this.fName = fName;
            this.fPortion = fPortion;
            this.fPrice = fPrice;
            this.wId = wId;
        }
    }
}
