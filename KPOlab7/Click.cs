using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KPOlab7
{
    class Click : IObservable
    {
        CheckBox checkbox;
        CkickActive sInfo;
        List<IObserver> observers;
        public Click(CheckBox checkbox)
        {
            this.checkbox = checkbox;
            observers = new List<IObserver>();
            sInfo = new CkickActive();
        }
        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }

        public void NotifyObservers()
        {
            foreach (IObserver o in observers)
            {
                o.Update(sInfo);
            }
        }

        public void CheckClick()
        {
            sInfo.active = checkbox.Checked;
            NotifyObservers();
        }
    }
}
