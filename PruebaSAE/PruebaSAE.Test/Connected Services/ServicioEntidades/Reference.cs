﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PruebaSAE.Test.ServicioEntidades {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/PruebaSAE.Negocio")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="RespuestaPadres", Namespace="http://schemas.datacontract.org/2004/07/PruebaSAE.Negocio.Respuestas")]
    [System.SerializableAttribute()]
    public partial class RespuestaPadres : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool EstadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MensajeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private PruebaSAE.Test.ServicioEntidades.Padre[] PadresField;
        
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
        public bool Estado {
            get {
                return this.EstadoField;
            }
            set {
                if ((this.EstadoField.Equals(value) != true)) {
                    this.EstadoField = value;
                    this.RaisePropertyChanged("Estado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Mensaje {
            get {
                return this.MensajeField;
            }
            set {
                if ((object.ReferenceEquals(this.MensajeField, value) != true)) {
                    this.MensajeField = value;
                    this.RaisePropertyChanged("Mensaje");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public PruebaSAE.Test.ServicioEntidades.Padre[] Padres {
            get {
                return this.PadresField;
            }
            set {
                if ((object.ReferenceEquals(this.PadresField, value) != true)) {
                    this.PadresField = value;
                    this.RaisePropertyChanged("Padres");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Padre", Namespace="http://schemas.datacontract.org/2004/07/PruebaSAE.Negocio.Entidades")]
    [System.SerializableAttribute()]
    public partial class Padre : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private PruebaSAE.Test.ServicioEntidades.Hijo[] HijosField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
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
        public PruebaSAE.Test.ServicioEntidades.Hijo[] Hijos {
            get {
                return this.HijosField;
            }
            set {
                if ((object.ReferenceEquals(this.HijosField, value) != true)) {
                    this.HijosField = value;
                    this.RaisePropertyChanged("Hijos");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Hijo", Namespace="http://schemas.datacontract.org/2004/07/PruebaSAE.Negocio.Entidades")]
    [System.SerializableAttribute()]
    public partial class Hijo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long IdPadreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
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
        public long Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long IdPadre {
            get {
                return this.IdPadreField;
            }
            set {
                if ((this.IdPadreField.Equals(value) != true)) {
                    this.IdPadreField = value;
                    this.RaisePropertyChanged("IdPadre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="RespuestaHijos", Namespace="http://schemas.datacontract.org/2004/07/PruebaSAE.Negocio.Respuestas")]
    [System.SerializableAttribute()]
    public partial class RespuestaHijos : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool EstadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private PruebaSAE.Test.ServicioEntidades.Hijo[] HijosField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MensajeField;
        
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
        public bool Estado {
            get {
                return this.EstadoField;
            }
            set {
                if ((this.EstadoField.Equals(value) != true)) {
                    this.EstadoField = value;
                    this.RaisePropertyChanged("Estado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public PruebaSAE.Test.ServicioEntidades.Hijo[] Hijos {
            get {
                return this.HijosField;
            }
            set {
                if ((object.ReferenceEquals(this.HijosField, value) != true)) {
                    this.HijosField = value;
                    this.RaisePropertyChanged("Hijos");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Mensaje {
            get {
                return this.MensajeField;
            }
            set {
                if ((object.ReferenceEquals(this.MensajeField, value) != true)) {
                    this.MensajeField = value;
                    this.RaisePropertyChanged("Mensaje");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServicioEntidades.IEntidades")]
    public interface IEntidades {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEntidades/GetData", ReplyAction="http://tempuri.org/IEntidades/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEntidades/GetData", ReplyAction="http://tempuri.org/IEntidades/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEntidades/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IEntidades/GetDataUsingDataContractResponse")]
        PruebaSAE.Test.ServicioEntidades.CompositeType GetDataUsingDataContract(PruebaSAE.Test.ServicioEntidades.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEntidades/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IEntidades/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<PruebaSAE.Test.ServicioEntidades.CompositeType> GetDataUsingDataContractAsync(PruebaSAE.Test.ServicioEntidades.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEntidades/ObtenerPadres", ReplyAction="http://tempuri.org/IEntidades/ObtenerPadresResponse")]
        PruebaSAE.Test.ServicioEntidades.RespuestaPadres ObtenerPadres();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEntidades/ObtenerPadres", ReplyAction="http://tempuri.org/IEntidades/ObtenerPadresResponse")]
        System.Threading.Tasks.Task<PruebaSAE.Test.ServicioEntidades.RespuestaPadres> ObtenerPadresAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEntidades/ObtenerHijosDePadre", ReplyAction="http://tempuri.org/IEntidades/ObtenerHijosDePadreResponse")]
        PruebaSAE.Test.ServicioEntidades.RespuestaHijos ObtenerHijosDePadre(long idPadre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEntidades/ObtenerHijosDePadre", ReplyAction="http://tempuri.org/IEntidades/ObtenerHijosDePadreResponse")]
        System.Threading.Tasks.Task<PruebaSAE.Test.ServicioEntidades.RespuestaHijos> ObtenerHijosDePadreAsync(long idPadre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEntidades/CrearPadre", ReplyAction="http://tempuri.org/IEntidades/CrearPadreResponse")]
        PruebaSAE.Test.ServicioEntidades.RespuestaPadres CrearPadre(string nombre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEntidades/CrearPadre", ReplyAction="http://tempuri.org/IEntidades/CrearPadreResponse")]
        System.Threading.Tasks.Task<PruebaSAE.Test.ServicioEntidades.RespuestaPadres> CrearPadreAsync(string nombre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEntidades/CrearHijo", ReplyAction="http://tempuri.org/IEntidades/CrearHijoResponse")]
        PruebaSAE.Test.ServicioEntidades.RespuestaHijos CrearHijo(long idPadre, string nombre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEntidades/CrearHijo", ReplyAction="http://tempuri.org/IEntidades/CrearHijoResponse")]
        System.Threading.Tasks.Task<PruebaSAE.Test.ServicioEntidades.RespuestaHijos> CrearHijoAsync(long idPadre, string nombre);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEntidadesChannel : PruebaSAE.Test.ServicioEntidades.IEntidades, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EntidadesClient : System.ServiceModel.ClientBase<PruebaSAE.Test.ServicioEntidades.IEntidades>, PruebaSAE.Test.ServicioEntidades.IEntidades {
        
        public EntidadesClient() {
        }
        
        public EntidadesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EntidadesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EntidadesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EntidadesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public PruebaSAE.Test.ServicioEntidades.CompositeType GetDataUsingDataContract(PruebaSAE.Test.ServicioEntidades.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<PruebaSAE.Test.ServicioEntidades.CompositeType> GetDataUsingDataContractAsync(PruebaSAE.Test.ServicioEntidades.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public PruebaSAE.Test.ServicioEntidades.RespuestaPadres ObtenerPadres() {
            return base.Channel.ObtenerPadres();
        }
        
        public System.Threading.Tasks.Task<PruebaSAE.Test.ServicioEntidades.RespuestaPadres> ObtenerPadresAsync() {
            return base.Channel.ObtenerPadresAsync();
        }
        
        public PruebaSAE.Test.ServicioEntidades.RespuestaHijos ObtenerHijosDePadre(long idPadre) {
            return base.Channel.ObtenerHijosDePadre(idPadre);
        }
        
        public System.Threading.Tasks.Task<PruebaSAE.Test.ServicioEntidades.RespuestaHijos> ObtenerHijosDePadreAsync(long idPadre) {
            return base.Channel.ObtenerHijosDePadreAsync(idPadre);
        }
        
        public PruebaSAE.Test.ServicioEntidades.RespuestaPadres CrearPadre(string nombre) {
            return base.Channel.CrearPadre(nombre);
        }
        
        public System.Threading.Tasks.Task<PruebaSAE.Test.ServicioEntidades.RespuestaPadres> CrearPadreAsync(string nombre) {
            return base.Channel.CrearPadreAsync(nombre);
        }
        
        public PruebaSAE.Test.ServicioEntidades.RespuestaHijos CrearHijo(long idPadre, string nombre) {
            return base.Channel.CrearHijo(idPadre, nombre);
        }
        
        public System.Threading.Tasks.Task<PruebaSAE.Test.ServicioEntidades.RespuestaHijos> CrearHijoAsync(long idPadre, string nombre) {
            return base.Channel.CrearHijoAsync(idPadre, nombre);
        }
    }
}