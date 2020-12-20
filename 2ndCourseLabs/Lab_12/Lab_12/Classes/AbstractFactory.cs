using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_12.Classes
{
    abstract class AbstractFactory
    {
        public abstract void updateDate();
    }

    class dateData : AbstractFactory
    {
        protected string date;
        protected string time;

        protected dateData() { }

        public override void updateDate() {
            date = DateTime.Now.ToLongDateString();
            time = DateTime.Now.ToLongTimeString();
        }
    }

    class ToolStripDate : dateData {
        public ToolStripLabel dateLabel;
        public ToolStripLabel timeLabel;
        
        public ToolStripDate() : base() {
            dateLabel = new ToolStripLabel();
            timeLabel = new ToolStripLabel();
        }

        public void updateToolStrip() {
            updateDate();
            dateLabel.Text = date;
            timeLabel.Text = time;
        }
    }
}
