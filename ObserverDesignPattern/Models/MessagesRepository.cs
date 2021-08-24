using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ObserverDesignPattern.Models
{
    public interface IMessages
    {
        IEnumerable<Message> Messages { get; }
        Message AddMessage(Message msg);
    }
    public class MemoryMessages : IMessages
    {
        private List<Message> messages = new List<Message>();
        public IEnumerable<Message> Messages => messages;
        public Message AddMessage(Message msg)
        {
            messages.Add(msg);
            return msg;
        }
    }
}
