namespace Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20201001Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.PowerShell;

    /// <summary>ARM proxy resource.</summary>
    [System.ComponentModel.TypeConverter(typeof(ProxyResourceTypeConverter))]
    public partial class ProxyResource
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20201001Preview.ProxyResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20201001Preview.IProxyResource"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20201001Preview.IProxyResource DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ProxyResource(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20201001Preview.ProxyResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20201001Preview.IProxyResource"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20201001Preview.IProxyResource DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ProxyResource(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ProxyResource" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20201001Preview.IProxyResource FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20201001Preview.ProxyResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ProxyResource(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20201001Preview.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20201001Preview.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20201001Preview.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20201001Preview.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20201001Preview.IResourceInternal)this).SystemDataCreatedByType = (string) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20201001Preview.IResourceInternal)this).SystemDataCreatedByType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20201001Preview.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20201001Preview.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20201001Preview.IResourceInternal)this).SystemDataLastModifiedByType = (string) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20201001Preview.IResourceInternal)this).SystemDataLastModifiedByType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20201001Preview.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20201001Preview.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20201001Preview.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20201001Preview.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20201001Preview.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20201001Preview.SystemDataTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20201001Preview.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20201001Preview.IResourceInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20201001Preview.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20201001Preview.IResourceInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20201001Preview.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20201001Preview.IResourceInternal)this).Type, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20201001Preview.ProxyResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ProxyResource(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20201001Preview.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20201001Preview.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20201001Preview.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20201001Preview.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20201001Preview.IResourceInternal)this).SystemDataCreatedByType = (string) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20201001Preview.IResourceInternal)this).SystemDataCreatedByType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20201001Preview.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20201001Preview.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20201001Preview.IResourceInternal)this).SystemDataLastModifiedByType = (string) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20201001Preview.IResourceInternal)this).SystemDataLastModifiedByType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20201001Preview.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20201001Preview.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20201001Preview.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20201001Preview.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20201001Preview.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20201001Preview.SystemDataTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20201001Preview.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20201001Preview.IResourceInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20201001Preview.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20201001Preview.IResourceInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20201001Preview.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Models.Api20201001Preview.IResourceInternal)this).Type, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.KubernetesConfiguration.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// ARM proxy resource.
    [System.ComponentModel.TypeConverter(typeof(ProxyResourceTypeConverter))]
    public partial interface IProxyResource

    {

    }
}