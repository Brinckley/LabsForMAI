using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_14.Classes
{
    interface ICommand //Command
    {
        void Execute();
        void Undo();
    }

    class ScreenSwitcher //Receiver
    {
        public void On() {
            Lab_14.screenWorking = true;
        }

        public void Off() {
            Lab_14.screenWorking = false;
        }
    }

    class ScreenCommand : ICommand
    {
        ScreenSwitcher screen;
        public ScreenCommand(ScreenSwitcher screen) { this.screen = screen; }

        public void Execute()
        {
            screen.On();
        }

        public void Undo()
        {
            screen.Off();
        }
    }

    class Switcher // Invoker
    {
        ICommand command;

        public Switcher(ICommand command) { this.command = command; }

        public void buttonOn() {
            command.Execute();
        }

        public void buttonOff() {
            command.Execute();
        }

    }

}
