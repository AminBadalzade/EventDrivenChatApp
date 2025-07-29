using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDrivenChatApp
{
    public class MessageEventArgs : EventArgs
    {
        public string Sender { get; set; }
        public string Message { get; set; }
        public DateTime Timestamp { get; set; }

        public MessageEventArgs(string sender, string message)
        {
            Sender = sender;
            Message = message;
            Timestamp = DateTime.Now;
        }
    }

    public class ChatServer
    {
        public event EventHandler<MessageEventArgs> MessageReceived;
        
        public void Broadcast(string senderName, string message)
        {
            Console.WriteLine($"{senderName} is typing...");
            Thread.Sleep(1000);
            MessageReceived?.Invoke(this, new MessageEventArgs(senderName, message));
        }
    
    }
}
