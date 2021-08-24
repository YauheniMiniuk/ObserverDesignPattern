using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ObserverDesignPattern.Models
{
    public interface IMessageNotifier
    {
        // Attach an order observer to the subject.
        void Attach(IMessageObserver observer);

        // Detach an order observer from the subject.
        void Detach(IMessageObserver observer);

        // Notify all order observers about an event.
        void Notify(Message message);
    }
    public interface IMessageServices : IMessageNotifier
    {
        void UpdateMessage(Message message);
    }
}
