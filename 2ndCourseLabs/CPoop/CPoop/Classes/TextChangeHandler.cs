using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPoop.Classes
{
    public class FontRTB
    {
        public bool BoldChange { get; set; }
        public bool ItalicsChange { get; set; }
        public bool UnderlineChange { get; set; }
        public Font tFont { get; set; }

        public FontRTB(bool bc, bool ic, bool uc, Font tFont)
        {
            BoldChange = bc;
            ItalicsChange = ic;
            UnderlineChange = uc;
            this.tFont = tFont;
        }
    }

    abstract class TextChangeHandler
    {
        public TextChangeHandler Successor { get; set; }
        public abstract void Handle(FontRTB font);
    }

    class BoldChangeHandler : TextChangeHandler
    {
        public override void Handle(FontRTB font)
        {
            if (font.BoldChange)
            {
                font.tFont = new Font(font.tFont.FontFamily.Name, font.tFont.Size, FontStyle.Bold);
            }
            else if (Successor != null)
            {
                Successor.Handle(font);
            }
        }
    }

    class ItalicsChangeHandler : TextChangeHandler
    {
        public override void Handle(FontRTB font)
        {
            if (font.ItalicsChange)
            {
                font.tFont = new Font(font.tFont.FontFamily.Name, font.tFont.Size, FontStyle.Italic);
            }
            else if (Successor != null)
            {
                Successor.Handle(font);
            }
        }
    }

    class UnderlineChangeHandler : TextChangeHandler
    {
        public override void Handle(FontRTB font)
        {
            if (font.UnderlineChange)
            {
                font.tFont = new Font(font.tFont.FontFamily.Name, font.tFont.Size, FontStyle.Underline);
            }
            else if (Successor != null)
            {
                Successor.Handle(font);
            }
        }
    }
}
