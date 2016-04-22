using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace GettingStartedLib
{
    [ServiceContract]
    public interface IServiceChatCallback
    {

        [OperationContract(IsOneWay = true)]
        void NewUserArrived(string user);

        [OperationContract(IsOneWay = true)]
        void NewRoomOpened(string room);
        [OperationContract(IsOneWay = true)]
        void ConnectedToRoom(string room);

        [OperationContract(IsOneWay = true)]
        void NewMessage(string message);

        [OperationContract(IsOneWay = true)]
        void NewPrivateMessage(string message);

        [OperationContract(IsOneWay = true)]
        void Update(List<string> users, List<string> rooms);

        [OperationContract]
        void RoomRemoved(string room);
    }

    [ServiceContract(SessionMode = SessionMode.Required, CallbackContract = typeof(IServiceChatCallback))]
    public interface IServiceChat
    {
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        void SendPrivateMessage(string message, string reciever);

        [OperationContract]
        string  CreateNewRoom(string name);

        [OperationContract]
        void RemoveClient(string name);

        [OperationContract]
        void AddToSomeRoom(string room, string user);

        [OperationContract]
        void QuitRoom(string room, string user);

        [OperationContract]
        void SendMessageToRoom(string room, string message);

        [OperationContract]
        string CreateNewUser( string user);
    }
    [DataContract]
    public class User
    {
        [DataMember]
        public List<string> Rooms { get; set; }

        [DataMember]
        public IServiceChatCallback address { get; set; }

        [DataMember]
        public string Name { get; set; }
    }




    [DataContract]
    public class Room
    {


        List<User> users = new List<User>();
        string name = "";
        [DataMember]
        public List<User> Users
        {
            get { return users; }
            set { users = value; }
        }
        [DataMember]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
