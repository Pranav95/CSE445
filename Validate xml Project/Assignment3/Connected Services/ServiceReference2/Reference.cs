﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Assignment3.ServiceReference2 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DoWork", ReplyAction="http://tempuri.org/IService1/DoWorkResponse")]
        void DoWork();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DoWork", ReplyAction="http://tempuri.org/IService1/DoWorkResponse")]
        System.Threading.Tasks.Task DoWorkAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/verify", ReplyAction="http://tempuri.org/IService1/verifyResponse")]
        string verify(string xmlstring, string xsd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/verify", ReplyAction="http://tempuri.org/IService1/verifyResponse")]
        System.Threading.Tasks.Task<string> verifyAsync(string xmlstring, string xsd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/transform", ReplyAction="http://tempuri.org/IService1/transformResponse")]
        string transform(string xmlstring, string xslstring);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/transform", ReplyAction="http://tempuri.org/IService1/transformResponse")]
        System.Threading.Tasks.Task<string> transformAsync(string xmlstring, string xslstring);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Assignment3.ServiceReference2.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Assignment3.ServiceReference2.IService1>, Assignment3.ServiceReference2.IService1 {
        
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
        
        public void DoWork() {
            base.Channel.DoWork();
        }
        
        public System.Threading.Tasks.Task DoWorkAsync() {
            return base.Channel.DoWorkAsync();
        }
        
        public string verify(string xmlstring, string xsd) {
            return base.Channel.verify(xmlstring, xsd);
        }
        
        public System.Threading.Tasks.Task<string> verifyAsync(string xmlstring, string xsd) {
            return base.Channel.verifyAsync(xmlstring, xsd);
        }
        
        public string transform(string xmlstring, string xslstring) {
            return base.Channel.transform(xmlstring, xslstring);
        }
        
        public System.Threading.Tasks.Task<string> transformAsync(string xmlstring, string xslstring) {
            return base.Channel.transformAsync(xmlstring, xslstring);
        }
    }
}
