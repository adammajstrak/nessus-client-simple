namespace NessusClient.DTO
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    [System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
    public partial class NessusClientData_v2
    {

        private NessusClientData_v2Policy policyField;

        private NessusClientData_v2Report reportField;

        /// <remarks/>
        public NessusClientData_v2Policy Policy
        {
            get
            {
                return policyField;
            }
            set
            {
                policyField = value;
            }
        }

        /// <remarks/>
        public NessusClientData_v2Report Report
        {
            get
            {
                return reportField;
            }
            set
            {
                reportField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public partial class NessusClientData_v2Policy
    {

        private string policyNameField;

        private NessusClientData_v2PolicyPreferences preferencesField;

        private NessusClientData_v2PolicyFamilyItem[] familySelectionField;

        private NessusClientData_v2PolicyPluginItem[] individualPluginSelectionField;

        /// <remarks/>
        public string policyName
        {
            get
            {
                return policyNameField;
            }
            set
            {
                policyNameField = value;
            }
        }

        /// <remarks/>
        public NessusClientData_v2PolicyPreferences Preferences
        {
            get
            {
                return preferencesField;
            }
            set
            {
                preferencesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItem("FamilyItem", IsNullable = false)]
        public NessusClientData_v2PolicyFamilyItem[] FamilySelection
        {
            get
            {
                return familySelectionField;
            }
            set
            {
                familySelectionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItem("PluginItem", IsNullable = false)]
        public NessusClientData_v2PolicyPluginItem[] IndividualPluginSelection
        {
            get
            {
                return individualPluginSelectionField;
            }
            set
            {
                individualPluginSelectionField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public partial class NessusClientData_v2PolicyPreferences
    {

        private NessusClientData_v2PolicyPreferencesPreference[] serverPreferencesField;

        private NessusClientData_v2PolicyPreferencesItem[] pluginsPreferencesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItem("preference", IsNullable = false)]
        public NessusClientData_v2PolicyPreferencesPreference[] ServerPreferences
        {
            get
            {
                return serverPreferencesField;
            }
            set
            {
                serverPreferencesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItem("item", IsNullable = false)]
        public NessusClientData_v2PolicyPreferencesItem[] PluginsPreferences
        {
            get
            {
                return pluginsPreferencesField;
            }
            set
            {
                pluginsPreferencesField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public partial class NessusClientData_v2PolicyPreferencesPreference
    {

        private string nameField;

        private string valueField;

        /// <remarks/>
        public string name
        {
            get
            {
                return nameField;
            }
            set
            {
                nameField = value;
            }
        }

        /// <remarks/>
        public string value
        {
            get
            {
                return valueField;
            }
            set
            {
                valueField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public partial class NessusClientData_v2PolicyPreferencesItem
    {

        private string pluginNameField;

        private uint pluginIdField;

        private string fullNameField;

        private string preferenceNameField;

        private string preferenceTypeField;

        private string preferenceValuesField;

        private string selectedValueField;

        /// <remarks/>
        public string pluginName
        {
            get
            {
                return pluginNameField;
            }
            set
            {
                pluginNameField = value;
            }
        }

        /// <remarks/>
        public uint pluginId
        {
            get
            {
                return pluginIdField;
            }
            set
            {
                pluginIdField = value;
            }
        }

        /// <remarks/>
        public string fullName
        {
            get
            {
                return fullNameField;
            }
            set
            {
                fullNameField = value;
            }
        }

        /// <remarks/>
        public string preferenceName
        {
            get
            {
                return preferenceNameField;
            }
            set
            {
                preferenceNameField = value;
            }
        }

        /// <remarks/>
        public string preferenceType
        {
            get
            {
                return preferenceTypeField;
            }
            set
            {
                preferenceTypeField = value;
            }
        }

        /// <remarks/>
        public string preferenceValues
        {
            get
            {
                return preferenceValuesField;
            }
            set
            {
                preferenceValuesField = value;
            }
        }

        /// <remarks/>
        public string selectedValue
        {
            get
            {
                return selectedValueField;
            }
            set
            {
                selectedValueField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public partial class NessusClientData_v2PolicyFamilyItem
    {

        private string familyNameField;

        private string statusField;

        /// <remarks/>
        public string FamilyName
        {
            get
            {
                return familyNameField;
            }
            set
            {
                familyNameField = value;
            }
        }

        /// <remarks/>
        public string Status
        {
            get
            {
                return statusField;
            }
            set
            {
                statusField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public partial class NessusClientData_v2PolicyPluginItem
    {

        private ushort pluginIdField;

        private string pluginNameField;

        private string familyField;

        private string statusField;

        /// <remarks/>
        public ushort PluginId
        {
            get
            {
                return pluginIdField;
            }
            set
            {
                pluginIdField = value;
            }
        }

        /// <remarks/>
        public string PluginName
        {
            get
            {
                return pluginNameField;
            }
            set
            {
                pluginNameField = value;
            }
        }

        /// <remarks/>
        public string Family
        {
            get
            {
                return familyField;
            }
            set
            {
                familyField = value;
            }
        }

        /// <remarks/>
        public string Status
        {
            get
            {
                return statusField;
            }
            set
            {
                statusField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public partial class NessusClientData_v2Report
    {

        private NessusClientData_v2ReportReportHost[] reportHostField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ReportHost")]
        public NessusClientData_v2ReportReportHost[] ReportHost
        {
            get
            {
                return reportHostField;
            }
            set
            {
                reportHostField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string name
        {
            get
            {
                return nameField;
            }
            set
            {
                nameField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public partial class NessusClientData_v2ReportReportHost
    {

        private NessusClientData_v2ReportReportHostTag[] hostPropertiesField;

        private NessusClientData_v2ReportReportHostReportItem[] reportItemField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItem("tag", IsNullable = false)]
        public NessusClientData_v2ReportReportHostTag[] HostProperties
        {
            get
            {
                return hostPropertiesField;
            }
            set
            {
                hostPropertiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ReportItem")]
        public NessusClientData_v2ReportReportHostReportItem[] ReportItem
        {
            get
            {
                return reportItemField;
            }
            set
            {
                reportItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string name
        {
            get
            {
                return nameField;
            }
            set
            {
                nameField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public partial class NessusClientData_v2ReportReportHostTag
    {

        private string nameField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string name
        {
            get
            {
                return nameField;
            }
            set
            {
                nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlText()]
        public string Value
        {
            get
            {
                return valueField;
            }
            set
            {
                valueField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public partial class NessusClientData_v2ReportReportHostReportItem
    {

        private object[] itemsField;

        private ItemsChoiceType[] itemsElementNameField;

        private ushort portField;

        private string svc_nameField;

        private string protocolField;

        private byte severityField;

        private uint pluginIDField;

        private string pluginNameField;

        private string pluginFamilyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("agent", typeof(string))]
        [System.Xml.Serialization.XmlElement("asset_inventory", typeof(string))]
        [System.Xml.Serialization.XmlElement("asset_inventory_category", typeof(string))]
        [System.Xml.Serialization.XmlElement("cpe", typeof(string))]
        [System.Xml.Serialization.XmlElement("cve", typeof(string))]
        [System.Xml.Serialization.XmlElement("cvss3_base_score", typeof(decimal))]
        [System.Xml.Serialization.XmlElement("cvss3_temporal_score", typeof(decimal))]
        [System.Xml.Serialization.XmlElement("cvss3_temporal_vector", typeof(string))]
        [System.Xml.Serialization.XmlElement("cvss3_vector", typeof(string))]
        [System.Xml.Serialization.XmlElement("cvss_base_score", typeof(decimal))]
        [System.Xml.Serialization.XmlElement("cvss_score_rationale", typeof(string))]
        [System.Xml.Serialization.XmlElement("cvss_score_source", typeof(string))]
        [System.Xml.Serialization.XmlElement("cvss_temporal_score", typeof(decimal))]
        [System.Xml.Serialization.XmlElement("cvss_temporal_vector", typeof(string))]
        [System.Xml.Serialization.XmlElement("cvss_vector", typeof(string))]
        [System.Xml.Serialization.XmlElement("cwe", typeof(int))]
        [System.Xml.Serialization.XmlElement("description", typeof(string))]
        [System.Xml.Serialization.XmlElement("exploit_available", typeof(bool))]
        [System.Xml.Serialization.XmlElement("exploitability_ease", typeof(string))]
        [System.Xml.Serialization.XmlElement("fname", typeof(string))]
        [System.Xml.Serialization.XmlElement("iavb", typeof(string))]
        [System.Xml.Serialization.XmlElement("iavt", typeof(string))]
        [System.Xml.Serialization.XmlElement("in_the_news", typeof(bool))]
        [System.Xml.Serialization.XmlElement("os_identification", typeof(string))]
        [System.Xml.Serialization.XmlElement("plugin_modification_date", typeof(string))]
        [System.Xml.Serialization.XmlElement("plugin_name", typeof(string))]
        [System.Xml.Serialization.XmlElement("plugin_output", typeof(string))]
        [System.Xml.Serialization.XmlElement("plugin_publication_date", typeof(string))]
        [System.Xml.Serialization.XmlElement("plugin_type", typeof(string))]
        [System.Xml.Serialization.XmlElement("risk_factor", typeof(string))]
        [System.Xml.Serialization.XmlElement("script_version", typeof(string))]
        [System.Xml.Serialization.XmlElement("see_also", typeof(string))]
        [System.Xml.Serialization.XmlElement("solution", typeof(string))]
        [System.Xml.Serialization.XmlElement("synopsis", typeof(string))]
        [System.Xml.Serialization.XmlElement("thorough_tests", typeof(bool))]
        [System.Xml.Serialization.XmlElement("vuln_publication_date", typeof(string))]
        [System.Xml.Serialization.XmlElement("xref", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifier("ItemsElementName")]
        public object[] Items
        {
            get
            {
                return itemsField;
            }
            set
            {
                itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnore()]
        public ItemsChoiceType[] ItemsElementName
        {
            get
            {
                return itemsElementNameField;
            }
            set
            {
                itemsElementNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public ushort port
        {
            get
            {
                return portField;
            }
            set
            {
                portField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string svc_name
        {
            get
            {
                return svc_nameField;
            }
            set
            {
                svc_nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string protocol
        {
            get
            {
                return protocolField;
            }
            set
            {
                protocolField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public byte severity
        {
            get
            {
                return severityField;
            }
            set
            {
                severityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public uint pluginID
        {
            get
            {
                return pluginIDField;
            }
            set
            {
                pluginIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string pluginName
        {
            get
            {
                return pluginNameField;
            }
            set
            {
                pluginNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string pluginFamily
        {
            get
            {
                return pluginFamilyField;
            }
            set
            {
                pluginFamilyField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [System.Xml.Serialization.XmlType(IncludeInSchema = false)]
    public enum ItemsChoiceType
    {

        /// <remarks/>
        agent,

        /// <remarks/>
        asset_inventory,

        /// <remarks/>
        asset_inventory_category,

        /// <remarks/>
        cpe,

        /// <remarks/>
        cve,

        /// <remarks/>
        cvss3_base_score,

        /// <remarks/>
        cvss3_temporal_score,

        /// <remarks/>
        cvss3_temporal_vector,

        /// <remarks/>
        cvss3_vector,

        /// <remarks/>
        cvss_base_score,

        /// <remarks/>
        cvss_score_rationale,

        /// <remarks/>
        cvss_score_source,

        /// <remarks/>
        cvss_temporal_score,

        /// <remarks/>
        cvss_temporal_vector,

        /// <remarks/>
        cvss_vector,

        /// <remarks/>
        cwe,

        /// <remarks/>
        description,

        /// <remarks/>
        exploit_available,

        /// <remarks/>
        exploitability_ease,

        /// <remarks/>
        fname,

        /// <remarks/>
        iavb,

        /// <remarks/>
        iavt,

        /// <remarks/>
        in_the_news,

        /// <remarks/>
        os_identification,

        /// <remarks/>
        plugin_modification_date,

        /// <remarks/>
        plugin_name,

        /// <remarks/>
        plugin_output,

        /// <remarks/>
        plugin_publication_date,

        /// <remarks/>
        plugin_type,

        /// <remarks/>
        risk_factor,

        /// <remarks/>
        script_version,

        /// <remarks/>
        see_also,

        /// <remarks/>
        solution,

        /// <remarks/>
        synopsis,

        /// <remarks/>
        thorough_tests,

        /// <remarks/>
        vuln_publication_date,

        /// <remarks/>
        xref,
    }


}
