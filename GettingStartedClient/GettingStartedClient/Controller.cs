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

    public delegate void GotMessageDelegate(string room, string message);
    public delegate void GotPrivateMessageDelegate(string message, string user);
    public delegate void GotUserToAddDelegate(string userName);
    public delegate void GotUserToDeleteDelegate(string userName);
    public delegate void GotUpdateDelegate(List<string> usersNames);
    public delegate void GotRoomAddDelegate(string roomName);
    public delegate void GotRoomEnterDelegate(string roomName, string name);
    public delegate void GotRoomDeleteDelegate(string roomName, string user);
    class Listener
    {
        public event GotMessageDelegate GotMessageEvent;
        public event GotPrivateMessageDelegate GotPrivateMessageEvent;
        public event GotUserToAddDelegate GotUserToAddEvent;
        public event GotUserToDeleteDelegate GotUserToDeleteEvent;
        public event GotUpdateDelegate GotUpdateEvent;
        public event GotRoomAddDelegate GotRoomAddEvent;
        public event GotRoomEnterDelegate GotRoomEnterEvent;
        public event GotRoomDeleteDelegate GotRoomDeleteEvent;

        ServiceChatClient client = null;
        public List<string> users = new List<string>();
        public List<string> rooms = new List<string>();

        public void NewUserArrived(string name)
        {
            if (GotUserToAddEvent != null)
                GotUserToAddEvent(name);
        }

        public void DeleteUser(string name)
        {
            if (GotUserToDeleteEvent != null)
                GotUserToDeleteEvent(name);
        }

        public void Delete(string name)
        {
            client.RemoveClient(name);
        }

        public void NewRoom(string name)
        {
            if (GotRoomAddEvent != null)
                GotRoomAddEvent(name);
        }
        public void NewMessage(string room, string message)
        {
            if (GotMessageEvent != null)
                GotMessageEvent(room, message);
        }

        public void RoomEnter(string room, string name)
        {
            if (GotRoomEnterEvent != null)
                GotRoomEnterEvent(room, name);
        }

        public void NewPrivateMessage(string message, string user)
        {
            if (GotPrivateMessageEvent != null)
                GotPrivateMessageEvent(message, user);
        }

        private void RemoveClient(string name)
        {
            client.RemoveClient(name);
            var Message = MessageBox.Show("Вы отключились от чата. Больше вы не будете получть сообщения.");
        }

        public void Send_Private(string message, string user)
        {
            client.SendPrivateMessage(message, user);
        }

        public void AddNewUser(string name)
        {
            users.Add(client.CreateNewUser(name));    
        }
        public void EnterRoom(string room, string name)
        {
            client.AddToSomeRoom(room, name);
        }
        public void AddNewRoom(string name)
        {
            rooms.Add(client.CreateNewRoom(name));  
        }

        public void Quit_Room(string room, string user)
        {
            client.QuitRoom(room, user);
        }

        public void StartClient(Form1 form1)
        {
            ClienChatCallbackHandler callback = new ClienChatCallbackHandler(form1);
            InstanceContext instanseContext = new InstanceContext(callback);
            client = new ServiceChatClient(instanseContext);
        }

        public void send(string current_room, string message)
        {
            client.SendMessageToRoom(current_room, message);
        }

        public void Remove_Client(string name)
        {
            client.RemoveClient(name);
        }

    }

}
