﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.42
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Data;



[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="IWCFService")]
public interface IWCFService
{
    
    // CODEGEN: Parameter 'GetSystemIPAddressResult' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFService/GetSystemIPAddress", ReplyAction="http://tempuri.org/IWCFService/GetSystemIPAddressResponse")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    GetSystemIPAddressResponse GetSystemIPAddress(GetSystemIPAddressRequest request);
    
    // CODEGEN: Parameter 'GetEmployeeListResult' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFService/GetEmployeeList", ReplyAction="http://tempuri.org/IWCFService/GetEmployeeListResponse")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    GetEmployeeListResponse GetEmployeeList(GetEmployeeListRequest request);
    
    // CODEGEN: Parameter 'GetEmpolyeeArrayResult' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlArrayAttribute'.
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFService/GetEmpolyeeArray", ReplyAction="http://tempuri.org/IWCFService/GetEmpolyeeArrayResponse")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    GetEmpolyeeArrayResponse GetEmpolyeeArray(GetEmpolyeeArrayRequest request);
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
[System.ServiceModel.MessageContractAttribute(WrapperName="GetSystemIPAddress", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
public partial class GetSystemIPAddressRequest
{
    
    public GetSystemIPAddressRequest()
    {
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
[System.ServiceModel.MessageContractAttribute(WrapperName="GetSystemIPAddressResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
public partial class GetSystemIPAddressResponse
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public string GetSystemIPAddressResult;
    
    public GetSystemIPAddressResponse()
    {
    }
    
    public GetSystemIPAddressResponse(string GetSystemIPAddressResult)
    {
        this.GetSystemIPAddressResult = GetSystemIPAddressResult;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
[System.ServiceModel.MessageContractAttribute(WrapperName="GetEmployeeList", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
public partial class GetEmployeeListRequest
{
    
    public GetEmployeeListRequest()
    {
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
[System.ServiceModel.MessageContractAttribute(WrapperName="GetEmployeeListResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
public partial class GetEmployeeListResponse
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public System.Data.DataSet GetEmployeeListResult;
    
    public GetEmployeeListResponse()
    {
    }
    
    public GetEmployeeListResponse(System.Data.DataSet GetEmployeeListResult)
    {
        this.GetEmployeeListResult = GetEmployeeListResult;
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.30")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/WCFService")]
public partial class Employee
{
    
    private int employeeIDField;
    
    private bool employeeIDFieldSpecified;
    
    private decimal experienceField;
    
    private bool experienceFieldSpecified;
    
    private string firstNameField;
    
    private string lastNameField;
    
    private string middleNameField;
    
    private string qualificationField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public int EmployeeID
    {
        get
        {
            return this.employeeIDField;
        }
        set
        {
            this.employeeIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool EmployeeIDSpecified
    {
        get
        {
            return this.employeeIDFieldSpecified;
        }
        set
        {
            this.employeeIDFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public decimal Experience
    {
        get
        {
            return this.experienceField;
        }
        set
        {
            this.experienceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ExperienceSpecified
    {
        get
        {
            return this.experienceFieldSpecified;
        }
        set
        {
            this.experienceFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
    public string FirstName
    {
        get
        {
            return this.firstNameField;
        }
        set
        {
            this.firstNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
    public string LastName
    {
        get
        {
            return this.lastNameField;
        }
        set
        {
            this.lastNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=4)]
    public string MiddleName
    {
        get
        {
            return this.middleNameField;
        }
        set
        {
            this.middleNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=5)]
    public string Qualification
    {
        get
        {
            return this.qualificationField;
        }
        set
        {
            this.qualificationField = value;
        }
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
[System.ServiceModel.MessageContractAttribute(WrapperName="GetEmpolyeeArray", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
public partial class GetEmpolyeeArrayRequest
{
    
    public GetEmpolyeeArrayRequest()
    {
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
[System.ServiceModel.MessageContractAttribute(WrapperName="GetEmpolyeeArrayResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
public partial class GetEmpolyeeArrayResponse
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
    [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
    [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.datacontract.org/2004/07/WCFService")]
    public Employee[] GetEmpolyeeArrayResult;
    
    public GetEmpolyeeArrayResponse()
    {
    }
    
    public GetEmpolyeeArrayResponse(Employee[] GetEmpolyeeArrayResult)
    {
        this.GetEmpolyeeArrayResult = GetEmpolyeeArrayResult;
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
public interface IWCFServiceChannel : IWCFService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
public partial class WCFServiceClient : System.ServiceModel.ClientBase<IWCFService>, IWCFService
{
    
    public WCFServiceClient()
    {
    }
    
    public WCFServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public WCFServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public WCFServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public WCFServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    GetSystemIPAddressResponse IWCFService.GetSystemIPAddress(GetSystemIPAddressRequest request)
    {
        return base.Channel.GetSystemIPAddress(request);
    }
    
    public string GetSystemIPAddress()
    {
        GetSystemIPAddressRequest inValue = new GetSystemIPAddressRequest();
        GetSystemIPAddressResponse retVal = ((IWCFService)(this)).GetSystemIPAddress(inValue);
        return retVal.GetSystemIPAddressResult;
    }
    
    GetEmployeeListResponse IWCFService.GetEmployeeList(GetEmployeeListRequest request)
    {
        return base.Channel.GetEmployeeList(request);
    }
    
    public System.Data.DataSet GetEmployeeList()
    {
        GetEmployeeListRequest inValue = new GetEmployeeListRequest();
        GetEmployeeListResponse retVal = ((IWCFService)(this)).GetEmployeeList(inValue);
        return retVal.GetEmployeeListResult;
    }
    
    GetEmpolyeeArrayResponse IWCFService.GetEmpolyeeArray(GetEmpolyeeArrayRequest request)
    {
        return base.Channel.GetEmpolyeeArray(request);
    }
    
    public Employee[] GetEmpolyeeArray()
    {
        GetEmpolyeeArrayRequest inValue = new GetEmpolyeeArrayRequest();
        GetEmpolyeeArrayResponse retVal = ((IWCFService)(this)).GetEmpolyeeArray(inValue);
        return retVal.GetEmpolyeeArrayResult;
    }
}