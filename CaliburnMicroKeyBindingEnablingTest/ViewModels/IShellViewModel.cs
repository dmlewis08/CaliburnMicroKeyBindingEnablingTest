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
        Task DoAsyncThingAsync();
        bool CanDoAsyncThing { get; }
        void DoSecondThing();
        void ChangeEnabledForDoAsyncThing();
        void ChangeEnabledForDoSecondThing();

        bool CanDoSecondThing { get; }

        Task DoSecondAsyncThingAsync();
        bool CanDoSecondAsyncThing { get; }
        void ChangeEnabledForDoSecondAsyncThing();
    }

    internal class ShellViewModel : Screen, IShellViewModel
    {
        private bool _canDoThing = true, _canDoAsyncThing = true, _canDoSecondThing = true, _canDoSecondAsyncThing = true;

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

        public async Task DoAsyncThingAsync()
        {
            await Task.Run(() => MessageBox.Show("I did an async thing!"));
        }

        public bool CanDoAsyncThing
        {
            get => _canDoAsyncThing;
            private set => Set(ref _canDoAsyncThing, value);
        }

        public void ChangeEnabledForDoAsyncThing()
        {
            CanDoAsyncThing = !CanDoAsyncThing;
        }

        public void DoSecondThing()
        {
            MessageBox.Show("I did a second thing!");
        }

        public bool CanDoSecondThing
        {
            get => _canDoSecondThing;
            private set => Set(ref _canDoSecondThing, value);
        }

        public void ChangeEnabledForDoSecondThing()
        {
            CanDoSecondThing = !CanDoSecondThing;
        }

        public async Task DoSecondAsyncThingAsync()
        {
            await Task.Run(() => MessageBox.Show("I did a second async thing!"));
        }

        public bool CanDoSecondAsyncThing
        {
            get => _canDoSecondAsyncThing;
            private set => Set(ref _canDoSecondAsyncThing, value);
        }

        public void ChangeEnabledForDoSecondAsyncThing()
        {
            CanDoSecondAsyncThing = !CanDoSecondAsyncThing;
        }
    }
}
