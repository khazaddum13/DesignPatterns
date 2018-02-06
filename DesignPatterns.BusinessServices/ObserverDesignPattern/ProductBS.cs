using DesignPatterns.BusinessServices.Interfaces;
using System.Collections.Generic;

namespace DesignPatterns.BusinessServices
{
    public class ProductBS : IProductBS, IObserver
    {
        #region Property

        private List<IObserver> m_Observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            m_Observers.Add(observer);
        }

        #endregion

        public void ChangeStock()
        {
            this.Notify();
        }

        public void Detach(IObserver observer)
        {
            m_Observers.Remove(observer);
        }

        public void Notify()
        {
            m_Observers.ForEach(o => o.Update());
        }

        public string Update()
        {
            return "Stock changed!";
        }
    }
}
