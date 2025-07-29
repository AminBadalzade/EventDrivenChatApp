💬 Event-Driven Console Chat App
================================

A simple event-driven chat simulation in C# using delegates and events to broadcast messages between users — all from the console!

🚀 Features
-----------
- 📤 Event-based messaging: When one user sends a message, all others receive it via events.
- 👤 Multiple users: Supports custom usernames and dynamic user count.
- 🎨 Colored messages: Each user sees messages in their own unique console color.
- 📂 Message logging: All chat messages are saved to "chat.txt" with timestamps.
- 📡 Simulated broadcasting: Mimics real-time "typing..." and delivery feedback.
- 🧠 User filtering: Sender doesn’t receive their own message.

🛠️ Technologies Used
---------------------
- C# (.NET)
- Console Application
- EventHandler, Custom EventArgs
- File Handling (File.AppendAllText)
- ConsoleColor for visual enhancement

📸 Sample Output
----------------
How many users: 3  
Enter name for user 1: Amin  
Enter name for user 2: Elvin  
Enter name for user 3: Sara  

Who is sending the message? (type 'exit' to quit)  
Amin  
Enter message: Hello everyone!  
Amin is typing...  
DEBUG: Elvin received message from Amin  
[10:15:23] Amin says: Hello everyone!  
DEBUG: Sara received message from Amin  
[10:15:23] Amin says: Hello everyone!

Messages are also saved in "chat.txt":
[10:15:23] Amin says: Hello everyone!

🧪 How It Works
---------------
1. ChatServer raises a MessageReceived event.
2. ChatUser subscribes to the server and listens for events.
3. When a user sends a message:
   - All other users are notified.
   - Messages are displayed with timestamps and stored in a file.
   - Console colors help differentiate between users.
