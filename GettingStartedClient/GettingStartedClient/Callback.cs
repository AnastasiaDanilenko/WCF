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

    public delegate void GotPrivateDelegate(string message);
    public delegate void GotMessDelegate(string message);
    public delegate void GotUserArrivedDelegate(string userName);
    public delegate void GotUpdDelegate(List<string> usersNames, List<string> roomNames);
    public delegate void GotRoomOpenedDelegate(string roomName);
    public delegate void GotUserDeleteDelegate(string name);
    public delegate void GotRDeleteDelegate(string name);

    [System.ServiceModel.CallbackBehavior(UseSynchronizationContext = false)]
    public class ClienChatCallbackHandler : IServiceChatCallback
    {
        public static RichTextBox text { get; private set; }

        public event GotPrivateDelegate GotPrivate;
        public event GotMessDelegate GotMess;
        public event GotUserArrivedDelegate GotUserArrived;
        public event GotUpdDelegate GotUpd;
        public event GotRoomOpenedDelegate GotRoomOpened;
        public event GotRDeleteDelegate GotRDelete;
        public event GotUserDeleteDelegate GotUserDelete;


        public void ConnectedToRoom(string room)
        {

        }
        public void NewUserArrived(string clients)
        {
            if (GotUserArrived != null)
                GotUserArrived(clients);

        }
        public void RoomRemoved(string room)
        {
            if (GotRDelete != null)
                GotRDelete(room);
        }

        public void Update(string[] users, string[] rooms)
        {
            if (GotUpd != null)
                GotUpd(users.ToList(), rooms.ToList());
        }

        public void NewRoomOpened(string room)
        {
            if (GotRoomOpened != null)
                GotRoomOpened(room);
        }

        public void NewMessage(string message)
        {
            if (GotMess != null)
                GotMess(message);
        }

        public void NewPrivateMessage(string message)
        {
            if (GotPrivate != null)
                GotPrivate(message);

        }
    }
}