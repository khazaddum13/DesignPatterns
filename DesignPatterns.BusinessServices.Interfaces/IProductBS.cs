using DesignPatterns.BusinessServices.Interfaces;
using System;

namespace DesignPatterns.BusinessServices
{
    public interface IProductBS
    {
        void Notify();

        void ChangeStock();

        void Attach(IObserver observer);

        void Detach(IObserver observer);
    }
}
