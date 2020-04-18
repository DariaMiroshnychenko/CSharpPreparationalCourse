using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.Course
{
    public class MessageStorage
    {
        public delegate void AddingMessageEventHandler(Message message);
        public event AddingMessageEventHandler MessageIsAdded;

        public delegate void RemovingMessageEventHandler(Message message);
        public event RemovingMessageEventHandler MessageIsRemoved;

        public List<Message> Messages { get; set; }

        public MessageStorage()
        {
            Messages = new List<Message>();
        }

        public MessageStorage(List<Message> messages)
        {
            Messages = messages;
        }

        public void Add(Message message)
        {
            Messages.Add(message);
            OnMessageIsAdded(message);
        }

        public void Remove(Message message)
        {
            Messages.Remove(message);
            OnMessageIsRemoved(message);
        }

        public void OnMessageIsAdded(Message message)
        {
            InvokeMessageIsAdded(MessageIsAdded, message);
        }

        private void InvokeMessageIsAdded(AddingMessageEventHandler addingMessageHandler, Message message)
        {
            addingMessageHandler?.Invoke(message);
        }

        public void OnMessageIsRemoved(Message message)
        {
            InvokeMessageIsRemoved(MessageIsRemoved, message);
        }

        private void InvokeMessageIsRemoved(RemovingMessageEventHandler removingMessageHandler, Message message)
        {
            removingMessageHandler?.Invoke(message);
        }
    }
}
