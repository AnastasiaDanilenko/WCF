using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Windows.Forms;
using GettingStartedClient.ServerChat;

namespace GettingStartedClient
{
    [System.ServiceModel.CallbackBehavior(UseSynchronizationContext = false)]
    public class ClienChatCallbackHandler : IServiceChatCallback
    {
        private Form1 mainform = null;
        public delegate void NewMS(string mes);
        public static RichTextBox text { get; private set; }
        public ClienChatCallbackHandler(Form1 Form1)
        {
            mainform = Form1;
            text = mainform.richTextBox_text;
        }

        public void ConnectedToRoom(string room)
        {
            mainform.current_room = room;
        }
        public void NewUserArrived(string clients)
        {

            mainform.users.Add(clients);
            string message = "\nК чату присоединился новый пользователь: " + clients;
            if (text.InvokeRequired)
            {
                text.BeginInvoke(new NewMS(NewMessage), message);
            }
            else
                text.AppendText("\n" + message);
        }
        public void RoomRemoved(string room)
        {
            mainform.current_room = "";
        }

        public void Update(string[] users, string[] rooms)
        {
            mainform.users = users.ToList();
            mainform.rooms = rooms.ToList();
        }

        public void NewRoomOpened(string room)
        {
            mainform.rooms.Add(room);
            string message = "\nОткрылась новая комната: " + room;
            if (text.InvokeRequired)
            {
                text.BeginInvoke(new NewMS(NewMessage), message);
            }
            else
                text.AppendText("\n" + message);
        }

        public void NewMessage(string message)
        {
            if (text.InvokeRequired)
            {
                text.BeginInvoke(new NewMS(NewMessage), message);
            }
            else
                text.AppendText("\n" + message);
        }

        public void NewPrivateMessage(string message)
        {
            if (text.InvokeRequired)
            {
                text.BeginInvoke(new NewMS(NewPrivateMessage), message);
            }
            else
                text.AppendText("\nПринято приватное сообщение от пользователя " + message);
        }
    }
}
