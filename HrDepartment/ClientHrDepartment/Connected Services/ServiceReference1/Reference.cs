﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientHrDepartment.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DepartmentInfo", Namespace="http://schemas.datacontract.org/2004/07/HrDepartment")]
    [System.SerializableAttribute()]
    public partial class DepartmentInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AssociatesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EngineersField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ManagersField;
        
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
        public int Associates {
            get {
                return this.AssociatesField;
            }
            set {
                if ((this.AssociatesField.Equals(value) != true)) {
                    this.AssociatesField = value;
                    this.RaisePropertyChanged("Associates");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Engineers {
            get {
                return this.EngineersField;
            }
            set {
                if ((this.EngineersField.Equals(value) != true)) {
                    this.EngineersField = value;
                    this.RaisePropertyChanged("Engineers");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Managers {
            get {
                return this.ManagersField;
            }
            set {
                if ((this.ManagersField.Equals(value) != true)) {
                    this.ManagersField = value;
                    this.RaisePropertyChanged("Managers");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDepartmnetDetails", ReplyAction="http://tempuri.org/IService1/GetDepartmnetDetailsResponse")]
        ClientHrDepartment.ServiceReference1.DepartmentInfo GetDepartmnetDetails(string region);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDepartmnetDetails", ReplyAction="http://tempuri.org/IService1/GetDepartmnetDetailsResponse")]
        System.Threading.Tasks.Task<ClientHrDepartment.ServiceReference1.DepartmentInfo> GetDepartmnetDetailsAsync(string region);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : ClientHrDepartment.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<ClientHrDepartment.ServiceReference1.IService1>, ClientHrDepartment.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ClientHrDepartment.ServiceReference1.DepartmentInfo GetDepartmnetDetails(string region) {
            return base.Channel.GetDepartmnetDetails(region);
        }
        
        public System.Threading.Tasks.Task<ClientHrDepartment.ServiceReference1.DepartmentInfo> GetDepartmnetDetailsAsync(string region) {
            return base.Channel.GetDepartmnetDetailsAsync(region);
        }

        internal DepartmentInfo GetDepartmnetDetails()
        {
            throw new NotImplementedException();
        }
    }
}