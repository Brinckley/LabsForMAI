using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixCode.Classes
{
    class MistakeClass
    {
        private int numMis;
        public bool another;
        public int mistakeNum
        {
            get { return numMis; }
            set { if (value > 0) {
                    numMis = value;
                }
            }
        }
    }
}
