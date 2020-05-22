using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixCode.Classes.NewTry
{
    public static class RichTextBoxExtensions
    {
        public static void AppendText(this RichTextBox box, string str, Color color)
        {
            int position_save = box.SelectionStart; // сохраняем позицию курсора из начально

            int i = 0;
            while (i <= box.Text.Length - str.Length)
            {
                //выделение цветом
                i = box.Text.IndexOf(str, i);
                if (i < 0) break;
                box.SelectionStart = i;
                box.SelectionLength = str.Length;
                box.SelectionColor = color;
                box.SelectionStart = position_save; // ставим как было
                box.SelectionColor = Color.Black; // чужое красим в черное
                i += str.Length; //Так по лучше

            }

        }
    }
}
