﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientTest.WcfService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Player", Namespace="http://schemas.datacontract.org/2004/07/LeagueGoServer.Model")]
    [System.SerializableAttribute()]
    public partial class Player : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ClientTest.WcfService.ClientInfo ClientField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ColorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ClientTest.WcfService.PlayerType TypeField;
        
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
        public ClientTest.WcfService.ClientInfo Client {
            get {
                return this.ClientField;
            }
            set {
                if ((object.ReferenceEquals(this.ClientField, value) != true)) {
                    this.ClientField = value;
                    this.RaisePropertyChanged("Client");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Color {
            get {
                return this.ColorField;
            }
            set {
                if ((this.ColorField.Equals(value) != true)) {
                    this.ColorField = value;
                    this.RaisePropertyChanged("Color");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
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
        public ClientTest.WcfService.PlayerType Type {
            get {
                return this.TypeField;
            }
            set {
                if ((this.TypeField.Equals(value) != true)) {
                    this.TypeField = value;
                    this.RaisePropertyChanged("Type");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ClientInfo", Namespace="http://schemas.datacontract.org/2004/07/LeagueGoServer.Model")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ClientTest.WcfService.Player[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ClientTest.WcfService.Player))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ClientTest.WcfService.ClientState))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ClientTest.WcfService.PlayerType))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ClientTest.WcfService.GameSetting))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ClientTest.WcfService.Game))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ClientTest.WcfService.MovePoint[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ClientTest.WcfService.MovePoint))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ClientTest.WcfService.GameState))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ClientTest.WcfService.Game[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(int[]))]
    public partial class ClientInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private object ClientCallbackField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private object ClientChannelField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime HeartbeatTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ClientTest.WcfService.ClientState PlayingStateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SessionIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
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
        public object ClientCallback {
            get {
                return this.ClientCallbackField;
            }
            set {
                if ((object.ReferenceEquals(this.ClientCallbackField, value) != true)) {
                    this.ClientCallbackField = value;
                    this.RaisePropertyChanged("ClientCallback");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public object ClientChannel {
            get {
                return this.ClientChannelField;
            }
            set {
                if ((object.ReferenceEquals(this.ClientChannelField, value) != true)) {
                    this.ClientChannelField = value;
                    this.RaisePropertyChanged("ClientChannel");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime HeartbeatTime {
            get {
                return this.HeartbeatTimeField;
            }
            set {
                if ((this.HeartbeatTimeField.Equals(value) != true)) {
                    this.HeartbeatTimeField = value;
                    this.RaisePropertyChanged("HeartbeatTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ClientTest.WcfService.ClientState PlayingState {
            get {
                return this.PlayingStateField;
            }
            set {
                if ((this.PlayingStateField.Equals(value) != true)) {
                    this.PlayingStateField = value;
                    this.RaisePropertyChanged("PlayingState");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SessionID {
            get {
                return this.SessionIDField;
            }
            set {
                if ((object.ReferenceEquals(this.SessionIDField, value) != true)) {
                    this.SessionIDField = value;
                    this.RaisePropertyChanged("SessionID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PlayerType", Namespace="http://schemas.datacontract.org/2004/07/LeagueGoServer.Model")]
    public enum PlayerType : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        AI = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        RealBoard = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Host = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Internet = 3,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ClientState", Namespace="http://schemas.datacontract.org/2004/07/LeagueGoServer.Model")]
    public enum ClientState : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Idel = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Waiting = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Playing = 2,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GameSetting", Namespace="http://schemas.datacontract.org/2004/07/LeagueGoServer.Model")]
    [System.SerializableAttribute()]
    public partial class GameSetting : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int BoardSizeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int HandicapField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int KomiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TimeSettingField;
        
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
        public int BoardSize {
            get {
                return this.BoardSizeField;
            }
            set {
                if ((this.BoardSizeField.Equals(value) != true)) {
                    this.BoardSizeField = value;
                    this.RaisePropertyChanged("BoardSize");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Handicap {
            get {
                return this.HandicapField;
            }
            set {
                if ((this.HandicapField.Equals(value) != true)) {
                    this.HandicapField = value;
                    this.RaisePropertyChanged("Handicap");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Komi {
            get {
                return this.KomiField;
            }
            set {
                if ((this.KomiField.Equals(value) != true)) {
                    this.KomiField = value;
                    this.RaisePropertyChanged("Komi");
                }
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
        public int TimeSetting {
            get {
                return this.TimeSettingField;
            }
            set {
                if ((this.TimeSettingField.Equals(value) != true)) {
                    this.TimeSettingField = value;
                    this.RaisePropertyChanged("TimeSetting");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Game", Namespace="http://schemas.datacontract.org/2004/07/LeagueGoServer.Model")]
    [System.SerializableAttribute()]
    public partial class Game : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int[] BoardStateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ClientTest.WcfService.Player CurrentPlayerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GameIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ClientTest.WcfService.GameSetting GameSettingField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ClientTest.WcfService.MovePoint[] MoveHistoryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ClientTest.WcfService.Player[] PlayersField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ClientTest.WcfService.GameState StateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int StepNumField;
        
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
        public int[] BoardState {
            get {
                return this.BoardStateField;
            }
            set {
                if ((object.ReferenceEquals(this.BoardStateField, value) != true)) {
                    this.BoardStateField = value;
                    this.RaisePropertyChanged("BoardState");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ClientTest.WcfService.Player CurrentPlayer {
            get {
                return this.CurrentPlayerField;
            }
            set {
                if ((object.ReferenceEquals(this.CurrentPlayerField, value) != true)) {
                    this.CurrentPlayerField = value;
                    this.RaisePropertyChanged("CurrentPlayer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string GameID {
            get {
                return this.GameIDField;
            }
            set {
                if ((object.ReferenceEquals(this.GameIDField, value) != true)) {
                    this.GameIDField = value;
                    this.RaisePropertyChanged("GameID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ClientTest.WcfService.GameSetting GameSetting {
            get {
                return this.GameSettingField;
            }
            set {
                if ((object.ReferenceEquals(this.GameSettingField, value) != true)) {
                    this.GameSettingField = value;
                    this.RaisePropertyChanged("GameSetting");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ClientTest.WcfService.MovePoint[] MoveHistory {
            get {
                return this.MoveHistoryField;
            }
            set {
                if ((object.ReferenceEquals(this.MoveHistoryField, value) != true)) {
                    this.MoveHistoryField = value;
                    this.RaisePropertyChanged("MoveHistory");
                }
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
        public ClientTest.WcfService.Player[] Players {
            get {
                return this.PlayersField;
            }
            set {
                if ((object.ReferenceEquals(this.PlayersField, value) != true)) {
                    this.PlayersField = value;
                    this.RaisePropertyChanged("Players");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ClientTest.WcfService.GameState State {
            get {
                return this.StateField;
            }
            set {
                if ((this.StateField.Equals(value) != true)) {
                    this.StateField = value;
                    this.RaisePropertyChanged("State");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int StepNum {
            get {
                return this.StepNumField;
            }
            set {
                if ((this.StepNumField.Equals(value) != true)) {
                    this.StepNumField = value;
                    this.RaisePropertyChanged("StepNum");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="MovePoint", Namespace="http://schemas.datacontract.org/2004/07/LeagueGoServer.Model")]
    [System.SerializableAttribute()]
    public partial class MovePoint : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int XField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int YField;
        
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
        public int X {
            get {
                return this.XField;
            }
            set {
                if ((this.XField.Equals(value) != true)) {
                    this.XField = value;
                    this.RaisePropertyChanged("X");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Y {
            get {
                return this.YField;
            }
            set {
                if ((this.YField.Equals(value) != true)) {
                    this.YField = value;
                    this.RaisePropertyChanged("Y");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GameState", Namespace="http://schemas.datacontract.org/2004/07/LeagueGoServer.Model")]
    public enum GameState : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Waiting = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Playing = 1,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WcfService.IWcfService", CallbackContract=typeof(ClientTest.WcfService.IWcfServiceCallback), SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface IWcfService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfService/Login", ReplyAction="http://tempuri.org/IWcfService/LoginResponse")]
        int Login(string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfService/Login", ReplyAction="http://tempuri.org/IWcfService/LoginResponse")]
        System.Threading.Tasks.Task<int> LoginAsync(string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfService/CreateGame", ReplyAction="http://tempuri.org/IWcfService/CreateGameResponse")]
        void CreateGame(ClientTest.WcfService.Player[] players, ClientTest.WcfService.GameSetting gameSettign);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfService/CreateGame", ReplyAction="http://tempuri.org/IWcfService/CreateGameResponse")]
        System.Threading.Tasks.Task CreateGameAsync(ClientTest.WcfService.Player[] players, ClientTest.WcfService.GameSetting gameSettign);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfService/ApplyToJoinGame", ReplyAction="http://tempuri.org/IWcfService/ApplyToJoinGameResponse")]
        void ApplyToJoinGame(string gameID, int playerID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfService/ApplyToJoinGame", ReplyAction="http://tempuri.org/IWcfService/ApplyToJoinGameResponse")]
        System.Threading.Tasks.Task ApplyToJoinGameAsync(string gameID, int playerID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfService/GameStart", ReplyAction="http://tempuri.org/IWcfService/GameStartResponse")]
        void GameStart();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfService/GameStart", ReplyAction="http://tempuri.org/IWcfService/GameStartResponse")]
        System.Threading.Tasks.Task GameStartAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfService/ClientCommitMove", ReplyAction="http://tempuri.org/IWcfService/ClientCommitMoveResponse")]
        void ClientCommitMove(int stepNum, int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWcfService/ClientCommitMove", ReplyAction="http://tempuri.org/IWcfService/ClientCommitMoveResponse")]
        System.Threading.Tasks.Task ClientCommitMoveAsync(int stepNum, int x, int y);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWcfServiceCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IWcfService/DistributeNewGame")]
        void DistributeNewGame(ClientTest.WcfService.Game game);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IWcfService/DistributeAllGameInfo")]
        void DistributeAllGameInfo(ClientTest.WcfService.Game[] game);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IWcfService/DistributeApplyGameResult")]
        void DistributeApplyGameResult(bool success, ClientTest.WcfService.Game game);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IWcfService/DistributeGameStart")]
        void DistributeGameStart(int[] blackPlayerIDs, int[] whitePlayerIDs, int currentPlayerID);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IWcfService/DistributeMove")]
        void DistributeMove(int stepNum, int x, int y, int nextPlayerID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWcfServiceChannel : ClientTest.WcfService.IWcfService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WcfServiceClient : System.ServiceModel.DuplexClientBase<ClientTest.WcfService.IWcfService>, ClientTest.WcfService.IWcfService {
        
        public WcfServiceClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public WcfServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public WcfServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public WcfServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public WcfServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public int Login(string userName) {
            return base.Channel.Login(userName);
        }
        
        public System.Threading.Tasks.Task<int> LoginAsync(string userName) {
            return base.Channel.LoginAsync(userName);
        }
        
        public void CreateGame(ClientTest.WcfService.Player[] players, ClientTest.WcfService.GameSetting gameSettign) {
            base.Channel.CreateGame(players, gameSettign);
        }
        
        public System.Threading.Tasks.Task CreateGameAsync(ClientTest.WcfService.Player[] players, ClientTest.WcfService.GameSetting gameSettign) {
            return base.Channel.CreateGameAsync(players, gameSettign);
        }
        
        public void ApplyToJoinGame(string gameID, int playerID) {
            base.Channel.ApplyToJoinGame(gameID, playerID);
        }
        
        public System.Threading.Tasks.Task ApplyToJoinGameAsync(string gameID, int playerID) {
            return base.Channel.ApplyToJoinGameAsync(gameID, playerID);
        }
        
        public void GameStart() {
            base.Channel.GameStart();
        }
        
        public System.Threading.Tasks.Task GameStartAsync() {
            return base.Channel.GameStartAsync();
        }
        
        public void ClientCommitMove(int stepNum, int x, int y) {
            base.Channel.ClientCommitMove(stepNum, x, y);
        }
        
        public System.Threading.Tasks.Task ClientCommitMoveAsync(int stepNum, int x, int y) {
            return base.Channel.ClientCommitMoveAsync(stepNum, x, y);
        }
    }
}
