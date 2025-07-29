using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDrivenChatApp
{
    public class ChatUser
    {
        public string UserName { get; set; }
        public void ReceiveMessage(object obj, MessageEventArgs m)
        {
            if (!UserName.Equals(m.Sender, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"DEBUG: {UserName} received message from {m.Sender}");
                string message = $"[{m.Timestamp.ToString("hh:mm:ss")}] {m.Sender} says: {m.Message}";
                Console.WriteLine(message);
                File.AppendAllText("chat.txt", message + Environment.NewLine);
            }
        }

    }
}
