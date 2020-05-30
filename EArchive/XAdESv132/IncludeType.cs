namespace EArchive.XAdESv132
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    [System.Xml.Serialization.XmlRootAttribute("Include", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable = false)]
    public partial class IncludeType
    {
        private string uRIField;
        private bool referencedDataField;
        private bool referencedDataFieldSpecified;
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string URI
        {
            get
            {
                return this.uRIField;
            }
            set
            {
                this.uRIField = value;
            }
        }
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool referencedData
        {
            get
            {
                return this.referencedDataField;
            }
            set
            {
                this.referencedDataField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool referencedDataSpecified
        {
            get
            {
                return this.referencedDataFieldSpecified;
            }
            set
            {
                this.referencedDataFieldSpecified = value;
            }
        }
    }
}