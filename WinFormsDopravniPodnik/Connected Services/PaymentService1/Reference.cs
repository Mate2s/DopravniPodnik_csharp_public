//------------------------------------------------------------------------------
// <auto-generated>
//     Tento kód byl generován nástrojem.
//     Verze modulu runtime:4.0.30319.42000
//
//     Změny tohoto souboru mohou způsobit nesprávné chování a budou ztraceny,
//     dojde-li k novému generování kódu.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WinFormsDopravniPodnik.PaymentService1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PaymentService1.IPaymentService")]
    public interface IPaymentService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaymentService/Payment", ReplyAction="http://tempuri.org/IPaymentService/PaymentResponse")]
        void Payment(decimal value, int customerId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPaymentService/Payment", ReplyAction="http://tempuri.org/IPaymentService/PaymentResponse")]
        System.Threading.Tasks.Task PaymentAsync(decimal value, int customerId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPaymentServiceChannel : WinFormsDopravniPodnik.PaymentService1.IPaymentService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PaymentServiceClient : System.ServiceModel.ClientBase<WinFormsDopravniPodnik.PaymentService1.IPaymentService>, WinFormsDopravniPodnik.PaymentService1.IPaymentService {
        
        public PaymentServiceClient() {
        }
        
        public PaymentServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PaymentServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PaymentServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PaymentServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void Payment(decimal value, int customerId) {
            base.Channel.Payment(value, customerId);
        }
        
        public System.Threading.Tasks.Task PaymentAsync(decimal value, int customerId) {
            return base.Channel.PaymentAsync(value, customerId);
        }
    }
}
