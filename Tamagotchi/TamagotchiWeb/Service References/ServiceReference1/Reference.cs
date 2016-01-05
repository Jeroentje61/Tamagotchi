﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TamagotchiWeb.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Tamagotchi", Namespace="http://schemas.datacontract.org/2004/07/Tamagotchi_WCF")]
    [System.SerializableAttribute()]
    public partial class Tamagotchi : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime AccesGrantedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int BoredomField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int HealthField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int HungerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime LastAccesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NaamField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SleepField;
        
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
        public System.DateTime AccesGranted {
            get {
                return this.AccesGrantedField;
            }
            set {
                if ((this.AccesGrantedField.Equals(value) != true)) {
                    this.AccesGrantedField = value;
                    this.RaisePropertyChanged("AccesGranted");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Boredom {
            get {
                return this.BoredomField;
            }
            set {
                if ((this.BoredomField.Equals(value) != true)) {
                    this.BoredomField = value;
                    this.RaisePropertyChanged("Boredom");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Health {
            get {
                return this.HealthField;
            }
            set {
                if ((this.HealthField.Equals(value) != true)) {
                    this.HealthField = value;
                    this.RaisePropertyChanged("Health");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Hunger {
            get {
                return this.HungerField;
            }
            set {
                if ((this.HungerField.Equals(value) != true)) {
                    this.HungerField = value;
                    this.RaisePropertyChanged("Hunger");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime LastAcces {
            get {
                return this.LastAccesField;
            }
            set {
                if ((this.LastAccesField.Equals(value) != true)) {
                    this.LastAccesField = value;
                    this.RaisePropertyChanged("LastAcces");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Naam {
            get {
                return this.NaamField;
            }
            set {
                if ((object.ReferenceEquals(this.NaamField, value) != true)) {
                    this.NaamField = value;
                    this.RaisePropertyChanged("Naam");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Sleep {
            get {
                return this.SleepField;
            }
            set {
                if ((this.SleepField.Equals(value) != true)) {
                    this.SleepField = value;
                    this.RaisePropertyChanged("Sleep");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ITamagotchiService")]
    public interface ITamagotchiService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITamagotchiService/GetTamagotchis", ReplyAction="http://tempuri.org/ITamagotchiService/GetTamagotchisResponse")]
        TamagotchiWeb.ServiceReference1.Tamagotchi[] GetTamagotchis();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITamagotchiService/GetTamagotchis", ReplyAction="http://tempuri.org/ITamagotchiService/GetTamagotchisResponse")]
        System.Threading.Tasks.Task<TamagotchiWeb.ServiceReference1.Tamagotchi[]> GetTamagotchisAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITamagotchiService/ChooseTamagotchi", ReplyAction="http://tempuri.org/ITamagotchiService/ChooseTamagotchiResponse")]
        TamagotchiWeb.ServiceReference1.Tamagotchi ChooseTamagotchi(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITamagotchiService/ChooseTamagotchi", ReplyAction="http://tempuri.org/ITamagotchiService/ChooseTamagotchiResponse")]
        System.Threading.Tasks.Task<TamagotchiWeb.ServiceReference1.Tamagotchi> ChooseTamagotchiAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITamagotchiService/GetStatusses", ReplyAction="http://tempuri.org/ITamagotchiService/GetStatussesResponse")]
        int[] GetStatusses();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITamagotchiService/GetStatusses", ReplyAction="http://tempuri.org/ITamagotchiService/GetStatussesResponse")]
        System.Threading.Tasks.Task<int[]> GetStatussesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITamagotchiService/PerformAction", ReplyAction="http://tempuri.org/ITamagotchiService/PerformActionResponse")]
        string PerformAction(string action, TamagotchiWeb.ServiceReference1.Tamagotchi tmg);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITamagotchiService/PerformAction", ReplyAction="http://tempuri.org/ITamagotchiService/PerformActionResponse")]
        System.Threading.Tasks.Task<string> PerformActionAsync(string action, TamagotchiWeb.ServiceReference1.Tamagotchi tmg);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITamagotchiService/CreateTamagotchi", ReplyAction="http://tempuri.org/ITamagotchiService/CreateTamagotchiResponse")]
        TamagotchiWeb.ServiceReference1.Tamagotchi CreateTamagotchi(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITamagotchiService/CreateTamagotchi", ReplyAction="http://tempuri.org/ITamagotchiService/CreateTamagotchiResponse")]
        System.Threading.Tasks.Task<TamagotchiWeb.ServiceReference1.Tamagotchi> CreateTamagotchiAsync(string name);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITamagotchiServiceChannel : TamagotchiWeb.ServiceReference1.ITamagotchiService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TamagotchiServiceClient : System.ServiceModel.ClientBase<TamagotchiWeb.ServiceReference1.ITamagotchiService>, TamagotchiWeb.ServiceReference1.ITamagotchiService {
        
        public TamagotchiServiceClient() {
        }
        
        public TamagotchiServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TamagotchiServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TamagotchiServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TamagotchiServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public TamagotchiWeb.ServiceReference1.Tamagotchi[] GetTamagotchis() {
            return base.Channel.GetTamagotchis();
        }
        
        public System.Threading.Tasks.Task<TamagotchiWeb.ServiceReference1.Tamagotchi[]> GetTamagotchisAsync() {
            return base.Channel.GetTamagotchisAsync();
        }
        
        public TamagotchiWeb.ServiceReference1.Tamagotchi ChooseTamagotchi(string name) {
            return base.Channel.ChooseTamagotchi(name);
        }
        
        public System.Threading.Tasks.Task<TamagotchiWeb.ServiceReference1.Tamagotchi> ChooseTamagotchiAsync(string name) {
            return base.Channel.ChooseTamagotchiAsync(name);
        }
        
        public int[] GetStatusses() {
            return base.Channel.GetStatusses();
        }
        
        public System.Threading.Tasks.Task<int[]> GetStatussesAsync() {
            return base.Channel.GetStatussesAsync();
        }
        
        public string PerformAction(string action, TamagotchiWeb.ServiceReference1.Tamagotchi tmg) {
            return base.Channel.PerformAction(action, tmg);
        }
        
        public System.Threading.Tasks.Task<string> PerformActionAsync(string action, TamagotchiWeb.ServiceReference1.Tamagotchi tmg) {
            return base.Channel.PerformActionAsync(action, tmg);
        }
        
        public TamagotchiWeb.ServiceReference1.Tamagotchi CreateTamagotchi(string name) {
            return base.Channel.CreateTamagotchi(name);
        }
        
        public System.Threading.Tasks.Task<TamagotchiWeb.ServiceReference1.Tamagotchi> CreateTamagotchiAsync(string name) {
            return base.Channel.CreateTamagotchiAsync(name);
        }
    }
}
