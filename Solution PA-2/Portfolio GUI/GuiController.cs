using System;
using System.Collections.Generic;
using Class_Library;

namespace Portfolio_GUI
{
    internal class GuiController
    {
        private Account _account;
        private List<Observer> _observers;
        public GuiController(Account a)
        {
            this._account = a;
            _observers = new List<Observer>();
        }

        public void RegisterAccount(Observer o)
        {
            _observers.Add(o);
        }

        public void Handle(object sender, EventArgs e)
        {
            sender.ToString();
        }

        /// <summary>
        /// Signals the observers to update fields of the user interface
        /// </summary>
        private void SignalObservers()
        {
            foreach (var o in _observers)
            {
                o();
            }
        }
    }
}