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
        public ConsoleColor TextColor { get; set; }

        public ChatUser(string UserName, ConsoleColor TextColor) { 
        this.UserName = UserName;
        this.TextColor = TextColor;
        }
        public void ReceiveMessage(object obj, MessageEventArgs m)
        {
            if (!UserName.Equals(m.Sender, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"DEBUG: {UserName} received message from {m.Sender}");
                Console.ForegroundColor = TextColor;
                string message = $"[{m.Timestamp.ToString("hh:mm:ss")}] {m.Sender} says: {m.Message}";
                Console.WriteLine(message);
                Console.ResetColor();
                File.AppendAllText("chat.txt", message + Environment.NewLine);
            }
        }

    }
}
