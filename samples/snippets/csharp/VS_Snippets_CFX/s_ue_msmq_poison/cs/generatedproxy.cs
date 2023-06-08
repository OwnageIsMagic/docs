﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.12
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Do not add data members to types. Will cause serialization to fail.
namespace Microsoft.ServiceModel.Samples
{
    using System.Runtime.Serialization;
    using System.ServiceModel.Channels;


    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class PurchaseOrder : object, System.Runtime.Serialization.IExtensibleDataObject
    {

        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private string CustomerIdField;

        private string PONumberField;

        private Microsoft.ServiceModel.Samples.PurchaseOrderLineItem[] orderLineItemsField;

        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CustomerId
        {
            get
            {
                return this.CustomerIdField;
            }
            set
            {
                this.CustomerIdField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PONumber
        {
            get
            {
                return this.PONumberField;
            }
            set
            {
                this.PONumberField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public Microsoft.ServiceModel.Samples.PurchaseOrderLineItem[] orderLineItems
        {
            get
            {
                return this.orderLineItemsField;
            }
            set
            {
                this.orderLineItemsField = value;
            }
        }
    }

    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class PurchaseOrderLineItem : object, System.Runtime.Serialization.IExtensibleDataObject
    {

        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private string ProductIdField;

        private int QuantityField;

        private float UnitCostField;

        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductId
        {
            get
            {
                return this.ProductIdField;
            }
            set
            {
                this.ProductIdField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Quantity
        {
            get
            {
                return this.QuantityField;
            }
            set
            {
                this.QuantityField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public float UnitCost
        {
            get
            {
                return this.UnitCostField;
            }
            set
            {
                this.UnitCostField = value;
            }
        }
    }
}


[System.ServiceModel.ServiceContractAttribute(Namespace="http://Microsoft.ServiceModel.Samples")]
public interface IOrderProcessor
{

    [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://Microsoft.ServiceModel.Samples/IOrderProcessor/SubmitPurchaseOrder")]
    void SubmitPurchaseOrder(Microsoft.ServiceModel.Samples.PurchaseOrder po);
}

public interface IOrderProcessorChannel : IOrderProcessor, System.ServiceModel.IClientChannel
{
}

public partial class OrderProcessorClient : System.ServiceModel.ClientBase<IOrderProcessor>, IOrderProcessor
{

    public OrderProcessorClient()
    {
    }

    public OrderProcessorClient(string endpointConfigurationName) :
            base(endpointConfigurationName)
    {
    }

    public OrderProcessorClient(string endpointConfigurationName, string remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
    {
    }

    public OrderProcessorClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
    {
    }

    public OrderProcessorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
            base(binding, remoteAddress)
    {
    }

    public void SubmitPurchaseOrder(Microsoft.ServiceModel.Samples.PurchaseOrder po)
    {
        base.Channel.SubmitPurchaseOrder(po);
    }
}