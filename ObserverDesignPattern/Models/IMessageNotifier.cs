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
    public interface IMessageService : IMessageNotifier
    {
        void UpdateMessage(Message message);
    }
    public class MessageService : IMessageService
    {
        public List<IMessageObserver> Observers = new List<IMessageObserver>
        {
            new MessageObserver()
        };
        public void UpdateMessage(Message message)
        {
            Notify(message);
        }
        public void Attach(IMessageObserver observer)
        {
            Observers.Add(observer);
        }
        public void Detach(IMessageObserver observer)
        {
            Observers.Remove(observer);
        }
        public void Notify(Message message)
        {
            foreach (var obs in Observers)
            {
                obs.Update(message);
            }
        }
    }
}
