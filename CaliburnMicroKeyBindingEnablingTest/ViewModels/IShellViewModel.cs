using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CaliburnMicroKeyBindingEnablingTest.ViewModels
{
    internal interface IShellViewModel
    {
        bool CanDoThing { get; }
        void DoThing();
        void ChangeEnabledForDoThing();
    }

    internal class ShellViewModel : Screen, IShellViewModel
    {
        private bool _canDoThing = true;

        public ShellViewModel()
        {

        }

        public bool CanDoThing
        {
            get => _canDoThing;
            private set => Set(ref _canDoThing, value);
        }

        public void DoThing()
        {
            MessageBox.Show("I did a thing!");
        }

        public void ChangeEnabledForDoThing()
        {
            CanDoThing = !CanDoThing;
        }
    }
}
