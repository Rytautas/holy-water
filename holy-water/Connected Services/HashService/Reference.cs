﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace holy_water.HashService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="HashService.IHashService")]
    public interface IHashService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHashService/HashPassword", ReplyAction="http://tempuri.org/IHashService/HashPasswordResponse")]
        int HashPassword(string pw);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHashService/HashPassword", ReplyAction="http://tempuri.org/IHashService/HashPasswordResponse")]
        System.Threading.Tasks.Task<int> HashPasswordAsync(string pw);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IHashServiceChannel : holy_water.HashService.IHashService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HashServiceClient : System.ServiceModel.ClientBase<holy_water.HashService.IHashService>, holy_water.HashService.IHashService {
        
        public HashServiceClient() {
        }
        
        public HashServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public HashServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HashServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HashServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int HashPassword(string pw) {
            return base.Channel.HashPassword(pw);
        }
        
        public System.Threading.Tasks.Task<int> HashPasswordAsync(string pw) {
            return base.Channel.HashPasswordAsync(pw);
        }
    }
}
