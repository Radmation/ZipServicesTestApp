﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestZipServices.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IZip2City1")]
    public interface IZip2City1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IZip2City1/GetCity", ReplyAction="http://tempuri.org/IZip2City1/GetCityResponse")]
        string GetCity(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IZip2City1/GetCity", ReplyAction="http://tempuri.org/IZip2City1/GetCityResponse")]
        System.Threading.Tasks.Task<string> GetCityAsync(string value);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IZip2City1Channel : TestZipServices.ServiceReference1.IZip2City1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Zip2City1Client : System.ServiceModel.ClientBase<TestZipServices.ServiceReference1.IZip2City1>, TestZipServices.ServiceReference1.IZip2City1 {
        
        public Zip2City1Client() {
        }
        
        public Zip2City1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Zip2City1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Zip2City1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Zip2City1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetCity(string value) {
            return base.Channel.GetCity(value);
        }
        
        public System.Threading.Tasks.Task<string> GetCityAsync(string value) {
            return base.Channel.GetCityAsync(value);
        }
    }
}
