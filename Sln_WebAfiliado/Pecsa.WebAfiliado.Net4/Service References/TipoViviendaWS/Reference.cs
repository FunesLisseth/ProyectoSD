﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.18444
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pecsa.WebAfiliado.Net4.TipoViviendaWS {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TipoVivienda", Namespace="http://schemas.datacontract.org/2004/07/CondominioService.MasterTables.Dominio")]
    [System.SerializableAttribute()]
    public partial class TipoVivienda : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CodigoTipoViviendaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreTipoViviendaField;
        
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
        public int CodigoTipoVivienda {
            get {
                return this.CodigoTipoViviendaField;
            }
            set {
                if ((this.CodigoTipoViviendaField.Equals(value) != true)) {
                    this.CodigoTipoViviendaField = value;
                    this.RaisePropertyChanged("CodigoTipoVivienda");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NombreTipoVivienda {
            get {
                return this.NombreTipoViviendaField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreTipoViviendaField, value) != true)) {
                    this.NombreTipoViviendaField = value;
                    this.RaisePropertyChanged("NombreTipoVivienda");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TipoViviendaWS.ITipoViviendaService")]
    public interface ITipoViviendaService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITipoViviendaService/ListarTipoVivienda", ReplyAction="http://tempuri.org/ITipoViviendaService/ListarTipoViviendaResponse")]
        Pecsa.WebAfiliado.Net4.TipoViviendaWS.TipoVivienda[] ListarTipoVivienda();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITipoViviendaServiceChannel : Pecsa.WebAfiliado.Net4.TipoViviendaWS.ITipoViviendaService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TipoViviendaServiceClient : System.ServiceModel.ClientBase<Pecsa.WebAfiliado.Net4.TipoViviendaWS.ITipoViviendaService>, Pecsa.WebAfiliado.Net4.TipoViviendaWS.ITipoViviendaService {
        
        public TipoViviendaServiceClient() {
        }
        
        public TipoViviendaServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TipoViviendaServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TipoViviendaServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TipoViviendaServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Pecsa.WebAfiliado.Net4.TipoViviendaWS.TipoVivienda[] ListarTipoVivienda() {
            return base.Channel.ListarTipoVivienda();
        }
    }
}