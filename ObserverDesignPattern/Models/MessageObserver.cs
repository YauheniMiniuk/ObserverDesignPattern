using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ObserverDesignPattern.Models
{
    public interface IMessageObserver
    {
        void Update(Message message);
    }
    public class MessageObserver : IMessageObserver
    {
        public void Update(Message message)
        {
            Console.WriteLine($"New message: {message.MessageText}, Time: {message.DateTime}");
        }
    }
}
