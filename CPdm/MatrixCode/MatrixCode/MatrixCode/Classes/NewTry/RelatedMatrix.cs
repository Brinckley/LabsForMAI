using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixCode.Classes.NewTry
{
    static class RelatedMatrix
    {

        public static string func(int n, string s) {
            if(n == 7) {
                if (s[0] == '1')
                {
                    s = s.Remove(0, 1).Insert(0, "0");
                }
                else
                {
                    s = s.Remove(0, 1).Insert(0, "1");
                }
                if (s[1] == '1')
                {
                    s = s.Remove(1, 1).Insert(1, "0");
                }
                else
                {
                    s = s.Remove(1, 1).Insert(1, "1");
                }
            } else {
                if (s[n] == '1')
                {
                    s = s.Remove(n, 1).Insert(n, "0");
                }
                else {
                    s = s.Remove(n, 1).Insert(n, "1");
                }
            }
            return s;
        }
        public static string[,] relatedWorker(string[] b) {
            string[,] r = new string[Mistake.n.Length, b.Length];

            for (int i = 0; i < Mistake.n.Length; ++i) {
                for (int j = 0; j < b.Length; ++j) {
                    r[i, j] = func(Mistake.n[i], b[j]);
                }
            }
            return r;
        }

        public static string[] bmaker(ref int[,] g) {
            string[] s = new string[8];
            for (int i = 0; i < 8; ++i) {
                int[] a = MatrixWorkerClass.codeInto(ref g, new int[3] { 0, 0, 0});
                for (int j = 0; j < a.Length; ++j) {
                    s[i] += Convert.ToString(a[j]);
                }
            }
            return s;
        }
    }
}
