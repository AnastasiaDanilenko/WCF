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
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Room", Namespace="http://schemas.datacontract.org/2004/07/GettingStartedLib")]
    [System.SerializableAttribute()]
    public partial class Room : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private GettingStartedClient.ServerChat.User[] UsersField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private GettingStartedClient.ServerChat.Room current_roomField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GettingStartedClient.ServerChat.User[] Users {
            get {
                return this.UsersField;
            }
            set {
                if ((object.ReferenceEquals(this.UsersField, value) != true)) {
                    this.UsersField = value;
                    this.RaisePropertyChanged("Users");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GettingStartedClient.ServerChat.Room current_room {
            get {
                return this.current_roomField;
            }
            set {
                if ((object.ReferenceEquals(this.current_roomField, value) != true)) {
                    this.current_roomField = value;
                    this.RaisePropertyChanged("current_room");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/GettingStartedLib")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string[] RoomsField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] Rooms {
            get {
                return this.RoomsField;
            }
            set {
                if ((object.ReferenceEquals(this.RoomsField, value) != true)) {
                    this.RoomsField = value;
                    this.RaisePropertyChanged("Rooms");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServerChat.IServiceChat", CallbackContract=typeof(GettingStartedClient.ServerChat.IServiceChatCallback), SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface IServiceChat {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceChat/GetData", ReplyAction="http://tempuri.org/IServiceChat/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceChat/GetData", ReplyAction="http://tempuri.org/IServiceChat/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceChat/SendPrivateMessage", ReplyAction="http://tempuri.org/IServiceChat/SendPrivateMessageResponse")]
        string SendPrivateMessage(string message, string reciever);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceChat/SendPrivateMessage", ReplyAction="http://tempuri.org/IServiceChat/SendPrivateMessageResponse")]
        System.Threading.Tasks.Task<string> SendPrivateMessageAsync(string message, string reciever);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceChat/CreateNewRoom", ReplyAction="http://tempuri.org/IServiceChat/CreateNewRoomResponse")]
        GettingStartedClient.ServerChat.Room CreateNewRoom(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceChat/CreateNewRoom", ReplyAction="http://tempuri.org/IServiceChat/CreateNewRoomResponse")]
        System.Threading.Tasks.Task<GettingStartedClient.ServerChat.Room> CreateNewRoomAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceChat/AddToSomeRoom", ReplyAction="http://tempuri.org/IServiceChat/AddToSomeRoomResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(GettingStartedClient.ServerChat.Room))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(GettingStartedClient.ServerChat.User[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(GettingStartedClient.ServerChat.User))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(string[]))]
        bool AddToSomeRoom(object some_user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceChat/AddToSomeRoom", ReplyAction="http://tempuri.org/IServiceChat/AddToSomeRoomResponse")]
        System.Threading.Tasks.Task<bool> AddToSomeRoomAsync(object some_user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceChat/SendMessageToRoom", ReplyAction="http://tempuri.org/IServiceChat/SendMessageToRoomResponse")]
        string SendMessageToRoom(string message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceChat/SendMessageToRoom", ReplyAction="http://tempuri.org/IServiceChat/SendMessageToRoomResponse")]
        System.Threading.Tasks.Task<string> SendMessageToRoomAsync(string message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceChat/CheckRoom", ReplyAction="http://tempuri.org/IServiceChat/CheckRoomResponse")]
        string[] CheckRoom();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceChat/CheckRoom", ReplyAction="http://tempuri.org/IServiceChat/CheckRoomResponse")]
        System.Threading.Tasks.Task<string[]> CheckRoomAsync();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServiceChat/CreateNewUser")]
        void CreateNewUser(string user_name);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServiceChat/CreateNewUser")]
        System.Threading.Tasks.Task CreateNewUserAsync(string user_name);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChatCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServiceChat/NewUserArrived")]
        void NewUserArrived(string user);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServiceChat/NewRoomOpened")]
        void NewRoomOpened(string room);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServiceChat/NewMessage")]
        void NewMessage(string message);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServiceChat/NewPrivateMessage")]
        void NewPrivateMessage(string message, string user_name);
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
        
        public string SendPrivateMessage(string message, string reciever) {
            return base.Channel.SendPrivateMessage(message, reciever);
        }
        
        public System.Threading.Tasks.Task<string> SendPrivateMessageAsync(string message, string reciever) {
            return base.Channel.SendPrivateMessageAsync(message, reciever);
        }
        
        public GettingStartedClient.ServerChat.Room CreateNewRoom(string name) {
            return base.Channel.CreateNewRoom(name);
        }
        
        public System.Threading.Tasks.Task<GettingStartedClient.ServerChat.Room> CreateNewRoomAsync(string name) {
            return base.Channel.CreateNewRoomAsync(name);
        }
        
        public bool AddToSomeRoom(object some_user) {
            return base.Channel.AddToSomeRoom(some_user);
        }
        
        public System.Threading.Tasks.Task<bool> AddToSomeRoomAsync(object some_user) {
            return base.Channel.AddToSomeRoomAsync(some_user);
        }
        
        public string SendMessageToRoom(string message) {
            return base.Channel.SendMessageToRoom(message);
        }
        
        public System.Threading.Tasks.Task<string> SendMessageToRoomAsync(string message) {
            return base.Channel.SendMessageToRoomAsync(message);
        }
        
        public string[] CheckRoom() {
            return base.Channel.CheckRoom();
        }
        
        public System.Threading.Tasks.Task<string[]> CheckRoomAsync() {
            return base.Channel.CheckRoomAsync();
        }
        
        public void CreateNewUser(string user_name) {
            base.Channel.CreateNewUser(user_name);
        }
        
        public System.Threading.Tasks.Task CreateNewUserAsync(string user_name) {
            return base.Channel.CreateNewUserAsync(user_name);
        }
    }
}
