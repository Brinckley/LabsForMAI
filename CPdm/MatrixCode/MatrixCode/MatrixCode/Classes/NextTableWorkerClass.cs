using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixCode.Classes
{
    class NextTableWorkerClass
    {
        public string[,] relatedTable;
        public MistakeClass[] mistakesArray;
        public RelatedBArray[] nextArr;


        public static string correct(MistakeClass m, RelatedBArray r) {
            if (r.N[m.mistakeNum] == '1')
            {
                r.N = r.N.Remove(m.mistakeNum - 1, 1).Insert(m.mistakeNum - 1, "0");
            }
            else {
                r.N = r.N.Remove(m.mistakeNum - 1, 1).Insert(m.mistakeNum - 1, "1");
            }
            if (m.another) {
                if (r.N[1] == '1')
                {
                    r.N = r.N.Remove(1, 1).Insert(1, "0");
                }
                else
                {
                    r.N = r.N.Remove(1, 1).Insert(1, "1");
                }
            }
            return r.N;
        }

        public void fillinMistakesArray() {
            mistakesArray = new MistakeClass[8];
            for (int i = 0; i < mistakesArray.Length; ++i) {
                mistakesArray[i].mistakeNum = i;
                if (i == 7) {
                    mistakesArray[i].another = true;
                } else {
                    mistakesArray[i].another = false;
                }
            }
        }

        public void fillinRelatedTable() {
            relatedTable = new string[mistakesArray.Length, nextArr.Length];
            
        }
    }
}
