using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_15.Classes
{
    class NameWorker
    {
        public void randomName() {
            if (Form1.nodeList != null) {
                MessageBox.Show(Form1.nodeList[new Random().Next(0, Form1.nodeList.Size())].Name, "Information"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }

    class NumberWorker
    {
        public void randomNumber() {
            if (Form1.nodeList != null) {
                MessageBox.Show(Form1.nodeList[new Random().Next(0, Form1.nodeList.Size())].Number.ToString(), "Information"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }

    class Facade
    {
        NameWorker name;
        NumberWorker number;

        public Facade(NameWorker name, NumberWorker number) {
            this.name = name;
            this.number = number;
        }

        public void randomObject() {
            name.randomName();
            number.randomNumber();
        }

        public void randomName() {
            name.randomName();
        }

        public void randomNumber() {
            number.randomNumber();
        }
    }
}
