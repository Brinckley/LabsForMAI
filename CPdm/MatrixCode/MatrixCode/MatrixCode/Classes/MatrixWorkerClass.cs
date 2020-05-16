using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace MatrixCode
{
    static class MatrixWorkerClass
    {
        public static int misrakenumber = 0;
        public static int[] codeInto(ref int[,] bornMatrix, int[] a) {
            int sum = 0;
            int[] b = new int[6];
            for (int i = 0; i < bornMatrix.GetLength(1) - 1; ++i)
            {
                for (int j = 0; j < bornMatrix.GetLength(0); ++j)
                {
                    sum = sum + (bornMatrix[j, i] * a[j]);
                }
                b[i] = (sum % 2);
                sum = 0;
            }
            return b;
        }

        public static string codeIntoS(int[,] bornMatrix, string word)
        {
            string s = "";
            int sum = 0;
            int tmp = 0;
            for (int i = 0; i < bornMatrix.GetLength(1) - 1; ++i)
            {
                sum = 0;
                for (int j = 0; j < bornMatrix.GetLength(0); ++j)
                {
                    if (word[j] == '1')
                    {
                        sum = sum + (bornMatrix[j, i] * 1);
                    }
                    else {
                        sum = sum + (bornMatrix[j, i] * 0);
                    }
                }
                s += (Convert.ToString((sum % 2)));
                
            }
            return s;
        }

            public static int[] wordToArray(int word, int n) {
            int[] a = new int[n];//записываю исходное слово в массив
            int counter = n - 1;
            while (word > 0)
            {//записываю исходное слово в массив
                a[counter] = (word % 10);
                counter--;
                word /= 10;
            }
            return a;
        }

        public static int[] mistakeSearch(ref int[,] g, int[] a) {
            int sum = 0;
            int[] b = new int[3];
            for (int i = 0; i < g.GetLength(0) ; ++i) {
                for (int j = 0; j < g.GetLength(1); ++j) {
                    sum += (g[i, j] * a[j]);
                }
                b[i] = (sum % 2);
                sum = 0;
            }
            return b;
        }


        public static int[] mistakeCorrect(int[] word, int[] mistake) {
            int number = 0;
            for (int i = 0; i < mistake.Length; ++i) {
                number = number * 10 + mistake[i];
            }
            String s = Convert.ToString(number);
            number = Convert.ToInt32(s, 2);
            misrakenumber = number;
            if (number == 0) {
                return word;
            }
            if (word[number - 1] == 1)
            {
                word[number - 1] = 0;
            }
            else
            {
                word[number - 1] = 1;
            }
            return word;

        }

        public static int[] decoding(int[] word) {
            int[] answer = new int[4];
            answer[0] = word[2];
            answer[1] = word[4];
            answer[2] = word[5];
            answer[3] = word[6];
            return answer;
        }
    }
}
