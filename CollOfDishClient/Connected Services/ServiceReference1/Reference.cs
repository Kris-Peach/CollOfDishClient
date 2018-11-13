﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CollOfDishClient.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Payment", Namespace="urn:Agregator")]
    [System.SerializableAttribute()]
    public partial class Payment : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int userIdField;
        
        private double costField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int userId {
            get {
                return this.userIdField;
            }
            set {
                if ((this.userIdField.Equals(value) != true)) {
                    this.userIdField = value;
                    this.RaisePropertyChanged("userId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=1)]
        public double cost {
            get {
                return this.costField;
            }
            set {
                if ((this.costField.Equals(value) != true)) {
                    this.costField = value;
                    this.RaisePropertyChanged("cost");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="UserRequestLog", Namespace="urn:Agregator")]
    [System.SerializableAttribute()]
    public partial class UserRequestLog : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int userIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string userRequestField;
        
        private System.DateTime dateField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int userId {
            get {
                return this.userIdField;
            }
            set {
                if ((this.userIdField.Equals(value) != true)) {
                    this.userIdField = value;
                    this.RaisePropertyChanged("userId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string userRequest {
            get {
                return this.userRequestField;
            }
            set {
                if ((object.ReferenceEquals(this.userRequestField, value) != true)) {
                    this.userRequestField = value;
                    this.RaisePropertyChanged("userRequest");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public System.DateTime date {
            get {
                return this.dateField;
            }
            set {
                if ((this.dateField.Equals(value) != true)) {
                    this.dateField = value;
                    this.RaisePropertyChanged("date");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:Agregator", ConfigurationName="ServiceReference1.AgregatorServerSoap")]
    public interface AgregatorServerSoap {
        
        // CODEGEN: Контракт генерации сообщений с именем HelloWorldResult из пространства имен urn:Agregator не отмечен как обнуляемый
        [System.ServiceModel.OperationContractAttribute(Action="urn:Agregator/HelloWorld", ReplyAction="*")]
        CollOfDishClient.ServiceReference1.HelloWorldResponse HelloWorld(CollOfDishClient.ServiceReference1.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:Agregator/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<CollOfDishClient.ServiceReference1.HelloWorldResponse> HelloWorldAsync(CollOfDishClient.ServiceReference1.HelloWorldRequest request);
        
        // CODEGEN: Контракт генерации сообщений с именем name из пространства имен urn:Agregator не отмечен как обнуляемый
        [System.ServiceModel.OperationContractAttribute(Action="urn:Agregator/TestMethod", ReplyAction="*")]
        CollOfDishClient.ServiceReference1.TestMethodResponse TestMethod(CollOfDishClient.ServiceReference1.TestMethodRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:Agregator/TestMethod", ReplyAction="*")]
        System.Threading.Tasks.Task<CollOfDishClient.ServiceReference1.TestMethodResponse> TestMethodAsync(CollOfDishClient.ServiceReference1.TestMethodRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:Agregator/Convert", ReplyAction="*")]
        double Convert(double Celsius);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:Agregator/Convert", ReplyAction="*")]
        System.Threading.Tasks.Task<double> ConvertAsync(double Celsius);
        
        // CODEGEN: Контракт генерации сообщений с именем firstname из пространства имен urn:Agregator не отмечен как обнуляемый
        [System.ServiceModel.OperationContractAttribute(Action="urn:Agregator/GetUser", ReplyAction="*")]
        CollOfDishClient.ServiceReference1.GetUserResponse GetUser(CollOfDishClient.ServiceReference1.GetUserRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:Agregator/GetUser", ReplyAction="*")]
        System.Threading.Tasks.Task<CollOfDishClient.ServiceReference1.GetUserResponse> GetUserAsync(CollOfDishClient.ServiceReference1.GetUserRequest request);
        
        // CODEGEN: Контракт генерации сообщений с именем outPaymentResult из пространства имен urn:Agregator не отмечен как обнуляемый
        [System.ServiceModel.OperationContractAttribute(Action="urn:Agregator/outPayment", ReplyAction="*")]
        CollOfDishClient.ServiceReference1.outPaymentResponse outPayment(CollOfDishClient.ServiceReference1.outPaymentRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:Agregator/outPayment", ReplyAction="*")]
        System.Threading.Tasks.Task<CollOfDishClient.ServiceReference1.outPaymentResponse> outPaymentAsync(CollOfDishClient.ServiceReference1.outPaymentRequest request);
        
        // CODEGEN: Контракт генерации сообщений с именем begin из пространства имен urn:Agregator не отмечен как обнуляемый
        [System.ServiceModel.OperationContractAttribute(Action="urn:Agregator/ListOfUserRequest", ReplyAction="*")]
        CollOfDishClient.ServiceReference1.ListOfUserRequestResponse ListOfUserRequest(CollOfDishClient.ServiceReference1.ListOfUserRequestRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:Agregator/ListOfUserRequest", ReplyAction="*")]
        System.Threading.Tasks.Task<CollOfDishClient.ServiceReference1.ListOfUserRequestResponse> ListOfUserRequestAsync(CollOfDishClient.ServiceReference1.ListOfUserRequestRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="urn:Agregator", Order=0)]
        public CollOfDishClient.ServiceReference1.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(CollOfDishClient.ServiceReference1.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="urn:Agregator", Order=0)]
        public CollOfDishClient.ServiceReference1.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(CollOfDishClient.ServiceReference1.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="urn:Agregator")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class TestMethodRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="TestMethod", Namespace="urn:Agregator", Order=0)]
        public CollOfDishClient.ServiceReference1.TestMethodRequestBody Body;
        
        public TestMethodRequest() {
        }
        
        public TestMethodRequest(CollOfDishClient.ServiceReference1.TestMethodRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="urn:Agregator")]
    public partial class TestMethodRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string name;
        
        public TestMethodRequestBody() {
        }
        
        public TestMethodRequestBody(string name) {
            this.name = name;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class TestMethodResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="TestMethodResponse", Namespace="urn:Agregator", Order=0)]
        public CollOfDishClient.ServiceReference1.TestMethodResponseBody Body;
        
        public TestMethodResponse() {
        }
        
        public TestMethodResponse(CollOfDishClient.ServiceReference1.TestMethodResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="urn:Agregator")]
    public partial class TestMethodResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string TestMethodResult;
        
        public TestMethodResponseBody() {
        }
        
        public TestMethodResponseBody(string TestMethodResult) {
            this.TestMethodResult = TestMethodResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetUserRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetUser", Namespace="urn:Agregator", Order=0)]
        public CollOfDishClient.ServiceReference1.GetUserRequestBody Body;
        
        public GetUserRequest() {
        }
        
        public GetUserRequest(CollOfDishClient.ServiceReference1.GetUserRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="urn:Agregator")]
    public partial class GetUserRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int id;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string firstname;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string secondname;
        
        public GetUserRequestBody() {
        }
        
        public GetUserRequestBody(int id, string firstname, string secondname) {
            this.id = id;
            this.firstname = firstname;
            this.secondname = secondname;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetUserResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetUserResponse", Namespace="urn:Agregator", Order=0)]
        public CollOfDishClient.ServiceReference1.GetUserResponseBody Body;
        
        public GetUserResponse() {
        }
        
        public GetUserResponse(CollOfDishClient.ServiceReference1.GetUserResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="urn:Agregator")]
    public partial class GetUserResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int GetUserResult;
        
        public GetUserResponseBody() {
        }
        
        public GetUserResponseBody(int GetUserResult) {
            this.GetUserResult = GetUserResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class outPaymentRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="outPayment", Namespace="urn:Agregator", Order=0)]
        public CollOfDishClient.ServiceReference1.outPaymentRequestBody Body;
        
        public outPaymentRequest() {
        }
        
        public outPaymentRequest(CollOfDishClient.ServiceReference1.outPaymentRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class outPaymentRequestBody {
        
        public outPaymentRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class outPaymentResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="outPaymentResponse", Namespace="urn:Agregator", Order=0)]
        public CollOfDishClient.ServiceReference1.outPaymentResponseBody Body;
        
        public outPaymentResponse() {
        }
        
        public outPaymentResponse(CollOfDishClient.ServiceReference1.outPaymentResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="urn:Agregator")]
    public partial class outPaymentResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public CollOfDishClient.ServiceReference1.Payment outPaymentResult;
        
        public outPaymentResponseBody() {
        }
        
        public outPaymentResponseBody(CollOfDishClient.ServiceReference1.Payment outPaymentResult) {
            this.outPaymentResult = outPaymentResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListOfUserRequestRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ListOfUserRequest", Namespace="urn:Agregator", Order=0)]
        public CollOfDishClient.ServiceReference1.ListOfUserRequestRequestBody Body;
        
        public ListOfUserRequestRequest() {
        }
        
        public ListOfUserRequestRequest(CollOfDishClient.ServiceReference1.ListOfUserRequestRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="urn:Agregator")]
    public partial class ListOfUserRequestRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string begin;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string end;
        
        public ListOfUserRequestRequestBody() {
        }
        
        public ListOfUserRequestRequestBody(string begin, string end) {
            this.begin = begin;
            this.end = end;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListOfUserRequestResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ListOfUserRequestResponse", Namespace="urn:Agregator", Order=0)]
        public CollOfDishClient.ServiceReference1.ListOfUserRequestResponseBody Body;
        
        public ListOfUserRequestResponse() {
        }
        
        public ListOfUserRequestResponse(CollOfDishClient.ServiceReference1.ListOfUserRequestResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="urn:Agregator")]
    public partial class ListOfUserRequestResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public CollOfDishClient.ServiceReference1.UserRequestLog[] ListOfUserRequestResult;
        
        public ListOfUserRequestResponseBody() {
        }
        
        public ListOfUserRequestResponseBody(CollOfDishClient.ServiceReference1.UserRequestLog[] ListOfUserRequestResult) {
            this.ListOfUserRequestResult = ListOfUserRequestResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface AgregatorServerSoapChannel : CollOfDishClient.ServiceReference1.AgregatorServerSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AgregatorServerSoapClient : System.ServiceModel.ClientBase<CollOfDishClient.ServiceReference1.AgregatorServerSoap>, CollOfDishClient.ServiceReference1.AgregatorServerSoap {
        
        public AgregatorServerSoapClient() {
        }
        
        public AgregatorServerSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AgregatorServerSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AgregatorServerSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AgregatorServerSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CollOfDishClient.ServiceReference1.HelloWorldResponse CollOfDishClient.ServiceReference1.AgregatorServerSoap.HelloWorld(CollOfDishClient.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            CollOfDishClient.ServiceReference1.HelloWorldRequest inValue = new CollOfDishClient.ServiceReference1.HelloWorldRequest();
            inValue.Body = new CollOfDishClient.ServiceReference1.HelloWorldRequestBody();
            CollOfDishClient.ServiceReference1.HelloWorldResponse retVal = ((CollOfDishClient.ServiceReference1.AgregatorServerSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CollOfDishClient.ServiceReference1.HelloWorldResponse> CollOfDishClient.ServiceReference1.AgregatorServerSoap.HelloWorldAsync(CollOfDishClient.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<CollOfDishClient.ServiceReference1.HelloWorldResponse> HelloWorldAsync() {
            CollOfDishClient.ServiceReference1.HelloWorldRequest inValue = new CollOfDishClient.ServiceReference1.HelloWorldRequest();
            inValue.Body = new CollOfDishClient.ServiceReference1.HelloWorldRequestBody();
            return ((CollOfDishClient.ServiceReference1.AgregatorServerSoap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CollOfDishClient.ServiceReference1.TestMethodResponse CollOfDishClient.ServiceReference1.AgregatorServerSoap.TestMethod(CollOfDishClient.ServiceReference1.TestMethodRequest request) {
            return base.Channel.TestMethod(request);
        }
        
        public string TestMethod(string name) {
            CollOfDishClient.ServiceReference1.TestMethodRequest inValue = new CollOfDishClient.ServiceReference1.TestMethodRequest();
            inValue.Body = new CollOfDishClient.ServiceReference1.TestMethodRequestBody();
            inValue.Body.name = name;
            CollOfDishClient.ServiceReference1.TestMethodResponse retVal = ((CollOfDishClient.ServiceReference1.AgregatorServerSoap)(this)).TestMethod(inValue);
            return retVal.Body.TestMethodResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CollOfDishClient.ServiceReference1.TestMethodResponse> CollOfDishClient.ServiceReference1.AgregatorServerSoap.TestMethodAsync(CollOfDishClient.ServiceReference1.TestMethodRequest request) {
            return base.Channel.TestMethodAsync(request);
        }
        
        public System.Threading.Tasks.Task<CollOfDishClient.ServiceReference1.TestMethodResponse> TestMethodAsync(string name) {
            CollOfDishClient.ServiceReference1.TestMethodRequest inValue = new CollOfDishClient.ServiceReference1.TestMethodRequest();
            inValue.Body = new CollOfDishClient.ServiceReference1.TestMethodRequestBody();
            inValue.Body.name = name;
            return ((CollOfDishClient.ServiceReference1.AgregatorServerSoap)(this)).TestMethodAsync(inValue);
        }
        
        public double Convert(double Celsius) {
            return base.Channel.Convert(Celsius);
        }
        
        public System.Threading.Tasks.Task<double> ConvertAsync(double Celsius) {
            return base.Channel.ConvertAsync(Celsius);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CollOfDishClient.ServiceReference1.GetUserResponse CollOfDishClient.ServiceReference1.AgregatorServerSoap.GetUser(CollOfDishClient.ServiceReference1.GetUserRequest request) {
            return base.Channel.GetUser(request);
        }
        
        public int GetUser(int id, string firstname, string secondname) {
            CollOfDishClient.ServiceReference1.GetUserRequest inValue = new CollOfDishClient.ServiceReference1.GetUserRequest();
            inValue.Body = new CollOfDishClient.ServiceReference1.GetUserRequestBody();
            inValue.Body.id = id;
            inValue.Body.firstname = firstname;
            inValue.Body.secondname = secondname;
            CollOfDishClient.ServiceReference1.GetUserResponse retVal = ((CollOfDishClient.ServiceReference1.AgregatorServerSoap)(this)).GetUser(inValue);
            return retVal.Body.GetUserResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CollOfDishClient.ServiceReference1.GetUserResponse> CollOfDishClient.ServiceReference1.AgregatorServerSoap.GetUserAsync(CollOfDishClient.ServiceReference1.GetUserRequest request) {
            return base.Channel.GetUserAsync(request);
        }
        
        public System.Threading.Tasks.Task<CollOfDishClient.ServiceReference1.GetUserResponse> GetUserAsync(int id, string firstname, string secondname) {
            CollOfDishClient.ServiceReference1.GetUserRequest inValue = new CollOfDishClient.ServiceReference1.GetUserRequest();
            inValue.Body = new CollOfDishClient.ServiceReference1.GetUserRequestBody();
            inValue.Body.id = id;
            inValue.Body.firstname = firstname;
            inValue.Body.secondname = secondname;
            return ((CollOfDishClient.ServiceReference1.AgregatorServerSoap)(this)).GetUserAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CollOfDishClient.ServiceReference1.outPaymentResponse CollOfDishClient.ServiceReference1.AgregatorServerSoap.outPayment(CollOfDishClient.ServiceReference1.outPaymentRequest request) {
            return base.Channel.outPayment(request);
        }
        
        public CollOfDishClient.ServiceReference1.Payment outPayment() {
            CollOfDishClient.ServiceReference1.outPaymentRequest inValue = new CollOfDishClient.ServiceReference1.outPaymentRequest();
            inValue.Body = new CollOfDishClient.ServiceReference1.outPaymentRequestBody();
            CollOfDishClient.ServiceReference1.outPaymentResponse retVal = ((CollOfDishClient.ServiceReference1.AgregatorServerSoap)(this)).outPayment(inValue);
            return retVal.Body.outPaymentResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CollOfDishClient.ServiceReference1.outPaymentResponse> CollOfDishClient.ServiceReference1.AgregatorServerSoap.outPaymentAsync(CollOfDishClient.ServiceReference1.outPaymentRequest request) {
            return base.Channel.outPaymentAsync(request);
        }
        
        public System.Threading.Tasks.Task<CollOfDishClient.ServiceReference1.outPaymentResponse> outPaymentAsync() {
            CollOfDishClient.ServiceReference1.outPaymentRequest inValue = new CollOfDishClient.ServiceReference1.outPaymentRequest();
            inValue.Body = new CollOfDishClient.ServiceReference1.outPaymentRequestBody();
            return ((CollOfDishClient.ServiceReference1.AgregatorServerSoap)(this)).outPaymentAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CollOfDishClient.ServiceReference1.ListOfUserRequestResponse CollOfDishClient.ServiceReference1.AgregatorServerSoap.ListOfUserRequest(CollOfDishClient.ServiceReference1.ListOfUserRequestRequest request) {
            return base.Channel.ListOfUserRequest(request);
        }
        
        public CollOfDishClient.ServiceReference1.UserRequestLog[] ListOfUserRequest(string begin, string end) {
            CollOfDishClient.ServiceReference1.ListOfUserRequestRequest inValue = new CollOfDishClient.ServiceReference1.ListOfUserRequestRequest();
            inValue.Body = new CollOfDishClient.ServiceReference1.ListOfUserRequestRequestBody();
            inValue.Body.begin = begin;
            inValue.Body.end = end;
            CollOfDishClient.ServiceReference1.ListOfUserRequestResponse retVal = ((CollOfDishClient.ServiceReference1.AgregatorServerSoap)(this)).ListOfUserRequest(inValue);
            return retVal.Body.ListOfUserRequestResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CollOfDishClient.ServiceReference1.ListOfUserRequestResponse> CollOfDishClient.ServiceReference1.AgregatorServerSoap.ListOfUserRequestAsync(CollOfDishClient.ServiceReference1.ListOfUserRequestRequest request) {
            return base.Channel.ListOfUserRequestAsync(request);
        }
        
        public System.Threading.Tasks.Task<CollOfDishClient.ServiceReference1.ListOfUserRequestResponse> ListOfUserRequestAsync(string begin, string end) {
            CollOfDishClient.ServiceReference1.ListOfUserRequestRequest inValue = new CollOfDishClient.ServiceReference1.ListOfUserRequestRequest();
            inValue.Body = new CollOfDishClient.ServiceReference1.ListOfUserRequestRequestBody();
            inValue.Body.begin = begin;
            inValue.Body.end = end;
            return ((CollOfDishClient.ServiceReference1.AgregatorServerSoap)(this)).ListOfUserRequestAsync(inValue);
        }
    }
}