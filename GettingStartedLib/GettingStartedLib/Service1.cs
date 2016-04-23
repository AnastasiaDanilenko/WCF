using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace GettingStartedLib
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде и файле конфигурации.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Reentrant)]
    public class ServiceChat : IServiceChat
    {
        List<User> user_list = new List<User>();
         List<Room> room_list = new List<Room>();
        List<IServiceChatCallback> connected_users = new List<IServiceChatCallback>();
        List<string> users = new List<string>();
        List<string> rooms = new List<string>();
        public User current_user = new User();
        public Room current_room = new Room();
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public IServiceChatCallback Callback
            {

             get
               {
                return OperationContext.Current.GetCallbackChannel<IServiceChatCallback>();
                }
           }
        public void SendPrivateMessage(string message, string reciever)
        {
            Console.WriteLine("Private message recieved: " + message + " to user " + reciever);
            foreach (User u in user_list)
            {
                if (u.Name == reciever)
                {
                    u.address.NewPrivateMessage(message);
                    break;
                }
            }
        }

       public  void QuitRoom(string room, string user)
        {
            foreach (Room r in room_list)
            {
                if (r.Name == room)
                {
                    foreach (User u in user_list)
                    {
                        if (u.Name == user)
                        {
                            r.Users.Remove(u);
                        }
                    }
                }
            }
            Callback.RoomRemoved(room);
           
        }

        public string CreateNewRoom(string name)
        {
            Room new_room = new Room();
            new_room.Name = name;
            new_room.Users = new List<User>();
            Console.WriteLine("New room: " + name);
            add_to_room_list(new_room);
            foreach (IServiceChatCallback ics in connected_users)
            {
                ics.NewRoomOpened(name);
            }
            UpdateUsers();
            return name;
        }
       public  void AddToSomeRoom(string room, string user)
        {
            foreach (Room r in room_list)
            {
                if (r.Name == room)
                {
                    foreach (User u in user_list)
                    {
                        if (u.Name == user)
                            r.Users.Add(u);
                    }

                }
            }
            
        }

        public void RemoveClient(string name)
        {
            foreach (User u in user_list)
            {
                if (u.Name == name)
                {
                    user_list.Remove(u);
                    connected_users.Remove(u.address);
                    break;
                }
            }
            users.Remove(name);
            Console.WriteLine("Users in chat: " + connected_users.Count().ToString());
            Callback.UserRemoved(name);
        }

       public void SendMessageToRoom(string room, string message)
        {
            Console.WriteLine("Message accepted: " + message);
            foreach (Room r in room_list)
            {
                if (r.Name == room)
                {
                    foreach(User u in r.Users)
                    {
                        u.address.NewMessage(message);
                    }
                }
            }
        }

       

        public string CreateNewUser(string user_name)
        {
            User new_user = new User();
            new_user.Name = user_name;
            new_user.address = Callback;
            new_user.Rooms = new List<string>();
            current_user = new_user;
            Console.WriteLine("New user: " + user_name);
            add_to_user_list(new_user);
            if (!connected_users.Contains(Callback))
            {
                connected_users.Add(Callback);
            }
            foreach (IServiceChatCallback ics in connected_users)
            {
                ics.NewUserArrived(user_name);
            }
            Console.WriteLine("Users in chat: " + connected_users.Count.ToString());
            UpdateUsers();
            return user_name;
        }

        public bool UpdateUsers()
        {
            foreach (IServiceChatCallback ics in connected_users)
            {
                Callback.Update(users, rooms);
            }
            return true;
        }

         public List<User> add_to_user_list(User new_user)
        {
            user_list.Add(new_user);
            users.Add(new_user.Name);
            return user_list;
        }

        private List<Room> add_to_room_list(Room new_room)
        {
            room_list.Add(new_room);
            rooms.Add(new_room.Name);
            return room_list;
        }
    }
}
