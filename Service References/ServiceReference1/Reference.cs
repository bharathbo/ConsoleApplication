﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.9179
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApplication1.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.Service1Soap")]
    public interface Service1Soap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        int Add(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Subtract", ReplyAction="*")]
        int Subtract(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Multiply", ReplyAction="*")]
        int Multiply(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Divide", ReplyAction="*")]
        int Divide(int a, int b);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface Service1SoapChannel : ConsoleApplication1.ServiceReference1.Service1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class Service1SoapClient : System.ServiceModel.ClientBase<ConsoleApplication1.ServiceReference1.Service1Soap>, ConsoleApplication1.ServiceReference1.Service1Soap {
        
        public Service1SoapClient() {
        }
        
        public Service1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Add(int a, int b) {
            return base.Channel.Add(a, b);
        }
        
        public int Subtract(int a, int b) {
            return base.Channel.Subtract(a, b);
        }
        
        public int Multiply(int a, int b) {
            return base.Channel.Multiply(a, b);
        }
        
        public int Divide(int a, int b) {
            return base.Channel.Divide(a, b);
        }
    }
}
