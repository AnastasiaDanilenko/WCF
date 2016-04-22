﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GettingStartedClient.ServerChat {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServerChat.IServiceChat", CallbackContract=typeof(GettingStartedClient.ServerChat.IServiceChatCallback), SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface IServiceChat {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceChat/GetData", ReplyAction="http://tempuri.org/IServiceChat/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceChat/GetData", ReplyAction="http://tempuri.org/IServiceChat/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceChat/SendPrivateMessage", ReplyAction="http://tempuri.org/IServiceChat/SendPrivateMessageResponse")]
        void SendPrivateMessage(string message, string reciever);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceChat/SendPrivateMessage", ReplyAction="http://tempuri.org/IServiceChat/SendPrivateMessageResponse")]
        System.Threading.Tasks.Task SendPrivateMessageAsync(string message, string reciever);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceChat/CreateNewRoom", ReplyAction="http://tempuri.org/IServiceChat/CreateNewRoomResponse")]
        string CreateNewRoom(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceChat/CreateNewRoom", ReplyAction="http://tempuri.org/IServiceChat/CreateNewRoomResponse")]
        System.Threading.Tasks.Task<string> CreateNewRoomAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceChat/RemoveClient", ReplyAction="http://tempuri.org/IServiceChat/RemoveClientResponse")]
        void RemoveClient(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceChat/RemoveClient", ReplyAction="http://tempuri.org/IServiceChat/RemoveClientResponse")]
        System.Threading.Tasks.Task RemoveClientAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceChat/AddToSomeRoom", ReplyAction="http://tempuri.org/IServiceChat/AddToSomeRoomResponse")]
        void AddToSomeRoom(string room, string user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceChat/AddToSomeRoom", ReplyAction="http://tempuri.org/IServiceChat/AddToSomeRoomResponse")]
        System.Threading.Tasks.Task AddToSomeRoomAsync(string room, string user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceChat/QuitRoom", ReplyAction="http://tempuri.org/IServiceChat/QuitRoomResponse")]
        void QuitRoom(string room, string user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceChat/QuitRoom", ReplyAction="http://tempuri.org/IServiceChat/QuitRoomResponse")]
        System.Threading.Tasks.Task QuitRoomAsync(string room, string user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceChat/SendMessageToRoom", ReplyAction="http://tempuri.org/IServiceChat/SendMessageToRoomResponse")]
        void SendMessageToRoom(string room, string message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceChat/SendMessageToRoom", ReplyAction="http://tempuri.org/IServiceChat/SendMessageToRoomResponse")]
        System.Threading.Tasks.Task SendMessageToRoomAsync(string room, string message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceChat/CreateNewUser", ReplyAction="http://tempuri.org/IServiceChat/CreateNewUserResponse")]
        string CreateNewUser(string user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceChat/CreateNewUser", ReplyAction="http://tempuri.org/IServiceChat/CreateNewUserResponse")]
        System.Threading.Tasks.Task<string> CreateNewUserAsync(string user);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChatCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServiceChat/NewUserArrived")]
        void NewUserArrived(string user);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServiceChat/NewRoomOpened")]
        void NewRoomOpened(string room);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServiceChat/ConnectedToRoom")]
        void ConnectedToRoom(string room);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServiceChat/NewMessage")]
        void NewMessage(string message);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServiceChat/NewPrivateMessage")]
        void NewPrivateMessage(string message);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServiceChat/Update")]
        void Update(string[] users, string[] rooms);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceChat/RoomRemoved", ReplyAction="http://tempuri.org/IServiceChat/RoomRemovedResponse")]
        void RoomRemoved(string room);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChatChannel : GettingStartedClient.ServerChat.IServiceChat, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceChatClient : System.ServiceModel.DuplexClientBase<GettingStartedClient.ServerChat.IServiceChat>, GettingStartedClient.ServerChat.IServiceChat {
        
        public ServiceChatClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public ServiceChatClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public ServiceChatClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceChatClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceChatClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public void SendPrivateMessage(string message, string reciever) {
            base.Channel.SendPrivateMessage(message, reciever);
        }
        
        public System.Threading.Tasks.Task SendPrivateMessageAsync(string message, string reciever) {
            return base.Channel.SendPrivateMessageAsync(message, reciever);
        }
        
        public string CreateNewRoom(string name) {
            return base.Channel.CreateNewRoom(name);
        }
        
        public System.Threading.Tasks.Task<string> CreateNewRoomAsync(string name) {
            return base.Channel.CreateNewRoomAsync(name);
        }
        
        public void RemoveClient(string name) {
            base.Channel.RemoveClient(name);
        }
        
        public System.Threading.Tasks.Task RemoveClientAsync(string name) {
            return base.Channel.RemoveClientAsync(name);
        }
        
        public void AddToSomeRoom(string room, string user) {
            base.Channel.AddToSomeRoom(room, user);
        }
        
        public System.Threading.Tasks.Task AddToSomeRoomAsync(string room, string user) {
            return base.Channel.AddToSomeRoomAsync(room, user);
        }
        
        public void QuitRoom(string room, string user) {
            base.Channel.QuitRoom(room, user);
        }
        
        public System.Threading.Tasks.Task QuitRoomAsync(string room, string user) {
            return base.Channel.QuitRoomAsync(room, user);
        }
        
        public void SendMessageToRoom(string room, string message) {
            base.Channel.SendMessageToRoom(room, message);
        }
        
        public System.Threading.Tasks.Task SendMessageToRoomAsync(string room, string message) {
            return base.Channel.SendMessageToRoomAsync(room, message);
        }
        
        public string CreateNewUser(string user) {
            return base.Channel.CreateNewUser(user);
        }
        
        public System.Threading.Tasks.Task<string> CreateNewUserAsync(string user) {
            return base.Channel.CreateNewUserAsync(user);
        }
    }
}
