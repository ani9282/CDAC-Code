﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.488
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication1.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Employee", Namespace="http://schemas.datacontract.org/2004/07/WcfDataContract")]
    [System.SerializableAttribute()]
    public partial class Employee : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int BsalField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DeptField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EidField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EnameField;
        
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
        public int Bsal {
            get {
                return this.BsalField;
            }
            set {
                if ((this.BsalField.Equals(value) != true)) {
                    this.BsalField = value;
                    this.RaisePropertyChanged("Bsal");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Dept {
            get {
                return this.DeptField;
            }
            set {
                if ((object.ReferenceEquals(this.DeptField, value) != true)) {
                    this.DeptField = value;
                    this.RaisePropertyChanged("Dept");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Eid {
            get {
                return this.EidField;
            }
            set {
                if ((this.EidField.Equals(value) != true)) {
                    this.EidField = value;
                    this.RaisePropertyChanged("Eid");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Ename {
            get {
                return this.EnameField;
            }
            set {
                if ((object.ReferenceEquals(this.EnameField, value) != true)) {
                    this.EnameField = value;
                    this.RaisePropertyChanged("Ename");
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
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetEmployeeDetail", ReplyAction="http://tempuri.org/IService1/GetEmployeeDetailResponse")]
        WindowsFormsApplication1.ServiceReference1.Employee GetEmployeeDetail(int empId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WindowsFormsApplication1.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WindowsFormsApplication1.ServiceReference1.IService1>, WindowsFormsApplication1.ServiceReference1.IService1 {
        
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
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public WindowsFormsApplication1.ServiceReference1.Employee GetEmployeeDetail(int empId) {
            return base.Channel.GetEmployeeDetail(empId);
        }
    }
}