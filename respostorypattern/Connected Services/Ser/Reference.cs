﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace respostorypattern.Ser {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UrunDTO", Namespace="http://schemas.datacontract.org/2004/07/respostorypattern.DTO.Urunler")]
    [System.SerializableAttribute()]
    public partial class UrunDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> TedarikciIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UrunAdiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UrunIDField;
        
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
        public System.Nullable<int> TedarikciID {
            get {
                return this.TedarikciIDField;
            }
            set {
                if ((this.TedarikciIDField.Equals(value) != true)) {
                    this.TedarikciIDField = value;
                    this.RaisePropertyChanged("TedarikciID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UrunAdi {
            get {
                return this.UrunAdiField;
            }
            set {
                if ((object.ReferenceEquals(this.UrunAdiField, value) != true)) {
                    this.UrunAdiField = value;
                    this.RaisePropertyChanged("UrunAdi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UrunID {
            get {
                return this.UrunIDField;
            }
            set {
                if ((this.UrunIDField.Equals(value) != true)) {
                    this.UrunIDField = value;
                    this.RaisePropertyChanged("UrunID");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Ser.IServiceOf_UrunDTO")]
    public interface IServiceOf_UrunDTO {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceOf_UrunDTO/Listele", ReplyAction="http://tempuri.org/IServiceOf_UrunDTO/ListeleResponse")]
        System.Collections.Generic.List<respostorypattern.Ser.UrunDTO> Listele();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceOf_UrunDTO/Listele", ReplyAction="http://tempuri.org/IServiceOf_UrunDTO/ListeleResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<respostorypattern.Ser.UrunDTO>> ListeleAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceOf_UrunDTO/Ekele", ReplyAction="http://tempuri.org/IServiceOf_UrunDTO/EkeleResponse")]
        bool Ekele(respostorypattern.Ser.UrunDTO entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceOf_UrunDTO/Ekele", ReplyAction="http://tempuri.org/IServiceOf_UrunDTO/EkeleResponse")]
        System.Threading.Tasks.Task<bool> EkeleAsync(respostorypattern.Ser.UrunDTO entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceOf_UrunDTO/Sil", ReplyAction="http://tempuri.org/IServiceOf_UrunDTO/SilResponse")]
        bool Sil(respostorypattern.Ser.UrunDTO entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceOf_UrunDTO/Sil", ReplyAction="http://tempuri.org/IServiceOf_UrunDTO/SilResponse")]
        System.Threading.Tasks.Task<bool> SilAsync(respostorypattern.Ser.UrunDTO entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceOf_UrunDTO/Guncelle", ReplyAction="http://tempuri.org/IServiceOf_UrunDTO/GuncelleResponse")]
        bool Guncelle(respostorypattern.Ser.UrunDTO entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceOf_UrunDTO/Guncelle", ReplyAction="http://tempuri.org/IServiceOf_UrunDTO/GuncelleResponse")]
        System.Threading.Tasks.Task<bool> GuncelleAsync(respostorypattern.Ser.UrunDTO entity);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceOf_UrunDTOChannel : respostorypattern.Ser.IServiceOf_UrunDTO, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceOf_UrunDTOClient : System.ServiceModel.ClientBase<respostorypattern.Ser.IServiceOf_UrunDTO>, respostorypattern.Ser.IServiceOf_UrunDTO {
        
        public ServiceOf_UrunDTOClient() {
        }
        
        public ServiceOf_UrunDTOClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceOf_UrunDTOClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceOf_UrunDTOClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceOf_UrunDTOClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<respostorypattern.Ser.UrunDTO> Listele() {
            return base.Channel.Listele();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<respostorypattern.Ser.UrunDTO>> ListeleAsync() {
            return base.Channel.ListeleAsync();
        }
        
        public bool Ekele(respostorypattern.Ser.UrunDTO entity) {
            return base.Channel.Ekele(entity);
        }
        
        public System.Threading.Tasks.Task<bool> EkeleAsync(respostorypattern.Ser.UrunDTO entity) {
            return base.Channel.EkeleAsync(entity);
        }
        
        public bool Sil(respostorypattern.Ser.UrunDTO entity) {
            return base.Channel.Sil(entity);
        }
        
        public System.Threading.Tasks.Task<bool> SilAsync(respostorypattern.Ser.UrunDTO entity) {
            return base.Channel.SilAsync(entity);
        }
        
        public bool Guncelle(respostorypattern.Ser.UrunDTO entity) {
            return base.Channel.Guncelle(entity);
        }
        
        public System.Threading.Tasks.Task<bool> GuncelleAsync(respostorypattern.Ser.UrunDTO entity) {
            return base.Channel.GuncelleAsync(entity);
        }
    }
}
