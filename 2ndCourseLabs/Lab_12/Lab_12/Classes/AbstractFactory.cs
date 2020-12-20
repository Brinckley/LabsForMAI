using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_12.Classes
{//Factory Pattern
    abstract class AbstractFactory
    {
        public abstract StatusInfo createDateStatus();
        public abstract StatusInfo createTimeStatus();
    }

    class statusFactory : AbstractFactory
    {

        public override StatusInfo createDateStatus()
        {
            return new StatusStripDate();
        }

        public override StatusInfo createTimeStatus()
        {
            return new StatusStripTime();
        }
    }

    abstract class StatusInfo { 
        protected ToolStripLabel data;
        public abstract ToolStripLabel getData();
        public abstract void updateData();
    }

    class StatusStripDate : StatusInfo 
    {
        public override ToolStripLabel getData()
        {
            return data = new ToolStripLabel();
        }

        public override void updateData()
        {
            data.Text = DateTime.Now.ToLongDateString();
        }
    }

    class StatusStripTime : StatusInfo 
    {
        public override ToolStripLabel getData()
        {
            return data = new ToolStripLabel(); 
        }

        public override void updateData()
        {
            data.Text = DateTime.Now.ToLongTimeString();
        }
    }

    class StatusLabelInfo {
        private StatusInfo date;
        private StatusInfo time;

        public StatusLabelInfo(AbstractFactory abstractFactory) {
            date = abstractFactory.createDateStatus();
            time = abstractFactory.createTimeStatus();
        }

        public ToolStripLabel getDate() {
            return date.getData();
        }

        public ToolStripLabel getTime() {
            return time.getData();
        }

        public void updateDate()
        {
            date.updateData();
            time.updateData();
        }
    }

}
