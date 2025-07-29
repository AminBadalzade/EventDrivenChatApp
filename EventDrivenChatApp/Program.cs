using System;

namespace EventDrivenChatApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many users: ");
            int userCount = int.Parse(Console.ReadLine());

            List<ChatUser> users= new List<ChatUser>();

            var colors = new[] {ConsoleColor.Cyan, ConsoleColor.Yellow, ConsoleColor.Green,
            ConsoleColor.Magenta, ConsoleColor.Blue, ConsoleColor.White};

            for (int i = 0; i < userCount; i++) {
                Console.Write($"Enter name for user {i+1}: ");
                string name = Console.ReadLine();
                ConsoleColor textColor = colors[i % colors.Length];
                var user = new ChatUser(name, textColor);
                users.Add(user);
            }

            var server = new ChatServer();
            foreach(var user in users)
            {
                server.MessageReceived += user.ReceiveMessage;
            }

            bool isTrue = false;
            while (!isTrue)
            {
                Console.WriteLine("\nWho is sending the message?(type 'exit' to quit)");
                string sender = Console.ReadLine();

                if (sender == "exit") break;

                if (users.Any(x => x.UserName.ToLower() == sender.ToLower()))
                {
                    Console.Write("Enter message: ");
                    string message = Console.ReadLine();
                    server.Broadcast(sender, message);
                }
                else
                {
                    Console.WriteLine("We don't have a such user. Try again");
                }
            }
        }
    }
}